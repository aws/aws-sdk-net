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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kendra.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AttributeFilter Marshaller
    /// </summary>
    public class AttributeFilterMarshaller : IRequestMarshaller<AttributeFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AttributeFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAndAllFilters())
            {
                context.Writer.WritePropertyName("AndAllFilters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAndAllFiltersListValue in requestObject.AndAllFilters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AttributeFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectAndAllFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetContainsAll())
            {
                context.Writer.WritePropertyName("ContainsAll");
                context.Writer.WriteStartObject();

                var marshaller = DocumentAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.ContainsAll, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetContainsAny())
            {
                context.Writer.WritePropertyName("ContainsAny");
                context.Writer.WriteStartObject();

                var marshaller = DocumentAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.ContainsAny, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEqualsTo())
            {
                context.Writer.WritePropertyName("EqualsTo");
                context.Writer.WriteStartObject();

                var marshaller = DocumentAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.EqualsTo, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGreaterThan())
            {
                context.Writer.WritePropertyName("GreaterThan");
                context.Writer.WriteStartObject();

                var marshaller = DocumentAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.GreaterThan, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGreaterThanOrEquals())
            {
                context.Writer.WritePropertyName("GreaterThanOrEquals");
                context.Writer.WriteStartObject();

                var marshaller = DocumentAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.GreaterThanOrEquals, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLessThan())
            {
                context.Writer.WritePropertyName("LessThan");
                context.Writer.WriteStartObject();

                var marshaller = DocumentAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.LessThan, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLessThanOrEquals())
            {
                context.Writer.WritePropertyName("LessThanOrEquals");
                context.Writer.WriteStartObject();

                var marshaller = DocumentAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.LessThanOrEquals, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNotFilter())
            {
                context.Writer.WritePropertyName("NotFilter");
                context.Writer.WriteStartObject();

                var marshaller = AttributeFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.NotFilter, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOrAllFilters())
            {
                context.Writer.WritePropertyName("OrAllFilters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectOrAllFiltersListValue in requestObject.OrAllFilters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AttributeFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectOrAllFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AttributeFilterMarshaller Instance = new AttributeFilterMarshaller();

    }
}