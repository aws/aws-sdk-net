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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConvert.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
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
        /// <returns>The unmarshalled object</returns>
        public Job Unmarshall(JsonUnmarshallerContext context)
        {
            Job unmarshalledObject = new Job();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("accelerationSettings", targetDepth))
                {
                    var unmarshaller = AccelerationSettingsUnmarshaller.Instance;
                    unmarshalledObject.AccelerationSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("accelerationStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccelerationStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("billingTagsSource", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BillingTagsSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("clientRequestToken", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClientRequestToken = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("currentPhase", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrentPhase = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("errorCode", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ErrorCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("errorMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ErrorMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("hopDestinations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<HopDestination, HopDestinationUnmarshaller>(HopDestinationUnmarshaller.Instance);
                    unmarshalledObject.HopDestinations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jobEngineVersionRequested", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JobEngineVersionRequested = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jobEngineVersionUsed", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JobEngineVersionUsed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jobPercentComplete", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.JobPercentComplete = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jobTemplate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JobTemplate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastShareDetails", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastShareDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("messages", targetDepth))
                {
                    var unmarshaller = JobMessagesUnmarshaller.Instance;
                    unmarshalledObject.Messages = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("outputGroupDetails", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<OutputGroupDetail, OutputGroupDetailUnmarshaller>(OutputGroupDetailUnmarshaller.Instance);
                    unmarshalledObject.OutputGroupDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("priority", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Priority = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("queue", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Queue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("queueTransitions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<QueueTransition, QueueTransitionUnmarshaller>(QueueTransitionUnmarshaller.Instance);
                    unmarshalledObject.QueueTransitions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("retryCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.RetryCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("role", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Role = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("settings", targetDepth))
                {
                    var unmarshaller = JobSettingsUnmarshaller.Instance;
                    unmarshalledObject.Settings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("shareStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShareStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("simulateReservedQueue", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SimulateReservedQueue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("statusUpdateInterval", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StatusUpdateInterval = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timing", targetDepth))
                {
                    var unmarshaller = TimingUnmarshaller.Instance;
                    unmarshalledObject.Timing = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("userMetadata", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.UserMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("warnings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<WarningGroup, WarningGroupUnmarshaller>(WarningGroupUnmarshaller.Instance);
                    unmarshalledObject.Warnings = unmarshaller.Unmarshall(context);
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