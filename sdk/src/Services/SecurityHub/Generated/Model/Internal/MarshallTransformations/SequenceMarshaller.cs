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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Sequence Marshaller
    /// </summary>
    public class SequenceMarshaller : IRequestMarshaller<Sequence, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Sequence requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetActors())
            {
                context.Writer.WritePropertyName("Actors");
                context.Writer.WriteStartArray();
                foreach(var requestObjectActorsListValue in requestObject.Actors)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ActorMarshaller.Instance;
                    marshaller.Marshall(requestObjectActorsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEndpoints())
            {
                context.Writer.WritePropertyName("Endpoints");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEndpointsListValue in requestObject.Endpoints)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = NetworkEndpointMarshaller.Instance;
                    marshaller.Marshall(requestObjectEndpointsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSequenceIndicators())
            {
                context.Writer.WritePropertyName("SequenceIndicators");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSequenceIndicatorsListValue in requestObject.SequenceIndicators)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = IndicatorMarshaller.Instance;
                    marshaller.Marshall(requestObjectSequenceIndicatorsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSignals())
            {
                context.Writer.WritePropertyName("Signals");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSignalsListValue in requestObject.Signals)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SignalMarshaller.Instance;
                    marshaller.Marshall(requestObjectSignalsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetUid())
            {
                context.Writer.WritePropertyName("Uid");
                context.Writer.WriteStringValue(requestObject.Uid);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SequenceMarshaller Instance = new SequenceMarshaller();

    }
}