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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataExchange.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.DataExchange.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for S3DataAccessAsset Object
    /// </summary>  
    public class S3DataAccessAssetUnmarshaller : IJsonUnmarshaller<S3DataAccessAsset, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public S3DataAccessAsset Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            S3DataAccessAsset unmarshalledObject = new S3DataAccessAsset();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Bucket", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Bucket = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("KeyPrefixes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.KeyPrefixes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Keys", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Keys = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("KmsKeysToGrant", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<KmsKeyToGrant, KmsKeyToGrantUnmarshaller>(KmsKeyToGrantUnmarshaller.Instance);
                    unmarshalledObject.KmsKeysToGrant = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3AccessPointAlias", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.S3AccessPointAlias = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3AccessPointArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.S3AccessPointArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static S3DataAccessAssetUnmarshaller _instance = new S3DataAccessAssetUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static S3DataAccessAssetUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}