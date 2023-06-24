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
    /// Response Unmarshaller for CustomParameterValues Object
    /// </summary>  
    public class CustomParameterValuesUnmarshaller : IUnmarshaller<CustomParameterValues, XmlUnmarshallerContext>, IUnmarshaller<CustomParameterValues, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CustomParameterValues IUnmarshaller<CustomParameterValues, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CustomParameterValues Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            CustomParameterValues unmarshalledObject = new CustomParameterValues();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DateTimeValues", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DateTime, DateTimeUnmarshaller>(DateTimeUnmarshaller.Instance);
                    unmarshalledObject.DateTimeValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DecimalValues", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<double, DoubleUnmarshaller>(DoubleUnmarshaller.Instance);
                    unmarshalledObject.DecimalValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IntegerValues", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<long, LongUnmarshaller>(LongUnmarshaller.Instance);
                    unmarshalledObject.IntegerValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StringValues", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.StringValues = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static CustomParameterValuesUnmarshaller _instance = new CustomParameterValuesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CustomParameterValuesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}