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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CleanRooms.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CleanRooms.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AnalysisRuleAggregation Marshaller
    /// </summary>
    public class AnalysisRuleAggregationMarshaller : IRequestMarshaller<AnalysisRuleAggregation, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AnalysisRuleAggregation requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdditionalAnalyses())
            {
                context.Writer.WritePropertyName("additionalAnalyses");
                context.Writer.WriteStringValue(requestObject.AdditionalAnalyses);
            }

            if(requestObject.IsSetAggregateColumns())
            {
                context.Writer.WritePropertyName("aggregateColumns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAggregateColumnsListValue in requestObject.AggregateColumns)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AggregateColumnMarshaller.Instance;
                    marshaller.Marshall(requestObjectAggregateColumnsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetAllowedJoinOperators())
            {
                context.Writer.WritePropertyName("allowedJoinOperators");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAllowedJoinOperatorsListValue in requestObject.AllowedJoinOperators)
                {
                        context.Writer.WriteStringValue(requestObjectAllowedJoinOperatorsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDimensionColumns())
            {
                context.Writer.WritePropertyName("dimensionColumns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDimensionColumnsListValue in requestObject.DimensionColumns)
                {
                        context.Writer.WriteStringValue(requestObjectDimensionColumnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetJoinColumns())
            {
                context.Writer.WritePropertyName("joinColumns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectJoinColumnsListValue in requestObject.JoinColumns)
                {
                        context.Writer.WriteStringValue(requestObjectJoinColumnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetJoinRequired())
            {
                context.Writer.WritePropertyName("joinRequired");
                context.Writer.WriteStringValue(requestObject.JoinRequired);
            }

            if(requestObject.IsSetOutputConstraints())
            {
                context.Writer.WritePropertyName("outputConstraints");
                context.Writer.WriteStartArray();
                foreach(var requestObjectOutputConstraintsListValue in requestObject.OutputConstraints)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AggregationConstraintMarshaller.Instance;
                    marshaller.Marshall(requestObjectOutputConstraintsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetScalarFunctions())
            {
                context.Writer.WritePropertyName("scalarFunctions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectScalarFunctionsListValue in requestObject.ScalarFunctions)
                {
                        context.Writer.WriteStringValue(requestObjectScalarFunctionsListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AnalysisRuleAggregationMarshaller Instance = new AnalysisRuleAggregationMarshaller();

    }
}