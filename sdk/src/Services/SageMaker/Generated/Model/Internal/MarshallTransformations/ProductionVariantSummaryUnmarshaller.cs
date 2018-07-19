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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ProductionVariantSummary Object
    /// </summary>  
    public class ProductionVariantSummaryUnmarshaller : IUnmarshaller<ProductionVariantSummary, XmlUnmarshallerContext>, IUnmarshaller<ProductionVariantSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ProductionVariantSummary IUnmarshaller<ProductionVariantSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ProductionVariantSummary Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ProductionVariantSummary unmarshalledObject = new ProductionVariantSummary();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CurrentInstanceCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.CurrentInstanceCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CurrentWeight", targetDepth))
                {
                    var unmarshaller = FloatUnmarshaller.Instance;
                    unmarshalledObject.CurrentWeight = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeployedImages", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DeployedImage, DeployedImageUnmarshaller>(DeployedImageUnmarshaller.Instance);
                    unmarshalledObject.DeployedImages = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DesiredInstanceCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DesiredInstanceCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DesiredWeight", targetDepth))
                {
                    var unmarshaller = FloatUnmarshaller.Instance;
                    unmarshalledObject.DesiredWeight = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VariantName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VariantName = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ProductionVariantSummaryUnmarshaller _instance = new ProductionVariantSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ProductionVariantSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}