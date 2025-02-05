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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Scte35SegmentationDescriptor Object
    /// </summary>  
    public class Scte35SegmentationDescriptorUnmarshaller : IJsonUnmarshaller<Scte35SegmentationDescriptor, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Scte35SegmentationDescriptor Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Scte35SegmentationDescriptor unmarshalledObject = new Scte35SegmentationDescriptor();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("deliveryRestrictions", targetDepth))
                {
                    var unmarshaller = Scte35DeliveryRestrictionsUnmarshaller.Instance;
                    unmarshalledObject.DeliveryRestrictions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("segmentationCancelIndicator", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SegmentationCancelIndicator = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("segmentationDuration", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.SegmentationDuration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("segmentationEventId", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.SegmentationEventId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("segmentationTypeId", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.SegmentationTypeId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("segmentationUpid", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SegmentationUpid = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("segmentationUpidType", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.SegmentationUpidType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("segmentNum", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.SegmentNum = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("segmentsExpected", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.SegmentsExpected = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("subSegmentNum", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.SubSegmentNum = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("subSegmentsExpected", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.SubSegmentsExpected = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static Scte35SegmentationDescriptorUnmarshaller _instance = new Scte35SegmentationDescriptorUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static Scte35SegmentationDescriptorUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}