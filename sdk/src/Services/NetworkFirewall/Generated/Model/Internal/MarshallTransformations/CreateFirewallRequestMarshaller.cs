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
using ThirdParty.Json.LitJson;

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
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDeleteProtection())
                {
                    context.Writer.WritePropertyName("DeleteProtection");
                    context.Writer.Write(publicRequest.DeleteProtection);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetFirewallName())
                {
                    context.Writer.WritePropertyName("FirewallName");
                    context.Writer.Write(publicRequest.FirewallName);
                }

                if(publicRequest.IsSetFirewallPolicyArn())
                {
                    context.Writer.WritePropertyName("FirewallPolicyArn");
                    context.Writer.Write(publicRequest.FirewallPolicyArn);
                }

                if(publicRequest.IsSetFirewallPolicyChangeProtection())
                {
                    context.Writer.WritePropertyName("FirewallPolicyChangeProtection");
                    context.Writer.Write(publicRequest.FirewallPolicyChangeProtection);
                }

                if(publicRequest.IsSetSubnetChangeProtection())
                {
                    context.Writer.WritePropertyName("SubnetChangeProtection");
                    context.Writer.Write(publicRequest.SubnetChangeProtection);
                }

                if(publicRequest.IsSetSubnetMappings())
                {
                    context.Writer.WritePropertyName("SubnetMappings");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSubnetMappingsListValue in publicRequest.SubnetMappings)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SubnetMappingMarshaller.Instance;
                        marshaller.Marshall(publicRequestSubnetMappingsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetVpcId())
                {
                    context.Writer.WritePropertyName("VpcId");
                    context.Writer.Write(publicRequest.VpcId);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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