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

using Amazon.EventBridgeV2.Model;
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
    public partial class InvokeConfigurationUnmarshaller : ICborUnmarshaller<InvokeConfiguration, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public InvokeConfiguration Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new InvokeConfiguration();
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
                    case "EventBusV2Parameters":
                        context.AddPathSegment("EventBusV2Parameters");
                        unmarshalledObject.EventBusV2Parameters = EventBusV2ParametersUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "HttpParameters":
                        context.AddPathSegment("HttpParameters");
                        unmarshalledObject.HttpParameters = HttpParametersUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "KinesisParameters":
                        context.AddPathSegment("KinesisParameters");
                        unmarshalledObject.KinesisParameters = KinesisParametersUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LambdaParameters":
                        context.AddPathSegment("LambdaParameters");
                        unmarshalledObject.LambdaParameters = LambdaParametersUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RoleArn":
                        context.AddPathSegment("RoleArn");
                        unmarshalledObject.RoleArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SnsParameters":
                        context.AddPathSegment("SnsParameters");
                        unmarshalledObject.SnsParameters = SnsParametersUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SqsParameters":
                        context.AddPathSegment("SqsParameters");
                        unmarshalledObject.SqsParameters = SqsParametersUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StepFunctionsParameters":
                        context.AddPathSegment("StepFunctionsParameters");
                        unmarshalledObject.StepFunctionsParameters = StepFunctionsParametersUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TargetArn":
                        context.AddPathSegment("TargetArn");
                        unmarshalledObject.TargetArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "UniversalTargetParameters":
                        context.AddPathSegment("UniversalTargetParameters");
                        unmarshalledObject.UniversalTargetParameters = UniversalTargetParametersUnmarshaller.Instance.Unmarshall(context);
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

        private static InvokeConfigurationUnmarshaller _instance = new InvokeConfigurationUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static InvokeConfigurationUnmarshaller Instance => _instance;
    }
}
