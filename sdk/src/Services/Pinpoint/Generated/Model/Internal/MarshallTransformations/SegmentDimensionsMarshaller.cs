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
    /// SegmentDimensions Marshaller
    /// </summary>
    public class SegmentDimensionsMarshaller : IRequestMarshaller<SegmentDimensions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SegmentDimensions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAttributes())
            {
                context.Writer.WritePropertyName("Attributes");
                context.Writer.WriteStartObject();
                foreach (var requestObjectAttributesKvp in requestObject.Attributes)
                {
                    context.Writer.WritePropertyName(requestObjectAttributesKvp.Key);
                    var requestObjectAttributesValue = requestObjectAttributesKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = AttributeDimensionMarshaller.Instance;
                    marshaller.Marshall(requestObjectAttributesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBehavior())
            {
                context.Writer.WritePropertyName("Behavior");
                context.Writer.WriteStartObject();

                var marshaller = SegmentBehaviorsMarshaller.Instance;
                marshaller.Marshall(requestObject.Behavior, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDemographic())
            {
                context.Writer.WritePropertyName("Demographic");
                context.Writer.WriteStartObject();

                var marshaller = SegmentDemographicsMarshaller.Instance;
                marshaller.Marshall(requestObject.Demographic, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLocation())
            {
                context.Writer.WritePropertyName("Location");
                context.Writer.WriteStartObject();

                var marshaller = SegmentLocationMarshaller.Instance;
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

                    context.Writer.WriteStartObject();

                    var marshaller = MetricDimensionMarshaller.Instance;
                    marshaller.Marshall(requestObjectMetricsValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetUserAttributes())
            {
                context.Writer.WritePropertyName("UserAttributes");
                context.Writer.WriteStartObject();
                foreach (var requestObjectUserAttributesKvp in requestObject.UserAttributes)
                {
                    context.Writer.WritePropertyName(requestObjectUserAttributesKvp.Key);
                    var requestObjectUserAttributesValue = requestObjectUserAttributesKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = AttributeDimensionMarshaller.Instance;
                    marshaller.Marshall(requestObjectUserAttributesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SegmentDimensionsMarshaller Instance = new SegmentDimensionsMarshaller();

    }
}