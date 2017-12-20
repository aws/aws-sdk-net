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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CustomCodeSigning Object
    /// </summary>  
    public class CustomCodeSigningUnmarshaller : IUnmarshaller<CustomCodeSigning, XmlUnmarshallerContext>, IUnmarshaller<CustomCodeSigning, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CustomCodeSigning IUnmarshaller<CustomCodeSigning, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CustomCodeSigning Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            CustomCodeSigning unmarshalledObject = new CustomCodeSigning();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("certificateChain", targetDepth))
                {
                    var unmarshaller = CodeSigningCertificateChainUnmarshaller.Instance;
                    unmarshalledObject.CertificateChain = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("hashAlgorithm", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HashAlgorithm = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("signature", targetDepth))
                {
                    var unmarshaller = CodeSigningSignatureUnmarshaller.Instance;
                    unmarshalledObject.Signature = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("signatureAlgorithm", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SignatureAlgorithm = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static CustomCodeSigningUnmarshaller _instance = new CustomCodeSigningUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CustomCodeSigningUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}