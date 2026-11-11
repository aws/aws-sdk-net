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

using Amazon.Shield.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.Shield.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InclusionProtectionGroupFilters Marshaller
    /// </summary>
    public partial class InclusionProtectionGroupFiltersMarshaller : IRequestMarshaller<InclusionProtectionGroupFilters, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(InclusionProtectionGroupFilters requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAggregations())
            {
                context.Writer.WriteTextString("Aggregations");
                context.Writer.WriteStartArray(requestObject.Aggregations.Count);
                foreach (var requestObjectAggregationsListValue in requestObject.Aggregations)
                {
                    context.Writer.WriteTextString(requestObjectAggregationsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetPatterns())
            {
                context.Writer.WriteTextString("Patterns");
                context.Writer.WriteStartArray(requestObject.Patterns.Count);
                foreach (var requestObjectPatternsListValue in requestObject.Patterns)
                {
                    context.Writer.WriteTextString(requestObjectPatternsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetProtectionGroupIds())
            {
                context.Writer.WriteTextString("ProtectionGroupIds");
                context.Writer.WriteStartArray(requestObject.ProtectionGroupIds.Count);
                foreach (var requestObjectProtectionGroupIdsListValue in requestObject.ProtectionGroupIds)
                {
                    context.Writer.WriteTextString(requestObjectProtectionGroupIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetResourceTypes())
            {
                context.Writer.WriteTextString("ResourceTypes");
                context.Writer.WriteStartArray(requestObject.ResourceTypes.Count);
                foreach (var requestObjectResourceTypesListValue in requestObject.ResourceTypes)
                {
                    context.Writer.WriteTextString(requestObjectResourceTypesListValue);
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static InclusionProtectionGroupFiltersMarshaller Instance = new InclusionProtectionGroupFiltersMarshaller();
    }
}
