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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsGuardDutyDetectorDataSourcesDetails Object
    /// </summary>  
    public class AwsGuardDutyDetectorDataSourcesDetailsUnmarshaller : IJsonUnmarshaller<AwsGuardDutyDetectorDataSourcesDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AwsGuardDutyDetectorDataSourcesDetails Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AwsGuardDutyDetectorDataSourcesDetails unmarshalledObject = new AwsGuardDutyDetectorDataSourcesDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("CloudTrail", targetDepth))
                {
                    var unmarshaller = AwsGuardDutyDetectorDataSourcesCloudTrailDetailsUnmarshaller.Instance;
                    unmarshalledObject.CloudTrail = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DnsLogs", targetDepth))
                {
                    var unmarshaller = AwsGuardDutyDetectorDataSourcesDnsLogsDetailsUnmarshaller.Instance;
                    unmarshalledObject.DnsLogs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FlowLogs", targetDepth))
                {
                    var unmarshaller = AwsGuardDutyDetectorDataSourcesFlowLogsDetailsUnmarshaller.Instance;
                    unmarshalledObject.FlowLogs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Kubernetes", targetDepth))
                {
                    var unmarshaller = AwsGuardDutyDetectorDataSourcesKubernetesDetailsUnmarshaller.Instance;
                    unmarshalledObject.Kubernetes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MalwareProtection", targetDepth))
                {
                    var unmarshaller = AwsGuardDutyDetectorDataSourcesMalwareProtectionDetailsUnmarshaller.Instance;
                    unmarshalledObject.MalwareProtection = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("S3Logs", targetDepth))
                {
                    var unmarshaller = AwsGuardDutyDetectorDataSourcesS3LogsDetailsUnmarshaller.Instance;
                    unmarshalledObject.S3Logs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AwsGuardDutyDetectorDataSourcesDetailsUnmarshaller _instance = new AwsGuardDutyDetectorDataSourcesDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsGuardDutyDetectorDataSourcesDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}