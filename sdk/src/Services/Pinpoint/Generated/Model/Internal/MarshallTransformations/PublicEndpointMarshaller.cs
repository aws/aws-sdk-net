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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pinpoint.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PublicEndpoint Marshaller
    /// </summary>
    public class PublicEndpointMarshaller : IRequestMarshaller<PublicEndpoint, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PublicEndpoint requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAddress())
            {
                context.Writer.WritePropertyName("Address");
                context.Writer.WriteStringValue(requestObject.Address);
            }

            if(requestObject.IsSetAttributes())
            {
                context.Writer.WritePropertyName("Attributes");
                context.Writer.WriteStartObject();
                foreach (var requestObjectAttributesKvp in requestObject.Attributes)
                {
                    context.Writer.WritePropertyName(requestObjectAttributesKvp.Key);
                    var requestObjectAttributesValue = requestObjectAttributesKvp.Value;

                    context.Writer.WriteStartArray();
                    foreach(var requestObjectAttributesValueListValue in requestObjectAttributesValue)
                    {
                            context.Writer.WriteStringValue(requestObjectAttributesValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetChannelType())
            {
                context.Writer.WritePropertyName("ChannelType");
                context.Writer.WriteStringValue(requestObject.ChannelType);
            }

            if(requestObject.IsSetDemographic())
            {
                context.Writer.WritePropertyName("Demographic");
                context.Writer.WriteStartObject();

                var marshaller = EndpointDemographicMarshaller.Instance;
                marshaller.Marshall(requestObject.Demographic, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEffectiveDate())
            {
                context.Writer.WritePropertyName("EffectiveDate");
                context.Writer.WriteStringValue(requestObject.EffectiveDate);
            }

            if(requestObject.IsSetEndpointStatus())
            {
                context.Writer.WritePropertyName("EndpointStatus");
                context.Writer.WriteStringValue(requestObject.EndpointStatus);
            }

            if(requestObject.IsSetLocation())
            {
                context.Writer.WritePropertyName("Location");
                context.Writer.WriteStartObject();

                var marshaller = EndpointLocationMarshaller.Instance;
                marshaller.Marshall(requestObject.Location, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMetrics())
            {
                context.Writer.WritePropertyName("Metrics");
                context.Writer.WriteStartObject();
                foreach (var requestObjectMetricsKvp in requestObject.Metrics)
                {
                    context.Writer.WritePropertyName(requestObjectMetricsKvp.Key);
                    var requestObjectMetricsValue = requestObjectMetricsKvp.Value;

                        context.Writer.WriteNumberValue(requestObjectMetricsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOptOut())
            {
                context.Writer.WritePropertyName("OptOut");
                context.Writer.WriteStringValue(requestObject.OptOut);
            }

            if(requestObject.IsSetRequestId())
            {
                context.Writer.WritePropertyName("RequestId");
                context.Writer.WriteStringValue(requestObject.RequestId);
            }

            if(requestObject.IsSetUser())
            {
                context.Writer.WritePropertyName("User");
                context.Writer.WriteStartObject();

                var marshaller = EndpointUserMarshaller.Instance;
                marshaller.Marshall(requestObject.User, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PublicEndpointMarshaller Instance = new PublicEndpointMarshaller();

    }
}