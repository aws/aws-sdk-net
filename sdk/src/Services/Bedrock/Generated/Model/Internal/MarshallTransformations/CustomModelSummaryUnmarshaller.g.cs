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

using Amazon.Bedrock.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.Bedrock.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CustomModelSummary Object
    /// </summary>
    public partial class CustomModelSummaryUnmarshaller : IJsonUnmarshaller<CustomModelSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public CustomModelSummary Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new CustomModelSummary();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("baseModelArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BaseModelArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("baseModelName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BaseModelName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("creationTime", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("customizationType", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CustomizationType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("modelArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ModelArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("modelName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ModelName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("modelStatus", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ModelStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ownerAccountId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OwnerAccountId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static CustomModelSummaryUnmarshaller _instance = new CustomModelSummaryUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CustomModelSummaryUnmarshaller Instance => _instance;
    }
}
