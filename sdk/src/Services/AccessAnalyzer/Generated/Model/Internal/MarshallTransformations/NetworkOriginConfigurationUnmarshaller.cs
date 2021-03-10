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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AccessAnalyzer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AccessAnalyzer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for NetworkOriginConfiguration Object
    /// </summary>  
    public class NetworkOriginConfigurationUnmarshaller : IUnmarshaller<NetworkOriginConfiguration, XmlUnmarshallerContext>, IUnmarshaller<NetworkOriginConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        NetworkOriginConfiguration IUnmarshaller<NetworkOriginConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public NetworkOriginConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            NetworkOriginConfiguration unmarshalledObject = new NetworkOriginConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("internetConfiguration", targetDepth))
                {
                    var unmarshaller = InternetConfigurationUnmarshaller.Instance;
                    unmarshalledObject.InternetConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vpcConfiguration", targetDepth))
                {
                    var unmarshaller = VpcConfigurationUnmarshaller.Instance;
                    unmarshalledObject.VpcConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static NetworkOriginConfigurationUnmarshaller _instance = new NetworkOriginConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NetworkOriginConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}