using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.MachineLearning;
using Amazon.MachineLearning.Model;

using Amazon.S3;
using Amazon.S3.Model;

using Amazon.S3.Util;
using System.Threading;
using NUnit.Framework;
using CommonTests.Framework;


namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class MachineLearning : TestBase<AmazonMachineLearningClient>
    {
        static AmazonS3Client s3Client = TestBase.CreateClient<AmazonS3Client>();
        static string DATA_SCHEMA = @"{
             ""version"": ""1.0"",
             ""recordAnnotationFieldName"": null,
             ""recordWeightFieldName"": null,
             ""targetFieldName"": ""a"",
             ""dataFormat"": ""CSV"",
             ""dataFileContainsHeader"": false,
             ""variables"": [
               {
                 ""fieldName"": ""a"",
                 ""fieldType"": ""BINARY""
               },
               {
                 ""fieldName"": ""b"",
                 ""fieldType"": ""NUMERIC""
               },
               {
                 ""fieldName"": ""c"",
                 ""fieldType"": ""CATEGORICAL""
               },
               {
                 ""fieldName"": ""d"",
                 ""fieldType"": ""TEXT""
               }
             ]
           }";

        static string testRunId = UtilityMethods.GenerateName();
        static string bucketName = testRunId;

        protected override Amazon.RegionEndpoint AlternateEndpoint
        {
            get
            {
                return Amazon.RegionEndpoint.USEast1;
            }
        }

        [OneTimeSetUp]
        public void Setup()
        {
            s3Client.PutBucketAsync(bucketName).Wait();
        }

        [OneTimeTearDown]
        public void Teardown()
        {
            UtilityMethods.DeleteBucketWithObjectsAsync(s3Client, bucketName);

            var models = Client.DescribeMLModelsAsync(new DescribeMLModelsRequest {
                FilterVariable = MLModelFilterVariable.Name,
                Prefix = testRunId
            }).Result.Results;

            foreach (var model in models)
            {
                try
                {
                    if (model.EndpointInfo.EndpointStatus != RealtimeEndpointStatus.NONE)
                        Client.DeleteRealtimeEndpointAsync(new DeleteRealtimeEndpointRequest { MLModelId = model.MLModelId }).Wait();
                    Client.DeleteMLModelAsync(new DeleteMLModelRequest { MLModelId = model.MLModelId }).Wait();
                }
                catch
                {
                    Console.WriteLine("Failed to remove Model with id={0}", model.MLModelId);
                }
            }

            var dataSources = Client.DescribeDataSourcesAsync(new DescribeDataSourcesRequest {
                FilterVariable = DataSourceFilterVariable.DataLocationS3,
                Prefix = "s3://" + testRunId
            }).Result.Results;

            foreach (var ds in dataSources) 
            {             
                try
                {
                    Client.DeleteDataSourceAsync(new DeleteDataSourceRequest { DataSourceId = ds.DataSourceId }).Wait();
                }
                catch
                {
                    Console.WriteLine("Failed to remove DataSource with id={0}", ds.DataSourceId);
                }
            }
        }

        
        //[Test]
        [Category("MachineLearning")]
        public void TestCreateModel()
        {
            s3Client.PutObjectAsync(new PutObjectRequest { 
                BucketName = bucketName, 
                Key = "data.csv", 
                ContentBody = "0, 42, foo, bar", 
                CannedACL = S3CannedACL.PublicRead 
            }).Wait();

            var dataLocation = String.Format("s3://{0}/data.csv", bucketName);

            var dataSourceId = Client.CreateDataSourceFromS3Async(new CreateDataSourceFromS3Request {
                ComputeStatistics = true,
                DataSpec = new S3DataSpec 
                {
                    DataLocationS3 = dataLocation,
                    DataSchema = DATA_SCHEMA
                }
            }).Result.DataSourceId;

            var source = Client.DescribeDataSourcesAsync(new DescribeDataSourcesRequest
            {
                  FilterVariable = DataSourceFilterVariable.DataLocationS3,
                  EQ = dataLocation
            }).Result.Results.FirstOrDefault();

            Assert.IsNotNull(source);

            var modelName = UtilityMethods.GenerateName(testRunId);

            var modelId = Client.CreateMLModelAsync(new CreateMLModelRequest { 
                MLModelName = modelName,
                TrainingDataSourceId = dataSourceId,
                MLModelType = MLModelType.BINARY
            }).Result.MLModelId;

            UtilityMethods.WaitUntil(() => {
                var model = Client.DescribeMLModelsAsync(new DescribeMLModelsRequest {
                    FilterVariable = MLModelFilterVariable.Name,
                    EQ = modelName
                }).Result.Results.First();

                return model.Status == EntityStatus.COMPLETED;
                }, 30, 1800);

            var uri = Client.CreateRealtimeEndpointAsync(new CreateRealtimeEndpointRequest
            {
                MLModelId = modelId
            }).Result.RealtimeEndpointInfo.EndpointUrl;

            UtilityMethods.WaitUntil(() => {
                var model = Client.DescribeMLModelsAsync(new DescribeMLModelsRequest
                {
                    FilterVariable = MLModelFilterVariable.Name,
                    EQ = modelName
                }).Result.Results.First();

                return model.EndpointInfo.EndpointStatus == RealtimeEndpointStatus.READY;
            }, 30, 1800);

            Assert.IsNotNull(uri);

            // READY doesn't mean ready...

            UtilityMethods.Sleep(TimeSpan.FromSeconds(10));

            var prediction = Client.PredictAsync(new PredictRequest
            {
                MLModelId = modelId,
                PredictEndpoint = uri,
                Record = new Dictionary<string, string> {
                     {"b", "123"}, {"c", "oop"}, {"d", "goop"}
                 }
            }).Result.Prediction;

            Assert.IsNotNull(prediction);
        }
    }

}
