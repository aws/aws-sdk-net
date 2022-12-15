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
    /// Response Unmarshaller for RecommendationJobInputConfig Object
    /// </summary>  
    public class RecommendationJobInputConfigUnmarshaller : IUnmarshaller<RecommendationJobInputConfig, XmlUnmarshallerContext>, IUnmarshaller<RecommendationJobInputConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RecommendationJobInputConfig IUnmarshaller<RecommendationJobInputConfig, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public RecommendationJobInputConfig Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            RecommendationJobInputConfig unmarshalledObject = new RecommendationJobInputConfig();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ContainerConfig", targetDepth))
                {
                    var unmarshaller = RecommendationJobContainerConfigUnmarshaller.Instance;
                    unmarshalledObject.ContainerConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EndpointConfigurations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<EndpointInputConfiguration, EndpointInputConfigurationUnmarshaller>(EndpointInputConfigurationUnmarshaller.Instance);
                    unmarshalledObject.EndpointConfigurations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Endpoints", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<EndpointInfo, EndpointInfoUnmarshaller>(EndpointInfoUnmarshaller.Instance);
                    unmarshalledObject.Endpoints = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JobDurationInSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.JobDurationInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelPackageVersionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ModelPackageVersionArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceLimit", targetDepth))
                {
                    var unmarshaller = RecommendationJobResourceLimitUnmarshaller.Instance;
                    unmarshalledObject.ResourceLimit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrafficPattern", targetDepth))
                {
                    var unmarshaller = TrafficPatternUnmarshaller.Instance;
                    unmarshalledObject.TrafficPattern = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VolumeKmsKeyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VolumeKmsKeyId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VpcConfig", targetDepth))
                {
                    var unmarshaller = RecommendationJobVpcConfigUnmarshaller.Instance;
                    unmarshalledObject.VpcConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static RecommendationJobInputConfigUnmarshaller _instance = new RecommendationJobInputConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RecommendationJobInputConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}