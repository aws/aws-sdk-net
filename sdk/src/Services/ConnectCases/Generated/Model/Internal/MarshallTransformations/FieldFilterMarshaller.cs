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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConnectCases.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ConnectCases.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FieldFilter Marshaller
    /// </summary>
    public class FieldFilterMarshaller : IRequestMarshaller<FieldFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FieldFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetContains())
            {
                context.Writer.WritePropertyName("contains");
                context.Writer.WriteStartObject();

                var marshaller = FieldValueMarshaller.Instance;
                marshaller.Marshall(requestObject.Contains, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEqualTo())
            {
                context.Writer.WritePropertyName("equalTo");
                context.Writer.WriteStartObject();

                var marshaller = FieldValueMarshaller.Instance;
                marshaller.Marshall(requestObject.EqualTo, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGreaterThan())
            {
                context.Writer.WritePropertyName("greaterThan");
                context.Writer.WriteStartObject();

                var marshaller = FieldValueMarshaller.Instance;
                marshaller.Marshall(requestObject.GreaterThan, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGreaterThanOrEqualTo())
            {
                context.Writer.WritePropertyName("greaterThanOrEqualTo");
                context.Writer.WriteStartObject();

                var marshaller = FieldValueMarshaller.Instance;
                marshaller.Marshall(requestObject.GreaterThanOrEqualTo, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLessThan())
            {
                context.Writer.WritePropertyName("lessThan");
                context.Writer.WriteStartObject();

                var marshaller = FieldValueMarshaller.Instance;
                marshaller.Marshall(requestObject.LessThan, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLessThanOrEqualTo())
            {
                context.Writer.WritePropertyName("lessThanOrEqualTo");
                context.Writer.WriteStartObject();

                var marshaller = FieldValueMarshaller.Instance;
                marshaller.Marshall(requestObject.LessThanOrEqualTo, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FieldFilterMarshaller Instance = new FieldFilterMarshaller();

    }
}