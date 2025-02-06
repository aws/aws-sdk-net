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
    /// PutComplianceItems Request Marshaller
    /// </summary>       
    public class PutComplianceItemsRequestMarshaller : IMarshaller<IRequest, PutComplianceItemsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutComplianceItemsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutComplianceItemsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleSystemsManagement");
            string target = "AmazonSSM.PutComplianceItems";
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
            if(publicRequest.IsSetComplianceType())
            {
                context.Writer.WritePropertyName("ComplianceType");
                context.Writer.WriteStringValue(publicRequest.ComplianceType);
            }

            if(publicRequest.IsSetExecutionSummary())
            {
                context.Writer.WritePropertyName("ExecutionSummary");
                context.Writer.WriteStartObject();

                var marshaller = ComplianceExecutionSummaryMarshaller.Instance;
                marshaller.Marshall(publicRequest.ExecutionSummary, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetItemContentHash())
            {
                context.Writer.WritePropertyName("ItemContentHash");
                context.Writer.WriteStringValue(publicRequest.ItemContentHash);
            }

            if(publicRequest.IsSetItems())
            {
                context.Writer.WritePropertyName("Items");
                context.Writer.WriteStartArray();
                foreach(var publicRequestItemsListValue in publicRequest.Items)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ComplianceItemEntryMarshaller.Instance;
                    marshaller.Marshall(publicRequestItemsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetResourceId())
            {
                context.Writer.WritePropertyName("ResourceId");
                context.Writer.WriteStringValue(publicRequest.ResourceId);
            }

            if(publicRequest.IsSetResourceType())
            {
                context.Writer.WritePropertyName("ResourceType");
                context.Writer.WriteStringValue(publicRequest.ResourceType);
            }

            if(publicRequest.IsSetUploadType())
            {
                context.Writer.WritePropertyName("UploadType");
                context.Writer.WriteStringValue(publicRequest.UploadType);
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
        private static PutComplianceItemsRequestMarshaller _instance = new PutComplianceItemsRequestMarshaller();        

        internal static PutComplianceItemsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutComplianceItemsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}