/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// AwsSecurityFinding Marshaller
    /// </summary>       
    public class AwsSecurityFindingMarshaller : IRequestMarshaller<AwsSecurityFinding, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsSecurityFinding requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAwsAccountId())
            {
                context.Writer.WritePropertyName("AwsAccountId");
                context.Writer.Write(requestObject.AwsAccountId);
            }

            if(requestObject.IsSetCompliance())
            {
                context.Writer.WritePropertyName("Compliance");
                context.Writer.WriteObjectStart();

                var marshaller = ComplianceMarshaller.Instance;
                marshaller.Marshall(requestObject.Compliance, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetConfidence())
            {
                context.Writer.WritePropertyName("Confidence");
                context.Writer.Write(requestObject.Confidence);
            }

            if(requestObject.IsSetCreatedAt())
            {
                context.Writer.WritePropertyName("CreatedAt");
                context.Writer.Write(requestObject.CreatedAt);
            }

            if(requestObject.IsSetCriticality())
            {
                context.Writer.WritePropertyName("Criticality");
                context.Writer.Write(requestObject.Criticality);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetFirstObservedAt())
            {
                context.Writer.WritePropertyName("FirstObservedAt");
                context.Writer.Write(requestObject.FirstObservedAt);
            }

            if(requestObject.IsSetGeneratorId())
            {
                context.Writer.WritePropertyName("GeneratorId");
                context.Writer.Write(requestObject.GeneratorId);
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("Id");
                context.Writer.Write(requestObject.Id);
            }

            if(requestObject.IsSetLastObservedAt())
            {
                context.Writer.WritePropertyName("LastObservedAt");
                context.Writer.Write(requestObject.LastObservedAt);
            }

            if(requestObject.IsSetMalware())
            {
                context.Writer.WritePropertyName("Malware");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectMalwareListValue in requestObject.Malware)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = MalwareMarshaller.Instance;
                    marshaller.Marshall(requestObjectMalwareListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNetwork())
            {
                context.Writer.WritePropertyName("Network");
                context.Writer.WriteObjectStart();

                var marshaller = NetworkMarshaller.Instance;
                marshaller.Marshall(requestObject.Network, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetNote())
            {
                context.Writer.WritePropertyName("Note");
                context.Writer.WriteObjectStart();

                var marshaller = NoteMarshaller.Instance;
                marshaller.Marshall(requestObject.Note, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetProcess())
            {
                context.Writer.WritePropertyName("Process");
                context.Writer.WriteObjectStart();

                var marshaller = ProcessDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Process, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetProductArn())
            {
                context.Writer.WritePropertyName("ProductArn");
                context.Writer.Write(requestObject.ProductArn);
            }

            if(requestObject.IsSetProductFields())
            {
                context.Writer.WritePropertyName("ProductFields");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectProductFieldsKvp in requestObject.ProductFields)
                {
                    context.Writer.WritePropertyName(requestObjectProductFieldsKvp.Key);
                    var requestObjectProductFieldsValue = requestObjectProductFieldsKvp.Value;

                        context.Writer.Write(requestObjectProductFieldsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRecordState())
            {
                context.Writer.WritePropertyName("RecordState");
                context.Writer.Write(requestObject.RecordState);
            }

            if(requestObject.IsSetRelatedFindings())
            {
                context.Writer.WritePropertyName("RelatedFindings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRelatedFindingsListValue in requestObject.RelatedFindings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = RelatedFindingMarshaller.Instance;
                    marshaller.Marshall(requestObjectRelatedFindingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRemediation())
            {
                context.Writer.WritePropertyName("Remediation");
                context.Writer.WriteObjectStart();

                var marshaller = RemediationMarshaller.Instance;
                marshaller.Marshall(requestObject.Remediation, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetResources())
            {
                context.Writer.WritePropertyName("Resources");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourcesListValue in requestObject.Resources)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ResourceMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourcesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSchemaVersion())
            {
                context.Writer.WritePropertyName("SchemaVersion");
                context.Writer.Write(requestObject.SchemaVersion);
            }

            if(requestObject.IsSetSeverity())
            {
                context.Writer.WritePropertyName("Severity");
                context.Writer.WriteObjectStart();

                var marshaller = SeverityMarshaller.Instance;
                marshaller.Marshall(requestObject.Severity, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSourceUrl())
            {
                context.Writer.WritePropertyName("SourceUrl");
                context.Writer.Write(requestObject.SourceUrl);
            }

            if(requestObject.IsSetThreatIntelIndicators())
            {
                context.Writer.WritePropertyName("ThreatIntelIndicators");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectThreatIntelIndicatorsListValue in requestObject.ThreatIntelIndicators)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ThreatIntelIndicatorMarshaller.Instance;
                    marshaller.Marshall(requestObjectThreatIntelIndicatorsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTitle())
            {
                context.Writer.WritePropertyName("Title");
                context.Writer.Write(requestObject.Title);
            }

            if(requestObject.IsSetTypes())
            {
                context.Writer.WritePropertyName("Types");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTypesListValue in requestObject.Types)
                {
                        context.Writer.Write(requestObjectTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetUpdatedAt())
            {
                context.Writer.WritePropertyName("UpdatedAt");
                context.Writer.Write(requestObject.UpdatedAt);
            }

            if(requestObject.IsSetUserDefinedFields())
            {
                context.Writer.WritePropertyName("UserDefinedFields");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectUserDefinedFieldsKvp in requestObject.UserDefinedFields)
                {
                    context.Writer.WritePropertyName(requestObjectUserDefinedFieldsKvp.Key);
                    var requestObjectUserDefinedFieldsValue = requestObjectUserDefinedFieldsKvp.Value;

                        context.Writer.Write(requestObjectUserDefinedFieldsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVerificationState())
            {
                context.Writer.WritePropertyName("VerificationState");
                context.Writer.Write(requestObject.VerificationState);
            }

            if(requestObject.IsSetWorkflowState())
            {
                context.Writer.WritePropertyName("WorkflowState");
                context.Writer.Write(requestObject.WorkflowState);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsSecurityFindingMarshaller Instance = new AwsSecurityFindingMarshaller();

    }
}