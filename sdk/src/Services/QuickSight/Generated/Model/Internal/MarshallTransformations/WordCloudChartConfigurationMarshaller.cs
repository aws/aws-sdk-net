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
    /// WordCloudChartConfiguration Marshaller
    /// </summary>
    public class WordCloudChartConfigurationMarshaller : IRequestMarshaller<WordCloudChartConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(WordCloudChartConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCategoryLabelOptions())
            {
                context.Writer.WritePropertyName("CategoryLabelOptions");
                context.Writer.WriteObjectStart();

                var marshaller = ChartAxisLabelOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.CategoryLabelOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFieldWells())
            {
                context.Writer.WritePropertyName("FieldWells");
                context.Writer.WriteObjectStart();

                var marshaller = WordCloudFieldWellsMarshaller.Instance;
                marshaller.Marshall(requestObject.FieldWells, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSortConfiguration())
            {
                context.Writer.WritePropertyName("SortConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = WordCloudSortConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SortConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetWordCloudOptions())
            {
                context.Writer.WritePropertyName("WordCloudOptions");
                context.Writer.WriteObjectStart();

                var marshaller = WordCloudOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.WordCloudOptions, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static WordCloudChartConfigurationMarshaller Instance = new WordCloudChartConfigurationMarshaller();

    }
}