using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.BedrockRuntime;
using Amazon.BedrockRuntime.Model;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading;
using System;
using System.Diagnostics.Contracts;
namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    /// <summary>
    /// To run these tests on your local development acccount, you need to request access to the bedrock models
    /// 1. Go to AWS console.
    /// 2. Type Bedrock in the search bar
    /// 3. Select Model Access in the left hand side menu
    /// 4. Click Manage model access
    /// 5. Select all models and request access.
    /// 
    /// Because this test requires explicit access to the models it is ignored.
    /// </summary>
    [TestClass]
    [Ignore]
    public class BedrockRuntimeEventStreamTests : TestBase<AmazonBedrockRuntimeClient>
    {
#if BCL
        [TestMethod]
        public async Task PayloadIsSentBackCorrectlyAsync()
        {
            AutoResetEvent endEvent = new AutoResetEvent(false);
            var query = CreateStream("Who was the first US president");
            var response = await Client.InvokeModelWithResponseStreamAsync(new InvokeModelWithResponseStreamRequest
            {
                Accept = "*/*",
                ContentType = "application/json",
                Body = query,
                ModelId = "anthropic.claude-v2"
            }).ConfigureAwait(false);
            var eventStream = response.Body;
            Assert.IsNotNull(eventStream);
            Assert.AreEqual(response.HttpStatusCode, System.Net.HttpStatusCode.OK);
            string payloadString = null;
            using (eventStream)
            {
                eventStream.ChunkReceived += (sender, e) =>
                {
                    var sizeOfPayload = e.EventStreamEvent.Bytes.Length;
                    using (StreamReader r = new StreamReader(e.EventStreamEvent.Bytes))
                    {
                        payloadString = r.ReadToEnd();
                    }
                    //Since we don't know the contents of the response from Bedrock, we just assert that we received a payload
                    //and that the size of the payload is equal to what we read from the stream
                    var payloadStringSize = Encoding.UTF8.GetByteCount(payloadString);
                    Assert.IsNotNull(payloadString);
                    Assert.AreEqual(payloadStringSize, sizeOfPayload);
                    endEvent.Set();
                };
                eventStream.StartProcessing();
                //the maximum we will wait for a response is 20 seconds, if a payload chunk is received
                //we signal the end event and exit the test.We are purposely not waiting for the full response
                //because it will take too much time. We just check the first streamed payload.
                endEvent.WaitOne(TimeSpan.FromSeconds(20));
            }
        }
        [TestMethod]
        public async Task RequestWithInvalidBodyReturnsValidationException()
        {
            AutoResetEvent endEvent = new AutoResetEvent(false);
            var query = CreateStream("Who was the first US president", true);
            var response = await Client.InvokeModelWithResponseStreamAsync(new InvokeModelWithResponseStreamRequest
            {
                Accept = "*/*",
                ContentType = "application/json",
                Body = query,
                ModelId = "anthropic.claude-v2"
            }).ConfigureAwait(false);
            var eventStream = response.Body;
            Assert.IsNotNull(eventStream);
            Assert.AreEqual(response.HttpStatusCode, System.Net.HttpStatusCode.OK);
            bool chunkReceived = false;
            bool exceptionReceived = false;
            using (eventStream)
            {
                eventStream.ChunkReceived += (sender, e) =>
                {
                    chunkReceived = true;
                    endEvent.Set();
                };
                eventStream.ExceptionReceived += (sender, e) =>
                {
                    exceptionReceived = true;
                    var actualException = e.EventStreamException.InnerException;
                    Assert.IsInstanceOfType(e.EventStreamException.InnerException, typeof(ValidationException));
                    endEvent.Set();
                };
                eventStream.StartProcessing();

                endEvent.WaitOne(TimeSpan.FromSeconds(20));
            }
            Assert.IsTrue(exceptionReceived);
            Assert.IsFalse(chunkReceived);
        }
#endif
        static MemoryStream CreateStream(string query, bool createInvalidInput = false)
        {
            StringBuilder promptValueBuilder = new StringBuilder();
            if (createInvalidInput)
                promptValueBuilder.Append("INVALID INPUT QWEOASDASD");
            promptValueBuilder.Append("Human: ");
            promptValueBuilder.Append(query);
            if (!query.EndsWith("."))
                promptValueBuilder.Append(".");
            promptValueBuilder.AppendLine();
            promptValueBuilder.AppendLine("Assistant: ");
            MemoryStream stream = new MemoryStream();
            AnthropicClaudeV2Json jsonObject = new AnthropicClaudeV2Json
            {
                prompt = promptValueBuilder.ToString(),
                max_tokens_to_sample = 300
            };
            JsonSerializer.Serialize(stream, jsonObject, typeof(AnthropicClaudeV2Json));

            stream.Position = 0;
            return stream;
        }
        private class AnthropicClaudeV2Json
        {
            public string prompt { get; set; }
            public int max_tokens_to_sample { get; set; }
        }
    }
}

