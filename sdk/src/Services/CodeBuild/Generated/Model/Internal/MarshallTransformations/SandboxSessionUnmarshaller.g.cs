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

using Amazon.CodeBuild.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.CodeBuild.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SandboxSession Object
    /// </summary>
    public partial class SandboxSessionUnmarshaller : ICborUnmarshaller<SandboxSession, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public SandboxSession Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new SandboxSession();
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
                    case "currentPhase":
                        context.AddPathSegment("CurrentPhase");
                        unmarshalledObject.CurrentPhase = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "endTime":
                        context.AddPathSegment("EndTime");
                        unmarshalledObject.EndTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "id":
                        context.AddPathSegment("Id");
                        unmarshalledObject.Id = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "logs":
                        context.AddPathSegment("Logs");
                        unmarshalledObject.Logs = LogsLocationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "networkInterface":
                        context.AddPathSegment("NetworkInterface");
                        unmarshalledObject.NetworkInterface = NetworkInterfaceUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "phases":
                        context.AddPathSegment("Phases");
                        unmarshalledObject.Phases = new CborListUnmarshaller<SandboxSessionPhase, SandboxSessionPhaseUnmarshaller>(SandboxSessionPhaseUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "resolvedSourceVersion":
                        context.AddPathSegment("ResolvedSourceVersion");
                        unmarshalledObject.ResolvedSourceVersion = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "startTime":
                        context.AddPathSegment("StartTime");
                        unmarshalledObject.StartTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "status":
                        context.AddPathSegment("Status");
                        unmarshalledObject.Status = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static SandboxSessionUnmarshaller _instance = new SandboxSessionUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static SandboxSessionUnmarshaller Instance => _instance;
    }
}
