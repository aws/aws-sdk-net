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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ManagedBlockchainQuery.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TransactionEvent Object
    /// </summary>  
    public class TransactionEventUnmarshaller : IUnmarshaller<TransactionEvent, XmlUnmarshallerContext>, IUnmarshaller<TransactionEvent, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TransactionEvent IUnmarshaller<TransactionEvent, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public TransactionEvent Unmarshall(JsonUnmarshallerContext context)
        {
            TransactionEvent unmarshalledObject = new TransactionEvent();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("blockchainInstant", targetDepth))
                {
                    var unmarshaller = BlockchainInstantUnmarshaller.Instance;
                    unmarshalledObject.BlockchainInstant = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("confirmationStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConfirmationStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("contractAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ContractAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("eventType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EventType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("from", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.From = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("network", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Network = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("spentVoutIndex", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SpentVoutIndex = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("spentVoutTransactionHash", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SpentVoutTransactionHash = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("spentVoutTransactionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SpentVoutTransactionId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("to", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.To = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tokenId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TokenId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("transactionHash", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TransactionHash = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("transactionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TransactionId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("value", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Value = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("voutIndex", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.VoutIndex = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("voutSpent", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.VoutSpent = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TransactionEventUnmarshaller _instance = new TransactionEventUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TransactionEventUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}