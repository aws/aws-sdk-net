using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Amazon.DataPipeline;
using Amazon.DataPipeline.Model;
using CommonTests.Framework;
using NUnit.Framework;

namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class DataPipeline : TestBase<AmazonDataPipelineClient>
    {
        [Test]
        [Category("DataPipeline")]
        public void TestListPipelines()
        {
            var response = Client.ListPipelinesAsync().Result;
            Assert.IsNotNull(response);

            // if test a/c had some pipelines, iterate through
            // to verify marshal
            if (response.PipelineIdList.Count > 0)
            {
                foreach (var p in response.PipelineIdList)
                {
                    Assert.IsNotNull(p);
                    Assert.IsFalse(string.IsNullOrEmpty(p.Id));
                }
            }
        }

        //[Test]
        [Category("DataPipeline")]
        public void TestPipelineOperations()
        {
            const string testPipelineName = "dotnet-test-pipeline";
            const string testPipelineDescription = "dotnet test pipeline";
            
            var testPipelineId = "dotnet-test-pipeline" + DateTime.Now.ToFileTime();

            const string testObjectId = "123";
            const string testObjectName = "object";

            string createdPipelineId = null;

            try
            {
                var createPipelineResult
                    = Client.CreatePipelineAsync(new CreatePipelineRequest
                    {
                        Name = testPipelineName,
                        UniqueId = testPipelineId,
                        Description = testPipelineDescription
                    }).Result;
                createdPipelineId = createPipelineResult.PipelineId;
                Assert.IsNotNull(createdPipelineId);

                var pipelineObject = new PipelineObject { Id = testObjectId, Name = testObjectName };
                var field = new Field { Key = "workerGroup", StringValue = "dotnetsdk" };
                pipelineObject.Fields = new List<Field> { field };

                var putPipelineDefinitionResult
                    = Client.PutPipelineDefinitionAsync(new PutPipelineDefinitionRequest
                    {
                        PipelineId = createdPipelineId,
                        PipelineObjects = new List<PipelineObject> { pipelineObject }
                    }).Result;
                Assert.IsFalse(putPipelineDefinitionResult.Errored);

                var tags = new List<Tag>
                {
                    new Tag { Key = "tag1", Value = "42" },
                    new Tag { Key = "tag2", Value = DateTime.Now.ToString() }
                };
                Client.AddTagsAsync(createdPipelineId, tags).Wait();

                var describeResult = Client.DescribePipelinesAsync(new List<string> { createdPipelineId }).Result.PipelineDescriptionList;
                Assert.AreEqual(1, describeResult.Count);
                Assert.AreEqual(tags.Count, describeResult.First().Tags.Count);

                Client.RemoveTagsAsync(createdPipelineId, new List<string> { "tag1" }).Wait();

                describeResult = Client.DescribePipelinesAsync(new List<string> { createdPipelineId }).Result.PipelineDescriptionList;
                Assert.AreEqual(1, describeResult.Count);
                Assert.AreEqual(1, describeResult.First().Tags.Count);

                var activatePipelineResult = Client.ActivatePipelineAsync(new ActivatePipelineRequest
                {
                    PipelineId = createdPipelineId
                }).Result;
                Assert.IsNotNull(activatePipelineResult);

                
                var foundPipeline = false;
                for (int retries = 0; retries < 5 && !foundPipeline; retries++)
                {
                    UtilityMethods.Sleep(TimeSpan.FromSeconds(retries));

                    var listRequest = new ListPipelinesRequest();
                    var listResponse = new ListPipelinesResponse();
                    do
                    {
                        listRequest.Marker = listResponse.Marker;
                        listResponse = Client.ListPipelinesAsync(listRequest).Result;
                        if (listResponse.PipelineIdList.Count > 0)
                        {
                            if (listResponse.PipelineIdList.Any(p => p.Id.Equals(createdPipelineId) && p.Name.Equals(testPipelineName)))
                            {
                                foundPipeline = true;
                                break;
                            }
                        }
                    } while (!string.IsNullOrEmpty(listResponse.Marker));
                }
                Assert.IsTrue(foundPipeline);
            }
            finally
            {
                if (!string.IsNullOrEmpty(createdPipelineId))
                {
                    Client.DeletePipelineAsync(new DeletePipelineRequest { PipelineId = createdPipelineId }).Wait();
                }
            }    
        }
    }
}
