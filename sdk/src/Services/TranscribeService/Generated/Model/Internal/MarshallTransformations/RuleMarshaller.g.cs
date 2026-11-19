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

using Amazon.TranscribeService.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.TranscribeService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Rule Marshaller
    /// </summary>
    public partial class RuleMarshaller : IRequestMarshaller<Rule, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(Rule requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetInterruptionFilter())
            {
                context.Writer.WriteTextString("InterruptionFilter");
                context.Writer.WriteStartMap(null);

                var marshaller = InterruptionFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.InterruptionFilter, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetNonTalkTimeFilter())
            {
                context.Writer.WriteTextString("NonTalkTimeFilter");
                context.Writer.WriteStartMap(null);

                var marshaller = NonTalkTimeFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.NonTalkTimeFilter, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetSentimentFilter())
            {
                context.Writer.WriteTextString("SentimentFilter");
                context.Writer.WriteStartMap(null);

                var marshaller = SentimentFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.SentimentFilter, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetTranscriptFilter())
            {
                context.Writer.WriteTextString("TranscriptFilter");
                context.Writer.WriteStartMap(null);

                var marshaller = TranscriptFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.TranscriptFilter, context);

                context.Writer.WriteEndMap();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static RuleMarshaller Instance = new RuleMarshaller();
    }
}
