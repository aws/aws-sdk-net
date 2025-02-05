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
    /// Response Unmarshaller for Transaction Object
    /// </summary>  
    public class TransactionUnmarshaller : IJsonUnmarshaller<Transaction, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Transaction Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Transaction unmarshalledObject = new Transaction();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("blockHash", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BlockHash = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("blockNumber", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BlockNumber = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("confirmationStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConfirmationStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("contractAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ContractAddress = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("cumulativeGasUsed", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CumulativeGasUsed = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("effectiveGasPrice", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EffectiveGasPrice = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("executionStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExecutionStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("from", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.From = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("gasUsed", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GasUsed = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("network", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Network = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("numberOfTransactions", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.NumberOfTransactions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("signatureR", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SignatureR = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("signatureS", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SignatureS = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("signatureV", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.SignatureV = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("to", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.To = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("transactionFee", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TransactionFee = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("transactionHash", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TransactionHash = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("transactionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TransactionId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("transactionIndex", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.TransactionIndex = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("transactionTimestamp", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.TransactionTimestamp = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TransactionUnmarshaller _instance = new TransactionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TransactionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}