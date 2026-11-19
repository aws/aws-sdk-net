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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.NetworkFirewall.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.NetworkFirewall.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateFirewall Request Marshaller
    /// </summary>
    public partial class CreateFirewallRequestMarshaller : IMarshaller<IRequest, CreateFirewallRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFirewallRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateFirewallRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkFirewall");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-12";
            request.HttpMethod = "POST";

            request.ResourcePath = "service/NetworkFirewall_20201112/operation/CreateFirewall";
            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAvailabilityZoneChangeProtection())
                {
                    context.Writer.WriteTextString("AvailabilityZoneChangeProtection");
                    context.Writer.WriteBoolean(publicRequest.AvailabilityZoneChangeProtection.Value);
                }
                if (publicRequest.IsSetAvailabilityZoneMappings())
                {
                    context.Writer.WriteTextString("AvailabilityZoneMappings");
                    context.Writer.WriteStartArray(publicRequest.AvailabilityZoneMappings.Count);
                    foreach (var publicRequestAvailabilityZoneMappingsListValue in publicRequest.AvailabilityZoneMappings)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = AvailabilityZoneMappingMarshaller.Instance;
                        marshaller.Marshall(publicRequestAvailabilityZoneMappingsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetDeleteProtection())
                {
                    context.Writer.WriteTextString("DeleteProtection");
                    context.Writer.WriteBoolean(publicRequest.DeleteProtection.Value);
                }
                if (publicRequest.IsSetDescription())
                {
                    context.Writer.WriteTextString("Description");
                    context.Writer.WriteTextString(publicRequest.Description);
                }
                if (publicRequest.IsSetEnabledAnalysisTypes())
                {
                    context.Writer.WriteTextString("EnabledAnalysisTypes");
                    context.Writer.WriteStartArray(publicRequest.EnabledAnalysisTypes.Count);
                    foreach (var publicRequestEnabledAnalysisTypesListValue in publicRequest.EnabledAnalysisTypes)
                    {
                        context.Writer.WriteTextString(publicRequestEnabledAnalysisTypesListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetEncryptionConfiguration())
                {
                    context.Writer.WriteTextString("EncryptionConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = EncryptionConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EncryptionConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetFirewallName())
                {
                    context.Writer.WriteTextString("FirewallName");
                    context.Writer.WriteTextString(publicRequest.FirewallName);
                }
                if (publicRequest.IsSetFirewallPolicyArn())
                {
                    context.Writer.WriteTextString("FirewallPolicyArn");
                    context.Writer.WriteTextString(publicRequest.FirewallPolicyArn);
                }
                if (publicRequest.IsSetFirewallPolicyChangeProtection())
                {
                    context.Writer.WriteTextString("FirewallPolicyChangeProtection");
                    context.Writer.WriteBoolean(publicRequest.FirewallPolicyChangeProtection.Value);
                }
                if (publicRequest.IsSetNatGatewayCreateMappings())
                {
                    context.Writer.WriteTextString("NatGatewayCreateMappings");
                    context.Writer.WriteStartArray(publicRequest.NatGatewayCreateMappings.Count);
                    foreach (var publicRequestNatGatewayCreateMappingsListValue in publicRequest.NatGatewayCreateMappings)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = NatGatewayCreateMappingMarshaller.Instance;
                        marshaller.Marshall(publicRequestNatGatewayCreateMappingsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetProxySettings())
                {
                    context.Writer.WriteTextString("ProxySettings");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ProxySettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ProxySettings, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetSubnetChangeProtection())
                {
                    context.Writer.WriteTextString("SubnetChangeProtection");
                    context.Writer.WriteBoolean(publicRequest.SubnetChangeProtection.Value);
                }
                if (publicRequest.IsSetSubnetMappings())
                {
                    context.Writer.WriteTextString("SubnetMappings");
                    context.Writer.WriteStartArray(publicRequest.SubnetMappings.Count);
                    foreach (var publicRequestSubnetMappingsListValue in publicRequest.SubnetMappings)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = SubnetMappingMarshaller.Instance;
                        marshaller.Marshall(publicRequestSubnetMappingsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetTags())
                {
                    context.Writer.WriteTextString("Tags");
                    context.Writer.WriteStartArray(publicRequest.Tags.Count);
                    foreach (var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetTransitGatewayId())
                {
                    context.Writer.WriteTextString("TransitGatewayId");
                    context.Writer.WriteTextString(publicRequest.TransitGatewayId);
                }
                if (publicRequest.IsSetTransparentFilteringNatScope())
                {
                    context.Writer.WriteTextString("TransparentFilteringNatScope");
                    context.Writer.WriteTextString(publicRequest.TransparentFilteringNatScope);
                }
                if (publicRequest.IsSetVpcEndpoint())
                {
                    context.Writer.WriteTextString("VpcEndpoint");
                    context.Writer.WriteStartMap(null);

                    var marshaller = VpcEndpointMarshaller.Instance;
                    marshaller.Marshall(publicRequest.VpcEndpoint, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetVpcId())
                {
                    context.Writer.WriteTextString("VpcId");
                    context.Writer.WriteTextString(publicRequest.VpcId);
                }
                writer.WriteEndMap();
#if !NETFRAMEWORK
                var encodedLength = writer.BytesWritten;
                request.ContentStream = new PooledContentStream(encodedLength);
                var bufferWriter = ((PooledContentStream)request.ContentStream).BufferWriter;
                var span = bufferWriter.GetSpan(encodedLength);
                var bytesWritten = writer.Encode(span);
                bufferWriter.Advance(bytesWritten);
#else
                request.Content = writer.Encode();
#endif
            }
            finally
            {
                CborWriterPool.Return(writer);
            }

            return request;
        }

        private static readonly CreateFirewallRequestMarshaller _instance = new();

        internal static CreateFirewallRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateFirewallRequestMarshaller Instance => _instance;
    }
}
