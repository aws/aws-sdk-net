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
#pragma warning disable CS0612,CS0618
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
            if(requestObject == null)
                return;
            if(requestObject.IsSetAction())
            {
                context.Writer.WritePropertyName("Action");
                context.Writer.WriteStartObject();

                var marshaller = ActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Action, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAwsAccountId())
            {
                context.Writer.WritePropertyName("AwsAccountId");
                context.Writer.WriteStringValue(requestObject.AwsAccountId);
            }

            if(requestObject.IsSetAwsAccountName())
            {
                context.Writer.WritePropertyName("AwsAccountName");
                context.Writer.WriteStringValue(requestObject.AwsAccountName);
            }

            if(requestObject.IsSetCompanyName())
            {
                context.Writer.WritePropertyName("CompanyName");
                context.Writer.WriteStringValue(requestObject.CompanyName);
            }

            if(requestObject.IsSetCompliance())
            {
                context.Writer.WritePropertyName("Compliance");
                context.Writer.WriteStartObject();

                var marshaller = ComplianceMarshaller.Instance;
                marshaller.Marshall(requestObject.Compliance, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetConfidence())
            {
                context.Writer.WritePropertyName("Confidence");
                context.Writer.WriteNumberValue(requestObject.Confidence.Value);
            }

            if(requestObject.IsSetCreatedAt())
            {
                context.Writer.WritePropertyName("CreatedAt");
                context.Writer.WriteStringValue(requestObject.CreatedAt);
            }

            if(requestObject.IsSetCriticality())
            {
                context.Writer.WritePropertyName("Criticality");
                context.Writer.WriteNumberValue(requestObject.Criticality.Value);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetDetection())
            {
                context.Writer.WritePropertyName("Detection");
                context.Writer.WriteStartObject();

                var marshaller = DetectionMarshaller.Instance;
                marshaller.Marshall(requestObject.Detection, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFindingProviderFields())
            {
                context.Writer.WritePropertyName("FindingProviderFields");
                context.Writer.WriteStartObject();

                var marshaller = FindingProviderFieldsMarshaller.Instance;
                marshaller.Marshall(requestObject.FindingProviderFields, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFirstObservedAt())
            {
                context.Writer.WritePropertyName("FirstObservedAt");
                context.Writer.WriteStringValue(requestObject.FirstObservedAt);
            }

            if(requestObject.IsSetGeneratorDetails())
            {
                context.Writer.WritePropertyName("GeneratorDetails");
                context.Writer.WriteStartObject();

                var marshaller = GeneratorDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.GeneratorDetails, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGeneratorId())
            {
                context.Writer.WritePropertyName("GeneratorId");
                context.Writer.WriteStringValue(requestObject.GeneratorId);
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("Id");
                context.Writer.WriteStringValue(requestObject.Id);
            }

            if(requestObject.IsSetLastObservedAt())
            {
                context.Writer.WritePropertyName("LastObservedAt");
                context.Writer.WriteStringValue(requestObject.LastObservedAt);
            }

            if(requestObject.IsSetMalware())
            {
                context.Writer.WritePropertyName("Malware");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMalwareListValue in requestObject.Malware)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MalwareMarshaller.Instance;
                    marshaller.Marshall(requestObjectMalwareListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetNetwork())
            {
                context.Writer.WritePropertyName("Network");
                context.Writer.WriteStartObject();

                var marshaller = NetworkMarshaller.Instance;
                marshaller.Marshall(requestObject.Network, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNetworkPath())
            {
                context.Writer.WritePropertyName("NetworkPath");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNetworkPathListValue in requestObject.NetworkPath)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = NetworkPathComponentMarshaller.Instance;
                    marshaller.Marshall(requestObjectNetworkPathListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetNote())
            {
                context.Writer.WritePropertyName("Note");
                context.Writer.WriteStartObject();

                var marshaller = NoteMarshaller.Instance;
                marshaller.Marshall(requestObject.Note, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPatchSummary())
            {
                context.Writer.WritePropertyName("PatchSummary");
                context.Writer.WriteStartObject();

                var marshaller = PatchSummaryMarshaller.Instance;
                marshaller.Marshall(requestObject.PatchSummary, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetProcess())
            {
                context.Writer.WritePropertyName("Process");
                context.Writer.WriteStartObject();

                var marshaller = ProcessDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Process, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetProcessedAt())
            {
                context.Writer.WritePropertyName("ProcessedAt");
                context.Writer.WriteStringValue(requestObject.ProcessedAt);
            }

            if(requestObject.IsSetProductArn())
            {
                context.Writer.WritePropertyName("ProductArn");
                context.Writer.WriteStringValue(requestObject.ProductArn);
            }

            if(requestObject.IsSetProductFields())
            {
                context.Writer.WritePropertyName("ProductFields");
                context.Writer.WriteStartObject();
                foreach (var requestObjectProductFieldsKvp in requestObject.ProductFields)
                {
                    context.Writer.WritePropertyName(requestObjectProductFieldsKvp.Key);
                    var requestObjectProductFieldsValue = requestObjectProductFieldsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectProductFieldsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetProductName())
            {
                context.Writer.WritePropertyName("ProductName");
                context.Writer.WriteStringValue(requestObject.ProductName);
            }

            if(requestObject.IsSetRecordState())
            {
                context.Writer.WritePropertyName("RecordState");
                context.Writer.WriteStringValue(requestObject.RecordState);
            }

            if(requestObject.IsSetRegion())
            {
                context.Writer.WritePropertyName("Region");
                context.Writer.WriteStringValue(requestObject.Region);
            }

            if(requestObject.IsSetRelatedFindings())
            {
                context.Writer.WritePropertyName("RelatedFindings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRelatedFindingsListValue in requestObject.RelatedFindings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = RelatedFindingMarshaller.Instance;
                    marshaller.Marshall(requestObjectRelatedFindingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRemediation())
            {
                context.Writer.WritePropertyName("Remediation");
                context.Writer.WriteStartObject();

                var marshaller = RemediationMarshaller.Instance;
                marshaller.Marshall(requestObject.Remediation, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetResources())
            {
                context.Writer.WritePropertyName("Resources");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourcesListValue in requestObject.Resources)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ResourceMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourcesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSample())
            {
                context.Writer.WritePropertyName("Sample");
                context.Writer.WriteBooleanValue(requestObject.Sample.Value);
            }

            if(requestObject.IsSetSchemaVersion())
            {
                context.Writer.WritePropertyName("SchemaVersion");
                context.Writer.WriteStringValue(requestObject.SchemaVersion);
            }

            if(requestObject.IsSetSeverity())
            {
                context.Writer.WritePropertyName("Severity");
                context.Writer.WriteStartObject();

                var marshaller = SeverityMarshaller.Instance;
                marshaller.Marshall(requestObject.Severity, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSourceUrl())
            {
                context.Writer.WritePropertyName("SourceUrl");
                context.Writer.WriteStringValue(requestObject.SourceUrl);
            }

            if(requestObject.IsSetThreatIntelIndicators())
            {
                context.Writer.WritePropertyName("ThreatIntelIndicators");
                context.Writer.WriteStartArray();
                foreach(var requestObjectThreatIntelIndicatorsListValue in requestObject.ThreatIntelIndicators)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ThreatIntelIndicatorMarshaller.Instance;
                    marshaller.Marshall(requestObjectThreatIntelIndicatorsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetThreats())
            {
                context.Writer.WritePropertyName("Threats");
                context.Writer.WriteStartArray();
                foreach(var requestObjectThreatsListValue in requestObject.Threats)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ThreatMarshaller.Instance;
                    marshaller.Marshall(requestObjectThreatsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTitle())
            {
                context.Writer.WritePropertyName("Title");
                context.Writer.WriteStringValue(requestObject.Title);
            }

            if(requestObject.IsSetTypes())
            {
                context.Writer.WritePropertyName("Types");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTypesListValue in requestObject.Types)
                {
                        context.Writer.WriteStringValue(requestObjectTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetUpdatedAt())
            {
                context.Writer.WritePropertyName("UpdatedAt");
                context.Writer.WriteStringValue(requestObject.UpdatedAt);
            }

            if(requestObject.IsSetUserDefinedFields())
            {
                context.Writer.WritePropertyName("UserDefinedFields");
                context.Writer.WriteStartObject();
                foreach (var requestObjectUserDefinedFieldsKvp in requestObject.UserDefinedFields)
                {
                    context.Writer.WritePropertyName(requestObjectUserDefinedFieldsKvp.Key);
                    var requestObjectUserDefinedFieldsValue = requestObjectUserDefinedFieldsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectUserDefinedFieldsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVerificationState())
            {
                context.Writer.WritePropertyName("VerificationState");
                context.Writer.WriteStringValue(requestObject.VerificationState);
            }

            if(requestObject.IsSetVulnerabilities())
            {
                context.Writer.WritePropertyName("Vulnerabilities");
                context.Writer.WriteStartArray();
                foreach(var requestObjectVulnerabilitiesListValue in requestObject.Vulnerabilities)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = VulnerabilityMarshaller.Instance;
                    marshaller.Marshall(requestObjectVulnerabilitiesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetWorkflow())
            {
                context.Writer.WritePropertyName("Workflow");
                context.Writer.WriteStartObject();

                var marshaller = WorkflowMarshaller.Instance;
                marshaller.Marshall(requestObject.Workflow, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetWorkflowState())
            {
                context.Writer.WritePropertyName("WorkflowState");
                context.Writer.WriteStringValue(requestObject.WorkflowState);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsSecurityFindingMarshaller Instance = new AwsSecurityFindingMarshaller();

    }
}