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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.PartnerCentralSelling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.PartnerCentralSelling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsProductDetails Object
    /// </summary>  
    public class AwsProductDetailsUnmarshaller : IUnmarshaller<AwsProductDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsProductDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsProductDetails IUnmarshaller<AwsProductDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AwsProductDetails Unmarshall(JsonUnmarshallerContext context)
        {
            AwsProductDetails unmarshalledObject = new AwsProductDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Amount", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Amount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Categories", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Categories = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Optimizations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsProductOptimization, AwsProductOptimizationUnmarshaller>(AwsProductOptimizationUnmarshaller.Instance);
                    unmarshalledObject.Optimizations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OptimizedAmount", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OptimizedAmount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PotentialSavingsAmount", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PotentialSavingsAmount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProductCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProductCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceCode = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AwsProductDetailsUnmarshaller _instance = new AwsProductDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsProductDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}