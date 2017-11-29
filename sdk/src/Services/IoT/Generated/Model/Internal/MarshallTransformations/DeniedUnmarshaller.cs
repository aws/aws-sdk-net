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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Denied Object
    /// </summary>  
    public class DeniedUnmarshaller : IUnmarshaller<Denied, XmlUnmarshallerContext>, IUnmarshaller<Denied, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Denied IUnmarshaller<Denied, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Denied Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Denied unmarshalledObject = new Denied();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("explicitDeny", targetDepth))
                {
                    var unmarshaller = ExplicitDenyUnmarshaller.Instance;
                    unmarshalledObject.ExplicitDeny = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("implicitDeny", targetDepth))
                {
                    var unmarshaller = ImplicitDenyUnmarshaller.Instance;
                    unmarshalledObject.ImplicitDeny = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DeniedUnmarshaller _instance = new DeniedUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeniedUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}