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
 * Do not modify this file. This file is generated from the bcm-pricing-calculator-2024-06-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BCMPricingCalculator.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.BCMPricingCalculator.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Expression Marshaller
    /// </summary>
    public class ExpressionMarshaller : IRequestMarshaller<Expression, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Expression requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetAnd())
            {
                context.Writer.WriteTextString("and");
                context.Writer.WriteStartArray(requestObject.And.Count);
                foreach(var requestObjectAndListValue in requestObject.And)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = ExpressionMarshaller.Instance;
                    marshaller.Marshall(requestObjectAndListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetCostCategories())
            {
                context.Writer.WriteTextString("costCategories");
                context.Writer.WriteStartMap(null);

                var marshaller = ExpressionFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.CostCategories, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetDimensions())
            {
                context.Writer.WriteTextString("dimensions");
                context.Writer.WriteStartMap(null);

                var marshaller = ExpressionFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.Dimensions, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetNot())
            {
                context.Writer.WriteTextString("not");
                context.Writer.WriteStartMap(null);

                var marshaller = ExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.Not, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetOr())
            {
                context.Writer.WriteTextString("or");
                context.Writer.WriteStartArray(requestObject.Or.Count);
                foreach(var requestObjectOrListValue in requestObject.Or)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = ExpressionMarshaller.Instance;
                    marshaller.Marshall(requestObjectOrListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetTags())
            {
                context.Writer.WriteTextString("tags");
                context.Writer.WriteStartMap(null);

                var marshaller = ExpressionFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.Tags, context);

                context.Writer.WriteEndMap();
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ExpressionMarshaller Instance = new ExpressionMarshaller();

    }
}