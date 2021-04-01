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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53Resolver.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Route53Resolver.Model.Internal.MarshallTransformations
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
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Route53Resolver");
            string target = "Route53Resolver.CreateFirewallRule";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-01";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAction())
                {
                    context.Writer.WritePropertyName("Action");
                    context.Writer.Write(publicRequest.Action);
                }

                if(publicRequest.IsSetBlockOverrideDnsType())
                {
                    context.Writer.WritePropertyName("BlockOverrideDnsType");
                    context.Writer.Write(publicRequest.BlockOverrideDnsType);
                }

                if(publicRequest.IsSetBlockOverrideDomain())
                {
                    context.Writer.WritePropertyName("BlockOverrideDomain");
                    context.Writer.Write(publicRequest.BlockOverrideDomain);
                }

                if(publicRequest.IsSetBlockOverrideTtl())
                {
                    context.Writer.WritePropertyName("BlockOverrideTtl");
                    context.Writer.Write(publicRequest.BlockOverrideTtl);
                }

                if(publicRequest.IsSetBlockResponse())
                {
                    context.Writer.WritePropertyName("BlockResponse");
                    context.Writer.Write(publicRequest.BlockResponse);
                }

                if(publicRequest.IsSetCreatorRequestId())
                {
                    context.Writer.WritePropertyName("CreatorRequestId");
                    context.Writer.Write(publicRequest.CreatorRequestId);
                }

                else if(!(publicRequest.IsSetCreatorRequestId()))
                {
                    context.Writer.WritePropertyName("CreatorRequestId");
                    context.Writer.Write(Guid.NewGuid().ToString());                                                
                }
                if(publicRequest.IsSetFirewallDomainListId())
                {
                    context.Writer.WritePropertyName("FirewallDomainListId");
                    context.Writer.Write(publicRequest.FirewallDomainListId);
                }

                if(publicRequest.IsSetFirewallRuleGroupId())
                {
                    context.Writer.WritePropertyName("FirewallRuleGroupId");
                    context.Writer.Write(publicRequest.FirewallRuleGroupId);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetPriority())
                {
                    context.Writer.WritePropertyName("Priority");
                    context.Writer.Write(publicRequest.Priority);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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