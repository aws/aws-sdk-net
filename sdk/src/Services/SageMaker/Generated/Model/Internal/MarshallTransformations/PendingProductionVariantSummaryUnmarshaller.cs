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
    /// Response Unmarshaller for PendingProductionVariantSummary Object
    /// </summary>  
    public class PendingProductionVariantSummaryUnmarshaller : IUnmarshaller<PendingProductionVariantSummary, XmlUnmarshallerContext>, IUnmarshaller<PendingProductionVariantSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PendingProductionVariantSummary IUnmarshaller<PendingProductionVariantSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PendingProductionVariantSummary Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            PendingProductionVariantSummary unmarshalledObject = new PendingProductionVariantSummary();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AcceleratorType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AcceleratorType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CurrentInstanceCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.CurrentInstanceCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CurrentServerlessConfig", targetDepth))
                {
                    var unmarshaller = ProductionVariantServerlessConfigUnmarshaller.Instance;
                    unmarshalledObject.CurrentServerlessConfig = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("DesiredServerlessConfig", targetDepth))
                {
                    var unmarshaller = ProductionVariantServerlessConfigUnmarshaller.Instance;
                    unmarshalledObject.DesiredServerlessConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DesiredWeight", targetDepth))
                {
                    var unmarshaller = FloatUnmarshaller.Instance;
                    unmarshalledObject.DesiredWeight = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VariantName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VariantName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VariantStatus", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ProductionVariantStatus, ProductionVariantStatusUnmarshaller>(ProductionVariantStatusUnmarshaller.Instance);
                    unmarshalledObject.VariantStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static PendingProductionVariantSummaryUnmarshaller _instance = new PendingProductionVariantSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PendingProductionVariantSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}