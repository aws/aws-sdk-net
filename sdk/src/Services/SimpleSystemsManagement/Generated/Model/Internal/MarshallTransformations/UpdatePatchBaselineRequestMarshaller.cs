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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleSystemsManagement.Model;
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
namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdatePatchBaseline Request Marshaller
    /// </summary>       
    public class UpdatePatchBaselineRequestMarshaller : IMarshaller<IRequest, UpdatePatchBaselineRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdatePatchBaselineRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdatePatchBaselineRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleSystemsManagement");
            string target = "AmazonSSM.UpdatePatchBaseline";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-11-06";
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
            if(publicRequest.IsSetApprovalRules())
            {
                context.Writer.WritePropertyName("ApprovalRules");
                context.Writer.WriteStartObject();

                var marshaller = PatchRuleGroupMarshaller.Instance;
                marshaller.Marshall(publicRequest.ApprovalRules, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetApprovedPatches())
            {
                context.Writer.WritePropertyName("ApprovedPatches");
                context.Writer.WriteStartArray();
                foreach(var publicRequestApprovedPatchesListValue in publicRequest.ApprovedPatches)
                {
                        context.Writer.WriteStringValue(publicRequestApprovedPatchesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetApprovedPatchesComplianceLevel())
            {
                context.Writer.WritePropertyName("ApprovedPatchesComplianceLevel");
                context.Writer.WriteStringValue(publicRequest.ApprovedPatchesComplianceLevel);
            }

            if(publicRequest.IsSetApprovedPatchesEnableNonSecurity())
            {
                context.Writer.WritePropertyName("ApprovedPatchesEnableNonSecurity");
                context.Writer.WriteBooleanValue(publicRequest.ApprovedPatchesEnableNonSecurity.Value);
            }

            if(publicRequest.IsSetAvailableSecurityUpdatesComplianceStatus())
            {
                context.Writer.WritePropertyName("AvailableSecurityUpdatesComplianceStatus");
                context.Writer.WriteStringValue(publicRequest.AvailableSecurityUpdatesComplianceStatus);
            }

            if(publicRequest.IsSetBaselineId())
            {
                context.Writer.WritePropertyName("BaselineId");
                context.Writer.WriteStringValue(publicRequest.BaselineId);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetGlobalFilters())
            {
                context.Writer.WritePropertyName("GlobalFilters");
                context.Writer.WriteStartObject();

                var marshaller = PatchFilterGroupMarshaller.Instance;
                marshaller.Marshall(publicRequest.GlobalFilters, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetRejectedPatches())
            {
                context.Writer.WritePropertyName("RejectedPatches");
                context.Writer.WriteStartArray();
                foreach(var publicRequestRejectedPatchesListValue in publicRequest.RejectedPatches)
                {
                        context.Writer.WriteStringValue(publicRequestRejectedPatchesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetRejectedPatchesAction())
            {
                context.Writer.WritePropertyName("RejectedPatchesAction");
                context.Writer.WriteStringValue(publicRequest.RejectedPatchesAction);
            }

            if(publicRequest.IsSetReplace())
            {
                context.Writer.WritePropertyName("Replace");
                context.Writer.WriteBooleanValue(publicRequest.Replace.Value);
            }

            if(publicRequest.IsSetSources())
            {
                context.Writer.WritePropertyName("Sources");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSourcesListValue in publicRequest.Sources)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PatchSourceMarshaller.Instance;
                    marshaller.Marshall(publicRequestSourcesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
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
        private static UpdatePatchBaselineRequestMarshaller _instance = new UpdatePatchBaselineRequestMarshaller();        

        internal static UpdatePatchBaselineRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdatePatchBaselineRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}