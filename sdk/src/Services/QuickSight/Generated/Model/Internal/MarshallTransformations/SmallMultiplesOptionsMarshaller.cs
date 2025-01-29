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
    /// SmallMultiplesOptions Marshaller
    /// </summary>
    public class SmallMultiplesOptionsMarshaller : IRequestMarshaller<SmallMultiplesOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SmallMultiplesOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetMaxVisibleColumns())
            {
                context.Writer.WritePropertyName("MaxVisibleColumns");
                context.Writer.WriteNumberValue(requestObject.MaxVisibleColumns.Value);
            }

            if(requestObject.IsSetMaxVisibleRows())
            {
                context.Writer.WritePropertyName("MaxVisibleRows");
                context.Writer.WriteNumberValue(requestObject.MaxVisibleRows.Value);
            }

            if(requestObject.IsSetPanelConfiguration())
            {
                context.Writer.WritePropertyName("PanelConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = PanelConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.PanelConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetXAxis())
            {
                context.Writer.WritePropertyName("XAxis");
                context.Writer.WriteStartObject();

                var marshaller = SmallMultiplesAxisPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.XAxis, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetYAxis())
            {
                context.Writer.WritePropertyName("YAxis");
                context.Writer.WriteStartObject();

                var marshaller = SmallMultiplesAxisPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.YAxis, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SmallMultiplesOptionsMarshaller Instance = new SmallMultiplesOptionsMarshaller();

    }
}