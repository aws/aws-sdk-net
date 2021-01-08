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
    /// UpdateAccountAuditConfiguration Request Marshaller
    /// </summary>       
    public class UpdateAccountAuditConfigurationRequestMarshaller : IMarshaller<IRequest, UpdateAccountAuditConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAccountAuditConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateAccountAuditConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-05-28";            
            request.HttpMethod = "PATCH";

            request.ResourcePath = "/audit/configuration";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAuditCheckConfigurations())
                {
                    context.Writer.WritePropertyName("auditCheckConfigurations");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestAuditCheckConfigurationsKvp in publicRequest.AuditCheckConfigurations)
                    {
                        context.Writer.WritePropertyName(publicRequestAuditCheckConfigurationsKvp.Key);
                        var publicRequestAuditCheckConfigurationsValue = publicRequestAuditCheckConfigurationsKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = AuditCheckConfigurationMarshaller.Instance;
                        marshaller.Marshall(publicRequestAuditCheckConfigurationsValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAuditNotificationTargetConfigurations())
                {
                    context.Writer.WritePropertyName("auditNotificationTargetConfigurations");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestAuditNotificationTargetConfigurationsKvp in publicRequest.AuditNotificationTargetConfigurations)
                    {
                        context.Writer.WritePropertyName(publicRequestAuditNotificationTargetConfigurationsKvp.Key);
                        var publicRequestAuditNotificationTargetConfigurationsValue = publicRequestAuditNotificationTargetConfigurationsKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = AuditNotificationTargetMarshaller.Instance;
                        marshaller.Marshall(publicRequestAuditNotificationTargetConfigurationsValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("roleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateAccountAuditConfigurationRequestMarshaller _instance = new UpdateAccountAuditConfigurationRequestMarshaller();        

        internal static UpdateAccountAuditConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAccountAuditConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}