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
 * Do not modify this file. This file is generated from the compute-optimizer-automation-2025-09-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ComputeOptimizerAutomation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.ComputeOptimizerAutomation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AutomationEvent Object
    /// </summary>  
    public class AutomationEventUnmarshaller : ICborUnmarshaller<AutomationEvent, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AutomationEvent Unmarshall(CborUnmarshallerContext context)
        {
            AutomationEvent unmarshalledObject = new AutomationEvent();
            if (context.IsEmptyResponse)
                return null;
            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "accountId":
                        {
                            context.AddPathSegment("AccountId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AccountId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "completedTimestamp":
                        {
                            context.AddPathSegment("CompletedTimestamp");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.CompletedTimestamp = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "createdTimestamp":
                        {
                            context.AddPathSegment("CreatedTimestamp");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.CreatedTimestamp = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "estimatedMonthlySavings":
                        {
                            context.AddPathSegment("EstimatedMonthlySavings");
                            var unmarshaller = EstimatedMonthlySavingsUnmarshaller.Instance;
                            unmarshalledObject.EstimatedMonthlySavings = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "eventDescription":
                        {
                            context.AddPathSegment("EventDescription");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.EventDescription = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "eventId":
                        {
                            context.AddPathSegment("EventId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.EventId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "eventStatus":
                        {
                            context.AddPathSegment("EventStatus");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.EventStatus = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "eventStatusReason":
                        {
                            context.AddPathSegment("EventStatusReason");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.EventStatusReason = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "eventType":
                        {
                            context.AddPathSegment("EventType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.EventType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "recommendedActionId":
                        {
                            context.AddPathSegment("RecommendedActionId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.RecommendedActionId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "region":
                        {
                            context.AddPathSegment("Region");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Region = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "resourceArn":
                        {
                            context.AddPathSegment("ResourceArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ResourceArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "resourceId":
                        {
                            context.AddPathSegment("ResourceId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ResourceId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "resourceType":
                        {
                            context.AddPathSegment("ResourceType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ResourceType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ruleId":
                        {
                            context.AddPathSegment("RuleId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.RuleId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            return unmarshalledObject;
        }


        private static AutomationEventUnmarshaller _instance = new AutomationEventUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AutomationEventUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}