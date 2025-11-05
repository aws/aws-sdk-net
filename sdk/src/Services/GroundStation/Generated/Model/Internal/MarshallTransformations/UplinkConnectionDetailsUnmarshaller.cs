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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GroundStation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.GroundStation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for UplinkConnectionDetails Object
    /// </summary>  
    public class UplinkConnectionDetailsUnmarshaller : IUnmarshaller<UplinkConnectionDetails, XmlUnmarshallerContext>, IUnmarshaller<UplinkConnectionDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        UplinkConnectionDetails IUnmarshaller<UplinkConnectionDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public UplinkConnectionDetails Unmarshall(JsonUnmarshallerContext context)
        {
            UplinkConnectionDetails unmarshalledObject = new UplinkConnectionDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("agentIpAndPortAddress", targetDepth))
                {
                    var unmarshaller = RangedConnectionDetailsUnmarshaller.Instance;
                    unmarshalledObject.AgentIpAndPortAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ingressAddressAndPort", targetDepth))
                {
                    var unmarshaller = ConnectionDetailsUnmarshaller.Instance;
                    unmarshalledObject.IngressAddressAndPort = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static UplinkConnectionDetailsUnmarshaller _instance = new UplinkConnectionDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UplinkConnectionDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}