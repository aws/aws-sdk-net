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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DirectConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DirectConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Lag Object
    /// </summary>  
    public class LagUnmarshaller : IUnmarshaller<Lag, XmlUnmarshallerContext>, IUnmarshaller<Lag, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Lag IUnmarshaller<Lag, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Lag Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Lag unmarshalledObject = new Lag();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("allowsHostedConnections", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AllowsHostedConnections = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("awsDevice", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AwsDevice = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("awsDeviceV2", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AwsDeviceV2 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connections", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Connection, ConnectionUnmarshaller>(ConnectionUnmarshaller.Instance);
                    unmarshalledObject.Connections = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connectionsBandwidth", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConnectionsBandwidth = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("hasLogicalRedundancy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HasLogicalRedundancy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jumboFrameCapable", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.JumboFrameCapable = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lagId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LagId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lagName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LagName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lagState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LagState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("location", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Location = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("minimumLinks", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MinimumLinks = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("numberOfConnections", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NumberOfConnections = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ownerAccount", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OwnerAccount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("region", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Region = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static LagUnmarshaller _instance = new LagUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LagUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}