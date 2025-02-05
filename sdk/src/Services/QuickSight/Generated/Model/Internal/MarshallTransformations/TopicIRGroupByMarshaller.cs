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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TopicIRGroupBy Marshaller
    /// </summary>
    public class TopicIRGroupByMarshaller : IRequestMarshaller<TopicIRGroupBy, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TopicIRGroupBy requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDisplayFormat())
            {
                context.Writer.WritePropertyName("DisplayFormat");
                context.Writer.WriteStringValue(requestObject.DisplayFormat);
            }

            if(requestObject.IsSetDisplayFormatOptions())
            {
                context.Writer.WritePropertyName("DisplayFormatOptions");
                context.Writer.WriteStartObject();

                var marshaller = DisplayFormatOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.DisplayFormatOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFieldName())
            {
                context.Writer.WritePropertyName("FieldName");
                context.Writer.WriteStartObject();

                var marshaller = IdentifierMarshaller.Instance;
                marshaller.Marshall(requestObject.FieldName, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNamedEntity())
            {
                context.Writer.WritePropertyName("NamedEntity");
                context.Writer.WriteStartObject();

                var marshaller = NamedEntityRefMarshaller.Instance;
                marshaller.Marshall(requestObject.NamedEntity, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSort())
            {
                context.Writer.WritePropertyName("Sort");
                context.Writer.WriteStartObject();

                var marshaller = TopicSortClauseMarshaller.Instance;
                marshaller.Marshall(requestObject.Sort, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTimeGranularity())
            {
                context.Writer.WritePropertyName("TimeGranularity");
                context.Writer.WriteStringValue(requestObject.TimeGranularity);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TopicIRGroupByMarshaller Instance = new TopicIRGroupByMarshaller();

    }
}