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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EMRContainers.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.EMRContainers.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ParametricMonitoringConfiguration Object
    /// </summary>  
    public class ParametricMonitoringConfigurationUnmarshaller : IUnmarshaller<ParametricMonitoringConfiguration, XmlUnmarshallerContext>, IUnmarshaller<ParametricMonitoringConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ParametricMonitoringConfiguration IUnmarshaller<ParametricMonitoringConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ParametricMonitoringConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ParametricMonitoringConfiguration unmarshalledObject = new ParametricMonitoringConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("cloudWatchMonitoringConfiguration", targetDepth))
                {
                    var unmarshaller = ParametricCloudWatchMonitoringConfigurationUnmarshaller.Instance;
                    unmarshalledObject.CloudWatchMonitoringConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("persistentAppUI", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PersistentAppUI = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("s3MonitoringConfiguration", targetDepth))
                {
                    var unmarshaller = ParametricS3MonitoringConfigurationUnmarshaller.Instance;
                    unmarshalledObject.S3MonitoringConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ParametricMonitoringConfigurationUnmarshaller _instance = new ParametricMonitoringConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ParametricMonitoringConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}