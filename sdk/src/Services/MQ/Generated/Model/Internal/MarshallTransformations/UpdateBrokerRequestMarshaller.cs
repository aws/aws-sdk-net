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
 * Do not modify this file. This file is generated from the mq-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MQ.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MQ.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateBroker Request Marshaller
    /// </summary>       
    public class UpdateBrokerRequestMarshaller : IMarshaller<IRequest, UpdateBrokerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateBrokerRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateBrokerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MQ");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-11-27";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetBrokerId())
                throw new AmazonMQException("Request object does not have required field BrokerId set");
            request.AddPathResource("{broker-id}", StringUtils.FromString(publicRequest.BrokerId));
            request.ResourcePath = "/v1/brokers/{broker-id}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAuthenticationStrategy())
                {
                    context.Writer.WritePropertyName("authenticationStrategy");
                    context.Writer.Write(publicRequest.AuthenticationStrategy);
                }

                if(publicRequest.IsSetAutoMinorVersionUpgrade())
                {
                    context.Writer.WritePropertyName("autoMinorVersionUpgrade");
                    context.Writer.Write(publicRequest.AutoMinorVersionUpgrade);
                }

                if(publicRequest.IsSetConfiguration())
                {
                    context.Writer.WritePropertyName("configuration");
                    context.Writer.WriteObjectStart();

                    var marshaller = ConfigurationIdMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Configuration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDataReplicationMode())
                {
                    context.Writer.WritePropertyName("dataReplicationMode");
                    context.Writer.Write(publicRequest.DataReplicationMode);
                }

                if(publicRequest.IsSetEngineVersion())
                {
                    context.Writer.WritePropertyName("engineVersion");
                    context.Writer.Write(publicRequest.EngineVersion);
                }

                if(publicRequest.IsSetHostInstanceType())
                {
                    context.Writer.WritePropertyName("hostInstanceType");
                    context.Writer.Write(publicRequest.HostInstanceType);
                }

                if(publicRequest.IsSetLdapServerMetadata())
                {
                    context.Writer.WritePropertyName("ldapServerMetadata");
                    context.Writer.WriteObjectStart();

                    var marshaller = LdapServerMetadataInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LdapServerMetadata, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetLogs())
                {
                    context.Writer.WritePropertyName("logs");
                    context.Writer.WriteObjectStart();

                    var marshaller = LogsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Logs, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMaintenanceWindowStartTime())
                {
                    context.Writer.WritePropertyName("maintenanceWindowStartTime");
                    context.Writer.WriteObjectStart();

                    var marshaller = WeeklyStartTimeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MaintenanceWindowStartTime, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSecurityGroups())
                {
                    context.Writer.WritePropertyName("securityGroups");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSecurityGroupsListValue in publicRequest.SecurityGroups)
                    {
                            context.Writer.Write(publicRequestSecurityGroupsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateBrokerRequestMarshaller _instance = new UpdateBrokerRequestMarshaller();        

        internal static UpdateBrokerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateBrokerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}