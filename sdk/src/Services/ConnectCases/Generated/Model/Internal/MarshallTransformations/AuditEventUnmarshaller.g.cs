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

using Amazon.ConnectCases.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.ConnectCases.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AuditEvent Object
    /// </summary>
    public partial class AuditEventUnmarshaller : IJsonUnmarshaller<AuditEvent, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public AuditEvent Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new AuditEvent();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("eventId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EventId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("fields", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<AuditEventField, AuditEventFieldUnmarshaller>(AuditEventFieldUnmarshaller.Instance);
                    unmarshalledObject.Fields = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("performedBy", targetDepth, ref reader))
                {
                    var unmarshaller = AuditEventPerformedByUnmarshaller.Instance;
                    unmarshalledObject.PerformedBy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("performedTime", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.PerformedTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("relatedItemType", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RelatedItemType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("type", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static AuditEventUnmarshaller _instance = new AuditEventUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AuditEventUnmarshaller Instance => _instance;
    }
}
