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
    /// Response Unmarshaller for TokenBalance Object
    /// </summary>  
    public class TokenBalanceUnmarshaller : IUnmarshaller<TokenBalance, XmlUnmarshallerContext>, IUnmarshaller<TokenBalance, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TokenBalance IUnmarshaller<TokenBalance, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public TokenBalance Unmarshall(JsonUnmarshallerContext context)
        {
            TokenBalance unmarshalledObject = new TokenBalance();
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
                if (context.TestExpression("balance", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Balance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastUpdatedTime", targetDepth))
                {
                    var unmarshaller = BlockchainInstantUnmarshaller.Instance;
                    unmarshalledObject.LastUpdatedTime = unmarshaller.Unmarshall(context);
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


        private static TokenBalanceUnmarshaller _instance = new TokenBalanceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TokenBalanceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}