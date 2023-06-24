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
    /// KPIFieldWells Marshaller
    /// </summary>
    public class KPIFieldWellsMarshaller : IRequestMarshaller<KPIFieldWells, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(KPIFieldWells requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetTargetValues())
            {
                context.Writer.WritePropertyName("TargetValues");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTargetValuesListValue in requestObject.TargetValues)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = MeasureFieldMarshaller.Instance;
                    marshaller.Marshall(requestObjectTargetValuesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTrendGroups())
            {
                context.Writer.WritePropertyName("TrendGroups");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTrendGroupsListValue in requestObject.TrendGroups)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DimensionFieldMarshaller.Instance;
                    marshaller.Marshall(requestObjectTrendGroupsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetValues())
            {
                context.Writer.WritePropertyName("Values");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectValuesListValue in requestObject.Values)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = MeasureFieldMarshaller.Instance;
                    marshaller.Marshall(requestObjectValuesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static KPIFieldWellsMarshaller Instance = new KPIFieldWellsMarshaller();

    }
}