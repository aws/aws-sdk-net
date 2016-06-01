/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DeviceFarm.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DeviceFarm.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for OfferingTransaction Object
    /// </summary>  
    public class OfferingTransactionUnmarshaller : IUnmarshaller<OfferingTransaction, XmlUnmarshallerContext>, IUnmarshaller<OfferingTransaction, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        OfferingTransaction IUnmarshaller<OfferingTransaction, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public OfferingTransaction Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            OfferingTransaction unmarshalledObject = new OfferingTransaction();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("cost", targetDepth))
                {
                    var unmarshaller = MonetaryAmountUnmarshaller.Instance;
                    unmarshalledObject.Cost = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createdOn", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedOn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("offeringStatus", targetDepth))
                {
                    var unmarshaller = OfferingStatusUnmarshaller.Instance;
                    unmarshalledObject.OfferingStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("transactionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TransactionId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static OfferingTransactionUnmarshaller _instance = new OfferingTransactionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OfferingTransactionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}