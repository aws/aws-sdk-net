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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartAuditMitigationActionsTask Request Marshaller
    /// </summary>       
    public class StartAuditMitigationActionsTaskRequestMarshaller : IMarshaller<IRequest, StartAuditMitigationActionsTaskRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartAuditMitigationActionsTaskRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartAuditMitigationActionsTaskRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-05-28";            
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetTaskId())
                throw new AmazonIoTException("Request object does not have required field TaskId set");
            request.AddPathResource("{taskId}", StringUtils.FromString(publicRequest.TaskId));
            request.ResourcePath = "/audit/mitigationactions/tasks/{taskId}";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAuditCheckToActionsMapping())
                {
                    context.Writer.WritePropertyName("auditCheckToActionsMapping");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestAuditCheckToActionsMappingKvp in publicRequest.AuditCheckToActionsMapping)
                    {
                        context.Writer.WritePropertyName(publicRequestAuditCheckToActionsMappingKvp.Key);
                        var publicRequestAuditCheckToActionsMappingValue = publicRequestAuditCheckToActionsMappingKvp.Value;

                        context.Writer.WriteArrayStart();
                        foreach(var publicRequestAuditCheckToActionsMappingValueListValue in publicRequestAuditCheckToActionsMappingValue)
                        {
                                context.Writer.Write(publicRequestAuditCheckToActionsMappingValueListValue);
                        }
                        context.Writer.WriteArrayEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetClientRequestToken())
                {
                    context.Writer.WritePropertyName("clientRequestToken");
                    context.Writer.Write(publicRequest.ClientRequestToken);
                }

                else if(!(publicRequest.IsSetClientRequestToken()))
                {
                    context.Writer.WritePropertyName("clientRequestToken");
                    context.Writer.Write(Guid.NewGuid().ToString());                                                
                }
                if(publicRequest.IsSetTarget())
                {
                    context.Writer.WritePropertyName("target");
                    context.Writer.WriteObjectStart();

                    var marshaller = AuditMitigationActionsTaskTargetMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Target, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartAuditMitigationActionsTaskRequestMarshaller _instance = new StartAuditMitigationActionsTaskRequestMarshaller();        

        internal static StartAuditMitigationActionsTaskRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartAuditMitigationActionsTaskRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}