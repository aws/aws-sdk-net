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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GameLift.Model;
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
namespace Amazon.GameLift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateContainerFleet Request Marshaller
    /// </summary>       
    public class UpdateContainerFleetRequestMarshaller : IMarshaller<IRequest, UpdateContainerFleetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateContainerFleetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateContainerFleetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GameLift");
            string target = "GameLift.UpdateContainerFleet";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-10-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDeploymentConfiguration())
            {
                context.Writer.WritePropertyName("DeploymentConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DeploymentConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.DeploymentConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetFleetId())
            {
                context.Writer.WritePropertyName("FleetId");
                context.Writer.WriteStringValue(publicRequest.FleetId);
            }

            if(publicRequest.IsSetGameServerContainerGroupDefinitionName())
            {
                context.Writer.WritePropertyName("GameServerContainerGroupDefinitionName");
                context.Writer.WriteStringValue(publicRequest.GameServerContainerGroupDefinitionName);
            }

            if(publicRequest.IsSetGameServerContainerGroupsPerInstance())
            {
                context.Writer.WritePropertyName("GameServerContainerGroupsPerInstance");
                context.Writer.WriteNumberValue(publicRequest.GameServerContainerGroupsPerInstance.Value);
            }

            if(publicRequest.IsSetGameSessionCreationLimitPolicy())
            {
                context.Writer.WritePropertyName("GameSessionCreationLimitPolicy");
                context.Writer.WriteStartObject();

                var marshaller = GameSessionCreationLimitPolicyMarshaller.Instance;
                marshaller.Marshall(publicRequest.GameSessionCreationLimitPolicy, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInstanceConnectionPortRange())
            {
                context.Writer.WritePropertyName("InstanceConnectionPortRange");
                context.Writer.WriteStartObject();

                var marshaller = ConnectionPortRangeMarshaller.Instance;
                marshaller.Marshall(publicRequest.InstanceConnectionPortRange, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInstanceInboundPermissionAuthorizations())
            {
                context.Writer.WritePropertyName("InstanceInboundPermissionAuthorizations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestInstanceInboundPermissionAuthorizationsListValue in publicRequest.InstanceInboundPermissionAuthorizations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = IpPermissionMarshaller.Instance;
                    marshaller.Marshall(publicRequestInstanceInboundPermissionAuthorizationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetInstanceInboundPermissionRevocations())
            {
                context.Writer.WritePropertyName("InstanceInboundPermissionRevocations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestInstanceInboundPermissionRevocationsListValue in publicRequest.InstanceInboundPermissionRevocations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = IpPermissionMarshaller.Instance;
                    marshaller.Marshall(publicRequestInstanceInboundPermissionRevocationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetLogConfiguration())
            {
                context.Writer.WritePropertyName("LogConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = LogConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.LogConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMetricGroups())
            {
                context.Writer.WritePropertyName("MetricGroups");
                context.Writer.WriteStartArray();
                foreach(var publicRequestMetricGroupsListValue in publicRequest.MetricGroups)
                {
                        context.Writer.WriteStringValue(publicRequestMetricGroupsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetNewGameSessionProtectionPolicy())
            {
                context.Writer.WritePropertyName("NewGameSessionProtectionPolicy");
                context.Writer.WriteStringValue(publicRequest.NewGameSessionProtectionPolicy);
            }

            if(publicRequest.IsSetPerInstanceContainerGroupDefinitionName())
            {
                context.Writer.WritePropertyName("PerInstanceContainerGroupDefinitionName");
                context.Writer.WriteStringValue(publicRequest.PerInstanceContainerGroupDefinitionName);
            }

            if(publicRequest.IsSetRemoveAttributes())
            {
                context.Writer.WritePropertyName("RemoveAttributes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestRemoveAttributesListValue in publicRequest.RemoveAttributes)
                {
                        context.Writer.WriteStringValue(publicRequestRemoveAttributesListValue);
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
        private static UpdateContainerFleetRequestMarshaller _instance = new UpdateContainerFleetRequestMarshaller();        

        internal static UpdateContainerFleetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateContainerFleetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}