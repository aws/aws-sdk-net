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

using Amazon.QuickSight.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HierarchyFilter Marshaller
    /// </summary>
    public partial class HierarchyFilterMarshaller : IRequestMarshaller<HierarchyFilter, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(HierarchyFilter requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetColumn())
            {
                context.Writer.WritePropertyName("Column");
                context.Writer.WriteStartObject();

                var marshaller = ColumnIdentifierMarshaller.Instance;
                marshaller.Marshall(requestObject.Column, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetDefaultFilterControlConfiguration())
            {
                context.Writer.WritePropertyName("DefaultFilterControlConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DefaultFilterControlConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DefaultFilterControlConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetFilterId())
            {
                context.Writer.WritePropertyName("FilterId");
                context.Writer.WriteStringValue(requestObject.FilterId);
            }

            if (requestObject.IsSetHierarchyLevels())
            {
                context.Writer.WritePropertyName("HierarchyLevels");
                context.Writer.WriteStartArray();
                foreach (var requestObjectHierarchyLevelsListValue in requestObject.HierarchyLevels)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = HierarchyFilterLevelMarshaller.Instance;
                    marshaller.Marshall(requestObjectHierarchyLevelsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetHierarchyTree())
            {
                context.Writer.WritePropertyName("HierarchyTree");
                context.Writer.WriteStartObject();

                var marshaller = HierarchyFilterNodeMarshaller.Instance;
                marshaller.Marshall(requestObject.HierarchyTree, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetMatchOperator())
            {
                context.Writer.WritePropertyName("MatchOperator");
                context.Writer.WriteStringValue(requestObject.MatchOperator);
            }

            if (requestObject.IsSetNullOption())
            {
                context.Writer.WritePropertyName("NullOption");
                context.Writer.WriteStringValue(requestObject.NullOption);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static HierarchyFilterMarshaller Instance = new HierarchyFilterMarshaller();
    }
}
