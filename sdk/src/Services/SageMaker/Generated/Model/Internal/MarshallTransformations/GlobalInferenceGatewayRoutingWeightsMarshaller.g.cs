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

using Amazon.SageMaker.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GlobalInferenceGatewayRoutingWeights Marshaller
    /// </summary>
    public partial class GlobalInferenceGatewayRoutingWeightsMarshaller : IRequestMarshaller<GlobalInferenceGatewayRoutingWeights, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(GlobalInferenceGatewayRoutingWeights requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetErrorRate())
            {
                context.Writer.WritePropertyName("ErrorRate");
                if (StringUtils.IsSpecialFloatValue(requestObject.ErrorRate.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(requestObject.ErrorRate.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.ErrorRate.Value);
                }
            }

            if (requestObject.IsSetKVHeadroom())
            {
                context.Writer.WritePropertyName("KVHeadroom");
                if (StringUtils.IsSpecialFloatValue(requestObject.KVHeadroom.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(requestObject.KVHeadroom.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.KVHeadroom.Value);
                }
            }

            if (requestObject.IsSetQueueDepth())
            {
                context.Writer.WritePropertyName("QueueDepth");
                if (StringUtils.IsSpecialFloatValue(requestObject.QueueDepth.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(requestObject.QueueDepth.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.QueueDepth.Value);
                }
            }

            if (requestObject.IsSetRegionProximity())
            {
                context.Writer.WritePropertyName("RegionProximity");
                if (StringUtils.IsSpecialFloatValue(requestObject.RegionProximity.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(requestObject.RegionProximity.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.RegionProximity.Value);
                }
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static GlobalInferenceGatewayRoutingWeightsMarshaller Instance = new GlobalInferenceGatewayRoutingWeightsMarshaller();
    }
}
