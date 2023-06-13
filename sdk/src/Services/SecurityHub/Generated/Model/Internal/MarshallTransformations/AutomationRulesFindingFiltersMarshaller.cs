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
    /// AutomationRulesFindingFilters Marshaller
    /// </summary>
    public class AutomationRulesFindingFiltersMarshaller : IRequestMarshaller<AutomationRulesFindingFilters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AutomationRulesFindingFilters requestObject, JsonMarshallerContext context)
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
        public readonly static AutomationRulesFindingFiltersMarshaller Instance = new AutomationRulesFindingFiltersMarshaller();

    }
}