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
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.CodeBuild.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SandboxSession Object
    /// </summary>
    public partial class SandboxSessionUnmarshaller : IJsonUnmarshaller<SandboxSession, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public SandboxSession Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new SandboxSession();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("currentPhase", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrentPhase = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("endTime", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.EndTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("id", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("logs", targetDepth, ref reader))
                {
                    var unmarshaller = LogsLocationUnmarshaller.Instance;
                    unmarshalledObject.Logs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("networkInterface", targetDepth, ref reader))
                {
                    var unmarshaller = NetworkInterfaceUnmarshaller.Instance;
                    unmarshalledObject.NetworkInterface = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("phases", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<SandboxSessionPhase, SandboxSessionPhaseUnmarshaller>(SandboxSessionPhaseUnmarshaller.Instance);
                    unmarshalledObject.Phases = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("resolvedSourceVersion", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResolvedSourceVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("startTime", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("status", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static SandboxSessionUnmarshaller _instance = new SandboxSessionUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static SandboxSessionUnmarshaller Instance => _instance;
    }
}
