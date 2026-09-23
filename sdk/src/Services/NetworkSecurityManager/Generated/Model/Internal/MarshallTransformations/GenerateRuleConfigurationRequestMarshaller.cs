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
 * Do not modify this file. This file is generated from the network-security-manager-2025-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkSecurityManager.Model;
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
namespace Amazon.NetworkSecurityManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GenerateRuleConfiguration Request Marshaller
    /// </summary>       
    public class GenerateRuleConfigurationRequestMarshaller : IMarshaller<IRequest, GenerateRuleConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GenerateRuleConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GenerateRuleConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkSecurityManager");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-10-30";
            request.HttpMethod = "POST";

            request.ResourcePath = "/GenerateRuleConfiguration";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
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
            if(publicRequest.IsSetCurrentConfiguration())
            {
                context.Writer.WritePropertyName("currentConfiguration");
                context.Writer.WriteStringValue(publicRequest.CurrentConfiguration);
            }

            if(publicRequest.IsSetPrompt())
            {
                context.Writer.WritePropertyName("prompt");
                context.Writer.WriteStringValue(publicRequest.Prompt);
            }

            if(publicRequest.IsSetRuleFirewallType())
            {
                context.Writer.WritePropertyName("ruleFirewallType");
                context.Writer.WriteStringValue(publicRequest.RuleFirewallType);
            }

            if(publicRequest.IsSetRuleType())
            {
                context.Writer.WritePropertyName("ruleType");
                context.Writer.WriteStringValue(publicRequest.RuleType);
            }

            if(publicRequest.IsSetWafConfigDataType())
            {
                context.Writer.WritePropertyName("wafConfigDataType");
                context.Writer.WriteStringValue(publicRequest.WafConfigDataType);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static GenerateRuleConfigurationRequestMarshaller _instance = new GenerateRuleConfigurationRequestMarshaller();        

        internal static GenerateRuleConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GenerateRuleConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}