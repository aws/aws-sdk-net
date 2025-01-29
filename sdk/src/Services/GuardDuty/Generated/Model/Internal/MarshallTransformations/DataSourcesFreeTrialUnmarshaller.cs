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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.GuardDuty.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DataSourcesFreeTrial Object
    /// </summary>  
    public class DataSourcesFreeTrialUnmarshaller : IJsonUnmarshaller<DataSourcesFreeTrial, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public DataSourcesFreeTrial Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            DataSourcesFreeTrial unmarshalledObject = new DataSourcesFreeTrial();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("cloudTrail", targetDepth))
                {
                    var unmarshaller = DataSourceFreeTrialUnmarshaller.Instance;
                    unmarshalledObject.CloudTrail = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dnsLogs", targetDepth))
                {
                    var unmarshaller = DataSourceFreeTrialUnmarshaller.Instance;
                    unmarshalledObject.DnsLogs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("flowLogs", targetDepth))
                {
                    var unmarshaller = DataSourceFreeTrialUnmarshaller.Instance;
                    unmarshalledObject.FlowLogs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("kubernetes", targetDepth))
                {
                    var unmarshaller = KubernetesDataSourceFreeTrialUnmarshaller.Instance;
                    unmarshalledObject.Kubernetes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("malwareProtection", targetDepth))
                {
                    var unmarshaller = MalwareProtectionDataSourceFreeTrialUnmarshaller.Instance;
                    unmarshalledObject.MalwareProtection = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("s3Logs", targetDepth))
                {
                    var unmarshaller = DataSourceFreeTrialUnmarshaller.Instance;
                    unmarshalledObject.S3Logs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DataSourcesFreeTrialUnmarshaller _instance = new DataSourcesFreeTrialUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DataSourcesFreeTrialUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}