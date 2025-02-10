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
 * Do not modify this file. This file is generated from the managedblockchain-query-2023-05-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ManagedBlockchainQuery.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.ManagedBlockchainQuery.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BatchGetTokenBalanceOutputItem Object
    /// </summary>  
    public class BatchGetTokenBalanceOutputItemUnmarshaller : IJsonUnmarshaller<BatchGetTokenBalanceOutputItem, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public BatchGetTokenBalanceOutputItem Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            BatchGetTokenBalanceOutputItem unmarshalledObject = new BatchGetTokenBalanceOutputItem();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("atBlockchainInstant", targetDepth))
                {
                    var unmarshaller = BlockchainInstantUnmarshaller.Instance;
                    unmarshalledObject.AtBlockchainInstant = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("balance", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Balance = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lastUpdatedTime", targetDepth))
                {
                    var unmarshaller = BlockchainInstantUnmarshaller.Instance;
                    unmarshalledObject.LastUpdatedTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ownerIdentifier", targetDepth))
                {
                    var unmarshaller = OwnerIdentifierUnmarshaller.Instance;
                    unmarshalledObject.OwnerIdentifier = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("tokenIdentifier", targetDepth))
                {
                    var unmarshaller = TokenIdentifierUnmarshaller.Instance;
                    unmarshalledObject.TokenIdentifier = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static BatchGetTokenBalanceOutputItemUnmarshaller _instance = new BatchGetTokenBalanceOutputItemUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchGetTokenBalanceOutputItemUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}