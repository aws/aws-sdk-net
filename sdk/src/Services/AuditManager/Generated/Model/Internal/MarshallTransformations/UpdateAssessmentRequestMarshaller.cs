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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AuditManager.Model;
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
namespace Amazon.AuditManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAssessment Request Marshaller
    /// </summary>       
    public class UpdateAssessmentRequestMarshaller : IMarshaller<IRequest, UpdateAssessmentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAssessmentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateAssessmentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AuditManager");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetAssessmentId())
                throw new AmazonAuditManagerException("Request object does not have required field AssessmentId set");
            request.AddPathResource("{assessmentId}", StringUtils.FromString(publicRequest.AssessmentId));
            request.ResourcePath = "/assessments/{assessmentId}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAssessmentDescription())
            {
                context.Writer.WritePropertyName("assessmentDescription");
                context.Writer.WriteStringValue(publicRequest.AssessmentDescription);
            }

            if(publicRequest.IsSetAssessmentName())
            {
                context.Writer.WritePropertyName("assessmentName");
                context.Writer.WriteStringValue(publicRequest.AssessmentName);
            }

            if(publicRequest.IsSetAssessmentReportsDestination())
            {
                context.Writer.WritePropertyName("assessmentReportsDestination");
                context.Writer.WriteStartObject();

                var marshaller = AssessmentReportsDestinationMarshaller.Instance;
                marshaller.Marshall(publicRequest.AssessmentReportsDestination, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRoles())
            {
                context.Writer.WritePropertyName("roles");
                context.Writer.WriteStartArray();
                foreach(var publicRequestRolesListValue in publicRequest.Roles)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = RoleMarshaller.Instance;
                    marshaller.Marshall(publicRequestRolesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetScope())
            {
                context.Writer.WritePropertyName("scope");
                context.Writer.WriteStartObject();

                var marshaller = ScopeMarshaller.Instance;
                marshaller.Marshall(publicRequest.Scope, context);

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
        private static UpdateAssessmentRequestMarshaller _instance = new UpdateAssessmentRequestMarshaller();        

        internal static UpdateAssessmentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAssessmentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}