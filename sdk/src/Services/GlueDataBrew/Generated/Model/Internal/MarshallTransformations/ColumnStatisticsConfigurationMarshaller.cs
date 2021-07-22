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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GlueDataBrew.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GlueDataBrew.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ColumnStatisticsConfiguration Marshaller
    /// </summary>       
    public class ColumnStatisticsConfigurationMarshaller : IRequestMarshaller<ColumnStatisticsConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ColumnStatisticsConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetSelectors())
            {
                context.Writer.WritePropertyName("Selectors");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSelectorsListValue in requestObject.Selectors)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ColumnSelectorMarshaller.Instance;
                    marshaller.Marshall(requestObjectSelectorsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStatistics())
            {
                context.Writer.WritePropertyName("Statistics");
                context.Writer.WriteObjectStart();

                var marshaller = StatisticsConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Statistics, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ColumnStatisticsConfigurationMarshaller Instance = new ColumnStatisticsConfigurationMarshaller();

    }
}