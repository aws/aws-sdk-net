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
    /// Response Unmarshaller for ProductionVariant Object
    /// </summary>  
    public class ProductionVariantUnmarshaller : IUnmarshaller<ProductionVariant, XmlUnmarshallerContext>, IUnmarshaller<ProductionVariant, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ProductionVariant IUnmarshaller<ProductionVariant, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ProductionVariant Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ProductionVariant unmarshalledObject = new ProductionVariant();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AcceleratorType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AcceleratorType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ContainerStartupHealthCheckTimeoutInSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ContainerStartupHealthCheckTimeoutInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CoreDumpConfig", targetDepth))
                {
                    var unmarshaller = ProductionVariantCoreDumpConfigUnmarshaller.Instance;
                    unmarshalledObject.CoreDumpConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EnableSSMAccess", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EnableSSMAccess = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InitialInstanceCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.InitialInstanceCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InitialVariantWeight", targetDepth))
                {
                    var unmarshaller = FloatUnmarshaller.Instance;
                    unmarshalledObject.InitialVariantWeight = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelDataDownloadTimeoutInSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ModelDataDownloadTimeoutInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ModelName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServerlessConfig", targetDepth))
                {
                    var unmarshaller = ProductionVariantServerlessConfigUnmarshaller.Instance;
                    unmarshalledObject.ServerlessConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VariantName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VariantName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VolumeSizeInGB", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.VolumeSizeInGB = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ProductionVariantUnmarshaller _instance = new ProductionVariantUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ProductionVariantUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}