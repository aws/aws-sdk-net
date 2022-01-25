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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GuardDuty.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GuardDuty.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DataSourceConfigurationsResult Object
    /// </summary>  
    public class DataSourceConfigurationsResultUnmarshaller : IUnmarshaller<DataSourceConfigurationsResult, XmlUnmarshallerContext>, IUnmarshaller<DataSourceConfigurationsResult, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DataSourceConfigurationsResult IUnmarshaller<DataSourceConfigurationsResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DataSourceConfigurationsResult Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DataSourceConfigurationsResult unmarshalledObject = new DataSourceConfigurationsResult();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("cloudTrail", targetDepth))
                {
                    var unmarshaller = CloudTrailConfigurationResultUnmarshaller.Instance;
                    unmarshalledObject.CloudTrail = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dnsLogs", targetDepth))
                {
                    var unmarshaller = DNSLogsConfigurationResultUnmarshaller.Instance;
                    unmarshalledObject.DNSLogs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("flowLogs", targetDepth))
                {
                    var unmarshaller = FlowLogsConfigurationResultUnmarshaller.Instance;
                    unmarshalledObject.FlowLogs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("kubernetes", targetDepth))
                {
                    var unmarshaller = KubernetesConfigurationResultUnmarshaller.Instance;
                    unmarshalledObject.Kubernetes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("s3Logs", targetDepth))
                {
                    var unmarshaller = S3LogsConfigurationResultUnmarshaller.Instance;
                    unmarshalledObject.S3Logs = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DataSourceConfigurationsResultUnmarshaller _instance = new DataSourceConfigurationsResultUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DataSourceConfigurationsResultUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}