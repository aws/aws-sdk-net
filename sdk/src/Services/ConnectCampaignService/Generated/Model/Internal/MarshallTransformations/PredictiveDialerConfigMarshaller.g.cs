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

using Amazon.ConnectCampaignService.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.ConnectCampaignService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PredictiveDialerConfig Marshaller
    /// </summary>
    public partial class PredictiveDialerConfigMarshaller : IRequestMarshaller<PredictiveDialerConfig, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(PredictiveDialerConfig requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetBandwidthAllocation())
            {
                context.Writer.WritePropertyName("bandwidthAllocation");
                if (StringUtils.IsSpecialDoubleValue(requestObject.BandwidthAllocation.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.BandwidthAllocation.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.BandwidthAllocation.Value);
                }
            }

            if (requestObject.IsSetDialingCapacity())
            {
                context.Writer.WritePropertyName("dialingCapacity");
                if (StringUtils.IsSpecialDoubleValue(requestObject.DialingCapacity.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.DialingCapacity.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.DialingCapacity.Value);
                }
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static PredictiveDialerConfigMarshaller Instance = new PredictiveDialerConfigMarshaller();
    }
}
