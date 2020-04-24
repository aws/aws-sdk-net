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
 * Do not modify this file. This file is generated from the elastic-inference-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticInference.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticInference.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AcceleratorType Object
    /// </summary>  
    public class AcceleratorTypeUnmarshaller : IUnmarshaller<AcceleratorType, XmlUnmarshallerContext>, IUnmarshaller<AcceleratorType, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AcceleratorType IUnmarshaller<AcceleratorType, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AcceleratorType Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AcceleratorType unmarshalledObject = new AcceleratorType();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("acceleratorTypeName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AcceleratorTypeName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("memoryInfo", targetDepth))
                {
                    var unmarshaller = MemoryInfoUnmarshaller.Instance;
                    unmarshalledObject.MemoryInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("throughputInfo", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<KeyValuePair, KeyValuePairUnmarshaller>(KeyValuePairUnmarshaller.Instance);
                    unmarshalledObject.ThroughputInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AcceleratorTypeUnmarshaller _instance = new AcceleratorTypeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AcceleratorTypeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}