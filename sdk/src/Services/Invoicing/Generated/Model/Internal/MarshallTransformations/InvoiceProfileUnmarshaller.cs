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
 * Do not modify this file. This file is generated from the invoicing-2024-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Invoicing.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Invoicing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InvoiceProfile Object
    /// </summary>  
    public class InvoiceProfileUnmarshaller : IUnmarshaller<InvoiceProfile, XmlUnmarshallerContext>, IUnmarshaller<InvoiceProfile, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        InvoiceProfile IUnmarshaller<InvoiceProfile, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public InvoiceProfile Unmarshall(JsonUnmarshallerContext context)
        {
            InvoiceProfile unmarshalledObject = new InvoiceProfile();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AccountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccountId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Issuer", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Issuer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReceiverAddress", targetDepth))
                {
                    var unmarshaller = ReceiverAddressUnmarshaller.Instance;
                    unmarshalledObject.ReceiverAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReceiverEmail", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReceiverEmail = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReceiverName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReceiverName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TaxRegistrationNumber", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TaxRegistrationNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static InvoiceProfileUnmarshaller _instance = new InvoiceProfileUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InvoiceProfileUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}