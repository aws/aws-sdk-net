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
 * Do not modify this file. This file is generated from the mwaa-serverless-2024-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MWAAServerless.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MWAAServerless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateWorkflow Request Marshaller
    /// </summary>       
    public class UpdateWorkflowRequestMarshaller : IMarshaller<IRequest, UpdateWorkflowRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateWorkflowRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateWorkflowRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MWAAServerless");
            string target = "AmazonMWAAServerless.UpdateWorkflow";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-07-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDefinitionS3Location())
                {
                    context.Writer.WritePropertyName("DefinitionS3Location");
                    context.Writer.WriteObjectStart();

                    var marshaller = DefinitionS3LocationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DefinitionS3Location, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEngineVersion())
                {
                    context.Writer.WritePropertyName("EngineVersion");
                    context.Writer.Write(publicRequest.EngineVersion);
                }

                if(publicRequest.IsSetLoggingConfiguration())
                {
                    context.Writer.WritePropertyName("LoggingConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = LoggingConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LoggingConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetNetworkConfiguration())
                {
                    context.Writer.WritePropertyName("NetworkConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = NetworkConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.NetworkConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("RoleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                if(publicRequest.IsSetTriggerMode())
                {
                    context.Writer.WritePropertyName("TriggerMode");
                    context.Writer.Write(publicRequest.TriggerMode);
                }

                if(publicRequest.IsSetWorkflowArn())
                {
                    context.Writer.WritePropertyName("WorkflowArn");
                    context.Writer.Write(publicRequest.WorkflowArn);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateWorkflowRequestMarshaller _instance = new UpdateWorkflowRequestMarshaller();        

        internal static UpdateWorkflowRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateWorkflowRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}