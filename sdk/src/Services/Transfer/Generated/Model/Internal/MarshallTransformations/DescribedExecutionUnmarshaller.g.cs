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

using Amazon.Transfer.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.Transfer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribedExecution Object
    /// </summary>
    public partial class DescribedExecutionUnmarshaller : IJsonUnmarshaller<DescribedExecution, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public DescribedExecution Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new DescribedExecution();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("ExecutionId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExecutionId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ExecutionRole", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExecutionRole = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("InitialFileLocation", targetDepth, ref reader))
                {
                    var unmarshaller = FileLocationUnmarshaller.Instance;
                    unmarshalledObject.InitialFileLocation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("LoggingConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = LoggingConfigurationUnmarshaller.Instance;
                    unmarshalledObject.LoggingConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("PosixProfile", targetDepth, ref reader))
                {
                    var unmarshaller = PosixProfileUnmarshaller.Instance;
                    unmarshalledObject.PosixProfile = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Results", targetDepth, ref reader))
                {
                    var unmarshaller = ExecutionResultsUnmarshaller.Instance;
                    unmarshalledObject.Results = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ServiceMetadata", targetDepth, ref reader))
                {
                    var unmarshaller = ServiceMetadataUnmarshaller.Instance;
                    unmarshalledObject.ServiceMetadata = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Status", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static DescribedExecutionUnmarshaller _instance = new DescribedExecutionUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribedExecutionUnmarshaller Instance => _instance;
    }
}
