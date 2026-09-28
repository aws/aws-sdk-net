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

using Amazon.PersonalizeEvents.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.PersonalizeEvents.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ActionInteraction Marshaller
    /// </summary>
    public partial class ActionInteractionMarshaller : IRequestMarshaller<ActionInteraction, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ActionInteraction requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetActionId())
            {
                context.Writer.WritePropertyName("actionId");
                context.Writer.WriteStringValue(requestObject.ActionId);
            }

            if (requestObject.IsSetEventId())
            {
                context.Writer.WritePropertyName("eventId");
                context.Writer.WriteStringValue(requestObject.EventId);
            }

            if (requestObject.IsSetEventType())
            {
                context.Writer.WritePropertyName("eventType");
                context.Writer.WriteStringValue(requestObject.EventType);
            }

            if (requestObject.IsSetImpression())
            {
                context.Writer.WritePropertyName("impression");
                context.Writer.WriteStartArray();
                foreach (var requestObjectImpressionListValue in requestObject.Impression)
                {
                    context.Writer.WriteStringValue(requestObjectImpressionListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetProperties())
            {
                context.Writer.WritePropertyName("properties");
                context.Writer.WriteStringValue(requestObject.Properties);
            }

            if (requestObject.IsSetRecommendationId())
            {
                context.Writer.WritePropertyName("recommendationId");
                context.Writer.WriteStringValue(requestObject.RecommendationId);
            }

            if (requestObject.IsSetSessionId())
            {
                context.Writer.WritePropertyName("sessionId");
                context.Writer.WriteStringValue(requestObject.SessionId);
            }

            if (requestObject.IsSetTimestamp())
            {
                context.Writer.WritePropertyName("timestamp");
                context.Writer.WriteNumberValue(Amazon.Util.AWSSDKUtils.ConvertToUnixEpochSecondsDecimal(requestObject.Timestamp.Value));
            }

            if (requestObject.IsSetUserId())
            {
                context.Writer.WritePropertyName("userId");
                context.Writer.WriteStringValue(requestObject.UserId);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ActionInteractionMarshaller Instance = new ActionInteractionMarshaller();
    }
}
