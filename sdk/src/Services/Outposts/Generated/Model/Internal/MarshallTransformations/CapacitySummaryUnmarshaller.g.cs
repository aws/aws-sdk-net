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

using Amazon.Outposts.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.Outposts.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CapacitySummary Object
    /// </summary>
    public partial class CapacitySummaryUnmarshaller : IJsonUnmarshaller<CapacitySummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public CapacitySummary Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new CapacitySummary();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("CapacityChange", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<QuoteCapacity, QuoteCapacityUnmarshaller>(QuoteCapacityUnmarshaller.Instance);
                    unmarshalledObject.CapacityChange = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ExistingCapacities", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<QuoteCapacity, QuoteCapacityUnmarshaller>(QuoteCapacityUnmarshaller.Instance);
                    unmarshalledObject.ExistingCapacities = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("FinalCapacities", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<QuoteCapacity, QuoteCapacityUnmarshaller>(QuoteCapacityUnmarshaller.Instance);
                    unmarshalledObject.FinalCapacities = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static CapacitySummaryUnmarshaller _instance = new CapacitySummaryUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CapacitySummaryUnmarshaller Instance => _instance;
    }
}
