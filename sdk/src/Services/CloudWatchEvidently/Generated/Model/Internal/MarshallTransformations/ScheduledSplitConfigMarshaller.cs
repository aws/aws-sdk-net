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
    /// ScheduledSplitConfig Marshaller
    /// </summary>
    public class ScheduledSplitConfigMarshaller : IRequestMarshaller<ScheduledSplitConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ScheduledSplitConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetGroupWeights())
            {
                context.Writer.WritePropertyName("groupWeights");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectGroupWeightsKvp in requestObject.GroupWeights)
                {
                    context.Writer.WritePropertyName(requestObjectGroupWeightsKvp.Key);
                    var requestObjectGroupWeightsValue = requestObjectGroupWeightsKvp.Value;

                        context.Writer.Write(requestObjectGroupWeightsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStartTime())
            {
                context.Writer.WritePropertyName("startTime");
                context.Writer.Write(requestObject.StartTime);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ScheduledSplitConfigMarshaller Instance = new ScheduledSplitConfigMarshaller();

    }
}