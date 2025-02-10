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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WAFV2.Model;
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
namespace Amazon.WAFV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateRuleGroup Request Marshaller
    /// </summary>       
    public class UpdateRuleGroupRequestMarshaller : IMarshaller<IRequest, UpdateRuleGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateRuleGroupRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateRuleGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WAFV2");
            string target = "AWSWAF_20190729.UpdateRuleGroup";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-07-29";
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
            if(publicRequest.IsSetCustomResponseBodies())
            {
                context.Writer.WritePropertyName("CustomResponseBodies");
                context.Writer.WriteStartObject();
                foreach (var publicRequestCustomResponseBodiesKvp in publicRequest.CustomResponseBodies)
                {
                    context.Writer.WritePropertyName(publicRequestCustomResponseBodiesKvp.Key);
                    var publicRequestCustomResponseBodiesValue = publicRequestCustomResponseBodiesKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = CustomResponseBodyMarshaller.Instance;
                    marshaller.Marshall(publicRequestCustomResponseBodiesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetId())
            {
                context.Writer.WritePropertyName("Id");
                context.Writer.WriteStringValue(publicRequest.Id);
            }

            if(publicRequest.IsSetLockToken())
            {
                context.Writer.WritePropertyName("LockToken");
                context.Writer.WriteStringValue(publicRequest.LockToken);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetRules())
            {
                context.Writer.WritePropertyName("Rules");
                context.Writer.WriteStartArray();
                foreach(var publicRequestRulesListValue in publicRequest.Rules)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = RuleMarshaller.Instance;
                    marshaller.Marshall(publicRequestRulesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetScope())
            {
                context.Writer.WritePropertyName("Scope");
                context.Writer.WriteStringValue(publicRequest.Scope);
            }

            if(publicRequest.IsSetVisibilityConfig())
            {
                context.Writer.WritePropertyName("VisibilityConfig");
                context.Writer.WriteStartObject();

                var marshaller = VisibilityConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.VisibilityConfig, context);

                context.Writer.WriteEndObject();
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
        private static UpdateRuleGroupRequestMarshaller _instance = new UpdateRuleGroupRequestMarshaller();        

        internal static UpdateRuleGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateRuleGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}