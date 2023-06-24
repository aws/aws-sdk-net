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
    /// Response Unmarshaller for ListResourcesAssociatedToCustomLineItemResponseElement Object
    /// </summary>  
    public class ListResourcesAssociatedToCustomLineItemResponseElementUnmarshaller : IUnmarshaller<ListResourcesAssociatedToCustomLineItemResponseElement, XmlUnmarshallerContext>, IUnmarshaller<ListResourcesAssociatedToCustomLineItemResponseElement, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ListResourcesAssociatedToCustomLineItemResponseElement IUnmarshaller<ListResourcesAssociatedToCustomLineItemResponseElement, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ListResourcesAssociatedToCustomLineItemResponseElement Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ListResourcesAssociatedToCustomLineItemResponseElement unmarshalledObject = new ListResourcesAssociatedToCustomLineItemResponseElement();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EndBillingPeriod", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EndBillingPeriod = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Relationship", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Relationship = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ListResourcesAssociatedToCustomLineItemResponseElementUnmarshaller _instance = new ListResourcesAssociatedToCustomLineItemResponseElementUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListResourcesAssociatedToCustomLineItemResponseElementUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}