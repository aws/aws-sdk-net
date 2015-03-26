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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpsWorks.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AutoScalingThresholds Marshaller
    /// </summary>       
    public class AutoScalingThresholdsMarshaller : IRequestMarshaller<AutoScalingThresholds, JsonMarshallerContext> 
    {
        public void Marshall(AutoScalingThresholds requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCpuThreshold())
            {
                context.Writer.WritePropertyName("CpuThreshold");
                context.Writer.Write(requestObject.CpuThreshold);
            }

            if(requestObject.IsSetIgnoreMetricsTime())
            {
                context.Writer.WritePropertyName("IgnoreMetricsTime");
                context.Writer.Write(requestObject.IgnoreMetricsTime);
            }

            if(requestObject.IsSetInstanceCount())
            {
                context.Writer.WritePropertyName("InstanceCount");
                context.Writer.Write(requestObject.InstanceCount);
            }

            if(requestObject.IsSetLoadThreshold())
            {
                context.Writer.WritePropertyName("LoadThreshold");
                context.Writer.Write(requestObject.LoadThreshold);
            }

            if(requestObject.IsSetMemoryThreshold())
            {
                context.Writer.WritePropertyName("MemoryThreshold");
                context.Writer.Write(requestObject.MemoryThreshold);
            }

            if(requestObject.IsSetThresholdsWaitTime())
            {
                context.Writer.WritePropertyName("ThresholdsWaitTime");
                context.Writer.Write(requestObject.ThresholdsWaitTime);
            }

        }

        public readonly static AutoScalingThresholdsMarshaller Instance = new AutoScalingThresholdsMarshaller();

    }
}