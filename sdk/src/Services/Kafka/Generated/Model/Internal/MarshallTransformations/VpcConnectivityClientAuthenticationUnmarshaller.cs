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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kafka.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Kafka.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for VpcConnectivityClientAuthentication Object
    /// </summary>  
    public class VpcConnectivityClientAuthenticationUnmarshaller : IUnmarshaller<VpcConnectivityClientAuthentication, XmlUnmarshallerContext>, IUnmarshaller<VpcConnectivityClientAuthentication, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        VpcConnectivityClientAuthentication IUnmarshaller<VpcConnectivityClientAuthentication, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public VpcConnectivityClientAuthentication Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            VpcConnectivityClientAuthentication unmarshalledObject = new VpcConnectivityClientAuthentication();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("sasl", targetDepth))
                {
                    var unmarshaller = VpcConnectivitySaslUnmarshaller.Instance;
                    unmarshalledObject.Sasl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tls", targetDepth))
                {
                    var unmarshaller = VpcConnectivityTlsUnmarshaller.Instance;
                    unmarshalledObject.Tls = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static VpcConnectivityClientAuthenticationUnmarshaller _instance = new VpcConnectivityClientAuthenticationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VpcConnectivityClientAuthenticationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}