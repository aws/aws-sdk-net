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
 * Do not modify this file. This file is generated from the budgets-2016-10-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Budgets.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Budgets.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CostTypes Object
    /// </summary>  
    public class CostTypesUnmarshaller : IUnmarshaller<CostTypes, XmlUnmarshallerContext>, IUnmarshaller<CostTypes, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CostTypes IUnmarshaller<CostTypes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CostTypes Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            CostTypes unmarshalledObject = new CostTypes();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("IncludeCredit", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IncludeCredit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IncludeDiscount", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IncludeDiscount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IncludeOtherSubscription", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IncludeOtherSubscription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IncludeRecurring", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IncludeRecurring = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IncludeRefund", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IncludeRefund = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IncludeSubscription", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IncludeSubscription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IncludeSupport", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IncludeSupport = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IncludeTax", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IncludeTax = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IncludeUpfront", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IncludeUpfront = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseAmortized", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.UseAmortized = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseBlended", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.UseBlended = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static CostTypesUnmarshaller _instance = new CostTypesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CostTypesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}