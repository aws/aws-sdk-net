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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DeviceFarm.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DeviceFarm.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Counters Object
    /// </summary>  
    public class CountersUnmarshaller : IUnmarshaller<Counters, XmlUnmarshallerContext>, IUnmarshaller<Counters, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Counters IUnmarshaller<Counters, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Counters Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Counters unmarshalledObject = new Counters();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("errored", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Errored = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("failed", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Failed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("passed", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Passed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("skipped", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Skipped = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("stopped", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Stopped = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("total", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Total = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("warned", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Warned = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static CountersUnmarshaller _instance = new CountersUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CountersUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}