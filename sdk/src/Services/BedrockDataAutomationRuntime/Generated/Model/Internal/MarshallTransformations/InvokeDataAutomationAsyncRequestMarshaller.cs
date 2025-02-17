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
 * Do not modify this file. This file is generated from the bedrock-data-automation-runtime-2024-06-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockDataAutomationRuntime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockDataAutomationRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InvokeDataAutomationAsync Request Marshaller
    /// </summary>       
    public class InvokeDataAutomationAsyncRequestMarshaller : IMarshaller<IRequest, InvokeDataAutomationAsyncRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((InvokeDataAutomationAsyncRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(InvokeDataAutomationAsyncRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockDataAutomationRuntime");
            string target = "AmazonBedrockKeystoneRuntimeService.InvokeDataAutomationAsync";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-06-13";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBlueprints())
                {
                    context.Writer.WritePropertyName("blueprints");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestBlueprintsListValue in publicRequest.Blueprints)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = BlueprintMarshaller.Instance;
                        marshaller.Marshall(publicRequestBlueprintsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetDataAutomationConfiguration())
                {
                    context.Writer.WritePropertyName("dataAutomationConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = DataAutomationConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DataAutomationConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEncryptionConfiguration())
                {
                    context.Writer.WritePropertyName("encryptionConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = EncryptionConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EncryptionConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetInputConfiguration())
                {
                    context.Writer.WritePropertyName("inputConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = InputConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.InputConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetNotificationConfiguration())
                {
                    context.Writer.WritePropertyName("notificationConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = NotificationConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.NotificationConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOutputConfiguration())
                {
                    context.Writer.WritePropertyName("outputConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = OutputConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OutputConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static InvokeDataAutomationAsyncRequestMarshaller _instance = new InvokeDataAutomationAsyncRequestMarshaller();        

        internal static InvokeDataAutomationAsyncRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InvokeDataAutomationAsyncRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}