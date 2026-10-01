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

using Amazon.MediaTailor.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.MediaTailor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AdsPersonalizationTimeouts Marshaller
    /// </summary>
    public partial class AdsPersonalizationTimeoutsMarshaller : IRequestMarshaller<AdsPersonalizationTimeouts, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(AdsPersonalizationTimeouts requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAdsRequestTimeoutMilliseconds())
            {
                context.Writer.WritePropertyName("AdsRequestTimeoutMilliseconds");
                context.Writer.WriteNumberValue(requestObject.AdsRequestTimeoutMilliseconds.Value);
            }

            if (requestObject.IsSetLiveMaximumAdsPersonalizationTimeMilliseconds())
            {
                context.Writer.WritePropertyName("LiveMaximumAdsPersonalizationTimeMilliseconds");
                context.Writer.WriteNumberValue(requestObject.LiveMaximumAdsPersonalizationTimeMilliseconds.Value);
            }

            if (requestObject.IsSetPrefetchAdsRequestTimeoutMilliseconds())
            {
                context.Writer.WritePropertyName("PrefetchAdsRequestTimeoutMilliseconds");
                context.Writer.WriteNumberValue(requestObject.PrefetchAdsRequestTimeoutMilliseconds.Value);
            }

            if (requestObject.IsSetPrefetchMaximumAdsPersonalizationTimeMilliseconds())
            {
                context.Writer.WritePropertyName("PrefetchMaximumAdsPersonalizationTimeMilliseconds");
                context.Writer.WriteNumberValue(requestObject.PrefetchMaximumAdsPersonalizationTimeMilliseconds.Value);
            }

            if (requestObject.IsSetVodMaximumAdsPersonalizationTimeMilliseconds())
            {
                context.Writer.WritePropertyName("VodMaximumAdsPersonalizationTimeMilliseconds");
                context.Writer.WriteNumberValue(requestObject.VodMaximumAdsPersonalizationTimeMilliseconds.Value);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static AdsPersonalizationTimeoutsMarshaller Instance = new AdsPersonalizationTimeoutsMarshaller();
    }
}
