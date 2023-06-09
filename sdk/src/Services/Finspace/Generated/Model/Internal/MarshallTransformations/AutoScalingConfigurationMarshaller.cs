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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Finspace.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Finspace.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AutoScalingConfiguration Marshaller
    /// </summary>
    public class AutoScalingConfigurationMarshaller : IRequestMarshaller<AutoScalingConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AutoScalingConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAutoScalingMetric())
            {
                context.Writer.WritePropertyName("autoScalingMetric");
                context.Writer.Write(requestObject.AutoScalingMetric);
            }

            if(requestObject.IsSetMaxNodeCount())
            {
                context.Writer.WritePropertyName("maxNodeCount");
                context.Writer.Write(requestObject.MaxNodeCount);
            }

            if(requestObject.IsSetMetricTarget())
            {
                context.Writer.WritePropertyName("metricTarget");
                context.Writer.Write(requestObject.MetricTarget);
            }

            if(requestObject.IsSetMinNodeCount())
            {
                context.Writer.WritePropertyName("minNodeCount");
                context.Writer.Write(requestObject.MinNodeCount);
            }

            if(requestObject.IsSetScaleInCooldownSeconds())
            {
                context.Writer.WritePropertyName("scaleInCooldownSeconds");
                context.Writer.Write(requestObject.ScaleInCooldownSeconds);
            }

            if(requestObject.IsSetScaleOutCooldownSeconds())
            {
                context.Writer.WritePropertyName("scaleOutCooldownSeconds");
                context.Writer.Write(requestObject.ScaleOutCooldownSeconds);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AutoScalingConfigurationMarshaller Instance = new AutoScalingConfigurationMarshaller();

    }
}