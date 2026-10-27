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

using Amazon.DataSync.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.DataSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TaskReportConfig Object
    /// </summary>
    public partial class TaskReportConfigUnmarshaller : IJsonUnmarshaller<TaskReportConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public TaskReportConfig Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new TaskReportConfig();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Destination", targetDepth, ref reader))
                {
                    var unmarshaller = ReportDestinationUnmarshaller.Instance;
                    unmarshalledObject.Destination = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ObjectVersionIds", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ObjectVersionIds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("OutputType", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OutputType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Overrides", targetDepth, ref reader))
                {
                    var unmarshaller = ReportOverridesUnmarshaller.Instance;
                    unmarshalledObject.Overrides = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ReportLevel", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReportLevel = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static TaskReportConfigUnmarshaller _instance = new TaskReportConfigUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static TaskReportConfigUnmarshaller Instance => _instance;
    }
}
