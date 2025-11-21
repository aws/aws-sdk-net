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
 * Do not modify this file. This file is generated from the bcm-dashboards-2025-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BCMDashboards.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.BCMDashboards.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Widget Marshaller
    /// </summary>
    public class WidgetMarshaller : IRequestMarshaller<Widget, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Widget requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConfigs())
            {
                context.Writer.WritePropertyName("configs");
                context.Writer.WriteStartArray();
                foreach(var requestObjectConfigsListValue in requestObject.Configs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = WidgetConfigMarshaller.Instance;
                    marshaller.Marshall(requestObjectConfigsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetHeight())
            {
                context.Writer.WritePropertyName("height");
                context.Writer.WriteNumberValue(requestObject.Height.Value);
            }

            if(requestObject.IsSetHorizontalOffset())
            {
                context.Writer.WritePropertyName("horizontalOffset");
                context.Writer.WriteNumberValue(requestObject.HorizontalOffset.Value);
            }

            if(requestObject.IsSetTitle())
            {
                context.Writer.WritePropertyName("title");
                context.Writer.WriteStringValue(requestObject.Title);
            }

            if(requestObject.IsSetWidth())
            {
                context.Writer.WritePropertyName("width");
                context.Writer.WriteNumberValue(requestObject.Width.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static WidgetMarshaller Instance = new WidgetMarshaller();

    }
}