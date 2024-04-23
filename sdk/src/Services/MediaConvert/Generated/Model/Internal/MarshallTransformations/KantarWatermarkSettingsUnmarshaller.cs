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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConvert.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for KantarWatermarkSettings Object
    /// </summary>  
    public class KantarWatermarkSettingsUnmarshaller : IUnmarshaller<KantarWatermarkSettings, XmlUnmarshallerContext>, IUnmarshaller<KantarWatermarkSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        KantarWatermarkSettings IUnmarshaller<KantarWatermarkSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public KantarWatermarkSettings Unmarshall(JsonUnmarshallerContext context)
        {
            KantarWatermarkSettings unmarshalledObject = new KantarWatermarkSettings();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("channelName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ChannelName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("contentReference", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ContentReference = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("credentialsSecretName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CredentialsSecretName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fileOffset", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.FileOffset = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("kantarLicenseId", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.KantarLicenseId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("kantarServerUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KantarServerUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("logDestination", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogDestination = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("metadata3", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Metadata3 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("metadata4", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Metadata4 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("metadata5", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Metadata5 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("metadata6", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Metadata6 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("metadata7", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Metadata7 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("metadata8", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Metadata8 = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static KantarWatermarkSettingsUnmarshaller _instance = new KantarWatermarkSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static KantarWatermarkSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618