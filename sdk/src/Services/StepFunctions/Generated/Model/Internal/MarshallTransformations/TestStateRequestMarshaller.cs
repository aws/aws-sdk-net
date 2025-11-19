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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.StepFunctions.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.StepFunctions.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TestState Request Marshaller
    /// </summary>       
    public class TestStateRequestMarshaller : IMarshaller<IRequest, TestStateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((TestStateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(TestStateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.StepFunctions");
            string target = "AWSStepFunctions.TestState";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-11-23";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetContext())
                {
                    context.Writer.WritePropertyName("context");
                    context.Writer.Write(publicRequest.Context);
                }

                if(publicRequest.IsSetDefinition())
                {
                    context.Writer.WritePropertyName("definition");
                    context.Writer.Write(publicRequest.Definition);
                }

                if(publicRequest.IsSetInput())
                {
                    context.Writer.WritePropertyName("input");
                    context.Writer.Write(publicRequest.Input);
                }

                if(publicRequest.IsSetInspectionLevel())
                {
                    context.Writer.WritePropertyName("inspectionLevel");
                    context.Writer.Write(publicRequest.InspectionLevel);
                }

                if(publicRequest.IsSetMock())
                {
                    context.Writer.WritePropertyName("mock");
                    context.Writer.WriteObjectStart();

                    var marshaller = MockInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Mock, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRevealSecrets())
                {
                    context.Writer.WritePropertyName("revealSecrets");
                    context.Writer.Write(publicRequest.RevealSecrets);
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("roleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                if(publicRequest.IsSetStateConfiguration())
                {
                    context.Writer.WritePropertyName("stateConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = TestStateConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.StateConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetStateName())
                {
                    context.Writer.WritePropertyName("stateName");
                    context.Writer.Write(publicRequest.StateName);
                }

                if(publicRequest.IsSetVariables())
                {
                    context.Writer.WritePropertyName("variables");
                    context.Writer.Write(publicRequest.Variables);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            
            request.HostPrefix = $"sync-";

            return request;
        }
        private static TestStateRequestMarshaller _instance = new TestStateRequestMarshaller();        

        internal static TestStateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TestStateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}