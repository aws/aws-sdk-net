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
    /// LegendOptions Marshaller
    /// </summary>
    public class LegendOptionsMarshaller : IRequestMarshaller<LegendOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LegendOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetHeight())
            {
                context.Writer.WritePropertyName("Height");
                context.Writer.WriteStringValue(requestObject.Height);
            }

            if(requestObject.IsSetPosition())
            {
                context.Writer.WritePropertyName("Position");
                context.Writer.WriteStringValue(requestObject.Position);
            }

            if(requestObject.IsSetTitle())
            {
                context.Writer.WritePropertyName("Title");
                context.Writer.WriteStartObject();

                var marshaller = LabelOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Title, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetValueFontConfiguration())
            {
                context.Writer.WritePropertyName("ValueFontConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = FontConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ValueFontConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVisibility())
            {
                context.Writer.WritePropertyName("Visibility");
                context.Writer.WriteStringValue(requestObject.Visibility);
            }

            if(requestObject.IsSetWidth())
            {
                context.Writer.WritePropertyName("Width");
                context.Writer.WriteStringValue(requestObject.Width);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LegendOptionsMarshaller Instance = new LegendOptionsMarshaller();

    }
}