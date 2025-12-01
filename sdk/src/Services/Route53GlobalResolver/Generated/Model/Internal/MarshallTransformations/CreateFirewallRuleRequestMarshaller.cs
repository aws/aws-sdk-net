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
 * Do not modify this file. This file is generated from the route53globalresolver-2022-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53GlobalResolver.Model;
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
namespace Amazon.Route53GlobalResolver.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateFirewallRule Request Marshaller
    /// </summary>       
    public class CreateFirewallRuleRequestMarshaller : IMarshaller<IRequest, CreateFirewallRuleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFirewallRuleRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateFirewallRuleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Route53GlobalResolver");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-09-27";
            request.HttpMethod = "POST";

            request.ResourcePath = "/firewall-rules";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAction())
            {
                context.Writer.WritePropertyName("action");
                context.Writer.WriteStringValue(publicRequest.Action);
            }

            if(publicRequest.IsSetBlockOverrideDnsType())
            {
                context.Writer.WritePropertyName("blockOverrideDnsType");
                context.Writer.WriteStringValue(publicRequest.BlockOverrideDnsType);
            }

            if(publicRequest.IsSetBlockOverrideDomain())
            {
                context.Writer.WritePropertyName("blockOverrideDomain");
                context.Writer.WriteStringValue(publicRequest.BlockOverrideDomain);
            }

            if(publicRequest.IsSetBlockOverrideTtl())
            {
                context.Writer.WritePropertyName("blockOverrideTtl");
                context.Writer.WriteNumberValue(publicRequest.BlockOverrideTtl.Value);
            }

            if(publicRequest.IsSetBlockResponse())
            {
                context.Writer.WritePropertyName("blockResponse");
                context.Writer.WriteStringValue(publicRequest.BlockResponse);
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetConfidenceThreshold())
            {
                context.Writer.WritePropertyName("confidenceThreshold");
                context.Writer.WriteStringValue(publicRequest.ConfidenceThreshold);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetDnsAdvancedProtection())
            {
                context.Writer.WritePropertyName("dnsAdvancedProtection");
                context.Writer.WriteStringValue(publicRequest.DnsAdvancedProtection);
            }

            if(publicRequest.IsSetDnsViewId())
            {
                context.Writer.WritePropertyName("dnsViewId");
                context.Writer.WriteStringValue(publicRequest.DnsViewId);
            }

            if(publicRequest.IsSetFirewallDomainListId())
            {
                context.Writer.WritePropertyName("firewallDomainListId");
                context.Writer.WriteStringValue(publicRequest.FirewallDomainListId);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetPriority())
            {
                context.Writer.WritePropertyName("priority");
                context.Writer.WriteNumberValue(publicRequest.Priority.Value);
            }

            if(publicRequest.IsSetQType())
            {
                context.Writer.WritePropertyName("qType");
                context.Writer.WriteStringValue(publicRequest.QType);
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
        private static CreateFirewallRuleRequestMarshaller _instance = new CreateFirewallRuleRequestMarshaller();        

        internal static CreateFirewallRuleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateFirewallRuleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}