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
using ThirdParty.Json.LitJson;

namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SimpleCondition Marshaller
    /// </summary>       
    public class SimpleConditionMarshaller : IRequestMarshaller<SimpleCondition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SimpleCondition requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetEventCondition())
            {
                context.Writer.WritePropertyName("EventCondition");
                context.Writer.WriteObjectStart();

                var marshaller = EventConditionMarshaller.Instance;
                marshaller.Marshall(requestObject.EventCondition, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSegmentCondition())
            {
                context.Writer.WritePropertyName("SegmentCondition");
                context.Writer.WriteObjectStart();

                var marshaller = SegmentConditionMarshaller.Instance;
                marshaller.Marshall(requestObject.SegmentCondition, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSegmentDimensions())
            {
                context.Writer.WritePropertyName("segmentDimensions");
                context.Writer.WriteObjectStart();

                var marshaller = SegmentDimensionsMarshaller.Instance;
                marshaller.Marshall(requestObject.SegmentDimensions, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static SimpleConditionMarshaller Instance = new SimpleConditionMarshaller();

    }
}