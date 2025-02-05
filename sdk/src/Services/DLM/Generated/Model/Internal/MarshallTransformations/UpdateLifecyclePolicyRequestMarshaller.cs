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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DLM.Model;
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
namespace Amazon.DLM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateLifecyclePolicy Request Marshaller
    /// </summary>       
    public class UpdateLifecyclePolicyRequestMarshaller : IMarshaller<IRequest, UpdateLifecyclePolicyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateLifecyclePolicyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateLifecyclePolicyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DLM");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-01-12";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetPolicyId())
                throw new AmazonDLMException("Request object does not have required field PolicyId set");
            request.AddPathResource("{policyId}", StringUtils.FromString(publicRequest.PolicyId));
            request.ResourcePath = "/policies/{policyId}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCopyTags())
            {
                context.Writer.WritePropertyName("CopyTags");
                context.Writer.WriteBooleanValue(publicRequest.CopyTags.Value);
            }

            if(publicRequest.IsSetCreateInterval())
            {
                context.Writer.WritePropertyName("CreateInterval");
                context.Writer.WriteNumberValue(publicRequest.CreateInterval.Value);
            }

            if(publicRequest.IsSetCrossRegionCopyTargets())
            {
                context.Writer.WritePropertyName("CrossRegionCopyTargets");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCrossRegionCopyTargetsListValue in publicRequest.CrossRegionCopyTargets)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CrossRegionCopyTargetMarshaller.Instance;
                    marshaller.Marshall(publicRequestCrossRegionCopyTargetsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetExclusions())
            {
                context.Writer.WritePropertyName("Exclusions");
                context.Writer.WriteStartObject();

                var marshaller = ExclusionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.Exclusions, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetExecutionRoleArn())
            {
                context.Writer.WritePropertyName("ExecutionRoleArn");
                context.Writer.WriteStringValue(publicRequest.ExecutionRoleArn);
            }

            if(publicRequest.IsSetExtendDeletion())
            {
                context.Writer.WritePropertyName("ExtendDeletion");
                context.Writer.WriteBooleanValue(publicRequest.ExtendDeletion.Value);
            }

            if(publicRequest.IsSetPolicyDetails())
            {
                context.Writer.WritePropertyName("PolicyDetails");
                context.Writer.WriteStartObject();

                var marshaller = PolicyDetailsMarshaller.Instance;
                marshaller.Marshall(publicRequest.PolicyDetails, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRetainInterval())
            {
                context.Writer.WritePropertyName("RetainInterval");
                context.Writer.WriteNumberValue(publicRequest.RetainInterval.Value);
            }

            if(publicRequest.IsSetState())
            {
                context.Writer.WritePropertyName("State");
                context.Writer.WriteStringValue(publicRequest.State);
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
        private static UpdateLifecyclePolicyRequestMarshaller _instance = new UpdateLifecyclePolicyRequestMarshaller();        

        internal static UpdateLifecyclePolicyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateLifecyclePolicyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}