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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Route53GlobalResolver.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateFirewallRule Request Marshaller
    /// </summary>       
    public class UpdateFirewallRuleRequestMarshaller : IMarshaller<IRequest, UpdateFirewallRuleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateFirewallRuleRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateFirewallRuleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Route53GlobalResolver");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-09-27";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetFirewallRuleId())
                throw new AmazonRoute53GlobalResolverException("Request object does not have required field FirewallRuleId set");
            request.AddPathResource("{firewallRuleId}", StringUtils.FromString(publicRequest.FirewallRuleId));
            request.ResourcePath = "/firewall-rules/{firewallRuleId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAction())
                {
                    context.Writer.WritePropertyName("action");
                    context.Writer.Write(publicRequest.Action);
                }

                if(publicRequest.IsSetBlockOverrideDnsType())
                {
                    context.Writer.WritePropertyName("blockOverrideDnsType");
                    context.Writer.Write(publicRequest.BlockOverrideDnsType);
                }

                if(publicRequest.IsSetBlockOverrideDomain())
                {
                    context.Writer.WritePropertyName("blockOverrideDomain");
                    context.Writer.Write(publicRequest.BlockOverrideDomain);
                }

                if(publicRequest.IsSetBlockOverrideTtl())
                {
                    context.Writer.WritePropertyName("blockOverrideTtl");
                    context.Writer.Write(publicRequest.BlockOverrideTtl);
                }

                if(publicRequest.IsSetBlockResponse())
                {
                    context.Writer.WritePropertyName("blockResponse");
                    context.Writer.Write(publicRequest.BlockResponse);
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
                if(publicRequest.IsSetConfidenceThreshold())
                {
                    context.Writer.WritePropertyName("confidenceThreshold");
                    context.Writer.Write(publicRequest.ConfidenceThreshold);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetDnsAdvancedProtection())
                {
                    context.Writer.WritePropertyName("dnsAdvancedProtection");
                    context.Writer.Write(publicRequest.DnsAdvancedProtection);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetPriority())
                {
                    context.Writer.WritePropertyName("priority");
                    context.Writer.Write(publicRequest.Priority);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateFirewallRuleRequestMarshaller _instance = new UpdateFirewallRuleRequestMarshaller();        

        internal static UpdateFirewallRuleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateFirewallRuleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}