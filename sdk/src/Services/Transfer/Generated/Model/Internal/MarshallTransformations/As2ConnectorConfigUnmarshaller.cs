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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Transfer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Transfer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for As2ConnectorConfig Object
    /// </summary>  
    public class As2ConnectorConfigUnmarshaller : IUnmarshaller<As2ConnectorConfig, XmlUnmarshallerContext>, IUnmarshaller<As2ConnectorConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        As2ConnectorConfig IUnmarshaller<As2ConnectorConfig, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public As2ConnectorConfig Unmarshall(JsonUnmarshallerContext context)
        {
            As2ConnectorConfig unmarshalledObject = new As2ConnectorConfig();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AsyncMdnConfig", targetDepth))
                {
                    var unmarshaller = As2AsyncMdnConnectorConfigUnmarshaller.Instance;
                    unmarshalledObject.AsyncMdnConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BasicAuthSecretId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BasicAuthSecretId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Compression", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Compression = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EncryptionAlgorithm", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EncryptionAlgorithm = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LocalProfileId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LocalProfileId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MdnResponse", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MdnResponse = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MdnSigningAlgorithm", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MdnSigningAlgorithm = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MessageSubject", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MessageSubject = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PartnerProfileId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PartnerProfileId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreserveContentType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PreserveContentType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SigningAlgorithm", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SigningAlgorithm = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static As2ConnectorConfigUnmarshaller _instance = new As2ConnectorConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static As2ConnectorConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}