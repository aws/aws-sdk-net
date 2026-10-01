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
    /// NumericalMeasureField Marshaller
    /// </summary>
    public partial class NumericalMeasureFieldMarshaller : IRequestMarshaller<NumericalMeasureField, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(NumericalMeasureField requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAggregationFunction())
            {
                context.Writer.WritePropertyName("AggregationFunction");
                context.Writer.WriteStartObject();

                var marshaller = NumericalAggregationFunctionMarshaller.Instance;
                marshaller.Marshall(requestObject.AggregationFunction, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetColumn())
            {
                context.Writer.WritePropertyName("Column");
                context.Writer.WriteStartObject();

                var marshaller = ColumnIdentifierMarshaller.Instance;
                marshaller.Marshall(requestObject.Column, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetFieldId())
            {
                context.Writer.WritePropertyName("FieldId");
                context.Writer.WriteStringValue(requestObject.FieldId);
            }

            if (requestObject.IsSetFormatConfiguration())
            {
                context.Writer.WritePropertyName("FormatConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = NumberFormatConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.FormatConfiguration, context);

                context.Writer.WriteEndObject();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static NumericalMeasureFieldMarshaller Instance = new NumericalMeasureFieldMarshaller();
    }
}
