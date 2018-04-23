using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Amazon.DataPipeline;
using Amazon.DataPipeline.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class DataPipeline : TestBase<AmazonDataPipelineClient>
    {
        [TestMethod]
        [TestCategory("DataPipeline")]
        public void TestListPipelines()
        {
            var response = Client.ListPipelines();
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

        //[TestMethod]
        [TestCategory("DataPipeline")]
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
                    = Client.CreatePipeline(new CreatePipelineRequest
                    {
                        Name = testPipelineName,
                        UniqueId = testPipelineId,
                        Description = testPipelineDescription
                    });
                createdPipelineId = createPipelineResult.PipelineId;
                Assert.IsNotNull(createdPipelineId);

                var pipelineObject = new PipelineObject { Id = testObjectId, Name = testObjectName };
                var field = new Field { Key = "workerGroup", StringValue = "dotnetsdk" };
                pipelineObject.Fields = new List<Field> { field };

                var putPipelineDefinitionResult
                    = Client.PutPipelineDefinition(new PutPipelineDefinitionRequest
                    {
                        PipelineId = createdPipelineId,
                        PipelineObjects = new List<PipelineObject> { pipelineObject }
                    });
                Assert.IsFalse(putPipelineDefinitionResult.Errored);

                var tags = new List<Tag>
                {
                    new Tag { Key = "tag1", Value = "42" },
                    new Tag { Key = "tag2", Value = DateTime.Now.ToString() }
                };
                Client.AddTags(createdPipelineId, tags);

                var describeResult = Client.DescribePipelines(new List<string> { createdPipelineId }).PipelineDescriptionList;
                Assert.AreEqual(1, describeResult.Count);
                Assert.AreEqual(tags.Count, describeResult.First().Tags.Count);

                Client.RemoveTags(createdPipelineId, new List<string> { "tag1" });

                describeResult = Client.DescribePipelines(new List<string> { createdPipelineId }).PipelineDescriptionList;
                Assert.AreEqual(1, describeResult.Count);
                Assert.AreEqual(1, describeResult.First().Tags.Count);

                var activatePipelineResult = Client.ActivatePipeline(new ActivatePipelineRequest
                {
                    PipelineId = createdPipelineId
                });
                Assert.IsNotNull(activatePipelineResult);

                
                var foundPipeline = false;
                for (int retries = 0; retries < 5 && !foundPipeline; retries++)
                {
                    Thread.Sleep(1000 * retries);

                    var listRequest = new ListPipelinesRequest();
                    var listResponse = new ListPipelinesResponse();
                    do
                    {
                        listRequest.Marker = listResponse.Marker;
                        listResponse = Client.ListPipelines(listRequest);
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
                    Client.DeletePipeline(new DeletePipelineRequest { PipelineId = createdPipelineId });
                }
            }    
        }
    }
}
