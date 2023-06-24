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
    /// Response Unmarshaller for PendingDeploymentSummary Object
    /// </summary>  
    public class PendingDeploymentSummaryUnmarshaller : IUnmarshaller<PendingDeploymentSummary, XmlUnmarshallerContext>, IUnmarshaller<PendingDeploymentSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PendingDeploymentSummary IUnmarshaller<PendingDeploymentSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PendingDeploymentSummary Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            PendingDeploymentSummary unmarshalledObject = new PendingDeploymentSummary();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("EndpointConfigName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EndpointConfigName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProductionVariants", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PendingProductionVariantSummary, PendingProductionVariantSummaryUnmarshaller>(PendingProductionVariantSummaryUnmarshaller.Instance);
                    unmarshalledObject.ProductionVariants = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShadowProductionVariants", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PendingProductionVariantSummary, PendingProductionVariantSummaryUnmarshaller>(PendingProductionVariantSummaryUnmarshaller.Instance);
                    unmarshalledObject.ShadowProductionVariants = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static PendingDeploymentSummaryUnmarshaller _instance = new PendingDeploymentSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PendingDeploymentSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}