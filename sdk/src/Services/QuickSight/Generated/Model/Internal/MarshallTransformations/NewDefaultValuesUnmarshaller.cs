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
    /// Response Unmarshaller for NewDefaultValues Object
    /// </summary>  
    public class NewDefaultValuesUnmarshaller : IUnmarshaller<NewDefaultValues, XmlUnmarshallerContext>, IUnmarshaller<NewDefaultValues, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        NewDefaultValues IUnmarshaller<NewDefaultValues, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public NewDefaultValues Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            NewDefaultValues unmarshalledObject = new NewDefaultValues();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DateTimeStaticValues", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DateTime, DateTimeUnmarshaller>(DateTimeUnmarshaller.Instance);
                    unmarshalledObject.DateTimeStaticValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DecimalStaticValues", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<double, DoubleUnmarshaller>(DoubleUnmarshaller.Instance);
                    unmarshalledObject.DecimalStaticValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IntegerStaticValues", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<long, LongUnmarshaller>(LongUnmarshaller.Instance);
                    unmarshalledObject.IntegerStaticValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StringStaticValues", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.StringStaticValues = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static NewDefaultValuesUnmarshaller _instance = new NewDefaultValuesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NewDefaultValuesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}