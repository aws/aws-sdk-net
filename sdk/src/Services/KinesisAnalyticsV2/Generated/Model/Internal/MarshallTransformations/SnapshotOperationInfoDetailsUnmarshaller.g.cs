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

using Amazon.KinesisAnalyticsV2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.KinesisAnalyticsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SnapshotOperationInfoDetails Object
    /// </summary>
    public partial class SnapshotOperationInfoDetailsUnmarshaller : IJsonUnmarshaller<SnapshotOperationInfoDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public SnapshotOperationInfoDetails Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new SnapshotOperationInfoDetails();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("ApplicationOperationDescription", targetDepth, ref reader))
                {
                    var unmarshaller = ApplicationOperationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.ApplicationOperationDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("DestinationEncryptionConfigurationDescription", targetDepth, ref reader))
                {
                    var unmarshaller = EncryptionConfigurationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.DestinationEncryptionConfigurationDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("EndTime", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.EndTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("SnapshotArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SnapshotArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("SnapshotDestinationLocationDescription", targetDepth, ref reader))
                {
                    var unmarshaller = SnapshotOperationLocationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.SnapshotDestinationLocationDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("SnapshotOperation", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SnapshotOperation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("SnapshotOperationFailureDetails", targetDepth, ref reader))
                {
                    var unmarshaller = SnapshotOperationFailureDetailsUnmarshaller.Instance;
                    unmarshalledObject.SnapshotOperationFailureDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("SnapshotOperationId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SnapshotOperationId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("SnapshotOperationStatus", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SnapshotOperationStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("SnapshotSourceLocationDescription", targetDepth, ref reader))
                {
                    var unmarshaller = SnapshotOperationLocationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.SnapshotSourceLocationDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("SourceEncryptionConfigurationDescription", targetDepth, ref reader))
                {
                    var unmarshaller = EncryptionConfigurationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.SourceEncryptionConfigurationDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("StartTime", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static SnapshotOperationInfoDetailsUnmarshaller _instance = new SnapshotOperationInfoDetailsUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static SnapshotOperationInfoDetailsUnmarshaller Instance => _instance;
    }
}
