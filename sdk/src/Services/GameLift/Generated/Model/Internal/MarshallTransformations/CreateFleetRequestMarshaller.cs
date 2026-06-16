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
    /// CreateFleet Request Marshaller
    /// </summary>       
    public class CreateFleetRequestMarshaller : IMarshaller<IRequest, CreateFleetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFleetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateFleetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GameLift");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/GameLift/operation/CreateFleet";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-10-01";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAnywhereConfiguration())
                {
                    context.Writer.WriteTextString("AnywhereConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = AnywhereConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AnywhereConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetBuildId())
                {
                    context.Writer.WriteTextString("BuildId");
                    context.Writer.WriteTextString(publicRequest.BuildId);
                }
                if (publicRequest.IsSetCertificateConfiguration())
                {
                    context.Writer.WriteTextString("CertificateConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = CertificateConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CertificateConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetComputeType())
                {
                    context.Writer.WriteTextString("ComputeType");
                    context.Writer.WriteTextString(publicRequest.ComputeType);
                }
                if (publicRequest.IsSetDescription())
                {
                    context.Writer.WriteTextString("Description");
                    context.Writer.WriteTextString(publicRequest.Description);
                }
                if (publicRequest.IsSetEC2InboundPermissions())
                {
                    context.Writer.WriteTextString("EC2InboundPermissions");
                    context.Writer.WriteStartArray(publicRequest.EC2InboundPermissions.Count);
                    foreach(var publicRequestEC2InboundPermissionsListValue in publicRequest.EC2InboundPermissions)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = IpPermissionMarshaller.Instance;
                        marshaller.Marshall(publicRequestEC2InboundPermissionsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetEC2InstanceType())
                {
                    context.Writer.WriteTextString("EC2InstanceType");
                    context.Writer.WriteTextString(publicRequest.EC2InstanceType);
                }
                if (publicRequest.IsSetFleetType())
                {
                    context.Writer.WriteTextString("FleetType");
                    context.Writer.WriteTextString(publicRequest.FleetType);
                }
                if (publicRequest.IsSetInstanceRoleArn())
                {
                    context.Writer.WriteTextString("InstanceRoleArn");
                    context.Writer.WriteTextString(publicRequest.InstanceRoleArn);
                }
                if (publicRequest.IsSetInstanceRoleCredentialsProvider())
                {
                    context.Writer.WriteTextString("InstanceRoleCredentialsProvider");
                    context.Writer.WriteTextString(publicRequest.InstanceRoleCredentialsProvider);
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
                if (publicRequest.IsSetLogPaths())
                {
                    context.Writer.WriteTextString("LogPaths");
                    context.Writer.WriteStartArray(publicRequest.LogPaths.Count);
                    foreach(var publicRequestLogPathsListValue in publicRequest.LogPaths)
                    {
                            context.Writer.WriteTextString(publicRequestLogPathsListValue);
                    }
                    context.Writer.WriteEndArray();
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
                if (publicRequest.IsSetName())
                {
                    context.Writer.WriteTextString("Name");
                    context.Writer.WriteTextString(publicRequest.Name);
                }
                if (publicRequest.IsSetNewGameSessionProtectionPolicy())
                {
                    context.Writer.WriteTextString("NewGameSessionProtectionPolicy");
                    context.Writer.WriteTextString(publicRequest.NewGameSessionProtectionPolicy);
                }
                if (publicRequest.IsSetPeerVpcAwsAccountId())
                {
                    context.Writer.WriteTextString("PeerVpcAwsAccountId");
                    context.Writer.WriteTextString(publicRequest.PeerVpcAwsAccountId);
                }
                if (publicRequest.IsSetPeerVpcId())
                {
                    context.Writer.WriteTextString("PeerVpcId");
                    context.Writer.WriteTextString(publicRequest.PeerVpcId);
                }
                if (publicRequest.IsSetPlayerGatewayConfiguration())
                {
                    context.Writer.WriteTextString("PlayerGatewayConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = PlayerGatewayConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PlayerGatewayConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetPlayerGatewayMode())
                {
                    context.Writer.WriteTextString("PlayerGatewayMode");
                    context.Writer.WriteTextString(publicRequest.PlayerGatewayMode);
                }
                if (publicRequest.IsSetResourceCreationLimitPolicy())
                {
                    context.Writer.WriteTextString("ResourceCreationLimitPolicy");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ResourceCreationLimitPolicyMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ResourceCreationLimitPolicy, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetRuntimeConfiguration())
                {
                    context.Writer.WriteTextString("RuntimeConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = RuntimeConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RuntimeConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetScriptId())
                {
                    context.Writer.WriteTextString("ScriptId");
                    context.Writer.WriteTextString(publicRequest.ScriptId);
                }
                if (publicRequest.IsSetServerLaunchParameters())
                {
                    context.Writer.WriteTextString("ServerLaunchParameters");
                    context.Writer.WriteTextString(publicRequest.ServerLaunchParameters);
                }
                if (publicRequest.IsSetServerLaunchPath())
                {
                    context.Writer.WriteTextString("ServerLaunchPath");
                    context.Writer.WriteTextString(publicRequest.ServerLaunchPath);
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
        private static CreateFleetRequestMarshaller _instance = new CreateFleetRequestMarshaller();        

        internal static CreateFleetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateFleetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}