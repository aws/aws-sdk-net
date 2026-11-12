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

using Amazon.GuardDuty.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.GuardDuty.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for S3Activity Object
    /// </summary>
    public partial class S3ActivityUnmarshaller : IJsonUnmarshaller<S3Activity, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public S3Activity Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new S3Activity();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("activityWindow", targetDepth, ref reader))
                {
                    var unmarshaller = ActivityWindowUnmarshaller.Instance;
                    unmarshalledObject.ActivityWindow = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("actor", targetDepth, ref reader))
                {
                    var unmarshaller = InvestigationActorUnmarshaller.Instance;
                    unmarshalledObject.Actor = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("affectedBucket", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AffectedBucket = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("api", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Api = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("enrichment", targetDepth, ref reader))
                {
                    var unmarshaller = EnrichmentUnmarshaller.Instance;
                    unmarshalledObject.Enrichment = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("eventCount", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.EventCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("nonS3Activity", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NonS3Activity = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("otherS3Activity", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OtherS3Activity = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("sessionAssessment", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SessionAssessment = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("sourceIp", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceIp = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static S3ActivityUnmarshaller _instance = new S3ActivityUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static S3ActivityUnmarshaller Instance => _instance;
    }
}
