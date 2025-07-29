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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Batch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Batch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for JobQueueDetail Object
    /// </summary>  
    public class JobQueueDetailUnmarshaller : IUnmarshaller<JobQueueDetail, XmlUnmarshallerContext>, IUnmarshaller<JobQueueDetail, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        JobQueueDetail IUnmarshaller<JobQueueDetail, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public JobQueueDetail Unmarshall(JsonUnmarshallerContext context)
        {
            JobQueueDetail unmarshalledObject = new JobQueueDetail();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("computeEnvironmentOrder", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ComputeEnvironmentOrder, ComputeEnvironmentOrderUnmarshaller>(ComputeEnvironmentOrderUnmarshaller.Instance);
                    unmarshalledObject.ComputeEnvironmentOrder = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jobQueueArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JobQueueArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jobQueueName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JobQueueName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jobQueueType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JobQueueType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jobStateTimeLimitActions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<JobStateTimeLimitAction, JobStateTimeLimitActionUnmarshaller>(JobStateTimeLimitActionUnmarshaller.Instance);
                    unmarshalledObject.JobStateTimeLimitActions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("priority", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Priority = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("schedulingPolicyArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SchedulingPolicyArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("serviceEnvironmentOrder", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ServiceEnvironmentOrder, ServiceEnvironmentOrderUnmarshaller>(ServiceEnvironmentOrderUnmarshaller.Instance);
                    unmarshalledObject.ServiceEnvironmentOrder = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("state", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("statusReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StatusReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static JobQueueDetailUnmarshaller _instance = new JobQueueDetailUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static JobQueueDetailUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}