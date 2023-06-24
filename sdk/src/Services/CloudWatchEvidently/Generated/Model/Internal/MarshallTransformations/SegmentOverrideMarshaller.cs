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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchEvidently.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CloudWatchEvidently.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SegmentOverride Marshaller
    /// </summary>
    public class SegmentOverrideMarshaller : IRequestMarshaller<SegmentOverride, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SegmentOverride requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetEvaluationOrder())
            {
                context.Writer.WritePropertyName("evaluationOrder");
                context.Writer.Write(requestObject.EvaluationOrder);
            }

            if(requestObject.IsSetSegment())
            {
                context.Writer.WritePropertyName("segment");
                context.Writer.Write(requestObject.Segment);
            }

            if(requestObject.IsSetWeights())
            {
                context.Writer.WritePropertyName("weights");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectWeightsKvp in requestObject.Weights)
                {
                    context.Writer.WritePropertyName(requestObjectWeightsKvp.Key);
                    var requestObjectWeightsValue = requestObjectWeightsKvp.Value;

                        context.Writer.Write(requestObjectWeightsValue);
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SegmentOverrideMarshaller Instance = new SegmentOverrideMarshaller();

    }
}