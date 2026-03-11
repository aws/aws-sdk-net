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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CompositeAlarm Object
    /// </summary>  
    public class CompositeAlarmUnmarshaller : ICborUnmarshaller<CompositeAlarm, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public CompositeAlarm Unmarshall(CborUnmarshallerContext context)
        {
            CompositeAlarm unmarshalledObject = new CompositeAlarm();
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
                    case "ActionsEnabled":
                        {
                            context.AddPathSegment("ActionsEnabled");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.ActionsEnabled = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ActionsSuppressedBy":
                        {
                            context.AddPathSegment("ActionsSuppressedBy");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ActionsSuppressedBy = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ActionsSuppressedReason":
                        {
                            context.AddPathSegment("ActionsSuppressedReason");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ActionsSuppressedReason = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ActionsSuppressor":
                        {
                            context.AddPathSegment("ActionsSuppressor");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ActionsSuppressor = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ActionsSuppressorExtensionPeriod":
                        {
                            context.AddPathSegment("ActionsSuppressorExtensionPeriod");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.ActionsSuppressorExtensionPeriod = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ActionsSuppressorWaitPeriod":
                        {
                            context.AddPathSegment("ActionsSuppressorWaitPeriod");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.ActionsSuppressorWaitPeriod = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "AlarmActions":
                        {
                            context.AddPathSegment("AlarmActions");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.AlarmActions = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "AlarmArn":
                        {
                            context.AddPathSegment("AlarmArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AlarmArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "AlarmConfigurationUpdatedTimestamp":
                        {
                            context.AddPathSegment("AlarmConfigurationUpdatedTimestamp");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.AlarmConfigurationUpdatedTimestamp = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "AlarmDescription":
                        {
                            context.AddPathSegment("AlarmDescription");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AlarmDescription = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "AlarmName":
                        {
                            context.AddPathSegment("AlarmName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AlarmName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "AlarmRule":
                        {
                            context.AddPathSegment("AlarmRule");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AlarmRule = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "InsufficientDataActions":
                        {
                            context.AddPathSegment("InsufficientDataActions");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.InsufficientDataActions = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "OKActions":
                        {
                            context.AddPathSegment("OKActions");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.OKActions = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StateReason":
                        {
                            context.AddPathSegment("StateReason");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.StateReason = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StateReasonData":
                        {
                            context.AddPathSegment("StateReasonData");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.StateReasonData = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StateTransitionedTimestamp":
                        {
                            context.AddPathSegment("StateTransitionedTimestamp");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.StateTransitionedTimestamp = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StateUpdatedTimestamp":
                        {
                            context.AddPathSegment("StateUpdatedTimestamp");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.StateUpdatedTimestamp = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StateValue":
                        {
                            context.AddPathSegment("StateValue");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.StateValue = unmarshaller.Unmarshall(context);
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


        private static CompositeAlarmUnmarshaller _instance = new CompositeAlarmUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CompositeAlarmUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}