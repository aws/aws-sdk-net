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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.LookoutEquipment.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LookoutEquipment.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DataQualitySummary Object
    /// </summary>  
    public class DataQualitySummaryUnmarshaller : IUnmarshaller<DataQualitySummary, XmlUnmarshallerContext>, IUnmarshaller<DataQualitySummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DataQualitySummary IUnmarshaller<DataQualitySummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DataQualitySummary Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DataQualitySummary unmarshalledObject = new DataQualitySummary();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DuplicateTimestamps", targetDepth))
                {
                    var unmarshaller = DuplicateTimestampsUnmarshaller.Instance;
                    unmarshalledObject.DuplicateTimestamps = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InsufficientSensorData", targetDepth))
                {
                    var unmarshaller = InsufficientSensorDataUnmarshaller.Instance;
                    unmarshalledObject.InsufficientSensorData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InvalidSensorData", targetDepth))
                {
                    var unmarshaller = InvalidSensorDataUnmarshaller.Instance;
                    unmarshalledObject.InvalidSensorData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MissingSensorData", targetDepth))
                {
                    var unmarshaller = MissingSensorDataUnmarshaller.Instance;
                    unmarshalledObject.MissingSensorData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UnsupportedTimestamps", targetDepth))
                {
                    var unmarshaller = UnsupportedTimestampsUnmarshaller.Instance;
                    unmarshalledObject.UnsupportedTimestamps = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DataQualitySummaryUnmarshaller _instance = new DataQualitySummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DataQualitySummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}