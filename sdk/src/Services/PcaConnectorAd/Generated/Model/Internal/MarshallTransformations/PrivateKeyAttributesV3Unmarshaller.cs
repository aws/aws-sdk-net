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

#pragma warning disable CS0612,CS0618
namespace Amazon.PcaConnectorAd.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PrivateKeyAttributesV3 Object
    /// </summary>  
    public class PrivateKeyAttributesV3Unmarshaller : IUnmarshaller<PrivateKeyAttributesV3, XmlUnmarshallerContext>, IUnmarshaller<PrivateKeyAttributesV3, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PrivateKeyAttributesV3 IUnmarshaller<PrivateKeyAttributesV3, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public PrivateKeyAttributesV3 Unmarshall(JsonUnmarshallerContext context)
        {
            PrivateKeyAttributesV3 unmarshalledObject = new PrivateKeyAttributesV3();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Algorithm", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Algorithm = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CryptoProviders", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.CryptoProviders = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KeySpec", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KeySpec = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KeyUsageProperty", targetDepth))
                {
                    var unmarshaller = KeyUsagePropertyUnmarshaller.Instance;
                    unmarshalledObject.KeyUsageProperty = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MinimalKeyLength", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MinimalKeyLength = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static PrivateKeyAttributesV3Unmarshaller _instance = new PrivateKeyAttributesV3Unmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PrivateKeyAttributesV3Unmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618