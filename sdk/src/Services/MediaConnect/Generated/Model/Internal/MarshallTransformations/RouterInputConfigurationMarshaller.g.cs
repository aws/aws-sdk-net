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

using Amazon.MediaConnect.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.MediaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RouterInputConfiguration Marshaller
    /// </summary>
    public partial class RouterInputConfigurationMarshaller : IRequestMarshaller<RouterInputConfiguration, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(RouterInputConfiguration requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetFailover())
            {
                context.Writer.WritePropertyName("failover");
                context.Writer.WriteStartObject();

                var marshaller = FailoverRouterInputConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Failover, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetMediaConnectFlow())
            {
                context.Writer.WritePropertyName("mediaConnectFlow");
                context.Writer.WriteStartObject();

                var marshaller = MediaConnectFlowRouterInputConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.MediaConnectFlow, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetMediaLiveChannel())
            {
                context.Writer.WritePropertyName("mediaLiveChannel");
                context.Writer.WriteStartObject();

                var marshaller = MediaLiveChannelRouterInputConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.MediaLiveChannel, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetMerge())
            {
                context.Writer.WritePropertyName("merge");
                context.Writer.WriteStartObject();

                var marshaller = MergeRouterInputConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Merge, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetStandard())
            {
                context.Writer.WritePropertyName("standard");
                context.Writer.WriteStartObject();

                var marshaller = StandardRouterInputConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Standard, context);

                context.Writer.WriteEndObject();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static RouterInputConfigurationMarshaller Instance = new RouterInputConfigurationMarshaller();
    }
}
