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
    /// DataLabelOptions Marshaller
    /// </summary>
    public class DataLabelOptionsMarshaller : IRequestMarshaller<DataLabelOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DataLabelOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCategoryLabelVisibility())
            {
                context.Writer.WritePropertyName("CategoryLabelVisibility");
                context.Writer.Write(requestObject.CategoryLabelVisibility);
            }

            if(requestObject.IsSetDataLabelTypes())
            {
                context.Writer.WritePropertyName("DataLabelTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDataLabelTypesListValue in requestObject.DataLabelTypes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DataLabelTypeMarshaller.Instance;
                    marshaller.Marshall(requestObjectDataLabelTypesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLabelColor())
            {
                context.Writer.WritePropertyName("LabelColor");
                context.Writer.Write(requestObject.LabelColor);
            }

            if(requestObject.IsSetLabelContent())
            {
                context.Writer.WritePropertyName("LabelContent");
                context.Writer.Write(requestObject.LabelContent);
            }

            if(requestObject.IsSetLabelFontConfiguration())
            {
                context.Writer.WritePropertyName("LabelFontConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = FontConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.LabelFontConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMeasureLabelVisibility())
            {
                context.Writer.WritePropertyName("MeasureLabelVisibility");
                context.Writer.Write(requestObject.MeasureLabelVisibility);
            }

            if(requestObject.IsSetOverlap())
            {
                context.Writer.WritePropertyName("Overlap");
                context.Writer.Write(requestObject.Overlap);
            }

            if(requestObject.IsSetPosition())
            {
                context.Writer.WritePropertyName("Position");
                context.Writer.Write(requestObject.Position);
            }

            if(requestObject.IsSetVisibility())
            {
                context.Writer.WritePropertyName("Visibility");
                context.Writer.Write(requestObject.Visibility);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DataLabelOptionsMarshaller Instance = new DataLabelOptionsMarshaller();

    }
}