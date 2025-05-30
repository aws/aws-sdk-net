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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ProductionVariantSummary Object
    /// </summary>  
    public class ProductionVariantSummaryUnmarshaller : IJsonUnmarshaller<ProductionVariantSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ProductionVariantSummary Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ProductionVariantSummary unmarshalledObject = new ProductionVariantSummary();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("CapacityReservationConfig", targetDepth))
                {
                    var unmarshaller = ProductionVariantCapacityReservationSummaryUnmarshaller.Instance;
                    unmarshalledObject.CapacityReservationConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CurrentInstanceCount", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.CurrentInstanceCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CurrentServerlessConfig", targetDepth))
                {
                    var unmarshaller = ProductionVariantServerlessConfigUnmarshaller.Instance;
                    unmarshalledObject.CurrentServerlessConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CurrentWeight", targetDepth))
                {
                    var unmarshaller = NullableFloatUnmarshaller.Instance;
                    unmarshalledObject.CurrentWeight = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DeployedImages", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<DeployedImage, DeployedImageUnmarshaller>(DeployedImageUnmarshaller.Instance);
                    unmarshalledObject.DeployedImages = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DesiredInstanceCount", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.DesiredInstanceCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DesiredServerlessConfig", targetDepth))
                {
                    var unmarshaller = ProductionVariantServerlessConfigUnmarshaller.Instance;
                    unmarshalledObject.DesiredServerlessConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DesiredWeight", targetDepth))
                {
                    var unmarshaller = NullableFloatUnmarshaller.Instance;
                    unmarshalledObject.DesiredWeight = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ManagedInstanceScaling", targetDepth))
                {
                    var unmarshaller = ProductionVariantManagedInstanceScalingUnmarshaller.Instance;
                    unmarshalledObject.ManagedInstanceScaling = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RoutingConfig", targetDepth))
                {
                    var unmarshaller = ProductionVariantRoutingConfigUnmarshaller.Instance;
                    unmarshalledObject.RoutingConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VariantName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VariantName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VariantStatus", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ProductionVariantStatus, ProductionVariantStatusUnmarshaller>(ProductionVariantStatusUnmarshaller.Instance);
                    unmarshalledObject.VariantStatus = unmarshaller.Unmarshall(context, ref reader);
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