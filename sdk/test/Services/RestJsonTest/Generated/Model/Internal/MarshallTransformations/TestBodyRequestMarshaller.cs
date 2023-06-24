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

/*
 * Do not modify this file. This file is generated from the rest-json-test-2016-04-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RestJsonTest.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.RestJsonTest.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TestBody Request Marshaller
    /// </summary>       
    public class TestBodyRequestMarshaller : IMarshaller<IRequest, TestBodyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((TestBodyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(TestBodyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RestJsonTest");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-05-13";
            request.HttpMethod = "POST";

            request.ResourcePath = "/body";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetTestConfig())
                {
                    context.Writer.WritePropertyName("testConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = TestConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TestConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

        
            if (publicRequest.IsSetTestId()) 
            {
                request.Headers["x-amz-test-id"] = publicRequest.TestId;
            }

            return request;
        }
        private static TestBodyRequestMarshaller _instance = new TestBodyRequestMarshaller();        

        internal static TestBodyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TestBodyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}