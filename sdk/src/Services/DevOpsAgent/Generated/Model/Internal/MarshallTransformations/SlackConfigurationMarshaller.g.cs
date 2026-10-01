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

using Amazon.DevOpsAgent.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.DevOpsAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SlackConfiguration Marshaller
    /// </summary>
    public partial class SlackConfigurationMarshaller : IRequestMarshaller<SlackConfiguration, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(SlackConfiguration requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetBidirectional())
            {
                context.Writer.WritePropertyName("bidirectional");
                context.Writer.WriteStartObject();

                var marshaller = SlackBidirectionalConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Bidirectional, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetTransmissionTarget())
            {
                context.Writer.WritePropertyName("transmissionTarget");
                context.Writer.WriteStartObject();

                var marshaller = SlackTransmissionTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.TransmissionTarget, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetWorkspaceId())
            {
                context.Writer.WritePropertyName("workspaceId");
                context.Writer.WriteStringValue(requestObject.WorkspaceId);
            }

            if (requestObject.IsSetWorkspaceName())
            {
                context.Writer.WritePropertyName("workspaceName");
                context.Writer.WriteStringValue(requestObject.WorkspaceName);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static SlackConfigurationMarshaller Instance = new SlackConfigurationMarshaller();
    }
}
