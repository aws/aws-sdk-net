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
 * Do not modify this file. This file is generated from the runtime.lex-2016-11-28.normal.json service model.
 */


using System;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.Lex;
using Amazon.Lex.Model;
using Amazon.Lex.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class LexMarshallingTests
    {
        static readonly ServiceModel service_model = Utils.LoadServiceModel("runtime.lex");
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
        public void PostContentMarshallTest()
        {
            var operation = service_model.FindOperation("PostContent");

            var request = InstantiateClassGenerator.Execute<PostContentRequest>();
            var marshaller = new PostContentRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PostContent", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"Content-Type","Content-Type_Value"},
                    {"x-amz-lex-dialog-state","x-amz-lex-dialog-state_Value"},
                    {"x-amz-lex-input-transcript","x-amz-lex-input-transcript_Value"},
                    {"x-amz-lex-intent-name","x-amz-lex-intent-name_Value"},
                    {"x-amz-lex-message","x-amz-lex-message_Value"},
                    {"x-amz-lex-message-format","x-amz-lex-message-format_Value"},
                    {"x-amz-lex-session-attributes",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-session-attributes_Value"))},
                    {"x-amz-lex-slots",Convert.ToBase64String(Encoding.UTF8.GetBytes("x-amz-lex-slots_Value"))},
                    {"x-amz-lex-slot-to-elicit","x-amz-lex-slot-to-elicit_Value"},
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = PostContentResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PostContentResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("Lex")]
        public void PostTextMarshallTest()
        {
            var operation = service_model.FindOperation("PostText");

            var request = InstantiateClassGenerator.Execute<PostTextRequest>();
            var marshaller = new PostTextRequestMarshaller();

            var internalRequest = marshaller.Marshall(request);
            TestTools.RequestValidator.Validate("PostText", request, internalRequest, service_model);            

            var webResponse = new WebResponseData
            {
                Headers = {
                    {"x-amzn-RequestId", Guid.NewGuid().ToString()},
                    {"x-amz-crc32","0"}
                }
            };
            
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
            webResponse.Headers["Content-Length"] = UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString();
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
            ResponseUnmarshaller unmarshaller = PostTextResponseUnmarshaller.Instance;
            var response = unmarshaller.Unmarshall(context)
                as PostTextResponse;   
            InstantiateClassGenerator.ValidateObjectFullyInstantiated(response);               
        }

            }
}