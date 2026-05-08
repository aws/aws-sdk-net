/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2.Model.Internal.MarshallTransformations;
using Amazon.EC2.Model;
using Amazon.EC2.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using BenchmarkDotNet.Jobs;
using System.Text;
using AWSSDK_DotNet.UnitTests.TestTools;

namespace AWSSDK.Benchmarks
{
    /// <summary>
    /// Benchmarks for marshalling (serialization) and unmarshalling (deserialization)
    /// of AWS SDK request/response objects across JSON and XML protocols.
    /// Uses InProcessEmitToolchain (via SdkBenchmarkConfig) to avoid assembly resolution
    /// issues with internal SDK types when BenchmarkDotNet runs benchmarks out-of-process.
    /// </summary>
    [Config(typeof(SdkBenchmarkConfig))]
    public class MarshallAndUnmarshallBenchmarks
    {
        #region JSON Marshall/Unmarshall (DynamoDB - RestJson protocol)

        private PutItemRequest jsonRequest;

        [GlobalSetup(Targets = new[] { nameof(MarshallJSON) })]
        public void SetupForMarshallJSON()
        {
            jsonRequest = InstantiateClassGenerator.Execute<PutItemRequest>();
        }

        /// <summary>
        /// Test marshalling a DynamoDB PutItem request from object to JSON.
        /// Measures the serialization performance of the RestJson protocol.
        /// </summary>
        [Benchmark]
        public void MarshallJSON()
        {
            var marshaller = new PutItemRequestMarshaller();
            marshaller.Marshall(jsonRequest);
        }

        private string jsonResponseString;
        private byte[] jsonResponseBytes;

        [GlobalSetup(Targets = new[] { nameof(UnmarshallJSON) })]
        public void SetupForUnmarshallJSON()
        {
            var service_model = Utils.LoadServiceModel("dynamodb");
            var operation = service_model.FindOperation("PutItem");
            jsonResponseString = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            jsonResponseBytes = Encoding.UTF8.GetBytes(jsonResponseString);
        }

        /// <summary>
        /// Test unmarshalling a DynamoDB PutItem response from JSON to the response object.
        /// Measures the deserialization performance of the RestJson protocol using System.Text.Json.
        /// A new stream and context are created per iteration to avoid stream position issues.
        /// </summary>
        [Benchmark]
        public void UnmarshallJSON()
        {
            // Create a fresh stream and context for each iteration since v4's
            // StreamingUtf8JsonReader consumes the stream during unmarshalling
            using var stream = new MemoryStream(jsonResponseBytes);
            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"},
                    {"Content-Length", jsonResponseBytes.Length.ToString()}
                }
            };
            using var context = new JsonUnmarshallerContext(stream, false, webResponse);
            PutItemResponseUnmarshaller.Instance.Unmarshall(context);
        }

        #endregion

        #region XML Marshall/Unmarshall (EC2 - EC2/Query protocol)

        private RunInstancesRequest runInstancesRequest;

        [GlobalSetup(Targets = new[] { nameof(MarshallXML) })]
        public void SetupForMarshallXML()
        {
            runInstancesRequest = InstantiateClassGenerator.Execute<RunInstancesRequest>();
        }

        /// <summary>
        /// Test marshalling an EC2 RunInstances request from the request object to XML.
        /// Measures the serialization performance of the EC2/Query protocol.
        /// </summary>
        [Benchmark]
        public void MarshallXML()
        {
            var marshaller = new RunInstancesRequestMarshaller();
            marshaller.Marshall(runInstancesRequest);
        }

        private string xmlResponse;

        [GlobalSetup(Targets = new[] { nameof(UnmarshallXML) })]
        public void SetupForUnmarshallXML()
        {
            var service_model = Utils.LoadServiceModel("ec2");
            var operation = service_model.FindOperation("RunInstances");
            xmlResponse = new XmlSampleGenerator(service_model, operation).Execute();
        }

        /// <summary>
        /// Test unmarshalling an EC2 RunInstances response from XML to the response object.
        /// Measures the deserialization performance of the EC2/Query protocol.
        /// </summary>
        [Benchmark]
        public void UnmarshallXML()
        {
            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(xmlResponse), false, new WebResponseData());
            var response = RunInstancesResponseUnmarshaller.Instance.Unmarshall(context)
                as RunInstancesResponse;
        }

        #endregion
    }
}