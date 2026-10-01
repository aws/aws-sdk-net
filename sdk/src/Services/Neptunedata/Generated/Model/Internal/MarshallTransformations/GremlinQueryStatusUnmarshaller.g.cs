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

using Amazon.Neptunedata.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.Neptunedata.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GremlinQueryStatus Object
    /// </summary>
    public partial class GremlinQueryStatusUnmarshaller : IJsonUnmarshaller<GremlinQueryStatus, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public GremlinQueryStatus Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new GremlinQueryStatus();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("queryEvalStats", targetDepth, ref reader))
                {
                    var unmarshaller = QueryEvalStatsUnmarshaller.Instance;
                    unmarshalledObject.QueryEvalStats = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("queryId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.QueryId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("queryString", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.QueryString = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static GremlinQueryStatusUnmarshaller _instance = new GremlinQueryStatusUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GremlinQueryStatusUnmarshaller Instance => _instance;
    }
}
