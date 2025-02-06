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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
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
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAuthenticationStrategy())
            {
                context.Writer.WritePropertyName("authenticationStrategy");
                context.Writer.WriteStringValue(publicRequest.AuthenticationStrategy);
            }

            if(publicRequest.IsSetAutoMinorVersionUpgrade())
            {
                context.Writer.WritePropertyName("autoMinorVersionUpgrade");
                context.Writer.WriteBooleanValue(publicRequest.AutoMinorVersionUpgrade.Value);
            }

            if(publicRequest.IsSetConfiguration())
            {
                context.Writer.WritePropertyName("configuration");
                context.Writer.WriteStartObject();

                var marshaller = ConfigurationIdMarshaller.Instance;
                marshaller.Marshall(publicRequest.Configuration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDataReplicationMode())
            {
                context.Writer.WritePropertyName("dataReplicationMode");
                context.Writer.WriteStringValue(publicRequest.DataReplicationMode);
            }

            if(publicRequest.IsSetEngineVersion())
            {
                context.Writer.WritePropertyName("engineVersion");
                context.Writer.WriteStringValue(publicRequest.EngineVersion);
            }

            if(publicRequest.IsSetHostInstanceType())
            {
                context.Writer.WritePropertyName("hostInstanceType");
                context.Writer.WriteStringValue(publicRequest.HostInstanceType);
            }

            if(publicRequest.IsSetLdapServerMetadata())
            {
                context.Writer.WritePropertyName("ldapServerMetadata");
                context.Writer.WriteStartObject();

                var marshaller = LdapServerMetadataInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.LdapServerMetadata, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetLogs())
            {
                context.Writer.WritePropertyName("logs");
                context.Writer.WriteStartObject();

                var marshaller = LogsMarshaller.Instance;
                marshaller.Marshall(publicRequest.Logs, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMaintenanceWindowStartTime())
            {
                context.Writer.WritePropertyName("maintenanceWindowStartTime");
                context.Writer.WriteStartObject();

                var marshaller = WeeklyStartTimeMarshaller.Instance;
                marshaller.Marshall(publicRequest.MaintenanceWindowStartTime, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSecurityGroups())
            {
                context.Writer.WritePropertyName("securityGroups");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSecurityGroupsListValue in publicRequest.SecurityGroups)
                {
                        context.Writer.WriteStringValue(publicRequestSecurityGroupsListValue);
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


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