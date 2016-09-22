using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Amazon.DataPipeline;
using Amazon.DataPipeline.Model;
using Amazon.DNXCore.IntegrationTests;
using Xunit;

namespace Amazon.DNXCore.IntegrationTests
{
    
    public class DataPipeline : TestBase<AmazonDataPipelineClient>
    {
        [Fact]
        [Trait(CategoryAttribute,"DataPipeline")]
        public async Task TestListPipelines()
        {
            var response = await Client.ListPipelinesAsync();
            Assert.NotNull(response);

            // if test a/c had some pipelines, iterate through
            // to verify marshal
            if (response.PipelineIdList.Count > 0)
            {
                foreach (var p in response.PipelineIdList)
                {
                    Assert.NotNull(p);
                    Assert.False(string.IsNullOrEmpty(p.Id));
                }
            }
        }
    }
}
