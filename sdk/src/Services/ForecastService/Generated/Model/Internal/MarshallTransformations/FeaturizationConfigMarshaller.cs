/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ForecastService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ForecastService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FeaturizationConfig Marshaller
    /// </summary>       
    public class FeaturizationConfigMarshaller : IRequestMarshaller<FeaturizationConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FeaturizationConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetFeaturizations())
            {
                context.Writer.WritePropertyName("Featurizations");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFeaturizationsListValue in requestObject.Featurizations)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = FeaturizationMarshaller.Instance;
                    marshaller.Marshall(requestObjectFeaturizationsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetForecastDimensions())
            {
                context.Writer.WritePropertyName("ForecastDimensions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectForecastDimensionsListValue in requestObject.ForecastDimensions)
                {
                        context.Writer.Write(requestObjectForecastDimensionsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetForecastFrequency())
            {
                context.Writer.WritePropertyName("ForecastFrequency");
                context.Writer.Write(requestObject.ForecastFrequency);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static FeaturizationConfigMarshaller Instance = new FeaturizationConfigMarshaller();

    }
}