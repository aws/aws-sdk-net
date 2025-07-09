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
    /// CreateRuleGroup Request Marshaller
    /// </summary>       
    public class CreateRuleGroupRequestMarshaller : IMarshaller<IRequest, CreateRuleGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateRuleGroupRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateRuleGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkFirewall");
            string target = "NetworkFirewall_20201112.CreateRuleGroup";
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
            if(publicRequest.IsSetAnalyzeRuleGroup())
            {
                context.Writer.WritePropertyName("AnalyzeRuleGroup");
                context.Writer.WriteBooleanValue(publicRequest.AnalyzeRuleGroup.Value);
            }

            if(publicRequest.IsSetCapacity())
            {
                context.Writer.WritePropertyName("Capacity");
                context.Writer.WriteNumberValue(publicRequest.Capacity.Value);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetDryRun())
            {
                context.Writer.WritePropertyName("DryRun");
                context.Writer.WriteBooleanValue(publicRequest.DryRun.Value);
            }

            if(publicRequest.IsSetEncryptionConfiguration())
            {
                context.Writer.WritePropertyName("EncryptionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = EncryptionConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.EncryptionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRuleGroup())
            {
                context.Writer.WritePropertyName("RuleGroup");
                context.Writer.WriteStartObject();

                var marshaller = RuleGroupMarshaller.Instance;
                marshaller.Marshall(publicRequest.RuleGroup, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRuleGroupName())
            {
                context.Writer.WritePropertyName("RuleGroupName");
                context.Writer.WriteStringValue(publicRequest.RuleGroupName);
            }

            if(publicRequest.IsSetRules())
            {
                context.Writer.WritePropertyName("Rules");
                context.Writer.WriteStringValue(publicRequest.Rules);
            }

            if(publicRequest.IsSetSourceMetadata())
            {
                context.Writer.WritePropertyName("SourceMetadata");
                context.Writer.WriteStartObject();

                var marshaller = SourceMetadataMarshaller.Instance;
                marshaller.Marshall(publicRequest.SourceMetadata, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSummaryConfiguration())
            {
                context.Writer.WritePropertyName("SummaryConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SummaryConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.SummaryConfiguration, context);

                context.Writer.WriteEndObject();
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

            if(publicRequest.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.WriteStringValue(publicRequest.Type);
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
        private static CreateRuleGroupRequestMarshaller _instance = new CreateRuleGroupRequestMarshaller();        

        internal static CreateRuleGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateRuleGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}