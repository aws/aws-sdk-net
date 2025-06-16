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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkFirewall.Model;
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
namespace Amazon.NetworkFirewall.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateFirewall Request Marshaller
    /// </summary>       
    public class CreateFirewallRequestMarshaller : IMarshaller<IRequest, CreateFirewallRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFirewallRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateFirewallRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkFirewall");
            string target = "NetworkFirewall_20201112.CreateFirewall";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-12";
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
            if(publicRequest.IsSetAvailabilityZoneChangeProtection())
            {
                context.Writer.WritePropertyName("AvailabilityZoneChangeProtection");
                context.Writer.WriteBooleanValue(publicRequest.AvailabilityZoneChangeProtection.Value);
            }

            if(publicRequest.IsSetAvailabilityZoneMappings())
            {
                context.Writer.WritePropertyName("AvailabilityZoneMappings");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAvailabilityZoneMappingsListValue in publicRequest.AvailabilityZoneMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AvailabilityZoneMappingMarshaller.Instance;
                    marshaller.Marshall(publicRequestAvailabilityZoneMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDeleteProtection())
            {
                context.Writer.WritePropertyName("DeleteProtection");
                context.Writer.WriteBooleanValue(publicRequest.DeleteProtection.Value);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetEnabledAnalysisTypes())
            {
                context.Writer.WritePropertyName("EnabledAnalysisTypes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestEnabledAnalysisTypesListValue in publicRequest.EnabledAnalysisTypes)
                {
                        context.Writer.WriteStringValue(publicRequestEnabledAnalysisTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetEncryptionConfiguration())
            {
                context.Writer.WritePropertyName("EncryptionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = EncryptionConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.EncryptionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetFirewallName())
            {
                context.Writer.WritePropertyName("FirewallName");
                context.Writer.WriteStringValue(publicRequest.FirewallName);
            }

            if(publicRequest.IsSetFirewallPolicyArn())
            {
                context.Writer.WritePropertyName("FirewallPolicyArn");
                context.Writer.WriteStringValue(publicRequest.FirewallPolicyArn);
            }

            if(publicRequest.IsSetFirewallPolicyChangeProtection())
            {
                context.Writer.WritePropertyName("FirewallPolicyChangeProtection");
                context.Writer.WriteBooleanValue(publicRequest.FirewallPolicyChangeProtection.Value);
            }

            if(publicRequest.IsSetSubnetChangeProtection())
            {
                context.Writer.WritePropertyName("SubnetChangeProtection");
                context.Writer.WriteBooleanValue(publicRequest.SubnetChangeProtection.Value);
            }

            if(publicRequest.IsSetSubnetMappings())
            {
                context.Writer.WritePropertyName("SubnetMappings");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSubnetMappingsListValue in publicRequest.SubnetMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SubnetMappingMarshaller.Instance;
                    marshaller.Marshall(publicRequestSubnetMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTransitGatewayId())
            {
                context.Writer.WritePropertyName("TransitGatewayId");
                context.Writer.WriteStringValue(publicRequest.TransitGatewayId);
            }

            if(publicRequest.IsSetVpcId())
            {
                context.Writer.WritePropertyName("VpcId");
                context.Writer.WriteStringValue(publicRequest.VpcId);
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
        private static CreateFirewallRequestMarshaller _instance = new CreateFirewallRequestMarshaller();        

        internal static CreateFirewallRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateFirewallRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}