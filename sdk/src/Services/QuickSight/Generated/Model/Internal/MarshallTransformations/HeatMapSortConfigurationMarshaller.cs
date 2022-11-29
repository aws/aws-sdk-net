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
using ThirdParty.Json.LitJson;

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HeatMapSortConfiguration Marshaller
    /// </summary>
    public class HeatMapSortConfigurationMarshaller : IRequestMarshaller<HeatMapSortConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HeatMapSortConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetHeatMapColumnItemsLimitConfiguration())
            {
                context.Writer.WritePropertyName("HeatMapColumnItemsLimitConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = ItemsLimitConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.HeatMapColumnItemsLimitConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHeatMapColumnSort())
            {
                context.Writer.WritePropertyName("HeatMapColumnSort");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectHeatMapColumnSortListValue in requestObject.HeatMapColumnSort)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = FieldSortOptionsMarshaller.Instance;
                    marshaller.Marshall(requestObjectHeatMapColumnSortListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetHeatMapRowItemsLimitConfiguration())
            {
                context.Writer.WritePropertyName("HeatMapRowItemsLimitConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = ItemsLimitConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.HeatMapRowItemsLimitConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHeatMapRowSort())
            {
                context.Writer.WritePropertyName("HeatMapRowSort");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectHeatMapRowSortListValue in requestObject.HeatMapRowSort)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = FieldSortOptionsMarshaller.Instance;
                    marshaller.Marshall(requestObjectHeatMapRowSortListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HeatMapSortConfigurationMarshaller Instance = new HeatMapSortConfigurationMarshaller();

    }
}