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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTSiteWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdatePortal Request Marshaller
    /// </summary>       
    public class UpdatePortalRequestMarshaller : IMarshaller<IRequest, UpdatePortalRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdatePortalRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdatePortalRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTSiteWise");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetPortalId())
                throw new AmazonIoTSiteWiseException("Request object does not have required field PortalId set");
            request.AddPathResource("{portalId}", StringUtils.FromString(publicRequest.PortalId));
            request.ResourcePath = "/portals/{portalId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAlarms())
                {
                    context.Writer.WritePropertyName("alarms");
                    context.Writer.WriteObjectStart();

                    var marshaller = AlarmsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Alarms, context);

                    context.Writer.WriteObjectEnd();
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
                if(publicRequest.IsSetNotificationSenderEmail())
                {
                    context.Writer.WritePropertyName("notificationSenderEmail");
                    context.Writer.Write(publicRequest.NotificationSenderEmail);
                }

                if(publicRequest.IsSetPortalContactEmail())
                {
                    context.Writer.WritePropertyName("portalContactEmail");
                    context.Writer.Write(publicRequest.PortalContactEmail);
                }

                if(publicRequest.IsSetPortalDescription())
                {
                    context.Writer.WritePropertyName("portalDescription");
                    context.Writer.Write(publicRequest.PortalDescription);
                }

                if(publicRequest.IsSetPortalLogoImage())
                {
                    context.Writer.WritePropertyName("portalLogoImage");
                    context.Writer.WriteObjectStart();

                    var marshaller = ImageMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PortalLogoImage, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPortalName())
                {
                    context.Writer.WritePropertyName("portalName");
                    context.Writer.Write(publicRequest.PortalName);
                }

                if(publicRequest.IsSetPortalType())
                {
                    context.Writer.WritePropertyName("portalType");
                    context.Writer.Write(publicRequest.PortalType);
                }

                if(publicRequest.IsSetPortalTypeConfiguration())
                {
                    context.Writer.WritePropertyName("portalTypeConfiguration");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestPortalTypeConfigurationKvp in publicRequest.PortalTypeConfiguration)
                    {
                        context.Writer.WritePropertyName(publicRequestPortalTypeConfigurationKvp.Key);
                        var publicRequestPortalTypeConfigurationValue = publicRequestPortalTypeConfigurationKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = PortalTypeEntryMarshaller.Instance;
                        marshaller.Marshall(publicRequestPortalTypeConfigurationValue, context);

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

            
            request.HostPrefix = $"monitor.";

            return request;
        }
        private static UpdatePortalRequestMarshaller _instance = new UpdatePortalRequestMarshaller();        

        internal static UpdatePortalRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdatePortalRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}