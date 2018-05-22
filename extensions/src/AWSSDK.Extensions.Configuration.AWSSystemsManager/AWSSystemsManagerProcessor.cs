using System.Collections.Generic;
using System.Threading.Tasks;
using Amazon.Extensions.NETCore.Setup;
using Amazon.SimpleSystemsManagement;
using Amazon.SimpleSystemsManagement.Model;

namespace AWSSDK.Extensions.Configuration.AWSSystemsManager
{
    internal interface IAWSSystemsManagerProcessor
    {
        Task<List<Parameter>> GetParametersByPath(AWSOptions awsOptions, string path);
    }

    internal class AWSSystemsManagerProcessor : IAWSSystemsManagerProcessor
    {
        public async Task<List<Parameter>> GetParametersByPath(AWSOptions awsOptions, string path)
        {
            using (var client = awsOptions.CreateServiceClient<IAmazonSimpleSystemsManagement>())
            {
                var parameters = new List<Parameter>();
                string nextToken = null;
                do
                {
                    var response = await client.GetParametersByPathAsync(new GetParametersByPathRequest { Path = path, Recursive = true, WithDecryption = true, NextToken = nextToken });
                    nextToken = response.NextToken;
                    parameters.AddRange(response.Parameters);
                } while (nextToken != null);

                return parameters;
            }
        }
    }
}