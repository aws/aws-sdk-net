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
    /// Response Unmarshaller for DiscountsBreakdown Object
    /// </summary>  
    public class DiscountsBreakdownUnmarshaller : IUnmarshaller<DiscountsBreakdown, XmlUnmarshallerContext>, IUnmarshaller<DiscountsBreakdown, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DiscountsBreakdown IUnmarshaller<DiscountsBreakdown, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public DiscountsBreakdown Unmarshall(JsonUnmarshallerContext context)
        {
            DiscountsBreakdown unmarshalledObject = new DiscountsBreakdown();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Breakdown", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DiscountsBreakdownAmount, DiscountsBreakdownAmountUnmarshaller>(DiscountsBreakdownAmountUnmarshaller.Instance);
                    unmarshalledObject.Breakdown = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TotalAmount", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TotalAmount = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DiscountsBreakdownUnmarshaller _instance = new DiscountsBreakdownUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DiscountsBreakdownUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}