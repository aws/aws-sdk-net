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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.StepFunctions.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.StepFunctions.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for HistoryEvent Object
    /// </summary>  
    public class HistoryEventUnmarshaller : IJsonUnmarshaller<HistoryEvent, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public HistoryEvent Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            HistoryEvent unmarshalledObject = new HistoryEvent();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("activityFailedEventDetails", targetDepth))
                {
                    var unmarshaller = ActivityFailedEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.ActivityFailedEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("activityScheduledEventDetails", targetDepth))
                {
                    var unmarshaller = ActivityScheduledEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.ActivityScheduledEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("activityScheduleFailedEventDetails", targetDepth))
                {
                    var unmarshaller = ActivityScheduleFailedEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.ActivityScheduleFailedEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("activityStartedEventDetails", targetDepth))
                {
                    var unmarshaller = ActivityStartedEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.ActivityStartedEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("activitySucceededEventDetails", targetDepth))
                {
                    var unmarshaller = ActivitySucceededEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.ActivitySucceededEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("activityTimedOutEventDetails", targetDepth))
                {
                    var unmarshaller = ActivityTimedOutEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.ActivityTimedOutEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("evaluationFailedEventDetails", targetDepth))
                {
                    var unmarshaller = EvaluationFailedEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.EvaluationFailedEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("executionAbortedEventDetails", targetDepth))
                {
                    var unmarshaller = ExecutionAbortedEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.ExecutionAbortedEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("executionFailedEventDetails", targetDepth))
                {
                    var unmarshaller = ExecutionFailedEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.ExecutionFailedEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("executionRedrivenEventDetails", targetDepth))
                {
                    var unmarshaller = ExecutionRedrivenEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.ExecutionRedrivenEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("executionStartedEventDetails", targetDepth))
                {
                    var unmarshaller = ExecutionStartedEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.ExecutionStartedEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("executionSucceededEventDetails", targetDepth))
                {
                    var unmarshaller = ExecutionSucceededEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.ExecutionSucceededEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("executionTimedOutEventDetails", targetDepth))
                {
                    var unmarshaller = ExecutionTimedOutEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.ExecutionTimedOutEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lambdaFunctionFailedEventDetails", targetDepth))
                {
                    var unmarshaller = LambdaFunctionFailedEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.LambdaFunctionFailedEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lambdaFunctionScheduledEventDetails", targetDepth))
                {
                    var unmarshaller = LambdaFunctionScheduledEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.LambdaFunctionScheduledEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lambdaFunctionScheduleFailedEventDetails", targetDepth))
                {
                    var unmarshaller = LambdaFunctionScheduleFailedEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.LambdaFunctionScheduleFailedEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lambdaFunctionStartFailedEventDetails", targetDepth))
                {
                    var unmarshaller = LambdaFunctionStartFailedEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.LambdaFunctionStartFailedEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lambdaFunctionSucceededEventDetails", targetDepth))
                {
                    var unmarshaller = LambdaFunctionSucceededEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.LambdaFunctionSucceededEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lambdaFunctionTimedOutEventDetails", targetDepth))
                {
                    var unmarshaller = LambdaFunctionTimedOutEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.LambdaFunctionTimedOutEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mapIterationAbortedEventDetails", targetDepth))
                {
                    var unmarshaller = MapIterationEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.MapIterationAbortedEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mapIterationFailedEventDetails", targetDepth))
                {
                    var unmarshaller = MapIterationEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.MapIterationFailedEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mapIterationStartedEventDetails", targetDepth))
                {
                    var unmarshaller = MapIterationEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.MapIterationStartedEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mapIterationSucceededEventDetails", targetDepth))
                {
                    var unmarshaller = MapIterationEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.MapIterationSucceededEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mapRunFailedEventDetails", targetDepth))
                {
                    var unmarshaller = MapRunFailedEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.MapRunFailedEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mapRunRedrivenEventDetails", targetDepth))
                {
                    var unmarshaller = MapRunRedrivenEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.MapRunRedrivenEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mapRunStartedEventDetails", targetDepth))
                {
                    var unmarshaller = MapRunStartedEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.MapRunStartedEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mapStateStartedEventDetails", targetDepth))
                {
                    var unmarshaller = MapStateStartedEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.MapStateStartedEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("previousEventId", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.PreviousEventId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("stateEnteredEventDetails", targetDepth))
                {
                    var unmarshaller = StateEnteredEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.StateEnteredEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("stateExitedEventDetails", targetDepth))
                {
                    var unmarshaller = StateExitedEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.StateExitedEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("taskFailedEventDetails", targetDepth))
                {
                    var unmarshaller = TaskFailedEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.TaskFailedEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("taskScheduledEventDetails", targetDepth))
                {
                    var unmarshaller = TaskScheduledEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.TaskScheduledEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("taskStartedEventDetails", targetDepth))
                {
                    var unmarshaller = TaskStartedEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.TaskStartedEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("taskStartFailedEventDetails", targetDepth))
                {
                    var unmarshaller = TaskStartFailedEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.TaskStartFailedEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("taskSubmitFailedEventDetails", targetDepth))
                {
                    var unmarshaller = TaskSubmitFailedEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.TaskSubmitFailedEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("taskSubmittedEventDetails", targetDepth))
                {
                    var unmarshaller = TaskSubmittedEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.TaskSubmittedEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("taskSucceededEventDetails", targetDepth))
                {
                    var unmarshaller = TaskSucceededEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.TaskSucceededEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("taskTimedOutEventDetails", targetDepth))
                {
                    var unmarshaller = TaskTimedOutEventDetailsUnmarshaller.Instance;
                    unmarshalledObject.TaskTimedOutEventDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("timestamp", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.Timestamp = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static HistoryEventUnmarshaller _instance = new HistoryEventUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HistoryEventUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}