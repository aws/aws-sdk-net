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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleSystemsManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateMaintenanceWindowTask Request Marshaller
    /// </summary>       
    public class UpdateMaintenanceWindowTaskRequestMarshaller : IMarshaller<IRequest, UpdateMaintenanceWindowTaskRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateMaintenanceWindowTaskRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateMaintenanceWindowTaskRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleSystemsManagement");
            string target = "AmazonSSM.UpdateMaintenanceWindowTask";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetLoggingInfo())
                {
                    context.Writer.WritePropertyName("LoggingInfo");
                    context.Writer.WriteObjectStart();

                    var marshaller = LoggingInfoMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LoggingInfo, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMaxConcurrency())
                {
                    context.Writer.WritePropertyName("MaxConcurrency");
                    context.Writer.Write(publicRequest.MaxConcurrency);
                }

                if(publicRequest.IsSetMaxErrors())
                {
                    context.Writer.WritePropertyName("MaxErrors");
                    context.Writer.Write(publicRequest.MaxErrors);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetPriority())
                {
                    context.Writer.WritePropertyName("Priority");
                    context.Writer.Write(publicRequest.Priority);
                }

                if(publicRequest.IsSetReplace())
                {
                    context.Writer.WritePropertyName("Replace");
                    context.Writer.Write(publicRequest.Replace);
                }

                if(publicRequest.IsSetServiceRoleArn())
                {
                    context.Writer.WritePropertyName("ServiceRoleArn");
                    context.Writer.Write(publicRequest.ServiceRoleArn);
                }

                if(publicRequest.IsSetTargets())
                {
                    context.Writer.WritePropertyName("Targets");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTargetsListValue in publicRequest.Targets)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TargetMarshaller.Instance;
                        marshaller.Marshall(publicRequestTargetsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTaskArn())
                {
                    context.Writer.WritePropertyName("TaskArn");
                    context.Writer.Write(publicRequest.TaskArn);
                }

                if(publicRequest.IsSetTaskInvocationParameters())
                {
                    context.Writer.WritePropertyName("TaskInvocationParameters");
                    context.Writer.WriteObjectStart();

                    var marshaller = MaintenanceWindowTaskInvocationParametersMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TaskInvocationParameters, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTaskParameters())
                {
                    context.Writer.WritePropertyName("TaskParameters");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTaskParametersKvp in publicRequest.TaskParameters)
                    {
                        context.Writer.WritePropertyName(publicRequestTaskParametersKvp.Key);
                        var publicRequestTaskParametersValue = publicRequestTaskParametersKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = MaintenanceWindowTaskParameterValueExpressionMarshaller.Instance;
                        marshaller.Marshall(publicRequestTaskParametersValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetWindowId())
                {
                    context.Writer.WritePropertyName("WindowId");
                    context.Writer.Write(publicRequest.WindowId);
                }

                if(publicRequest.IsSetWindowTaskId())
                {
                    context.Writer.WritePropertyName("WindowTaskId");
                    context.Writer.Write(publicRequest.WindowTaskId);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateMaintenanceWindowTaskRequestMarshaller _instance = new UpdateMaintenanceWindowTaskRequestMarshaller();        

        internal static UpdateMaintenanceWindowTaskRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateMaintenanceWindowTaskRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}