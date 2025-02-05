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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Signer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SigningPlatform Object
    /// </summary>  
    public class SigningPlatformUnmarshaller : IJsonUnmarshaller<SigningPlatform, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public SigningPlatform Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            SigningPlatform unmarshalledObject = new SigningPlatform();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("category", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Category = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("displayName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DisplayName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("maxSizeInMB", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.MaxSizeInMB = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("partner", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Partner = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("platformId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PlatformId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("revocationSupported", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.RevocationSupported = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("signingConfiguration", targetDepth))
                {
                    var unmarshaller = SigningConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SigningConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("signingImageFormat", targetDepth))
                {
                    var unmarshaller = SigningImageFormatUnmarshaller.Instance;
                    unmarshalledObject.SigningImageFormat = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("target", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Target = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SigningPlatformUnmarshaller _instance = new SigningPlatformUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SigningPlatformUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}