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
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.GameLift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateContainerFleet Request Marshaller
    /// </summary>       
    public class CreateContainerFleetRequestMarshaller : IMarshaller<IRequest, CreateContainerFleetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateContainerFleetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateContainerFleetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GameLift");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/GameLift/operation/CreateContainerFleet";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-10-01";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetBillingType())
                {
                    context.Writer.WriteTextString("BillingType");
                    context.Writer.WriteTextString(publicRequest.BillingType);
                }
                if (publicRequest.IsSetDescription())
                {
                    context.Writer.WriteTextString("Description");
                    context.Writer.WriteTextString(publicRequest.Description);
                }
                if (publicRequest.IsSetFleetRoleArn())
                {
                    context.Writer.WriteTextString("FleetRoleArn");
                    context.Writer.WriteTextString(publicRequest.FleetRoleArn);
                }
                if (publicRequest.IsSetGameServerContainerGroupDefinitionName())
                {
                    context.Writer.WriteTextString("GameServerContainerGroupDefinitionName");
                    context.Writer.WriteTextString(publicRequest.GameServerContainerGroupDefinitionName);
                }
                if (publicRequest.IsSetGameServerContainerGroupsPerInstance())
                {
                    context.Writer.WriteTextString("GameServerContainerGroupsPerInstance");
                    context.Writer.WriteInt32(publicRequest.GameServerContainerGroupsPerInstance.Value);
                }
                if (publicRequest.IsSetGameSessionCreationLimitPolicy())
                {
                    context.Writer.WriteTextString("GameSessionCreationLimitPolicy");
                    context.Writer.WriteStartMap(null);

                    var marshaller = GameSessionCreationLimitPolicyMarshaller.Instance;
                    marshaller.Marshall(publicRequest.GameSessionCreationLimitPolicy, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetInstanceConnectionPortRange())
                {
                    context.Writer.WriteTextString("InstanceConnectionPortRange");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ConnectionPortRangeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.InstanceConnectionPortRange, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetInstanceInboundPermissions())
                {
                    context.Writer.WriteTextString("InstanceInboundPermissions");
                    context.Writer.WriteStartArray(publicRequest.InstanceInboundPermissions.Count);
                    foreach(var publicRequestInstanceInboundPermissionsListValue in publicRequest.InstanceInboundPermissions)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = IpPermissionMarshaller.Instance;
                        marshaller.Marshall(publicRequestInstanceInboundPermissionsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetInstanceType())
                {
                    context.Writer.WriteTextString("InstanceType");
                    context.Writer.WriteTextString(publicRequest.InstanceType);
                }
                if (publicRequest.IsSetLocations())
                {
                    context.Writer.WriteTextString("Locations");
                    context.Writer.WriteStartArray(publicRequest.Locations.Count);
                    foreach(var publicRequestLocationsListValue in publicRequest.Locations)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = LocationConfigurationMarshaller.Instance;
                        marshaller.Marshall(publicRequestLocationsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetLogConfiguration())
                {
                    context.Writer.WriteTextString("LogConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = LogConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LogConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetMetricGroups())
                {
                    context.Writer.WriteTextString("MetricGroups");
                    context.Writer.WriteStartArray(publicRequest.MetricGroups.Count);
                    foreach(var publicRequestMetricGroupsListValue in publicRequest.MetricGroups)
                    {
                            context.Writer.WriteTextString(publicRequestMetricGroupsListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetNewGameSessionProtectionPolicy())
                {
                    context.Writer.WriteTextString("NewGameSessionProtectionPolicy");
                    context.Writer.WriteTextString(publicRequest.NewGameSessionProtectionPolicy);
                }
                if (publicRequest.IsSetPerInstanceContainerGroupDefinitionName())
                {
                    context.Writer.WriteTextString("PerInstanceContainerGroupDefinitionName");
                    context.Writer.WriteTextString(publicRequest.PerInstanceContainerGroupDefinitionName);
                }
                if (publicRequest.IsSetPlayerGatewayMode())
                {
                    context.Writer.WriteTextString("PlayerGatewayMode");
                    context.Writer.WriteTextString(publicRequest.PlayerGatewayMode);
                }
                if (publicRequest.IsSetTags())
                {
                    context.Writer.WriteTextString("Tags");
                    context.Writer.WriteStartArray(publicRequest.Tags.Count);
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                writer.WriteEndMap();
                request.Content = writer.Encode();
            }
            finally
            {
                CborWriterPool.Return(writer);
            }
            
            return request;
        }
        private static CreateContainerFleetRequestMarshaller _instance = new CreateContainerFleetRequestMarshaller();        

        internal static CreateContainerFleetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateContainerFleetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}