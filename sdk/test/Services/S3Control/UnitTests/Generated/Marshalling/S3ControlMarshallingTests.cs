/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.S3Control;
using Amazon.S3Control.Model;
using Amazon.S3Control.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class S3ControlMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("s3control");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void DeletePublicAccessBlockMarshallTest()
        {
            var operation = service_model.FindOperation("DeletePublicAccessBlock");

            var request = InstantiateClassGenerator.Execute<DeletePublicAccessBlockRequest>();
            var marshaller = new DeletePublicAccessBlockRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("DeletePublicAccessBlock", request, internalRequest, service_model);            

        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void GetPublicAccessBlockMarshallTest()
        {
            var operation = service_model.FindOperation("GetPublicAccessBlock");

            var request = InstantiateClassGenerator.Execute<GetPublicAccessBlockRequest>();
            var marshaller = new GetPublicAccessBlockRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("GetPublicAccessBlock", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();            
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = GetPublicAccessBlockResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as GetPublicAccessBlockResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);       
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Xml")]
        [TestCategory("S3Control")]
        public void PutPublicAccessBlockMarshallTest()
        {
            var operation = service_model.FindOperation("PutPublicAccessBlock");

            var request = InstantiateClassGenerator.Execute<PutPublicAccessBlockRequest>();
            var marshaller = new PutPublicAccessBlockRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PutPublicAccessBlock", request, internalRequest, service_model);            

        }

            }
}