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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RowFilterExpression Marshaller
    /// </summary>
    public class RowFilterExpressionMarshaller : IRequestMarshaller<RowFilterExpression, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RowFilterExpression requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEqualTo())
            {
                context.Writer.WritePropertyName("equalTo");
                context.Writer.WriteStartObject();

                var marshaller = EqualToExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.EqualTo, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGreaterThan())
            {
                context.Writer.WritePropertyName("greaterThan");
                context.Writer.WriteStartObject();

                var marshaller = GreaterThanExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.GreaterThan, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGreaterThanOrEqualTo())
            {
                context.Writer.WritePropertyName("greaterThanOrEqualTo");
                context.Writer.WriteStartObject();

                var marshaller = GreaterThanOrEqualToExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.GreaterThanOrEqualTo, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIn())
            {
                context.Writer.WritePropertyName("in");
                context.Writer.WriteStartObject();

                var marshaller = InExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.In, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIsNotNull())
            {
                context.Writer.WritePropertyName("isNotNull");
                context.Writer.WriteStartObject();

                var marshaller = IsNotNullExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.IsNotNull, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIsNull())
            {
                context.Writer.WritePropertyName("isNull");
                context.Writer.WriteStartObject();

                var marshaller = IsNullExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.IsNull, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLessThan())
            {
                context.Writer.WritePropertyName("lessThan");
                context.Writer.WriteStartObject();

                var marshaller = LessThanExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.LessThan, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLessThanOrEqualTo())
            {
                context.Writer.WritePropertyName("lessThanOrEqualTo");
                context.Writer.WriteStartObject();

                var marshaller = LessThanOrEqualToExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.LessThanOrEqualTo, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLike())
            {
                context.Writer.WritePropertyName("like");
                context.Writer.WriteStartObject();

                var marshaller = LikeExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.Like, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNotEqualTo())
            {
                context.Writer.WritePropertyName("notEqualTo");
                context.Writer.WriteStartObject();

                var marshaller = NotEqualToExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.NotEqualTo, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNotIn())
            {
                context.Writer.WritePropertyName("notIn");
                context.Writer.WriteStartObject();

                var marshaller = NotInExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.NotIn, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNotLike())
            {
                context.Writer.WritePropertyName("notLike");
                context.Writer.WriteStartObject();

                var marshaller = NotLikeExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.NotLike, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RowFilterExpressionMarshaller Instance = new RowFilterExpressionMarshaller();

    }
}