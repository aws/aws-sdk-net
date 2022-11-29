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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.KeyManagementService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.KeyManagementService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for KeyMetadata Object
    /// </summary>  
    public class KeyMetadataUnmarshaller : IUnmarshaller<KeyMetadata, XmlUnmarshallerContext>, IUnmarshaller<KeyMetadata, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        KeyMetadata IUnmarshaller<KeyMetadata, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public KeyMetadata Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            KeyMetadata unmarshalledObject = new KeyMetadata();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AWSAccountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AWSAccountId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CloudHsmClusterId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CloudHsmClusterId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomerMasterKeySpec", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CustomerMasterKeySpec = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomKeyStoreId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CustomKeyStoreId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeletionDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.DeletionDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Enabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Enabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EncryptionAlgorithms", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.EncryptionAlgorithms = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExpirationModel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExpirationModel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KeyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KeyId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KeyManager", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KeyManager = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KeySpec", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KeySpec = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KeyState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KeyState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KeyUsage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KeyUsage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MacAlgorithms", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.MacAlgorithms = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MultiRegion", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.MultiRegion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MultiRegionConfiguration", targetDepth))
                {
                    var unmarshaller = MultiRegionConfigurationUnmarshaller.Instance;
                    unmarshalledObject.MultiRegionConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Origin", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Origin = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PendingDeletionWindowInDays", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.PendingDeletionWindowInDays = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SigningAlgorithms", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SigningAlgorithms = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ValidTo", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ValidTo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("XksKeyConfiguration", targetDepth))
                {
                    var unmarshaller = XksKeyConfigurationTypeUnmarshaller.Instance;
                    unmarshalledObject.XksKeyConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static KeyMetadataUnmarshaller _instance = new KeyMetadataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static KeyMetadataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}