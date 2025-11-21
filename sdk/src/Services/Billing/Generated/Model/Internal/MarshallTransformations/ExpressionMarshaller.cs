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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Billing.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Billing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Expression Marshaller
    /// </summary>
    public class ExpressionMarshaller : IRequestMarshaller<Expression, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Expression requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDimensions())
            {
                context.Writer.WritePropertyName("dimensions");
                context.Writer.WriteStartObject();

                var marshaller = DimensionValuesMarshaller.Instance;
                marshaller.Marshall(requestObject.Dimensions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();

                var marshaller = TagValuesMarshaller.Instance;
                marshaller.Marshall(requestObject.Tags, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTimeRange())
            {
                context.Writer.WritePropertyName("timeRange");
                context.Writer.WriteStartObject();

                var marshaller = TimeRangeMarshaller.Instance;
                marshaller.Marshall(requestObject.TimeRange, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ExpressionMarshaller Instance = new ExpressionMarshaller();

    }
}