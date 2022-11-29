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
using System.Net;
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
    /// Response Unmarshaller for TimeRangeFilterValue Object
    /// </summary>  
    public class TimeRangeFilterValueUnmarshaller : IUnmarshaller<TimeRangeFilterValue, XmlUnmarshallerContext>, IUnmarshaller<TimeRangeFilterValue, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TimeRangeFilterValue IUnmarshaller<TimeRangeFilterValue, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public TimeRangeFilterValue Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            TimeRangeFilterValue unmarshalledObject = new TimeRangeFilterValue();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Parameter", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Parameter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RollingDate", targetDepth))
                {
                    var unmarshaller = RollingDateConfigurationUnmarshaller.Instance;
                    unmarshalledObject.RollingDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StaticValue", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StaticValue = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static TimeRangeFilterValueUnmarshaller _instance = new TimeRangeFilterValueUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TimeRangeFilterValueUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}