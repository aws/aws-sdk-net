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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ACMPCA.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ACMPCA.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for KeyUsage Object
    /// </summary>  
    public class KeyUsageUnmarshaller : IUnmarshaller<KeyUsage, XmlUnmarshallerContext>, IUnmarshaller<KeyUsage, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        KeyUsage IUnmarshaller<KeyUsage, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public KeyUsage Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            KeyUsage unmarshalledObject = new KeyUsage();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CRLSign", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CRLSign = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataEncipherment", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DataEncipherment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DecipherOnly", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DecipherOnly = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DigitalSignature", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DigitalSignature = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EncipherOnly", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EncipherOnly = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KeyAgreement", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.KeyAgreement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KeyCertSign", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.KeyCertSign = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KeyEncipherment", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.KeyEncipherment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NonRepudiation", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.NonRepudiation = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static KeyUsageUnmarshaller _instance = new KeyUsageUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static KeyUsageUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}