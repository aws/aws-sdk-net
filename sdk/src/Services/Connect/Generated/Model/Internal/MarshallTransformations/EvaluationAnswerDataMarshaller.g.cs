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

using Amazon.Connect.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EvaluationAnswerData Marshaller
    /// </summary>
    public partial class EvaluationAnswerDataMarshaller : IRequestMarshaller<EvaluationAnswerData, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(EvaluationAnswerData requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetDateTimeValue())
            {
                context.Writer.WritePropertyName("DateTimeValue");
                context.Writer.WriteStringValue(requestObject.DateTimeValue);
            }

            if (requestObject.IsSetNotApplicable())
            {
                context.Writer.WritePropertyName("NotApplicable");
                context.Writer.WriteBooleanValue(requestObject.NotApplicable.Value);
            }

            if (requestObject.IsSetNumericValue())
            {
                context.Writer.WritePropertyName("NumericValue");
                if (StringUtils.IsSpecialDoubleValue(requestObject.NumericValue.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.NumericValue.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.NumericValue.Value);
                }
            }

            if (requestObject.IsSetStringValue())
            {
                context.Writer.WritePropertyName("StringValue");
                context.Writer.WriteStringValue(requestObject.StringValue);
            }

            if (requestObject.IsSetStringValues())
            {
                context.Writer.WritePropertyName("StringValues");
                context.Writer.WriteStartArray();
                foreach (var requestObjectStringValuesListValue in requestObject.StringValues)
                {
                    context.Writer.WriteStringValue(requestObjectStringValuesListValue);
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static EvaluationAnswerDataMarshaller Instance = new EvaluationAnswerDataMarshaller();
    }
}
