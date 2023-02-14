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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetAggregateColumns())
            {
                context.Writer.WritePropertyName("aggregateColumns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAggregateColumnsListValue in requestObject.AggregateColumns)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AggregateColumnMarshaller.Instance;
                    marshaller.Marshall(requestObjectAggregateColumnsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDimensionColumns())
            {
                context.Writer.WritePropertyName("dimensionColumns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDimensionColumnsListValue in requestObject.DimensionColumns)
                {
                        context.Writer.Write(requestObjectDimensionColumnsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetJoinColumns())
            {
                context.Writer.WritePropertyName("joinColumns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectJoinColumnsListValue in requestObject.JoinColumns)
                {
                        context.Writer.Write(requestObjectJoinColumnsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetJoinRequired())
            {
                context.Writer.WritePropertyName("joinRequired");
                context.Writer.Write(requestObject.JoinRequired);
            }

            if(requestObject.IsSetOutputConstraints())
            {
                context.Writer.WritePropertyName("outputConstraints");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectOutputConstraintsListValue in requestObject.OutputConstraints)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AggregationConstraintMarshaller.Instance;
                    marshaller.Marshall(requestObjectOutputConstraintsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetScalarFunctions())
            {
                context.Writer.WritePropertyName("scalarFunctions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectScalarFunctionsListValue in requestObject.ScalarFunctions)
                {
                        context.Writer.Write(requestObjectScalarFunctionsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AnalysisRuleAggregationMarshaller Instance = new AnalysisRuleAggregationMarshaller();

    }
}