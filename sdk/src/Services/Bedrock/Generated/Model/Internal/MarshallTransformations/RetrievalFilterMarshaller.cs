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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Bedrock.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Bedrock.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RetrievalFilter Marshaller
    /// </summary>
    public class RetrievalFilterMarshaller : IRequestMarshaller<RetrievalFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RetrievalFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAndAll())
            {
                context.Writer.WritePropertyName("andAll");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAndAllListValue in requestObject.AndAll)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = RetrievalFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectAndAllListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEquals())
            {
                context.Writer.WritePropertyName("equals");
                context.Writer.WriteStartObject();

                var marshaller = FilterAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.Equals, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGreaterThan())
            {
                context.Writer.WritePropertyName("greaterThan");
                context.Writer.WriteStartObject();

                var marshaller = FilterAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.GreaterThan, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGreaterThanOrEquals())
            {
                context.Writer.WritePropertyName("greaterThanOrEquals");
                context.Writer.WriteStartObject();

                var marshaller = FilterAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.GreaterThanOrEquals, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIn())
            {
                context.Writer.WritePropertyName("in");
                context.Writer.WriteStartObject();

                var marshaller = FilterAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.In, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLessThan())
            {
                context.Writer.WritePropertyName("lessThan");
                context.Writer.WriteStartObject();

                var marshaller = FilterAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.LessThan, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLessThanOrEquals())
            {
                context.Writer.WritePropertyName("lessThanOrEquals");
                context.Writer.WriteStartObject();

                var marshaller = FilterAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.LessThanOrEquals, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetListContains())
            {
                context.Writer.WritePropertyName("listContains");
                context.Writer.WriteStartObject();

                var marshaller = FilterAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.ListContains, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNotEquals())
            {
                context.Writer.WritePropertyName("notEquals");
                context.Writer.WriteStartObject();

                var marshaller = FilterAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.NotEquals, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNotIn())
            {
                context.Writer.WritePropertyName("notIn");
                context.Writer.WriteStartObject();

                var marshaller = FilterAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.NotIn, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOrAll())
            {
                context.Writer.WritePropertyName("orAll");
                context.Writer.WriteStartArray();
                foreach(var requestObjectOrAllListValue in requestObject.OrAll)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = RetrievalFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectOrAllListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetStartsWith())
            {
                context.Writer.WritePropertyName("startsWith");
                context.Writer.WriteStartObject();

                var marshaller = FilterAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.StartsWith, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStringContains())
            {
                context.Writer.WritePropertyName("stringContains");
                context.Writer.WriteStartObject();

                var marshaller = FilterAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.StringContains, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RetrievalFilterMarshaller Instance = new RetrievalFilterMarshaller();

    }
}