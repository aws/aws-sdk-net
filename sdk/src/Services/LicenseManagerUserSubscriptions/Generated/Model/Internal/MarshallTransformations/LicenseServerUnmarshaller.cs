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
 * Do not modify this file. This file is generated from the license-manager-user-subscriptions-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.LicenseManagerUserSubscriptions.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.LicenseManagerUserSubscriptions.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LicenseServer Object
    /// </summary>  
    public class LicenseServerUnmarshaller : IUnmarshaller<LicenseServer, XmlUnmarshallerContext>, IUnmarshaller<LicenseServer, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        LicenseServer IUnmarshaller<LicenseServer, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public LicenseServer Unmarshall(JsonUnmarshallerContext context)
        {
            LicenseServer unmarshalledObject = new LicenseServer();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("HealthStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HealthStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Ipv4Address", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Ipv4Address = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Ipv6Address", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Ipv6Address = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProvisioningStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProvisioningStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static LicenseServerUnmarshaller _instance = new LicenseServerUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LicenseServerUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}