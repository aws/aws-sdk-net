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
 * Do not modify this file. This file is generated from the forecastquery-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ForecastQueryService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ForecastQueryService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Forecast Object
    /// </summary>  
    public class ForecastUnmarshaller : IUnmarshaller<Forecast, XmlUnmarshallerContext>, IUnmarshaller<Forecast, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Forecast IUnmarshaller<Forecast, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Forecast Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Forecast unmarshalledObject = new Forecast();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Predictions", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, List<DataPoint>, StringUnmarshaller, ListUnmarshaller<DataPoint, DataPointUnmarshaller>>(StringUnmarshaller.Instance, new ListUnmarshaller<DataPoint, DataPointUnmarshaller>(DataPointUnmarshaller.Instance));
                    unmarshalledObject.Predictions = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ForecastUnmarshaller _instance = new ForecastUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ForecastUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}