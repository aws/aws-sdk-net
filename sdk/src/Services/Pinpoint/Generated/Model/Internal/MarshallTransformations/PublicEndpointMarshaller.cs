/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetAddress())
            {
                context.Writer.WritePropertyName("Address");
                context.Writer.Write(requestObject.Address);
            }

            if(requestObject.IsSetAttributes())
            {
                context.Writer.WritePropertyName("Attributes");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectAttributesKvp in requestObject.Attributes)
                {
                    context.Writer.WritePropertyName(requestObjectAttributesKvp.Key);
                    var requestObjectAttributesValue = requestObjectAttributesKvp.Value;

                    context.Writer.WriteArrayStart();
                    foreach(var requestObjectAttributesValueListValue in requestObjectAttributesValue)
                    {
                            context.Writer.Write(requestObjectAttributesValueListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetChannelType())
            {
                context.Writer.WritePropertyName("ChannelType");
                context.Writer.Write(requestObject.ChannelType);
            }

            if(requestObject.IsSetDemographic())
            {
                context.Writer.WritePropertyName("Demographic");
                context.Writer.WriteObjectStart();

                var marshaller = EndpointDemographicMarshaller.Instance;
                marshaller.Marshall(requestObject.Demographic, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEffectiveDate())
            {
                context.Writer.WritePropertyName("EffectiveDate");
                context.Writer.Write(requestObject.EffectiveDate);
            }

            if(requestObject.IsSetEndpointStatus())
            {
                context.Writer.WritePropertyName("EndpointStatus");
                context.Writer.Write(requestObject.EndpointStatus);
            }

            if(requestObject.IsSetLocation())
            {
                context.Writer.WritePropertyName("Location");
                context.Writer.WriteObjectStart();

                var marshaller = EndpointLocationMarshaller.Instance;
                marshaller.Marshall(requestObject.Location, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMetrics())
            {
                context.Writer.WritePropertyName("Metrics");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectMetricsKvp in requestObject.Metrics)
                {
                    context.Writer.WritePropertyName(requestObjectMetricsKvp.Key);
                    var requestObjectMetricsValue = requestObjectMetricsKvp.Value;

                        context.Writer.Write(requestObjectMetricsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOptOut())
            {
                context.Writer.WritePropertyName("OptOut");
                context.Writer.Write(requestObject.OptOut);
            }

            if(requestObject.IsSetRequestId())
            {
                context.Writer.WritePropertyName("RequestId");
                context.Writer.Write(requestObject.RequestId);
            }

            if(requestObject.IsSetUser())
            {
                context.Writer.WritePropertyName("User");
                context.Writer.WriteObjectStart();

                var marshaller = EndpointUserMarshaller.Instance;
                marshaller.Marshall(requestObject.User, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static PublicEndpointMarshaller Instance = new PublicEndpointMarshaller();

    }
}