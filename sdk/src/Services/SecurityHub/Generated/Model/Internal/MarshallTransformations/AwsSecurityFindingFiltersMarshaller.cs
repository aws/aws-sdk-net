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
    /// AwsSecurityFindingFilters Marshaller
    /// </summary>
    public class AwsSecurityFindingFiltersMarshaller : IRequestMarshaller<AwsSecurityFindingFilters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsSecurityFindingFilters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAwsAccountId())
            {
                context.Writer.WritePropertyName("AwsAccountId");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAwsAccountIdListValue in requestObject.AwsAccountId)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectAwsAccountIdListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetAwsAccountName())
            {
                context.Writer.WritePropertyName("AwsAccountName");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAwsAccountNameListValue in requestObject.AwsAccountName)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectAwsAccountNameListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCompanyName())
            {
                context.Writer.WritePropertyName("CompanyName");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCompanyNameListValue in requestObject.CompanyName)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectCompanyNameListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetComplianceAssociatedStandardsId())
            {
                context.Writer.WritePropertyName("ComplianceAssociatedStandardsId");
                context.Writer.WriteStartArray();
                foreach(var requestObjectComplianceAssociatedStandardsIdListValue in requestObject.ComplianceAssociatedStandardsId)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectComplianceAssociatedStandardsIdListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetComplianceSecurityControlId())
            {
                context.Writer.WritePropertyName("ComplianceSecurityControlId");
                context.Writer.WriteStartArray();
                foreach(var requestObjectComplianceSecurityControlIdListValue in requestObject.ComplianceSecurityControlId)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectComplianceSecurityControlIdListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetComplianceSecurityControlParametersName())
            {
                context.Writer.WritePropertyName("ComplianceSecurityControlParametersName");
                context.Writer.WriteStartArray();
                foreach(var requestObjectComplianceSecurityControlParametersNameListValue in requestObject.ComplianceSecurityControlParametersName)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectComplianceSecurityControlParametersNameListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetComplianceSecurityControlParametersValue())
            {
                context.Writer.WritePropertyName("ComplianceSecurityControlParametersValue");
                context.Writer.WriteStartArray();
                foreach(var requestObjectComplianceSecurityControlParametersValueListValue in requestObject.ComplianceSecurityControlParametersValue)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectComplianceSecurityControlParametersValueListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetComplianceStatus())
            {
                context.Writer.WritePropertyName("ComplianceStatus");
                context.Writer.WriteStartArray();
                foreach(var requestObjectComplianceStatusListValue in requestObject.ComplianceStatus)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectComplianceStatusListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetConfidence())
            {
                context.Writer.WritePropertyName("Confidence");
                context.Writer.WriteStartArray();
                foreach(var requestObjectConfidenceListValue in requestObject.Confidence)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = NumberFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectConfidenceListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCreatedAt())
            {
                context.Writer.WritePropertyName("CreatedAt");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCreatedAtListValue in requestObject.CreatedAt)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectCreatedAtListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCriticality())
            {
                context.Writer.WritePropertyName("Criticality");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCriticalityListValue in requestObject.Criticality)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = NumberFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectCriticalityListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDescriptionListValue in requestObject.Description)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectDescriptionListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFindingProviderFieldsConfidence())
            {
                context.Writer.WritePropertyName("FindingProviderFieldsConfidence");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFindingProviderFieldsConfidenceListValue in requestObject.FindingProviderFieldsConfidence)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = NumberFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFindingProviderFieldsConfidenceListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFindingProviderFieldsCriticality())
            {
                context.Writer.WritePropertyName("FindingProviderFieldsCriticality");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFindingProviderFieldsCriticalityListValue in requestObject.FindingProviderFieldsCriticality)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = NumberFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFindingProviderFieldsCriticalityListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFindingProviderFieldsRelatedFindingsId())
            {
                context.Writer.WritePropertyName("FindingProviderFieldsRelatedFindingsId");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFindingProviderFieldsRelatedFindingsIdListValue in requestObject.FindingProviderFieldsRelatedFindingsId)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFindingProviderFieldsRelatedFindingsIdListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFindingProviderFieldsRelatedFindingsProductArn())
            {
                context.Writer.WritePropertyName("FindingProviderFieldsRelatedFindingsProductArn");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFindingProviderFieldsRelatedFindingsProductArnListValue in requestObject.FindingProviderFieldsRelatedFindingsProductArn)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFindingProviderFieldsRelatedFindingsProductArnListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFindingProviderFieldsSeverityLabel())
            {
                context.Writer.WritePropertyName("FindingProviderFieldsSeverityLabel");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFindingProviderFieldsSeverityLabelListValue in requestObject.FindingProviderFieldsSeverityLabel)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFindingProviderFieldsSeverityLabelListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFindingProviderFieldsSeverityOriginal())
            {
                context.Writer.WritePropertyName("FindingProviderFieldsSeverityOriginal");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFindingProviderFieldsSeverityOriginalListValue in requestObject.FindingProviderFieldsSeverityOriginal)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFindingProviderFieldsSeverityOriginalListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFindingProviderFieldsTypes())
            {
                context.Writer.WritePropertyName("FindingProviderFieldsTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFindingProviderFieldsTypesListValue in requestObject.FindingProviderFieldsTypes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFindingProviderFieldsTypesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFirstObservedAt())
            {
                context.Writer.WritePropertyName("FirstObservedAt");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFirstObservedAtListValue in requestObject.FirstObservedAt)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFirstObservedAtListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetGeneratorId())
            {
                context.Writer.WritePropertyName("GeneratorId");
                context.Writer.WriteStartArray();
                foreach(var requestObjectGeneratorIdListValue in requestObject.GeneratorId)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectGeneratorIdListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("Id");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIdListValue in requestObject.Id)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectIdListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetKeyword())
            {
                context.Writer.WritePropertyName("Keyword");
                context.Writer.WriteStartArray();
                foreach(var requestObjectKeywordListValue in requestObject.Keyword)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = KeywordFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectKeywordListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLastObservedAt())
            {
                context.Writer.WritePropertyName("LastObservedAt");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLastObservedAtListValue in requestObject.LastObservedAt)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectLastObservedAtListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMalwareName())
            {
                context.Writer.WritePropertyName("MalwareName");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMalwareNameListValue in requestObject.MalwareName)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectMalwareNameListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMalwarePath())
            {
                context.Writer.WritePropertyName("MalwarePath");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMalwarePathListValue in requestObject.MalwarePath)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectMalwarePathListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMalwareState())
            {
                context.Writer.WritePropertyName("MalwareState");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMalwareStateListValue in requestObject.MalwareState)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectMalwareStateListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMalwareType())
            {
                context.Writer.WritePropertyName("MalwareType");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMalwareTypeListValue in requestObject.MalwareType)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectMalwareTypeListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetNetworkDestinationDomain())
            {
                context.Writer.WritePropertyName("NetworkDestinationDomain");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNetworkDestinationDomainListValue in requestObject.NetworkDestinationDomain)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectNetworkDestinationDomainListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetNetworkDestinationIpV4())
            {
                context.Writer.WritePropertyName("NetworkDestinationIpV4");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNetworkDestinationIpV4ListValue in requestObject.NetworkDestinationIpV4)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = IpFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectNetworkDestinationIpV4ListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetNetworkDestinationIpV6())
            {
                context.Writer.WritePropertyName("NetworkDestinationIpV6");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNetworkDestinationIpV6ListValue in requestObject.NetworkDestinationIpV6)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = IpFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectNetworkDestinationIpV6ListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetNetworkDestinationPort())
            {
                context.Writer.WritePropertyName("NetworkDestinationPort");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNetworkDestinationPortListValue in requestObject.NetworkDestinationPort)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = NumberFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectNetworkDestinationPortListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetNetworkDirection())
            {
                context.Writer.WritePropertyName("NetworkDirection");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNetworkDirectionListValue in requestObject.NetworkDirection)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectNetworkDirectionListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetNetworkProtocol())
            {
                context.Writer.WritePropertyName("NetworkProtocol");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNetworkProtocolListValue in requestObject.NetworkProtocol)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectNetworkProtocolListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetNetworkSourceDomain())
            {
                context.Writer.WritePropertyName("NetworkSourceDomain");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNetworkSourceDomainListValue in requestObject.NetworkSourceDomain)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectNetworkSourceDomainListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetNetworkSourceIpV4())
            {
                context.Writer.WritePropertyName("NetworkSourceIpV4");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNetworkSourceIpV4ListValue in requestObject.NetworkSourceIpV4)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = IpFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectNetworkSourceIpV4ListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetNetworkSourceIpV6())
            {
                context.Writer.WritePropertyName("NetworkSourceIpV6");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNetworkSourceIpV6ListValue in requestObject.NetworkSourceIpV6)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = IpFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectNetworkSourceIpV6ListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetNetworkSourceMac())
            {
                context.Writer.WritePropertyName("NetworkSourceMac");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNetworkSourceMacListValue in requestObject.NetworkSourceMac)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectNetworkSourceMacListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetNetworkSourcePort())
            {
                context.Writer.WritePropertyName("NetworkSourcePort");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNetworkSourcePortListValue in requestObject.NetworkSourcePort)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = NumberFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectNetworkSourcePortListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetNoteText())
            {
                context.Writer.WritePropertyName("NoteText");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNoteTextListValue in requestObject.NoteText)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectNoteTextListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetNoteUpdatedAt())
            {
                context.Writer.WritePropertyName("NoteUpdatedAt");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNoteUpdatedAtListValue in requestObject.NoteUpdatedAt)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectNoteUpdatedAtListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetNoteUpdatedBy())
            {
                context.Writer.WritePropertyName("NoteUpdatedBy");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNoteUpdatedByListValue in requestObject.NoteUpdatedBy)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectNoteUpdatedByListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetProcessLaunchedAt())
            {
                context.Writer.WritePropertyName("ProcessLaunchedAt");
                context.Writer.WriteStartArray();
                foreach(var requestObjectProcessLaunchedAtListValue in requestObject.ProcessLaunchedAt)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectProcessLaunchedAtListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetProcessName())
            {
                context.Writer.WritePropertyName("ProcessName");
                context.Writer.WriteStartArray();
                foreach(var requestObjectProcessNameListValue in requestObject.ProcessName)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectProcessNameListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetProcessParentPid())
            {
                context.Writer.WritePropertyName("ProcessParentPid");
                context.Writer.WriteStartArray();
                foreach(var requestObjectProcessParentPidListValue in requestObject.ProcessParentPid)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = NumberFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectProcessParentPidListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetProcessPath())
            {
                context.Writer.WritePropertyName("ProcessPath");
                context.Writer.WriteStartArray();
                foreach(var requestObjectProcessPathListValue in requestObject.ProcessPath)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectProcessPathListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetProcessPid())
            {
                context.Writer.WritePropertyName("ProcessPid");
                context.Writer.WriteStartArray();
                foreach(var requestObjectProcessPidListValue in requestObject.ProcessPid)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = NumberFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectProcessPidListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetProcessTerminatedAt())
            {
                context.Writer.WritePropertyName("ProcessTerminatedAt");
                context.Writer.WriteStartArray();
                foreach(var requestObjectProcessTerminatedAtListValue in requestObject.ProcessTerminatedAt)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectProcessTerminatedAtListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetProductArn())
            {
                context.Writer.WritePropertyName("ProductArn");
                context.Writer.WriteStartArray();
                foreach(var requestObjectProductArnListValue in requestObject.ProductArn)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectProductArnListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetProductFields())
            {
                context.Writer.WritePropertyName("ProductFields");
                context.Writer.WriteStartArray();
                foreach(var requestObjectProductFieldsListValue in requestObject.ProductFields)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MapFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectProductFieldsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetProductName())
            {
                context.Writer.WritePropertyName("ProductName");
                context.Writer.WriteStartArray();
                foreach(var requestObjectProductNameListValue in requestObject.ProductName)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectProductNameListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRecommendationText())
            {
                context.Writer.WritePropertyName("RecommendationText");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRecommendationTextListValue in requestObject.RecommendationText)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectRecommendationTextListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRecordState())
            {
                context.Writer.WritePropertyName("RecordState");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRecordStateListValue in requestObject.RecordState)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectRecordStateListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRegion())
            {
                context.Writer.WritePropertyName("Region");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRegionListValue in requestObject.Region)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectRegionListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRelatedFindingsId())
            {
                context.Writer.WritePropertyName("RelatedFindingsId");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRelatedFindingsIdListValue in requestObject.RelatedFindingsId)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectRelatedFindingsIdListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRelatedFindingsProductArn())
            {
                context.Writer.WritePropertyName("RelatedFindingsProductArn");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRelatedFindingsProductArnListValue in requestObject.RelatedFindingsProductArn)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectRelatedFindingsProductArnListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceApplicationArn())
            {
                context.Writer.WritePropertyName("ResourceApplicationArn");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceApplicationArnListValue in requestObject.ResourceApplicationArn)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceApplicationArnListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceApplicationName())
            {
                context.Writer.WritePropertyName("ResourceApplicationName");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceApplicationNameListValue in requestObject.ResourceApplicationName)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceApplicationNameListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceAwsEc2InstanceIamInstanceProfileArn())
            {
                context.Writer.WritePropertyName("ResourceAwsEc2InstanceIamInstanceProfileArn");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceAwsEc2InstanceIamInstanceProfileArnListValue in requestObject.ResourceAwsEc2InstanceIamInstanceProfileArn)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAwsEc2InstanceIamInstanceProfileArnListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceAwsEc2InstanceImageId())
            {
                context.Writer.WritePropertyName("ResourceAwsEc2InstanceImageId");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceAwsEc2InstanceImageIdListValue in requestObject.ResourceAwsEc2InstanceImageId)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAwsEc2InstanceImageIdListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceAwsEc2InstanceIpV4Addresses())
            {
                context.Writer.WritePropertyName("ResourceAwsEc2InstanceIpV4Addresses");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceAwsEc2InstanceIpV4AddressesListValue in requestObject.ResourceAwsEc2InstanceIpV4Addresses)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = IpFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAwsEc2InstanceIpV4AddressesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceAwsEc2InstanceIpV6Addresses())
            {
                context.Writer.WritePropertyName("ResourceAwsEc2InstanceIpV6Addresses");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceAwsEc2InstanceIpV6AddressesListValue in requestObject.ResourceAwsEc2InstanceIpV6Addresses)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = IpFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAwsEc2InstanceIpV6AddressesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceAwsEc2InstanceKeyName())
            {
                context.Writer.WritePropertyName("ResourceAwsEc2InstanceKeyName");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceAwsEc2InstanceKeyNameListValue in requestObject.ResourceAwsEc2InstanceKeyName)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAwsEc2InstanceKeyNameListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceAwsEc2InstanceLaunchedAt())
            {
                context.Writer.WritePropertyName("ResourceAwsEc2InstanceLaunchedAt");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceAwsEc2InstanceLaunchedAtListValue in requestObject.ResourceAwsEc2InstanceLaunchedAt)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAwsEc2InstanceLaunchedAtListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceAwsEc2InstanceSubnetId())
            {
                context.Writer.WritePropertyName("ResourceAwsEc2InstanceSubnetId");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceAwsEc2InstanceSubnetIdListValue in requestObject.ResourceAwsEc2InstanceSubnetId)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAwsEc2InstanceSubnetIdListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceAwsEc2InstanceType())
            {
                context.Writer.WritePropertyName("ResourceAwsEc2InstanceType");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceAwsEc2InstanceTypeListValue in requestObject.ResourceAwsEc2InstanceType)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAwsEc2InstanceTypeListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceAwsEc2InstanceVpcId())
            {
                context.Writer.WritePropertyName("ResourceAwsEc2InstanceVpcId");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceAwsEc2InstanceVpcIdListValue in requestObject.ResourceAwsEc2InstanceVpcId)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAwsEc2InstanceVpcIdListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceAwsIamAccessKeyCreatedAt())
            {
                context.Writer.WritePropertyName("ResourceAwsIamAccessKeyCreatedAt");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceAwsIamAccessKeyCreatedAtListValue in requestObject.ResourceAwsIamAccessKeyCreatedAt)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAwsIamAccessKeyCreatedAtListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceAwsIamAccessKeyPrincipalName())
            {
                context.Writer.WritePropertyName("ResourceAwsIamAccessKeyPrincipalName");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceAwsIamAccessKeyPrincipalNameListValue in requestObject.ResourceAwsIamAccessKeyPrincipalName)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAwsIamAccessKeyPrincipalNameListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceAwsIamAccessKeyStatus())
            {
                context.Writer.WritePropertyName("ResourceAwsIamAccessKeyStatus");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceAwsIamAccessKeyStatusListValue in requestObject.ResourceAwsIamAccessKeyStatus)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAwsIamAccessKeyStatusListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceAwsIamAccessKeyUserName())
            {
                context.Writer.WritePropertyName("ResourceAwsIamAccessKeyUserName");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceAwsIamAccessKeyUserNameListValue in requestObject.ResourceAwsIamAccessKeyUserName)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAwsIamAccessKeyUserNameListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceAwsIamUserUserName())
            {
                context.Writer.WritePropertyName("ResourceAwsIamUserUserName");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceAwsIamUserUserNameListValue in requestObject.ResourceAwsIamUserUserName)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAwsIamUserUserNameListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceAwsS3BucketOwnerId())
            {
                context.Writer.WritePropertyName("ResourceAwsS3BucketOwnerId");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceAwsS3BucketOwnerIdListValue in requestObject.ResourceAwsS3BucketOwnerId)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAwsS3BucketOwnerIdListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceAwsS3BucketOwnerName())
            {
                context.Writer.WritePropertyName("ResourceAwsS3BucketOwnerName");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceAwsS3BucketOwnerNameListValue in requestObject.ResourceAwsS3BucketOwnerName)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAwsS3BucketOwnerNameListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceContainerImageId())
            {
                context.Writer.WritePropertyName("ResourceContainerImageId");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceContainerImageIdListValue in requestObject.ResourceContainerImageId)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceContainerImageIdListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceContainerImageName())
            {
                context.Writer.WritePropertyName("ResourceContainerImageName");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceContainerImageNameListValue in requestObject.ResourceContainerImageName)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceContainerImageNameListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceContainerLaunchedAt())
            {
                context.Writer.WritePropertyName("ResourceContainerLaunchedAt");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceContainerLaunchedAtListValue in requestObject.ResourceContainerLaunchedAt)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceContainerLaunchedAtListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceContainerName())
            {
                context.Writer.WritePropertyName("ResourceContainerName");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceContainerNameListValue in requestObject.ResourceContainerName)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceContainerNameListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceDetailsOther())
            {
                context.Writer.WritePropertyName("ResourceDetailsOther");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceDetailsOtherListValue in requestObject.ResourceDetailsOther)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MapFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceDetailsOtherListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceId())
            {
                context.Writer.WritePropertyName("ResourceId");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceIdListValue in requestObject.ResourceId)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceIdListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourcePartition())
            {
                context.Writer.WritePropertyName("ResourcePartition");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourcePartitionListValue in requestObject.ResourcePartition)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourcePartitionListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceRegion())
            {
                context.Writer.WritePropertyName("ResourceRegion");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceRegionListValue in requestObject.ResourceRegion)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceRegionListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceTags())
            {
                context.Writer.WritePropertyName("ResourceTags");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceTagsListValue in requestObject.ResourceTags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MapFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceType())
            {
                context.Writer.WritePropertyName("ResourceType");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceTypeListValue in requestObject.ResourceType)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceTypeListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSample())
            {
                context.Writer.WritePropertyName("Sample");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSampleListValue in requestObject.Sample)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = BooleanFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectSampleListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSeverityLabel())
            {
                context.Writer.WritePropertyName("SeverityLabel");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSeverityLabelListValue in requestObject.SeverityLabel)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectSeverityLabelListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSeverityNormalized())
            {
                context.Writer.WritePropertyName("SeverityNormalized");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSeverityNormalizedListValue in requestObject.SeverityNormalized)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = NumberFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectSeverityNormalizedListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSeverityProduct())
            {
                context.Writer.WritePropertyName("SeverityProduct");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSeverityProductListValue in requestObject.SeverityProduct)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = NumberFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectSeverityProductListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSourceUrl())
            {
                context.Writer.WritePropertyName("SourceUrl");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSourceUrlListValue in requestObject.SourceUrl)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectSourceUrlListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetThreatIntelIndicatorCategory())
            {
                context.Writer.WritePropertyName("ThreatIntelIndicatorCategory");
                context.Writer.WriteStartArray();
                foreach(var requestObjectThreatIntelIndicatorCategoryListValue in requestObject.ThreatIntelIndicatorCategory)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectThreatIntelIndicatorCategoryListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetThreatIntelIndicatorLastObservedAt())
            {
                context.Writer.WritePropertyName("ThreatIntelIndicatorLastObservedAt");
                context.Writer.WriteStartArray();
                foreach(var requestObjectThreatIntelIndicatorLastObservedAtListValue in requestObject.ThreatIntelIndicatorLastObservedAt)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectThreatIntelIndicatorLastObservedAtListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetThreatIntelIndicatorSource())
            {
                context.Writer.WritePropertyName("ThreatIntelIndicatorSource");
                context.Writer.WriteStartArray();
                foreach(var requestObjectThreatIntelIndicatorSourceListValue in requestObject.ThreatIntelIndicatorSource)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectThreatIntelIndicatorSourceListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetThreatIntelIndicatorSourceUrl())
            {
                context.Writer.WritePropertyName("ThreatIntelIndicatorSourceUrl");
                context.Writer.WriteStartArray();
                foreach(var requestObjectThreatIntelIndicatorSourceUrlListValue in requestObject.ThreatIntelIndicatorSourceUrl)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectThreatIntelIndicatorSourceUrlListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetThreatIntelIndicatorType())
            {
                context.Writer.WritePropertyName("ThreatIntelIndicatorType");
                context.Writer.WriteStartArray();
                foreach(var requestObjectThreatIntelIndicatorTypeListValue in requestObject.ThreatIntelIndicatorType)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectThreatIntelIndicatorTypeListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetThreatIntelIndicatorValue())
            {
                context.Writer.WritePropertyName("ThreatIntelIndicatorValue");
                context.Writer.WriteStartArray();
                foreach(var requestObjectThreatIntelIndicatorValueListValue in requestObject.ThreatIntelIndicatorValue)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectThreatIntelIndicatorValueListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTitle())
            {
                context.Writer.WritePropertyName("Title");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTitleListValue in requestObject.Title)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectTitleListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTypeListValue in requestObject.Type)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectTypeListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetUpdatedAt())
            {
                context.Writer.WritePropertyName("UpdatedAt");
                context.Writer.WriteStartArray();
                foreach(var requestObjectUpdatedAtListValue in requestObject.UpdatedAt)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectUpdatedAtListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetUserDefinedFields())
            {
                context.Writer.WritePropertyName("UserDefinedFields");
                context.Writer.WriteStartArray();
                foreach(var requestObjectUserDefinedFieldsListValue in requestObject.UserDefinedFields)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MapFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectUserDefinedFieldsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetVerificationState())
            {
                context.Writer.WritePropertyName("VerificationState");
                context.Writer.WriteStartArray();
                foreach(var requestObjectVerificationStateListValue in requestObject.VerificationState)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectVerificationStateListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetVulnerabilitiesExploitAvailable())
            {
                context.Writer.WritePropertyName("VulnerabilitiesExploitAvailable");
                context.Writer.WriteStartArray();
                foreach(var requestObjectVulnerabilitiesExploitAvailableListValue in requestObject.VulnerabilitiesExploitAvailable)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectVulnerabilitiesExploitAvailableListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetVulnerabilitiesFixAvailable())
            {
                context.Writer.WritePropertyName("VulnerabilitiesFixAvailable");
                context.Writer.WriteStartArray();
                foreach(var requestObjectVulnerabilitiesFixAvailableListValue in requestObject.VulnerabilitiesFixAvailable)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectVulnerabilitiesFixAvailableListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetWorkflowState())
            {
                context.Writer.WritePropertyName("WorkflowState");
                context.Writer.WriteStartArray();
                foreach(var requestObjectWorkflowStateListValue in requestObject.WorkflowState)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectWorkflowStateListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetWorkflowStatus())
            {
                context.Writer.WritePropertyName("WorkflowStatus");
                context.Writer.WriteStartArray();
                foreach(var requestObjectWorkflowStatusListValue in requestObject.WorkflowStatus)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectWorkflowStatusListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsSecurityFindingFiltersMarshaller Instance = new AwsSecurityFindingFiltersMarshaller();

    }
}