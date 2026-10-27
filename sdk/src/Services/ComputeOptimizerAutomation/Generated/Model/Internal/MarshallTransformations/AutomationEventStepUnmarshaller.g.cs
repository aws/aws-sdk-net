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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.ComputeOptimizerAutomation.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.ComputeOptimizerAutomation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AutomationEventStep Object
    /// </summary>
    public partial class AutomationEventStepUnmarshaller : ICborUnmarshaller<AutomationEventStep, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public AutomationEventStep Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new AutomationEventStep();
            if (context.IsEmptyResponse) return null;

            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "completedTimestamp":
                        context.AddPathSegment("CompletedTimestamp");
                        unmarshalledObject.CompletedTimestamp = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "estimatedMonthlySavings":
                        context.AddPathSegment("EstimatedMonthlySavings");
                        unmarshalledObject.EstimatedMonthlySavings = EstimatedMonthlySavingsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "eventId":
                        context.AddPathSegment("EventId");
                        unmarshalledObject.EventId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "resourceId":
                        context.AddPathSegment("ResourceId");
                        unmarshalledObject.ResourceId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "startTimestamp":
                        context.AddPathSegment("StartTimestamp");
                        unmarshalledObject.StartTimestamp = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "stepId":
                        context.AddPathSegment("StepId");
                        unmarshalledObject.StepId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "stepStatus":
                        context.AddPathSegment("StepStatus");
                        unmarshalledObject.StepStatus = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "stepType":
                        context.AddPathSegment("StepType");
                        unmarshalledObject.StepType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            return unmarshalledObject;
        }

        private static AutomationEventStepUnmarshaller _instance = new AutomationEventStepUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AutomationEventStepUnmarshaller Instance => _instance;
    }
}
