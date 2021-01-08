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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppMesh.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AppMesh.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for VirtualNodeSpec Object
    /// </summary>  
    public class VirtualNodeSpecUnmarshaller : IUnmarshaller<VirtualNodeSpec, XmlUnmarshallerContext>, IUnmarshaller<VirtualNodeSpec, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        VirtualNodeSpec IUnmarshaller<VirtualNodeSpec, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public VirtualNodeSpec Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            VirtualNodeSpec unmarshalledObject = new VirtualNodeSpec();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("backendDefaults", targetDepth))
                {
                    var unmarshaller = BackendDefaultsUnmarshaller.Instance;
                    unmarshalledObject.BackendDefaults = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("backends", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Backend, BackendUnmarshaller>(BackendUnmarshaller.Instance);
                    unmarshalledObject.Backends = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("listeners", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Listener, ListenerUnmarshaller>(ListenerUnmarshaller.Instance);
                    unmarshalledObject.Listeners = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("logging", targetDepth))
                {
                    var unmarshaller = LoggingUnmarshaller.Instance;
                    unmarshalledObject.Logging = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("serviceDiscovery", targetDepth))
                {
                    var unmarshaller = ServiceDiscoveryUnmarshaller.Instance;
                    unmarshalledObject.ServiceDiscovery = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static VirtualNodeSpecUnmarshaller _instance = new VirtualNodeSpecUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VirtualNodeSpecUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}