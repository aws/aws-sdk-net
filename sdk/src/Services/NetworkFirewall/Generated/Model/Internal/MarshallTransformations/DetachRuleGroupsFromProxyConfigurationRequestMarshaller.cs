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

#pragma warning disable CS0612,CS0618
namespace Amazon.NetworkFirewall.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DetachRuleGroupsFromProxyConfiguration Request Marshaller
    /// </summary>       
    public class DetachRuleGroupsFromProxyConfigurationRequestMarshaller : IMarshaller<IRequest, DetachRuleGroupsFromProxyConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DetachRuleGroupsFromProxyConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DetachRuleGroupsFromProxyConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkFirewall");
            string target = "NetworkFirewall_20201112.DetachRuleGroupsFromProxyConfiguration";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-12";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetProxyConfigurationArn())
                {
                    context.Writer.WritePropertyName("ProxyConfigurationArn");
                    context.Writer.Write(publicRequest.ProxyConfigurationArn);
                }

                if(publicRequest.IsSetProxyConfigurationName())
                {
                    context.Writer.WritePropertyName("ProxyConfigurationName");
                    context.Writer.Write(publicRequest.ProxyConfigurationName);
                }

                if(publicRequest.IsSetRuleGroupArns())
                {
                    context.Writer.WritePropertyName("RuleGroupArns");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRuleGroupArnsListValue in publicRequest.RuleGroupArns)
                    {
                            context.Writer.Write(publicRequestRuleGroupArnsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRuleGroupNames())
                {
                    context.Writer.WritePropertyName("RuleGroupNames");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRuleGroupNamesListValue in publicRequest.RuleGroupNames)
                    {
                            context.Writer.Write(publicRequestRuleGroupNamesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetUpdateToken())
                {
                    context.Writer.WritePropertyName("UpdateToken");
                    context.Writer.Write(publicRequest.UpdateToken);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static DetachRuleGroupsFromProxyConfigurationRequestMarshaller _instance = new DetachRuleGroupsFromProxyConfigurationRequestMarshaller();        

        internal static DetachRuleGroupsFromProxyConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DetachRuleGroupsFromProxyConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}