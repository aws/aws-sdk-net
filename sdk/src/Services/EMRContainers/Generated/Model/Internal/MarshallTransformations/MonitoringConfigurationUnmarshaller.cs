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

#pragma warning disable CS0612,CS0618
namespace Amazon.EMRContainers.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MonitoringConfiguration Object
    /// </summary>  
    public class MonitoringConfigurationUnmarshaller : IUnmarshaller<MonitoringConfiguration, XmlUnmarshallerContext>, IUnmarshaller<MonitoringConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        MonitoringConfiguration IUnmarshaller<MonitoringConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public MonitoringConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            MonitoringConfiguration unmarshalledObject = new MonitoringConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("cloudWatchMonitoringConfiguration", targetDepth))
                {
                    var unmarshaller = CloudWatchMonitoringConfigurationUnmarshaller.Instance;
                    unmarshalledObject.CloudWatchMonitoringConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("containerLogRotationConfiguration", targetDepth))
                {
                    var unmarshaller = ContainerLogRotationConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ContainerLogRotationConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("managedLogs", targetDepth))
                {
                    var unmarshaller = ManagedLogsUnmarshaller.Instance;
                    unmarshalledObject.ManagedLogs = unmarshaller.Unmarshall(context);
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
                    var unmarshaller = S3MonitoringConfigurationUnmarshaller.Instance;
                    unmarshalledObject.S3MonitoringConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static MonitoringConfigurationUnmarshaller _instance = new MonitoringConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MonitoringConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}