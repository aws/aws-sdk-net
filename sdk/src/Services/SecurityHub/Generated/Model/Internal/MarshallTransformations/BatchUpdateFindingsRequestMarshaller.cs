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
using ThirdParty.Json.LitJson;

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
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetConfidence())
                {
                    context.Writer.WritePropertyName("Confidence");
                    context.Writer.Write(publicRequest.Confidence);
                }

                if(publicRequest.IsSetCriticality())
                {
                    context.Writer.WritePropertyName("Criticality");
                    context.Writer.Write(publicRequest.Criticality);
                }

                if(publicRequest.IsSetFindingIdentifiers())
                {
                    context.Writer.WritePropertyName("FindingIdentifiers");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestFindingIdentifiersListValue in publicRequest.FindingIdentifiers)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AwsSecurityFindingIdentifierMarshaller.Instance;
                        marshaller.Marshall(publicRequestFindingIdentifiersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetNote())
                {
                    context.Writer.WritePropertyName("Note");
                    context.Writer.WriteObjectStart();

                    var marshaller = NoteUpdateMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Note, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRelatedFindings())
                {
                    context.Writer.WritePropertyName("RelatedFindings");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRelatedFindingsListValue in publicRequest.RelatedFindings)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = RelatedFindingMarshaller.Instance;
                        marshaller.Marshall(publicRequestRelatedFindingsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSeverity())
                {
                    context.Writer.WritePropertyName("Severity");
                    context.Writer.WriteObjectStart();

                    var marshaller = SeverityUpdateMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Severity, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTypes())
                {
                    context.Writer.WritePropertyName("Types");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTypesListValue in publicRequest.Types)
                    {
                            context.Writer.Write(publicRequestTypesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetUserDefinedFields())
                {
                    context.Writer.WritePropertyName("UserDefinedFields");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestUserDefinedFieldsKvp in publicRequest.UserDefinedFields)
                    {
                        context.Writer.WritePropertyName(publicRequestUserDefinedFieldsKvp.Key);
                        var publicRequestUserDefinedFieldsValue = publicRequestUserDefinedFieldsKvp.Value;

                            context.Writer.Write(publicRequestUserDefinedFieldsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetVerificationState())
                {
                    context.Writer.WritePropertyName("VerificationState");
                    context.Writer.Write(publicRequest.VerificationState);
                }

                if(publicRequest.IsSetWorkflow())
                {
                    context.Writer.WritePropertyName("Workflow");
                    context.Writer.WriteObjectStart();

                    var marshaller = WorkflowUpdateMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Workflow, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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