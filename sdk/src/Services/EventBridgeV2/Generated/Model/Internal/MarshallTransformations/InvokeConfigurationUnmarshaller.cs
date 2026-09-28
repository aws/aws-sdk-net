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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EventBridgeV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.EventBridgeV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InvokeConfiguration Object
    /// </summary>  
    public class InvokeConfigurationUnmarshaller : ICborUnmarshaller<InvokeConfiguration, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public InvokeConfiguration Unmarshall(CborUnmarshallerContext context)
        {
            InvokeConfiguration unmarshalledObject = new InvokeConfiguration();
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
                    case "EventBusV2Parameters":
                        {
                            context.AddPathSegment("EventBusV2Parameters");
                            var unmarshaller = EventBusV2ParametersUnmarshaller.Instance;
                            unmarshalledObject.EventBusV2Parameters = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "HttpParameters":
                        {
                            context.AddPathSegment("HttpParameters");
                            var unmarshaller = HttpParametersUnmarshaller.Instance;
                            unmarshalledObject.HttpParameters = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "KinesisParameters":
                        {
                            context.AddPathSegment("KinesisParameters");
                            var unmarshaller = KinesisParametersUnmarshaller.Instance;
                            unmarshalledObject.KinesisParameters = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "LambdaParameters":
                        {
                            context.AddPathSegment("LambdaParameters");
                            var unmarshaller = LambdaParametersUnmarshaller.Instance;
                            unmarshalledObject.LambdaParameters = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "RoleArn":
                        {
                            context.AddPathSegment("RoleArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.RoleArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SnsParameters":
                        {
                            context.AddPathSegment("SnsParameters");
                            var unmarshaller = SnsParametersUnmarshaller.Instance;
                            unmarshalledObject.SnsParameters = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SqsParameters":
                        {
                            context.AddPathSegment("SqsParameters");
                            var unmarshaller = SqsParametersUnmarshaller.Instance;
                            unmarshalledObject.SqsParameters = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StepFunctionsParameters":
                        {
                            context.AddPathSegment("StepFunctionsParameters");
                            var unmarshaller = StepFunctionsParametersUnmarshaller.Instance;
                            unmarshalledObject.StepFunctionsParameters = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "TargetArn":
                        {
                            context.AddPathSegment("TargetArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.TargetArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "UniversalTargetParameters":
                        {
                            context.AddPathSegment("UniversalTargetParameters");
                            var unmarshaller = UniversalTargetParametersUnmarshaller.Instance;
                            unmarshalledObject.UniversalTargetParameters = unmarshaller.Unmarshall(context);
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


        private static InvokeConfigurationUnmarshaller _instance = new InvokeConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InvokeConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}