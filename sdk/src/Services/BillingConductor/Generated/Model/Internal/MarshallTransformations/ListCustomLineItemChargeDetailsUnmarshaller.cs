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
 * Do not modify this file. This file is generated from the billingconductor-2021-07-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.BillingConductor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.BillingConductor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ListCustomLineItemChargeDetails Object
    /// </summary>  
    public class ListCustomLineItemChargeDetailsUnmarshaller : IUnmarshaller<ListCustomLineItemChargeDetails, XmlUnmarshallerContext>, IUnmarshaller<ListCustomLineItemChargeDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ListCustomLineItemChargeDetails IUnmarshaller<ListCustomLineItemChargeDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ListCustomLineItemChargeDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ListCustomLineItemChargeDetails unmarshalledObject = new ListCustomLineItemChargeDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Flat", targetDepth))
                {
                    var unmarshaller = ListCustomLineItemFlatChargeDetailsUnmarshaller.Instance;
                    unmarshalledObject.Flat = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Percentage", targetDepth))
                {
                    var unmarshaller = ListCustomLineItemPercentageChargeDetailsUnmarshaller.Instance;
                    unmarshalledObject.Percentage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ListCustomLineItemChargeDetailsUnmarshaller _instance = new ListCustomLineItemChargeDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListCustomLineItemChargeDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}