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

using Amazon.CloudWatch.Model;
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
    public partial class CompositeAlarmUnmarshaller : ICborUnmarshaller<CompositeAlarm, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public CompositeAlarm Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new CompositeAlarm();
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
                    case "ActionConfiguration":
                        context.AddPathSegment("ActionConfiguration");
                        unmarshalledObject.ActionConfiguration = ActionConfigurationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ActionsEnabled":
                        context.AddPathSegment("ActionsEnabled");
                        unmarshalledObject.ActionsEnabled = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ActionsSuppressedBy":
                        context.AddPathSegment("ActionsSuppressedBy");
                        unmarshalledObject.ActionsSuppressedBy = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ActionsSuppressedReason":
                        context.AddPathSegment("ActionsSuppressedReason");
                        unmarshalledObject.ActionsSuppressedReason = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ActionsSuppressor":
                        context.AddPathSegment("ActionsSuppressor");
                        unmarshalledObject.ActionsSuppressor = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ActionsSuppressorExtensionPeriod":
                        context.AddPathSegment("ActionsSuppressorExtensionPeriod");
                        unmarshalledObject.ActionsSuppressorExtensionPeriod = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ActionsSuppressorWaitPeriod":
                        context.AddPathSegment("ActionsSuppressorWaitPeriod");
                        unmarshalledObject.ActionsSuppressorWaitPeriod = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "AlarmActions":
                        context.AddPathSegment("AlarmActions");
                        unmarshalledObject.AlarmActions = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "AlarmArn":
                        context.AddPathSegment("AlarmArn");
                        unmarshalledObject.AlarmArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "AlarmConfigurationUpdatedTimestamp":
                        context.AddPathSegment("AlarmConfigurationUpdatedTimestamp");
                        unmarshalledObject.AlarmConfigurationUpdatedTimestamp = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "AlarmDescription":
                        context.AddPathSegment("AlarmDescription");
                        unmarshalledObject.AlarmDescription = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "AlarmName":
                        context.AddPathSegment("AlarmName");
                        unmarshalledObject.AlarmName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "AlarmRule":
                        context.AddPathSegment("AlarmRule");
                        unmarshalledObject.AlarmRule = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "InsufficientDataActions":
                        context.AddPathSegment("InsufficientDataActions");
                        unmarshalledObject.InsufficientDataActions = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "OKActions":
                        context.AddPathSegment("OKActions");
                        unmarshalledObject.OKActions = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StateReason":
                        context.AddPathSegment("StateReason");
                        unmarshalledObject.StateReason = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StateReasonData":
                        context.AddPathSegment("StateReasonData");
                        unmarshalledObject.StateReasonData = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StateTransitionedTimestamp":
                        context.AddPathSegment("StateTransitionedTimestamp");
                        unmarshalledObject.StateTransitionedTimestamp = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StateUpdatedTimestamp":
                        context.AddPathSegment("StateUpdatedTimestamp");
                        unmarshalledObject.StateUpdatedTimestamp = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StateValue":
                        context.AddPathSegment("StateValue");
                        unmarshalledObject.StateValue = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static CompositeAlarmUnmarshaller _instance = new CompositeAlarmUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CompositeAlarmUnmarshaller Instance => _instance;
    }
}
