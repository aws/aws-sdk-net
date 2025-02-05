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
        public readonly static AutomationRulesFindingFiltersMarshaller Instance = new AutomationRulesFindingFiltersMarshaller();

    }
}