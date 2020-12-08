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
    /// Response Unmarshaller for MonitoringScheduleConfig Object
    /// </summary>  
    public class MonitoringScheduleConfigUnmarshaller : IUnmarshaller<MonitoringScheduleConfig, XmlUnmarshallerContext>, IUnmarshaller<MonitoringScheduleConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        MonitoringScheduleConfig IUnmarshaller<MonitoringScheduleConfig, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public MonitoringScheduleConfig Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            MonitoringScheduleConfig unmarshalledObject = new MonitoringScheduleConfig();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("MonitoringJobDefinition", targetDepth))
                {
                    var unmarshaller = MonitoringJobDefinitionUnmarshaller.Instance;
                    unmarshalledObject.MonitoringJobDefinition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MonitoringJobDefinitionName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MonitoringJobDefinitionName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MonitoringType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MonitoringType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScheduleConfig", targetDepth))
                {
                    var unmarshaller = ScheduleConfigUnmarshaller.Instance;
                    unmarshalledObject.ScheduleConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static MonitoringScheduleConfigUnmarshaller _instance = new MonitoringScheduleConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MonitoringScheduleConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}