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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TopicIRMetric Marshaller
    /// </summary>
    public class TopicIRMetricMarshaller : IRequestMarshaller<TopicIRMetric, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TopicIRMetric requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCalculatedFieldReferences())
            {
                context.Writer.WritePropertyName("CalculatedFieldReferences");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCalculatedFieldReferencesListValue in requestObject.CalculatedFieldReferences)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = IdentifierMarshaller.Instance;
                    marshaller.Marshall(requestObjectCalculatedFieldReferencesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetComparisonMethod())
            {
                context.Writer.WritePropertyName("ComparisonMethod");
                context.Writer.WriteObjectStart();

                var marshaller = TopicIRComparisonMethodMarshaller.Instance;
                marshaller.Marshall(requestObject.ComparisonMethod, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDisplayFormat())
            {
                context.Writer.WritePropertyName("DisplayFormat");
                context.Writer.Write(requestObject.DisplayFormat);
            }

            if(requestObject.IsSetDisplayFormatOptions())
            {
                context.Writer.WritePropertyName("DisplayFormatOptions");
                context.Writer.WriteObjectStart();

                var marshaller = DisplayFormatOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.DisplayFormatOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetExpression())
            {
                context.Writer.WritePropertyName("Expression");
                context.Writer.Write(requestObject.Expression);
            }

            if(requestObject.IsSetFunction())
            {
                context.Writer.WritePropertyName("Function");
                context.Writer.WriteObjectStart();

                var marshaller = AggFunctionMarshaller.Instance;
                marshaller.Marshall(requestObject.Function, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMetricId())
            {
                context.Writer.WritePropertyName("MetricId");
                context.Writer.WriteObjectStart();

                var marshaller = IdentifierMarshaller.Instance;
                marshaller.Marshall(requestObject.MetricId, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetNamedEntity())
            {
                context.Writer.WritePropertyName("NamedEntity");
                context.Writer.WriteObjectStart();

                var marshaller = NamedEntityRefMarshaller.Instance;
                marshaller.Marshall(requestObject.NamedEntity, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOperands())
            {
                context.Writer.WritePropertyName("Operands");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectOperandsListValue in requestObject.Operands)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = IdentifierMarshaller.Instance;
                    marshaller.Marshall(requestObjectOperandsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TopicIRMetricMarshaller Instance = new TopicIRMetricMarshaller();

    }
}