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
            if(requestObject.IsSetAwsAccountId())
            {
                context.Writer.WritePropertyName("AwsAccountId");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAwsAccountIdListValue in requestObject.AwsAccountId)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectAwsAccountIdListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCompanyName())
            {
                context.Writer.WritePropertyName("CompanyName");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCompanyNameListValue in requestObject.CompanyName)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectCompanyNameListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetComplianceAssociatedStandardsId())
            {
                context.Writer.WritePropertyName("ComplianceAssociatedStandardsId");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectComplianceAssociatedStandardsIdListValue in requestObject.ComplianceAssociatedStandardsId)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectComplianceAssociatedStandardsIdListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetComplianceSecurityControlId())
            {
                context.Writer.WritePropertyName("ComplianceSecurityControlId");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectComplianceSecurityControlIdListValue in requestObject.ComplianceSecurityControlId)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectComplianceSecurityControlIdListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetComplianceStatus())
            {
                context.Writer.WritePropertyName("ComplianceStatus");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectComplianceStatusListValue in requestObject.ComplianceStatus)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectComplianceStatusListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetConfidence())
            {
                context.Writer.WritePropertyName("Confidence");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectConfidenceListValue in requestObject.Confidence)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = NumberFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectConfidenceListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCreatedAt())
            {
                context.Writer.WritePropertyName("CreatedAt");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCreatedAtListValue in requestObject.CreatedAt)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectCreatedAtListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCriticality())
            {
                context.Writer.WritePropertyName("Criticality");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCriticalityListValue in requestObject.Criticality)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = NumberFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectCriticalityListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDescriptionListValue in requestObject.Description)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectDescriptionListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetFindingProviderFieldsConfidence())
            {
                context.Writer.WritePropertyName("FindingProviderFieldsConfidence");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFindingProviderFieldsConfidenceListValue in requestObject.FindingProviderFieldsConfidence)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = NumberFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFindingProviderFieldsConfidenceListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetFindingProviderFieldsCriticality())
            {
                context.Writer.WritePropertyName("FindingProviderFieldsCriticality");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFindingProviderFieldsCriticalityListValue in requestObject.FindingProviderFieldsCriticality)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = NumberFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFindingProviderFieldsCriticalityListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetFindingProviderFieldsRelatedFindingsId())
            {
                context.Writer.WritePropertyName("FindingProviderFieldsRelatedFindingsId");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFindingProviderFieldsRelatedFindingsIdListValue in requestObject.FindingProviderFieldsRelatedFindingsId)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFindingProviderFieldsRelatedFindingsIdListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetFindingProviderFieldsRelatedFindingsProductArn())
            {
                context.Writer.WritePropertyName("FindingProviderFieldsRelatedFindingsProductArn");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFindingProviderFieldsRelatedFindingsProductArnListValue in requestObject.FindingProviderFieldsRelatedFindingsProductArn)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFindingProviderFieldsRelatedFindingsProductArnListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetFindingProviderFieldsSeverityLabel())
            {
                context.Writer.WritePropertyName("FindingProviderFieldsSeverityLabel");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFindingProviderFieldsSeverityLabelListValue in requestObject.FindingProviderFieldsSeverityLabel)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFindingProviderFieldsSeverityLabelListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetFindingProviderFieldsSeverityOriginal())
            {
                context.Writer.WritePropertyName("FindingProviderFieldsSeverityOriginal");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFindingProviderFieldsSeverityOriginalListValue in requestObject.FindingProviderFieldsSeverityOriginal)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFindingProviderFieldsSeverityOriginalListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetFindingProviderFieldsTypes())
            {
                context.Writer.WritePropertyName("FindingProviderFieldsTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFindingProviderFieldsTypesListValue in requestObject.FindingProviderFieldsTypes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFindingProviderFieldsTypesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetFirstObservedAt())
            {
                context.Writer.WritePropertyName("FirstObservedAt");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFirstObservedAtListValue in requestObject.FirstObservedAt)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectFirstObservedAtListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetGeneratorId())
            {
                context.Writer.WritePropertyName("GeneratorId");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectGeneratorIdListValue in requestObject.GeneratorId)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectGeneratorIdListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("Id");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectIdListValue in requestObject.Id)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectIdListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetKeyword())
            {
                context.Writer.WritePropertyName("Keyword");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectKeywordListValue in requestObject.Keyword)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = KeywordFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectKeywordListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLastObservedAt())
            {
                context.Writer.WritePropertyName("LastObservedAt");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLastObservedAtListValue in requestObject.LastObservedAt)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectLastObservedAtListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetMalwareName())
            {
                context.Writer.WritePropertyName("MalwareName");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectMalwareNameListValue in requestObject.MalwareName)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectMalwareNameListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetMalwarePath())
            {
                context.Writer.WritePropertyName("MalwarePath");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectMalwarePathListValue in requestObject.MalwarePath)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectMalwarePathListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetMalwareState())
            {
                context.Writer.WritePropertyName("MalwareState");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectMalwareStateListValue in requestObject.MalwareState)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectMalwareStateListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetMalwareType())
            {
                context.Writer.WritePropertyName("MalwareType");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectMalwareTypeListValue in requestObject.MalwareType)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectMalwareTypeListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNetworkDestinationDomain())
            {
                context.Writer.WritePropertyName("NetworkDestinationDomain");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNetworkDestinationDomainListValue in requestObject.NetworkDestinationDomain)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectNetworkDestinationDomainListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNetworkDestinationIpV4())
            {
                context.Writer.WritePropertyName("NetworkDestinationIpV4");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNetworkDestinationIpV4ListValue in requestObject.NetworkDestinationIpV4)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = IpFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectNetworkDestinationIpV4ListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNetworkDestinationIpV6())
            {
                context.Writer.WritePropertyName("NetworkDestinationIpV6");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNetworkDestinationIpV6ListValue in requestObject.NetworkDestinationIpV6)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = IpFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectNetworkDestinationIpV6ListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNetworkDestinationPort())
            {
                context.Writer.WritePropertyName("NetworkDestinationPort");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNetworkDestinationPortListValue in requestObject.NetworkDestinationPort)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = NumberFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectNetworkDestinationPortListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNetworkDirection())
            {
                context.Writer.WritePropertyName("NetworkDirection");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNetworkDirectionListValue in requestObject.NetworkDirection)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectNetworkDirectionListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNetworkProtocol())
            {
                context.Writer.WritePropertyName("NetworkProtocol");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNetworkProtocolListValue in requestObject.NetworkProtocol)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectNetworkProtocolListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNetworkSourceDomain())
            {
                context.Writer.WritePropertyName("NetworkSourceDomain");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNetworkSourceDomainListValue in requestObject.NetworkSourceDomain)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectNetworkSourceDomainListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNetworkSourceIpV4())
            {
                context.Writer.WritePropertyName("NetworkSourceIpV4");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNetworkSourceIpV4ListValue in requestObject.NetworkSourceIpV4)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = IpFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectNetworkSourceIpV4ListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNetworkSourceIpV6())
            {
                context.Writer.WritePropertyName("NetworkSourceIpV6");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNetworkSourceIpV6ListValue in requestObject.NetworkSourceIpV6)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = IpFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectNetworkSourceIpV6ListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNetworkSourceMac())
            {
                context.Writer.WritePropertyName("NetworkSourceMac");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNetworkSourceMacListValue in requestObject.NetworkSourceMac)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectNetworkSourceMacListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNetworkSourcePort())
            {
                context.Writer.WritePropertyName("NetworkSourcePort");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNetworkSourcePortListValue in requestObject.NetworkSourcePort)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = NumberFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectNetworkSourcePortListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNoteText())
            {
                context.Writer.WritePropertyName("NoteText");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNoteTextListValue in requestObject.NoteText)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectNoteTextListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNoteUpdatedAt())
            {
                context.Writer.WritePropertyName("NoteUpdatedAt");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNoteUpdatedAtListValue in requestObject.NoteUpdatedAt)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectNoteUpdatedAtListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNoteUpdatedBy())
            {
                context.Writer.WritePropertyName("NoteUpdatedBy");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNoteUpdatedByListValue in requestObject.NoteUpdatedBy)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectNoteUpdatedByListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetProcessLaunchedAt())
            {
                context.Writer.WritePropertyName("ProcessLaunchedAt");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectProcessLaunchedAtListValue in requestObject.ProcessLaunchedAt)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectProcessLaunchedAtListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetProcessName())
            {
                context.Writer.WritePropertyName("ProcessName");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectProcessNameListValue in requestObject.ProcessName)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectProcessNameListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetProcessParentPid())
            {
                context.Writer.WritePropertyName("ProcessParentPid");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectProcessParentPidListValue in requestObject.ProcessParentPid)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = NumberFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectProcessParentPidListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetProcessPath())
            {
                context.Writer.WritePropertyName("ProcessPath");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectProcessPathListValue in requestObject.ProcessPath)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectProcessPathListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetProcessPid())
            {
                context.Writer.WritePropertyName("ProcessPid");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectProcessPidListValue in requestObject.ProcessPid)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = NumberFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectProcessPidListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetProcessTerminatedAt())
            {
                context.Writer.WritePropertyName("ProcessTerminatedAt");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectProcessTerminatedAtListValue in requestObject.ProcessTerminatedAt)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectProcessTerminatedAtListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetProductArn())
            {
                context.Writer.WritePropertyName("ProductArn");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectProductArnListValue in requestObject.ProductArn)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectProductArnListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetProductFields())
            {
                context.Writer.WritePropertyName("ProductFields");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectProductFieldsListValue in requestObject.ProductFields)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = MapFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectProductFieldsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetProductName())
            {
                context.Writer.WritePropertyName("ProductName");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectProductNameListValue in requestObject.ProductName)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectProductNameListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRecommendationText())
            {
                context.Writer.WritePropertyName("RecommendationText");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRecommendationTextListValue in requestObject.RecommendationText)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectRecommendationTextListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRecordState())
            {
                context.Writer.WritePropertyName("RecordState");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRecordStateListValue in requestObject.RecordState)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectRecordStateListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRegion())
            {
                context.Writer.WritePropertyName("Region");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRegionListValue in requestObject.Region)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectRegionListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRelatedFindingsId())
            {
                context.Writer.WritePropertyName("RelatedFindingsId");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRelatedFindingsIdListValue in requestObject.RelatedFindingsId)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectRelatedFindingsIdListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRelatedFindingsProductArn())
            {
                context.Writer.WritePropertyName("RelatedFindingsProductArn");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRelatedFindingsProductArnListValue in requestObject.RelatedFindingsProductArn)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectRelatedFindingsProductArnListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceAwsEc2InstanceIamInstanceProfileArn())
            {
                context.Writer.WritePropertyName("ResourceAwsEc2InstanceIamInstanceProfileArn");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceAwsEc2InstanceIamInstanceProfileArnListValue in requestObject.ResourceAwsEc2InstanceIamInstanceProfileArn)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAwsEc2InstanceIamInstanceProfileArnListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceAwsEc2InstanceImageId())
            {
                context.Writer.WritePropertyName("ResourceAwsEc2InstanceImageId");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceAwsEc2InstanceImageIdListValue in requestObject.ResourceAwsEc2InstanceImageId)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAwsEc2InstanceImageIdListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceAwsEc2InstanceIpV4Addresses())
            {
                context.Writer.WritePropertyName("ResourceAwsEc2InstanceIpV4Addresses");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceAwsEc2InstanceIpV4AddressesListValue in requestObject.ResourceAwsEc2InstanceIpV4Addresses)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = IpFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAwsEc2InstanceIpV4AddressesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceAwsEc2InstanceIpV6Addresses())
            {
                context.Writer.WritePropertyName("ResourceAwsEc2InstanceIpV6Addresses");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceAwsEc2InstanceIpV6AddressesListValue in requestObject.ResourceAwsEc2InstanceIpV6Addresses)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = IpFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAwsEc2InstanceIpV6AddressesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceAwsEc2InstanceKeyName())
            {
                context.Writer.WritePropertyName("ResourceAwsEc2InstanceKeyName");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceAwsEc2InstanceKeyNameListValue in requestObject.ResourceAwsEc2InstanceKeyName)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAwsEc2InstanceKeyNameListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceAwsEc2InstanceLaunchedAt())
            {
                context.Writer.WritePropertyName("ResourceAwsEc2InstanceLaunchedAt");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceAwsEc2InstanceLaunchedAtListValue in requestObject.ResourceAwsEc2InstanceLaunchedAt)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAwsEc2InstanceLaunchedAtListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceAwsEc2InstanceSubnetId())
            {
                context.Writer.WritePropertyName("ResourceAwsEc2InstanceSubnetId");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceAwsEc2InstanceSubnetIdListValue in requestObject.ResourceAwsEc2InstanceSubnetId)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAwsEc2InstanceSubnetIdListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceAwsEc2InstanceType())
            {
                context.Writer.WritePropertyName("ResourceAwsEc2InstanceType");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceAwsEc2InstanceTypeListValue in requestObject.ResourceAwsEc2InstanceType)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAwsEc2InstanceTypeListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceAwsEc2InstanceVpcId())
            {
                context.Writer.WritePropertyName("ResourceAwsEc2InstanceVpcId");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceAwsEc2InstanceVpcIdListValue in requestObject.ResourceAwsEc2InstanceVpcId)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAwsEc2InstanceVpcIdListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceAwsIamAccessKeyCreatedAt())
            {
                context.Writer.WritePropertyName("ResourceAwsIamAccessKeyCreatedAt");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceAwsIamAccessKeyCreatedAtListValue in requestObject.ResourceAwsIamAccessKeyCreatedAt)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAwsIamAccessKeyCreatedAtListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceAwsIamAccessKeyPrincipalName())
            {
                context.Writer.WritePropertyName("ResourceAwsIamAccessKeyPrincipalName");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceAwsIamAccessKeyPrincipalNameListValue in requestObject.ResourceAwsIamAccessKeyPrincipalName)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAwsIamAccessKeyPrincipalNameListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceAwsIamAccessKeyStatus())
            {
                context.Writer.WritePropertyName("ResourceAwsIamAccessKeyStatus");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceAwsIamAccessKeyStatusListValue in requestObject.ResourceAwsIamAccessKeyStatus)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAwsIamAccessKeyStatusListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceAwsIamAccessKeyUserName())
            {
                context.Writer.WritePropertyName("ResourceAwsIamAccessKeyUserName");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceAwsIamAccessKeyUserNameListValue in requestObject.ResourceAwsIamAccessKeyUserName)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAwsIamAccessKeyUserNameListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceAwsIamUserUserName())
            {
                context.Writer.WritePropertyName("ResourceAwsIamUserUserName");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceAwsIamUserUserNameListValue in requestObject.ResourceAwsIamUserUserName)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAwsIamUserUserNameListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceAwsS3BucketOwnerId())
            {
                context.Writer.WritePropertyName("ResourceAwsS3BucketOwnerId");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceAwsS3BucketOwnerIdListValue in requestObject.ResourceAwsS3BucketOwnerId)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAwsS3BucketOwnerIdListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceAwsS3BucketOwnerName())
            {
                context.Writer.WritePropertyName("ResourceAwsS3BucketOwnerName");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceAwsS3BucketOwnerNameListValue in requestObject.ResourceAwsS3BucketOwnerName)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceAwsS3BucketOwnerNameListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceContainerImageId())
            {
                context.Writer.WritePropertyName("ResourceContainerImageId");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceContainerImageIdListValue in requestObject.ResourceContainerImageId)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceContainerImageIdListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceContainerImageName())
            {
                context.Writer.WritePropertyName("ResourceContainerImageName");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceContainerImageNameListValue in requestObject.ResourceContainerImageName)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceContainerImageNameListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceContainerLaunchedAt())
            {
                context.Writer.WritePropertyName("ResourceContainerLaunchedAt");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceContainerLaunchedAtListValue in requestObject.ResourceContainerLaunchedAt)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceContainerLaunchedAtListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceContainerName())
            {
                context.Writer.WritePropertyName("ResourceContainerName");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceContainerNameListValue in requestObject.ResourceContainerName)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceContainerNameListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceDetailsOther())
            {
                context.Writer.WritePropertyName("ResourceDetailsOther");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceDetailsOtherListValue in requestObject.ResourceDetailsOther)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = MapFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceDetailsOtherListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceId())
            {
                context.Writer.WritePropertyName("ResourceId");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceIdListValue in requestObject.ResourceId)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceIdListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourcePartition())
            {
                context.Writer.WritePropertyName("ResourcePartition");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourcePartitionListValue in requestObject.ResourcePartition)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourcePartitionListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceRegion())
            {
                context.Writer.WritePropertyName("ResourceRegion");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceRegionListValue in requestObject.ResourceRegion)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceRegionListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceTags())
            {
                context.Writer.WritePropertyName("ResourceTags");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceTagsListValue in requestObject.ResourceTags)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = MapFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceTagsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceType())
            {
                context.Writer.WritePropertyName("ResourceType");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceTypeListValue in requestObject.ResourceType)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceTypeListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSample())
            {
                context.Writer.WritePropertyName("Sample");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSampleListValue in requestObject.Sample)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = BooleanFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectSampleListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSeverityLabel())
            {
                context.Writer.WritePropertyName("SeverityLabel");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSeverityLabelListValue in requestObject.SeverityLabel)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectSeverityLabelListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSeverityNormalized())
            {
                context.Writer.WritePropertyName("SeverityNormalized");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSeverityNormalizedListValue in requestObject.SeverityNormalized)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = NumberFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectSeverityNormalizedListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSeverityProduct())
            {
                context.Writer.WritePropertyName("SeverityProduct");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSeverityProductListValue in requestObject.SeverityProduct)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = NumberFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectSeverityProductListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSourceUrl())
            {
                context.Writer.WritePropertyName("SourceUrl");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSourceUrlListValue in requestObject.SourceUrl)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectSourceUrlListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetThreatIntelIndicatorCategory())
            {
                context.Writer.WritePropertyName("ThreatIntelIndicatorCategory");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectThreatIntelIndicatorCategoryListValue in requestObject.ThreatIntelIndicatorCategory)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectThreatIntelIndicatorCategoryListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetThreatIntelIndicatorLastObservedAt())
            {
                context.Writer.WritePropertyName("ThreatIntelIndicatorLastObservedAt");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectThreatIntelIndicatorLastObservedAtListValue in requestObject.ThreatIntelIndicatorLastObservedAt)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectThreatIntelIndicatorLastObservedAtListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetThreatIntelIndicatorSource())
            {
                context.Writer.WritePropertyName("ThreatIntelIndicatorSource");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectThreatIntelIndicatorSourceListValue in requestObject.ThreatIntelIndicatorSource)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectThreatIntelIndicatorSourceListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetThreatIntelIndicatorSourceUrl())
            {
                context.Writer.WritePropertyName("ThreatIntelIndicatorSourceUrl");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectThreatIntelIndicatorSourceUrlListValue in requestObject.ThreatIntelIndicatorSourceUrl)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectThreatIntelIndicatorSourceUrlListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetThreatIntelIndicatorType())
            {
                context.Writer.WritePropertyName("ThreatIntelIndicatorType");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectThreatIntelIndicatorTypeListValue in requestObject.ThreatIntelIndicatorType)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectThreatIntelIndicatorTypeListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetThreatIntelIndicatorValue())
            {
                context.Writer.WritePropertyName("ThreatIntelIndicatorValue");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectThreatIntelIndicatorValueListValue in requestObject.ThreatIntelIndicatorValue)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectThreatIntelIndicatorValueListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTitle())
            {
                context.Writer.WritePropertyName("Title");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTitleListValue in requestObject.Title)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectTitleListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTypeListValue in requestObject.Type)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectTypeListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetUpdatedAt())
            {
                context.Writer.WritePropertyName("UpdatedAt");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectUpdatedAtListValue in requestObject.UpdatedAt)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectUpdatedAtListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetUserDefinedFields())
            {
                context.Writer.WritePropertyName("UserDefinedFields");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectUserDefinedFieldsListValue in requestObject.UserDefinedFields)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = MapFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectUserDefinedFieldsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetVerificationState())
            {
                context.Writer.WritePropertyName("VerificationState");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectVerificationStateListValue in requestObject.VerificationState)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectVerificationStateListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetWorkflowState())
            {
                context.Writer.WritePropertyName("WorkflowState");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectWorkflowStateListValue in requestObject.WorkflowState)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectWorkflowStateListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetWorkflowStatus())
            {
                context.Writer.WritePropertyName("WorkflowStatus");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectWorkflowStatusListValue in requestObject.WorkflowStatus)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectWorkflowStatusListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsSecurityFindingFiltersMarshaller Instance = new AwsSecurityFindingFiltersMarshaller();

    }
}