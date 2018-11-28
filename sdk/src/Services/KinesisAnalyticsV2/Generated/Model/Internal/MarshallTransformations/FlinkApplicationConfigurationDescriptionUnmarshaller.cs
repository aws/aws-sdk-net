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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisAnalyticsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.KinesisAnalyticsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for FlinkApplicationConfigurationDescription Object
    /// </summary>  
    public class FlinkApplicationConfigurationDescriptionUnmarshaller : IUnmarshaller<FlinkApplicationConfigurationDescription, XmlUnmarshallerContext>, IUnmarshaller<FlinkApplicationConfigurationDescription, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        FlinkApplicationConfigurationDescription IUnmarshaller<FlinkApplicationConfigurationDescription, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public FlinkApplicationConfigurationDescription Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            FlinkApplicationConfigurationDescription unmarshalledObject = new FlinkApplicationConfigurationDescription();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CheckpointConfigurationDescription", targetDepth))
                {
                    var unmarshaller = CheckpointConfigurationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.CheckpointConfigurationDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JobPlanDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JobPlanDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MonitoringConfigurationDescription", targetDepth))
                {
                    var unmarshaller = MonitoringConfigurationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.MonitoringConfigurationDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ParallelismConfigurationDescription", targetDepth))
                {
                    var unmarshaller = ParallelismConfigurationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.ParallelismConfigurationDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static FlinkApplicationConfigurationDescriptionUnmarshaller _instance = new FlinkApplicationConfigurationDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FlinkApplicationConfigurationDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}