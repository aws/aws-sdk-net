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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
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
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchUpdateFindings Request Marshaller
    /// </summary>       
    public class BatchUpdateFindingsRequestMarshaller : IMarshaller<IRequest, BatchUpdateFindingsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchUpdateFindingsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchUpdateFindingsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SecurityHub");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-10-26";
            request.HttpMethod = "PATCH";

            request.ResourcePath = "/findings/batchupdate";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetConfidence())
            {
                context.Writer.WritePropertyName("Confidence");
                context.Writer.WriteNumberValue(publicRequest.Confidence.Value);
            }

            if(publicRequest.IsSetCriticality())
            {
                context.Writer.WritePropertyName("Criticality");
                context.Writer.WriteNumberValue(publicRequest.Criticality.Value);
            }

            if(publicRequest.IsSetFindingIdentifiers())
            {
                context.Writer.WritePropertyName("FindingIdentifiers");
                context.Writer.WriteStartArray();
                foreach(var publicRequestFindingIdentifiersListValue in publicRequest.FindingIdentifiers)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsSecurityFindingIdentifierMarshaller.Instance;
                    marshaller.Marshall(publicRequestFindingIdentifiersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetNote())
            {
                context.Writer.WritePropertyName("Note");
                context.Writer.WriteStartObject();

                var marshaller = NoteUpdateMarshaller.Instance;
                marshaller.Marshall(publicRequest.Note, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRelatedFindings())
            {
                context.Writer.WritePropertyName("RelatedFindings");
                context.Writer.WriteStartArray();
                foreach(var publicRequestRelatedFindingsListValue in publicRequest.RelatedFindings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = RelatedFindingMarshaller.Instance;
                    marshaller.Marshall(publicRequestRelatedFindingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSeverity())
            {
                context.Writer.WritePropertyName("Severity");
                context.Writer.WriteStartObject();

                var marshaller = SeverityUpdateMarshaller.Instance;
                marshaller.Marshall(publicRequest.Severity, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTypes())
            {
                context.Writer.WritePropertyName("Types");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTypesListValue in publicRequest.Types)
                {
                        context.Writer.WriteStringValue(publicRequestTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetUserDefinedFields())
            {
                context.Writer.WritePropertyName("UserDefinedFields");
                context.Writer.WriteStartObject();
                foreach (var publicRequestUserDefinedFieldsKvp in publicRequest.UserDefinedFields)
                {
                    context.Writer.WritePropertyName(publicRequestUserDefinedFieldsKvp.Key);
                    var publicRequestUserDefinedFieldsValue = publicRequestUserDefinedFieldsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestUserDefinedFieldsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetVerificationState())
            {
                context.Writer.WritePropertyName("VerificationState");
                context.Writer.WriteStringValue(publicRequest.VerificationState);
            }

            if(publicRequest.IsSetWorkflow())
            {
                context.Writer.WritePropertyName("Workflow");
                context.Writer.WriteStartObject();

                var marshaller = WorkflowUpdateMarshaller.Instance;
                marshaller.Marshall(publicRequest.Workflow, context);

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
        private static BatchUpdateFindingsRequestMarshaller _instance = new BatchUpdateFindingsRequestMarshaller();        

        internal static BatchUpdateFindingsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchUpdateFindingsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}