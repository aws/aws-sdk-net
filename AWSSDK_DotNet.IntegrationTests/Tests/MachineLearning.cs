using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.MachineLearning;
using Amazon.MachineLearning.Model;
using AWSSDK_DotNet.IntegrationTests.Utils;
using AWSSDK_DotNet.IntegrationTests.Tests;
using Amazon.S3;
using Amazon.S3.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.S3.Util;
using System.Threading;


namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class MachineLearning : TestBase<AmazonMachineLearningClient>
    {
        static AmazonS3Client s3Client = new AmazonS3Client();
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

        
        [ClassInitialize]
        public static void Setup(TestContext ctx)
        {
            s3Client.PutBucket(bucketName);
        }

        [ClassCleanup]
        public static void Teardown()
        {
            AmazonS3Util.DeleteS3BucketWithObjects(s3Client, bucketName);

            var models = Client.DescribeMLModels(new DescribeMLModelsRequest {
                FilterVariable = MLModelFilterVariable.Name,
                Prefix = testRunId
            }).Results;

            foreach (var model in models)
            {
                try
                {
                    if (model.EndpointInfo.EndpointStatus != RealtimeEndpointStatus.NONE)
                        Client.DeleteRealtimeEndpoint(new DeleteRealtimeEndpointRequest { MLModelId = model.MLModelId });
                    Client.DeleteMLModel(new DeleteMLModelRequest { MLModelId = model.MLModelId });
                }
                catch
                {
                    Console.WriteLine("Failed to remove Model with id={0}", model.MLModelId);
                }
            }

            var dataSources = Client.DescribeDataSources(new DescribeDataSourcesRequest {
                FilterVariable = DataSourceFilterVariable.DataLocationS3,
                Prefix = "s3://" + testRunId
            }).Results;

            foreach (var ds in dataSources) 
            {             
                try
                {
                    Client.DeleteDataSource(new DeleteDataSourceRequest { DataSourceId = ds.DataSourceId });
                }
                catch
                {
                    Console.WriteLine("Failed to remove DataSource with id={0}", ds.DataSourceId);
                }
            }
        }

        
        //[TestMethod]
        [TestCategory("MachineLearning")]
        public void TestCreateModel()
        {
            s3Client.PutObject(new PutObjectRequest { 
                BucketName = bucketName, 
                Key = "data.csv", 
                ContentBody = "0, 42, foo, bar", 
                CannedACL = S3CannedACL.PublicRead 
            });

            var dataLocation = String.Format("s3://{0}/data.csv", bucketName);

            var dataSourceId = Client.CreateDataSourceFromS3(new CreateDataSourceFromS3Request {
                ComputeStatistics = true,
                DataSpec = new S3DataSpec 
                {
                    DataLocationS3 = dataLocation,
                    DataSchema = DATA_SCHEMA
                }
            }).DataSourceId;

            var source = Client.DescribeDataSources(new DescribeDataSourcesRequest
            {
                  FilterVariable = DataSourceFilterVariable.DataLocationS3,
                  EQ = dataLocation
            }).Results.FirstOrDefault();

            Assert.IsNotNull(source);

            var modelName = UtilityMethods.GenerateName(testRunId);

            var modelId = Client.CreateMLModel(new CreateMLModelRequest { 
                MLModelName = modelName,
                TrainingDataSourceId = dataSourceId,
                MLModelType = MLModelType.BINARY
            }).MLModelId;

            UtilityMethods.WaitUntil(() => {
                var model = Client.DescribeMLModels(new DescribeMLModelsRequest {
                    FilterVariable = MLModelFilterVariable.Name,
                    EQ = modelName
                }).Results.First();

                return model.Status == EntityStatus.COMPLETED;
                }, 30, 1800);

            var uri = Client.CreateRealtimeEndpoint(new CreateRealtimeEndpointRequest
            {
                MLModelId = modelId
            }).RealtimeEndpointInfo.EndpointUrl;

            UtilityMethods.WaitUntil(() => {
                var model = Client.DescribeMLModels(new DescribeMLModelsRequest
                {
                    FilterVariable = MLModelFilterVariable.Name,
                    EQ = modelName
                }).Results.First();

                return model.EndpointInfo.EndpointStatus == RealtimeEndpointStatus.READY;
            }, 30, 1800);

            Assert.IsNotNull(uri);

            // READY doesn't mean ready...

            Thread.Sleep(TimeSpan.FromSeconds(10));

            var prediction = Client.Predict(new PredictRequest
            {
                MLModelId = modelId,
                PredictEndpoint = uri,
                Record = new Dictionary<string, string> {
                     {"b", "123"}, {"c", "oop"}, {"d", "goop"}
                 }
            }).Prediction;

            Assert.IsNotNull(prediction);
        }
    }

}
