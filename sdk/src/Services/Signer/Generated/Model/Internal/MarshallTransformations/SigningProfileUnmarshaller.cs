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
 * Do not modify this file. This file is generated from the signer-2017-08-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Signer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Signer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SigningProfile Object
    /// </summary>  
    public class SigningProfileUnmarshaller : IUnmarshaller<SigningProfile, XmlUnmarshallerContext>, IUnmarshaller<SigningProfile, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SigningProfile IUnmarshaller<SigningProfile, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SigningProfile Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SigningProfile unmarshalledObject = new SigningProfile();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("platformDisplayName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PlatformDisplayName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("platformId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PlatformId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("profileName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProfileName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("profileVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProfileVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("profileVersionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProfileVersionArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("signatureValidityPeriod", targetDepth))
                {
                    var unmarshaller = SignatureValidityPeriodUnmarshaller.Instance;
                    unmarshalledObject.SignatureValidityPeriod = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("signingMaterial", targetDepth))
                {
                    var unmarshaller = SigningMaterialUnmarshaller.Instance;
                    unmarshalledObject.SigningMaterial = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("signingParameters", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.SigningParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SigningProfileUnmarshaller _instance = new SigningProfileUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SigningProfileUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}