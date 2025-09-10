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

#pragma warning disable CS0612,CS0618
namespace Amazon.PaymentCryptography.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Key Object
    /// </summary>  
    public class KeyUnmarshaller : IUnmarshaller<Key, XmlUnmarshallerContext>, IUnmarshaller<Key, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Key IUnmarshaller<Key, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Key Unmarshall(JsonUnmarshallerContext context)
        {
            Key unmarshalledObject = new Key();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CreateTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreateTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeletePendingTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.DeletePendingTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeleteTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.DeleteTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeriveKeyUsage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeriveKeyUsage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Enabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Enabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Exportable", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Exportable = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KeyArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KeyArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KeyAttributes", targetDepth))
                {
                    var unmarshaller = KeyAttributesUnmarshaller.Instance;
                    unmarshalledObject.KeyAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KeyCheckValue", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KeyCheckValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KeyCheckValueAlgorithm", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KeyCheckValueAlgorithm = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KeyOrigin", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KeyOrigin = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KeyState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.KeyState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MultiRegionKeyType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MultiRegionKeyType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PrimaryRegion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PrimaryRegion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReplicationStatus", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, ReplicationStatusType, StringUnmarshaller, ReplicationStatusTypeUnmarshaller>(StringUnmarshaller.Instance, ReplicationStatusTypeUnmarshaller.Instance);
                    unmarshalledObject.ReplicationStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UsageStartTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.UsageStartTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UsageStopTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.UsageStopTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UsingDefaultReplicationRegions", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.UsingDefaultReplicationRegions = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static KeyUnmarshaller _instance = new KeyUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static KeyUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}