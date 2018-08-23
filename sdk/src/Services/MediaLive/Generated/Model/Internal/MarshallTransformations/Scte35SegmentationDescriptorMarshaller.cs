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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetDeliveryRestrictions())
            {
                context.Writer.WritePropertyName("deliveryRestrictions");
                context.Writer.WriteObjectStart();

                var marshaller = Scte35DeliveryRestrictionsMarshaller.Instance;
                marshaller.Marshall(requestObject.DeliveryRestrictions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSegmentationCancelIndicator())
            {
                context.Writer.WritePropertyName("segmentationCancelIndicator");
                context.Writer.Write(requestObject.SegmentationCancelIndicator);
            }

            if(requestObject.IsSetSegmentationDuration())
            {
                context.Writer.WritePropertyName("segmentationDuration");
                context.Writer.Write(requestObject.SegmentationDuration);
            }

            if(requestObject.IsSetSegmentationEventId())
            {
                context.Writer.WritePropertyName("segmentationEventId");
                context.Writer.Write(requestObject.SegmentationEventId);
            }

            if(requestObject.IsSetSegmentationTypeId())
            {
                context.Writer.WritePropertyName("segmentationTypeId");
                context.Writer.Write(requestObject.SegmentationTypeId);
            }

            if(requestObject.IsSetSegmentationUpid())
            {
                context.Writer.WritePropertyName("segmentationUpid");
                context.Writer.Write(requestObject.SegmentationUpid);
            }

            if(requestObject.IsSetSegmentationUpidType())
            {
                context.Writer.WritePropertyName("segmentationUpidType");
                context.Writer.Write(requestObject.SegmentationUpidType);
            }

            if(requestObject.IsSetSegmentNum())
            {
                context.Writer.WritePropertyName("segmentNum");
                context.Writer.Write(requestObject.SegmentNum);
            }

            if(requestObject.IsSetSegmentsExpected())
            {
                context.Writer.WritePropertyName("segmentsExpected");
                context.Writer.Write(requestObject.SegmentsExpected);
            }

            if(requestObject.IsSetSubSegmentNum())
            {
                context.Writer.WritePropertyName("subSegmentNum");
                context.Writer.Write(requestObject.SubSegmentNum);
            }

            if(requestObject.IsSetSubSegmentsExpected())
            {
                context.Writer.WritePropertyName("subSegmentsExpected");
                context.Writer.Write(requestObject.SubSegmentsExpected);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static Scte35SegmentationDescriptorMarshaller Instance = new Scte35SegmentationDescriptorMarshaller();

    }
}