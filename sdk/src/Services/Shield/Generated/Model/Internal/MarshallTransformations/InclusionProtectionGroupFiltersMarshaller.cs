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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Shield.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Shield.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InclusionProtectionGroupFilters Marshaller
    /// </summary>
    public class InclusionProtectionGroupFiltersMarshaller : IRequestMarshaller<InclusionProtectionGroupFilters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InclusionProtectionGroupFilters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAggregations())
            {
                context.Writer.WritePropertyName("Aggregations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAggregationsListValue in requestObject.Aggregations)
                {
                        context.Writer.WriteStringValue(requestObjectAggregationsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPatterns())
            {
                context.Writer.WritePropertyName("Patterns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPatternsListValue in requestObject.Patterns)
                {
                        context.Writer.WriteStringValue(requestObjectPatternsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetProtectionGroupIds())
            {
                context.Writer.WritePropertyName("ProtectionGroupIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectProtectionGroupIdsListValue in requestObject.ProtectionGroupIds)
                {
                        context.Writer.WriteStringValue(requestObjectProtectionGroupIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceTypes())
            {
                context.Writer.WritePropertyName("ResourceTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceTypesListValue in requestObject.ResourceTypes)
                {
                        context.Writer.WriteStringValue(requestObjectResourceTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InclusionProtectionGroupFiltersMarshaller Instance = new InclusionProtectionGroupFiltersMarshaller();

    }
}