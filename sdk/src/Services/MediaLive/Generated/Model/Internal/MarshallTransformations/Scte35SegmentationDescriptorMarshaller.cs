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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Scte35SegmentationDescriptor Marshaller
    /// </summary>
    public class Scte35SegmentationDescriptorMarshaller : IRequestMarshaller<Scte35SegmentationDescriptor, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Scte35SegmentationDescriptor requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDeliveryRestrictions())
            {
                context.Writer.WritePropertyName("deliveryRestrictions");
                context.Writer.WriteStartObject();

                var marshaller = Scte35DeliveryRestrictionsMarshaller.Instance;
                marshaller.Marshall(requestObject.DeliveryRestrictions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSegmentationCancelIndicator())
            {
                context.Writer.WritePropertyName("segmentationCancelIndicator");
                context.Writer.WriteStringValue(requestObject.SegmentationCancelIndicator);
            }

            if(requestObject.IsSetSegmentationDuration())
            {
                context.Writer.WritePropertyName("segmentationDuration");
                context.Writer.WriteNumberValue(requestObject.SegmentationDuration.Value);
            }

            if(requestObject.IsSetSegmentationEventId())
            {
                context.Writer.WritePropertyName("segmentationEventId");
                context.Writer.WriteNumberValue(requestObject.SegmentationEventId.Value);
            }

            if(requestObject.IsSetSegmentationTypeId())
            {
                context.Writer.WritePropertyName("segmentationTypeId");
                context.Writer.WriteNumberValue(requestObject.SegmentationTypeId.Value);
            }

            if(requestObject.IsSetSegmentationUpid())
            {
                context.Writer.WritePropertyName("segmentationUpid");
                context.Writer.WriteStringValue(requestObject.SegmentationUpid);
            }

            if(requestObject.IsSetSegmentationUpidType())
            {
                context.Writer.WritePropertyName("segmentationUpidType");
                context.Writer.WriteNumberValue(requestObject.SegmentationUpidType.Value);
            }

            if(requestObject.IsSetSegmentNum())
            {
                context.Writer.WritePropertyName("segmentNum");
                context.Writer.WriteNumberValue(requestObject.SegmentNum.Value);
            }

            if(requestObject.IsSetSegmentsExpected())
            {
                context.Writer.WritePropertyName("segmentsExpected");
                context.Writer.WriteNumberValue(requestObject.SegmentsExpected.Value);
            }

            if(requestObject.IsSetSubSegmentNum())
            {
                context.Writer.WritePropertyName("subSegmentNum");
                context.Writer.WriteNumberValue(requestObject.SubSegmentNum.Value);
            }

            if(requestObject.IsSetSubSegmentsExpected())
            {
                context.Writer.WritePropertyName("subSegmentsExpected");
                context.Writer.WriteNumberValue(requestObject.SubSegmentsExpected.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static Scte35SegmentationDescriptorMarshaller Instance = new Scte35SegmentationDescriptorMarshaller();

    }
}