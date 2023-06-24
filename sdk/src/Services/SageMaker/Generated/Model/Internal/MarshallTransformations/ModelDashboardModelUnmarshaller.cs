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
    /// Response Unmarshaller for ModelDashboardModel Object
    /// </summary>  
    public class ModelDashboardModelUnmarshaller : IUnmarshaller<ModelDashboardModel, XmlUnmarshallerContext>, IUnmarshaller<ModelDashboardModel, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ModelDashboardModel IUnmarshaller<ModelDashboardModel, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ModelDashboardModel Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ModelDashboardModel unmarshalledObject = new ModelDashboardModel();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Endpoints", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ModelDashboardEndpoint, ModelDashboardEndpointUnmarshaller>(ModelDashboardEndpointUnmarshaller.Instance);
                    unmarshalledObject.Endpoints = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastBatchTransformJob", targetDepth))
                {
                    var unmarshaller = TransformJobUnmarshaller.Instance;
                    unmarshalledObject.LastBatchTransformJob = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Model", targetDepth))
                {
                    var unmarshaller = ModelUnmarshaller.Instance;
                    unmarshalledObject.Model = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelCard", targetDepth))
                {
                    var unmarshaller = ModelDashboardModelCardUnmarshaller.Instance;
                    unmarshalledObject.ModelCard = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MonitoringSchedules", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ModelDashboardMonitoringSchedule, ModelDashboardMonitoringScheduleUnmarshaller>(ModelDashboardMonitoringScheduleUnmarshaller.Instance);
                    unmarshalledObject.MonitoringSchedules = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ModelDashboardModelUnmarshaller _instance = new ModelDashboardModelUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModelDashboardModelUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}