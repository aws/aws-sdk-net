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
 * Do not modify this file. This file is generated from the rds-data-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDSDataService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.RDSDataService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ArrayValue Object
    /// </summary>  
    public class ArrayValueUnmarshaller : IUnmarshaller<ArrayValue, XmlUnmarshallerContext>, IUnmarshaller<ArrayValue, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ArrayValue IUnmarshaller<ArrayValue, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ArrayValue Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ArrayValue unmarshalledObject = new ArrayValue();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("arrayValues", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ArrayValue, ArrayValueUnmarshaller>(ArrayValueUnmarshaller.Instance);
                    unmarshalledObject.ArrayValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("booleanValues", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<bool, BoolUnmarshaller>(BoolUnmarshaller.Instance);
                    unmarshalledObject.BooleanValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("doubleValues", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<double, DoubleUnmarshaller>(DoubleUnmarshaller.Instance);
                    unmarshalledObject.DoubleValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("longValues", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<long, LongUnmarshaller>(LongUnmarshaller.Instance);
                    unmarshalledObject.LongValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("stringValues", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.StringValues = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ArrayValueUnmarshaller _instance = new ArrayValueUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ArrayValueUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}