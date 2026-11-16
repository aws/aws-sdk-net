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

using Amazon.WellArchitected.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.WellArchitected.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OrganizationalReportFilters Marshaller
    /// </summary>
    public partial class OrganizationalReportFiltersMarshaller : IRequestMarshaller<OrganizationalReportFilters, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(OrganizationalReportFilters requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAccountIds())
            {
                context.Writer.WritePropertyName("accountIds");
                context.Writer.WriteStartArray();
                foreach (var requestObjectAccountIdsListValue in requestObject.AccountIds)
                {
                    context.Writer.WriteStringValue(requestObjectAccountIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetCreatedAtRange())
            {
                context.Writer.WritePropertyName("createdAtRange");
                context.Writer.WriteStartObject();

                var marshaller = TimeWindowMarshaller.Instance;
                marshaller.Marshall(requestObject.CreatedAtRange, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetOrganizationalUnitIds())
            {
                context.Writer.WritePropertyName("organizationalUnitIds");
                context.Writer.WriteStartArray();
                foreach (var requestObjectOrganizationalUnitIdsListValue in requestObject.OrganizationalUnitIds)
                {
                    context.Writer.WriteStringValue(requestObjectOrganizationalUnitIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetPillars())
            {
                context.Writer.WritePropertyName("pillars");
                context.Writer.WriteStartArray();
                foreach (var requestObjectPillarsListValue in requestObject.Pillars)
                {
                    context.Writer.WriteStringValue(requestObjectPillarsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetPriorities())
            {
                context.Writer.WritePropertyName("priorities");
                context.Writer.WriteStartArray();
                foreach (var requestObjectPrioritiesListValue in requestObject.Priorities)
                {
                    context.Writer.WriteStringValue(requestObjectPrioritiesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetRecommendationTypes())
            {
                context.Writer.WritePropertyName("recommendationTypes");
                context.Writer.WriteStartArray();
                foreach (var requestObjectRecommendationTypesListValue in requestObject.RecommendationTypes)
                {
                    context.Writer.WriteStringValue(requestObjectRecommendationTypesListValue);
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

            if (requestObject.IsSetUpdatedAtRange())
            {
                context.Writer.WritePropertyName("updatedAtRange");
                context.Writer.WriteStartObject();

                var marshaller = TimeWindowMarshaller.Instance;
                marshaller.Marshall(requestObject.UpdatedAtRange, context);

                context.Writer.WriteEndObject();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static OrganizationalReportFiltersMarshaller Instance = new OrganizationalReportFiltersMarshaller();
    }
}
