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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GameLift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.GameLift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ScalingPolicy Object
    /// </summary>  
    public class ScalingPolicyUnmarshaller : ICborUnmarshaller<ScalingPolicy, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ScalingPolicy Unmarshall(CborUnmarshallerContext context)
        {
            ScalingPolicy unmarshalledObject = new ScalingPolicy();
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
                    case "ComparisonOperator":
                        {
                            context.AddPathSegment("ComparisonOperator");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ComparisonOperator = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "EvaluationPeriods":
                        {
                            context.AddPathSegment("EvaluationPeriods");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.EvaluationPeriods = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "FleetArn":
                        {
                            context.AddPathSegment("FleetArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.FleetArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "FleetId":
                        {
                            context.AddPathSegment("FleetId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.FleetId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Location":
                        {
                            context.AddPathSegment("Location");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Location = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "MetricName":
                        {
                            context.AddPathSegment("MetricName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.MetricName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Name":
                        {
                            context.AddPathSegment("Name");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PolicyType":
                        {
                            context.AddPathSegment("PolicyType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.PolicyType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ScalingAdjustment":
                        {
                            context.AddPathSegment("ScalingAdjustment");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.ScalingAdjustment = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ScalingAdjustmentType":
                        {
                            context.AddPathSegment("ScalingAdjustmentType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ScalingAdjustmentType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Status":
                        {
                            context.AddPathSegment("Status");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "TargetConfiguration":
                        {
                            context.AddPathSegment("TargetConfiguration");
                            var unmarshaller = TargetConfigurationUnmarshaller.Instance;
                            unmarshalledObject.TargetConfiguration = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Threshold":
                        {
                            context.AddPathSegment("Threshold");
                            var unmarshaller = CborNullableDoubleUnmarshaller.Instance;
                            unmarshalledObject.Threshold = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "UpdateStatus":
                        {
                            context.AddPathSegment("UpdateStatus");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.UpdateStatus = unmarshaller.Unmarshall(context);
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


        private static ScalingPolicyUnmarshaller _instance = new ScalingPolicyUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ScalingPolicyUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}