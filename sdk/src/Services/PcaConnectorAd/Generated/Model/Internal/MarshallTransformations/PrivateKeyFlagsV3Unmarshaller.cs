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
 * Do not modify this file. This file is generated from the pca-connector-ad-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.PcaConnectorAd.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.PcaConnectorAd.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PrivateKeyFlagsV3 Object
    /// </summary>  
    public class PrivateKeyFlagsV3Unmarshaller : IUnmarshaller<PrivateKeyFlagsV3, XmlUnmarshallerContext>, IUnmarshaller<PrivateKeyFlagsV3, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PrivateKeyFlagsV3 IUnmarshaller<PrivateKeyFlagsV3, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PrivateKeyFlagsV3 Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            PrivateKeyFlagsV3 unmarshalledObject = new PrivateKeyFlagsV3();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ClientVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClientVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExportableKey", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ExportableKey = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RequireAlternateSignatureAlgorithm", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.RequireAlternateSignatureAlgorithm = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StrongKeyProtectionRequired", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.StrongKeyProtectionRequired = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static PrivateKeyFlagsV3Unmarshaller _instance = new PrivateKeyFlagsV3Unmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PrivateKeyFlagsV3Unmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}