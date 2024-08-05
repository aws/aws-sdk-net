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
 * Do not modify this file. This file is generated from the apptest-2022-12-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppTest.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.AppTest.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateTestSuite Request Marshaller
    /// </summary>       
    public class UpdateTestSuiteRequestMarshaller : IMarshaller<IRequest, UpdateTestSuiteRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateTestSuiteRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateTestSuiteRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppTest");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-12-06";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetTestSuiteId())
                throw new AmazonAppTestException("Request object does not have required field TestSuiteId set");
            request.AddPathResource("{testSuiteId}", StringUtils.FromString(publicRequest.TestSuiteId));
            request.ResourcePath = "/testsuites/{testSuiteId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAfterSteps())
                {
                    context.Writer.WritePropertyName("afterSteps");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAfterStepsListValue in publicRequest.AfterSteps)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = StepMarshaller.Instance;
                        marshaller.Marshall(publicRequestAfterStepsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetBeforeSteps())
                {
                    context.Writer.WritePropertyName("beforeSteps");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestBeforeStepsListValue in publicRequest.BeforeSteps)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = StepMarshaller.Instance;
                        marshaller.Marshall(publicRequestBeforeStepsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetTestCases())
                {
                    context.Writer.WritePropertyName("testCases");
                    context.Writer.WriteObjectStart();

                    var marshaller = TestCasesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TestCases, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateTestSuiteRequestMarshaller _instance = new UpdateTestSuiteRequestMarshaller();        

        internal static UpdateTestSuiteRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateTestSuiteRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}