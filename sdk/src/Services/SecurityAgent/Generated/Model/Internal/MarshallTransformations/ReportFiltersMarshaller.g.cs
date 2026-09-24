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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.SecurityAgent.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.SecurityAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ReportFilters Marshaller
    /// </summary>
    public partial class ReportFiltersMarshaller : IRequestMarshaller<ReportFilters, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ReportFilters requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAnnotationNotes())
            {
                context.Writer.WritePropertyName("annotationNotes");
                context.Writer.WriteBooleanValue(requestObject.AnnotationNotes.Value);
            }

            if (requestObject.IsSetComplianceReport())
            {
                context.Writer.WritePropertyName("complianceReport");
                context.Writer.WriteBooleanValue(requestObject.ComplianceReport.Value);
            }

            if (requestObject.IsSetConfidenceLevels())
            {
                context.Writer.WritePropertyName("confidenceLevels");
                context.Writer.WriteStartArray();
                foreach (var requestObjectConfidenceLevelsListValue in requestObject.ConfidenceLevels)
                {
                    context.Writer.WriteStringValue(requestObjectConfidenceLevelsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetFindingTypes())
            {
                context.Writer.WritePropertyName("findingTypes");
                context.Writer.WriteStartArray();
                foreach (var requestObjectFindingTypesListValue in requestObject.FindingTypes)
                {
                    context.Writer.WriteStringValue(requestObjectFindingTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetRiskLevels())
            {
                context.Writer.WritePropertyName("riskLevels");
                context.Writer.WriteStartArray();
                foreach (var requestObjectRiskLevelsListValue in requestObject.RiskLevels)
                {
                    context.Writer.WriteStringValue(requestObjectRiskLevelsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetRiskTypes())
            {
                context.Writer.WritePropertyName("riskTypes");
                context.Writer.WriteStartArray();
                foreach (var requestObjectRiskTypesListValue in requestObject.RiskTypes)
                {
                    context.Writer.WriteStringValue(requestObjectRiskTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetStatuses())
            {
                context.Writer.WritePropertyName("statuses");
                context.Writer.WriteStartArray();
                foreach (var requestObjectStatusesListValue in requestObject.Statuses)
                {
                    context.Writer.WriteStringValue(requestObjectStatusesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetTaskStatuses())
            {
                context.Writer.WritePropertyName("taskStatuses");
                context.Writer.WriteStartArray();
                foreach (var requestObjectTaskStatusesListValue in requestObject.TaskStatuses)
                {
                    context.Writer.WriteStringValue(requestObjectTaskStatusesListValue);
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ReportFiltersMarshaller Instance = new ReportFiltersMarshaller();
    }
}
