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

using Amazon.QuickSight.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TopicNumericRangeFilter Object
    /// </summary>
    public partial class TopicNumericRangeFilterUnmarshaller : IJsonUnmarshaller<TopicNumericRangeFilter, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public TopicNumericRangeFilter Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new TopicNumericRangeFilter();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Aggregation", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Aggregation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Constant", targetDepth, ref reader))
                {
                    var unmarshaller = TopicRangeFilterConstantUnmarshaller.Instance;
                    unmarshalledObject.Constant = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Inclusive", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.Inclusive = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Inverse", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.Inverse = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("NullFilter", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NullFilter = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static TopicNumericRangeFilterUnmarshaller _instance = new TopicNumericRangeFilterUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static TopicNumericRangeFilterUnmarshaller Instance => _instance;
    }
}
