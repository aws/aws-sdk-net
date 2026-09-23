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
    /// CreatePolicy Request Marshaller
    /// </summary>       
    public class CreatePolicyRequestMarshaller : IMarshaller<IRequest, CreatePolicyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreatePolicyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreatePolicyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkSecurityManager");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-10-30";
            request.HttpMethod = "POST";

            request.ResourcePath = "/policies";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAssociatedTemplateAndRuleList())
            {
                context.Writer.WritePropertyName("associatedTemplateAndRuleList");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAssociatedTemplateAndRuleListListValue in publicRequest.AssociatedTemplateAndRuleList)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TemplateOrRuleReferenceMarshaller.Instance;
                    marshaller.Marshall(publicRequestAssociatedTemplateAndRuleListListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
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
            if(publicRequest.IsSetFirewallType())
            {
                context.Writer.WritePropertyName("firewallType");
                context.Writer.WriteStringValue(publicRequest.FirewallType);
            }

            if(publicRequest.IsSetIsPublished())
            {
                context.Writer.WritePropertyName("isPublished");
                context.Writer.WriteBooleanValue(publicRequest.IsPublished.Value);
            }

            if(publicRequest.IsSetPolicyConfiguration())
            {
                context.Writer.WritePropertyName("policyConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = PolicyConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.PolicyConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPolicyDescription())
            {
                context.Writer.WritePropertyName("policyDescription");
                context.Writer.WriteStringValue(publicRequest.PolicyDescription);
            }

            if(publicRequest.IsSetPolicyName())
            {
                context.Writer.WritePropertyName("policyName");
                context.Writer.WriteStringValue(publicRequest.PolicyName);
            }

            if(publicRequest.IsSetPriority())
            {
                context.Writer.WritePropertyName("priority");
                context.Writer.WriteNumberValue(publicRequest.Priority.Value);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreatePolicyRequestMarshaller _instance = new CreatePolicyRequestMarshaller();        

        internal static CreatePolicyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreatePolicyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}