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
    /// Response Unmarshaller for BatchGetTokenBalanceErrorItem Object
    /// </summary>  
    public class BatchGetTokenBalanceErrorItemUnmarshaller : IUnmarshaller<BatchGetTokenBalanceErrorItem, XmlUnmarshallerContext>, IUnmarshaller<BatchGetTokenBalanceErrorItem, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        BatchGetTokenBalanceErrorItem IUnmarshaller<BatchGetTokenBalanceErrorItem, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public BatchGetTokenBalanceErrorItem Unmarshall(JsonUnmarshallerContext context)
        {
            BatchGetTokenBalanceErrorItem unmarshalledObject = new BatchGetTokenBalanceErrorItem();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("atBlockchainInstant", targetDepth))
                {
                    var unmarshaller = BlockchainInstantUnmarshaller.Instance;
                    unmarshalledObject.AtBlockchainInstant = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("errorCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ErrorCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("errorMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ErrorMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("errorType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ErrorType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ownerIdentifier", targetDepth))
                {
                    var unmarshaller = OwnerIdentifierUnmarshaller.Instance;
                    unmarshalledObject.OwnerIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tokenIdentifier", targetDepth))
                {
                    var unmarshaller = TokenIdentifierUnmarshaller.Instance;
                    unmarshalledObject.TokenIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static BatchGetTokenBalanceErrorItemUnmarshaller _instance = new BatchGetTokenBalanceErrorItemUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchGetTokenBalanceErrorItemUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}