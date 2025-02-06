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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaTailor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaTailor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SegmentationDescriptor Marshaller
    /// </summary>
    public class SegmentationDescriptorMarshaller : IRequestMarshaller<SegmentationDescriptor, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SegmentationDescriptor requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetSegmentationEventId())
            {
                context.Writer.WritePropertyName("SegmentationEventId");
                context.Writer.WriteNumberValue(requestObject.SegmentationEventId.Value);
            }

            if(requestObject.IsSetSegmentationTypeId())
            {
                context.Writer.WritePropertyName("SegmentationTypeId");
                context.Writer.WriteNumberValue(requestObject.SegmentationTypeId.Value);
            }

            if(requestObject.IsSetSegmentationUpid())
            {
                context.Writer.WritePropertyName("SegmentationUpid");
                context.Writer.WriteStringValue(requestObject.SegmentationUpid);
            }

            if(requestObject.IsSetSegmentationUpidType())
            {
                context.Writer.WritePropertyName("SegmentationUpidType");
                context.Writer.WriteNumberValue(requestObject.SegmentationUpidType.Value);
            }

            if(requestObject.IsSetSegmentNum())
            {
                context.Writer.WritePropertyName("SegmentNum");
                context.Writer.WriteNumberValue(requestObject.SegmentNum.Value);
            }

            if(requestObject.IsSetSegmentsExpected())
            {
                context.Writer.WritePropertyName("SegmentsExpected");
                context.Writer.WriteNumberValue(requestObject.SegmentsExpected.Value);
            }

            if(requestObject.IsSetSubSegmentNum())
            {
                context.Writer.WritePropertyName("SubSegmentNum");
                context.Writer.WriteNumberValue(requestObject.SubSegmentNum.Value);
            }

            if(requestObject.IsSetSubSegmentsExpected())
            {
                context.Writer.WritePropertyName("SubSegmentsExpected");
                context.Writer.WriteNumberValue(requestObject.SubSegmentsExpected.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SegmentationDescriptorMarshaller Instance = new SegmentationDescriptorMarshaller();

    }
}