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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2.Model.Internal.MarshallTransformations;
using Amazon.EC2.Model;
using Amazon.EC2.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using System.Text;
using Amazon.S3;
using Amazon.S3.Util;
using Amazon;
using Amazon.S3.Model;
using System.Threading.Tasks;
using System;
using System.Diagnostics;
using System.IO;
using AWSSDK_DotNet.UnitTests.TestTools;
namespace AWSSDK.Benchmarks
{
    public class MarshallAndUnmarshallBenchmarks
    {
        PutItemRequest jsonRequest;
        [GlobalSetup(Targets = new[] { nameof(MarshallJSON) })]
        public void setupForMarshallJSON()
        {
            jsonRequest = InstantiateClassGenerator.Execute<PutItemRequest>();
        }

        /// <summary>
        /// Test marshalling a DynamoDB PutItem request from object to JSON
        /// </summary>
        [Benchmark]
        public void MarshallJSON()
        {
            var marshaller = new PutItemRequestMarshaller();
            marshaller.Marshall(jsonRequest);
        }

        private UnmarshallerContext jsonResponseContext;
        [GlobalSetup(Targets = new[] { nameof(UnmarshallJSON) })]
        public void setupForUnmarshallJSON()
        {
            var service_model = Utils.LoadServiceModel("dynamodb");
            var operation = service_model.FindOperation("PutItem");

            var jsonResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            webResponse.Headers.Add("Content-Length", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());

            jsonResponseContext = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
        }


        /// <summary>
        /// Test unmarshalling a DynamoDB PutItem request from JSON to the response object
        /// </summary>
        [Benchmark]
        public void UnmarshallJSON()
        {
            PutItemResponseUnmarshaller.Instance.Unmarshall(jsonResponseContext);
        }

        private RunInstancesRequest runInstancesRequest;

        #region XML Marshall/Unmarshall
        [GlobalSetup(Targets = new[] { nameof(MarshallXML) })]
        public void setupForMarshallXML()
        {
            runInstancesRequest = InstantiateClassGenerator.Execute<RunInstancesRequest>();
        }


        /// <summary>
        /// Test marshalling an EC2 RunInstances request from the request object to XML
        /// </summary>
        [Benchmark]
        public void MarshallXML()
        {
            var marshaller = new RunInstancesRequestMarshaller();
            marshaller.Marshall(runInstancesRequest);
        }


        private string xmlResponse;
        [GlobalSetup(Targets = new[] { nameof(UnmarshallXML) })]
        public void setupForUnmarshallXML()
        {
            var service_model = Utils.LoadServiceModel("ec2");
            var operation = service_model.FindOperation("RunInstances");

            xmlResponse = new XmlSampleGenerator(service_model, operation).Execute();
        }

        /// <summary>
        /// Test unmarshalling an EC2 RunInstances response from XML to the response object
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
