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
 * Do not modify this file. This file is generated from the payment-cryptography-2021-09-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.PaymentCryptography.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.PaymentCryptography.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for KeyModesOfUse Object
    /// </summary>  
    public class KeyModesOfUseUnmarshaller : IUnmarshaller<KeyModesOfUse, XmlUnmarshallerContext>, IUnmarshaller<KeyModesOfUse, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        KeyModesOfUse IUnmarshaller<KeyModesOfUse, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public KeyModesOfUse Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            KeyModesOfUse unmarshalledObject = new KeyModesOfUse();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Decrypt", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Decrypt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeriveKey", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DeriveKey = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Encrypt", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Encrypt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Generate", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Generate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NoRestrictions", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.NoRestrictions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Sign", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Sign = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Unwrap", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Unwrap = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Verify", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Verify = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Wrap", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Wrap = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static KeyModesOfUseUnmarshaller _instance = new KeyModesOfUseUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static KeyModesOfUseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}