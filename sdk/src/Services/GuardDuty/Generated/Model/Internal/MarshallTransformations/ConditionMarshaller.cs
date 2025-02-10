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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GuardDuty.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.GuardDuty.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Condition Marshaller
    /// </summary>
    public class ConditionMarshaller : IRequestMarshaller<Condition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Condition requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEq())
            {
                context.Writer.WritePropertyName("eq");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEqListValue in requestObject.Eq)
                {
                        context.Writer.WriteStringValue(requestObjectEqListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEquals())
            {
                context.Writer.WritePropertyName("equals");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEqualsListValue in requestObject.Equals)
                {
                        context.Writer.WriteStringValue(requestObjectEqualsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetGreaterThan())
            {
                context.Writer.WritePropertyName("greaterThan");
                context.Writer.WriteNumberValue(requestObject.GreaterThan.Value);
            }

            if(requestObject.IsSetGreaterThanOrEqual())
            {
                context.Writer.WritePropertyName("greaterThanOrEqual");
                context.Writer.WriteNumberValue(requestObject.GreaterThanOrEqual.Value);
            }

            if(requestObject.IsSetGt())
            {
                context.Writer.WritePropertyName("gt");
                context.Writer.WriteNumberValue(requestObject.Gt.Value);
            }

            if(requestObject.IsSetGte())
            {
                context.Writer.WritePropertyName("gte");
                context.Writer.WriteNumberValue(requestObject.Gte.Value);
            }

            if(requestObject.IsSetLessThan())
            {
                context.Writer.WritePropertyName("lessThan");
                context.Writer.WriteNumberValue(requestObject.LessThan.Value);
            }

            if(requestObject.IsSetLessThanOrEqual())
            {
                context.Writer.WritePropertyName("lessThanOrEqual");
                context.Writer.WriteNumberValue(requestObject.LessThanOrEqual.Value);
            }

            if(requestObject.IsSetLt())
            {
                context.Writer.WritePropertyName("lt");
                context.Writer.WriteNumberValue(requestObject.Lt.Value);
            }

            if(requestObject.IsSetLte())
            {
                context.Writer.WritePropertyName("lte");
                context.Writer.WriteNumberValue(requestObject.Lte.Value);
            }

            if(requestObject.IsSetNeq())
            {
                context.Writer.WritePropertyName("neq");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNeqListValue in requestObject.Neq)
                {
                        context.Writer.WriteStringValue(requestObjectNeqListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetNotEquals())
            {
                context.Writer.WritePropertyName("notEquals");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNotEqualsListValue in requestObject.NotEquals)
                {
                        context.Writer.WriteStringValue(requestObjectNotEqualsListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ConditionMarshaller Instance = new ConditionMarshaller();

    }
}