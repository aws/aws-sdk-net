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

using Amazon.PartnerCentralSelling.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.PartnerCentralSelling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ChannelRecommendation Marshaller
    /// </summary>
    public partial class ChannelRecommendationMarshaller : IRequestMarshaller<ChannelRecommendation, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ChannelRecommendation requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetBestOutreachWindows())
            {
                context.Writer.WritePropertyName("BestOutreachWindows");
                context.Writer.WriteStartArray();
                foreach (var requestObjectBestOutreachWindowsListValue in requestObject.BestOutreachWindows)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = BestOutreachWindowMarshaller.Instance;
                    marshaller.Marshall(requestObjectBestOutreachWindowsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetRecommendedChannel())
            {
                context.Writer.WritePropertyName("RecommendedChannel");
                context.Writer.WriteStringValue(requestObject.RecommendedChannel);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ChannelRecommendationMarshaller Instance = new ChannelRecommendationMarshaller();
    }
}
