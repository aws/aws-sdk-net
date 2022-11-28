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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Job Object
    /// </summary>  
    public class JobUnmarshaller : IUnmarshaller<Job, XmlUnmarshallerContext>, IUnmarshaller<Job, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Job IUnmarshaller<Job, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Job Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Job unmarshalledObject = new Job();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("abortConfig", targetDepth))
                {
                    var unmarshaller = AbortConfigUnmarshaller.Instance;
                    unmarshalledObject.AbortConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("comment", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Comment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("completedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CompletedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("documentParameters", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.DocumentParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("forceCanceled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ForceCanceled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("isConcurrent", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsConcurrent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jobArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JobArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jobExecutionsRetryConfig", targetDepth))
                {
                    var unmarshaller = JobExecutionsRetryConfigUnmarshaller.Instance;
                    unmarshalledObject.JobExecutionsRetryConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jobExecutionsRolloutConfig", targetDepth))
                {
                    var unmarshaller = JobExecutionsRolloutConfigUnmarshaller.Instance;
                    unmarshalledObject.JobExecutionsRolloutConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jobId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JobId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jobProcessDetails", targetDepth))
                {
                    var unmarshaller = JobProcessDetailsUnmarshaller.Instance;
                    unmarshalledObject.JobProcessDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jobTemplateArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JobTemplateArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastUpdatedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastUpdatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("namespaceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NamespaceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("presignedUrlConfig", targetDepth))
                {
                    var unmarshaller = PresignedUrlConfigUnmarshaller.Instance;
                    unmarshalledObject.PresignedUrlConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("reasonCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReasonCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("schedulingConfig", targetDepth))
                {
                    var unmarshaller = SchedulingConfigUnmarshaller.Instance;
                    unmarshalledObject.SchedulingConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("targets", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Targets = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("targetSelection", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TargetSelection = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timeoutConfig", targetDepth))
                {
                    var unmarshaller = TimeoutConfigUnmarshaller.Instance;
                    unmarshalledObject.TimeoutConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static JobUnmarshaller _instance = new JobUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static JobUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}