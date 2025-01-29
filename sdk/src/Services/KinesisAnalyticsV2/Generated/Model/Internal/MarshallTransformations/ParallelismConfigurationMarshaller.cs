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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisAnalyticsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.KinesisAnalyticsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ParallelismConfiguration Marshaller
    /// </summary>
    public class ParallelismConfigurationMarshaller : IRequestMarshaller<ParallelismConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ParallelismConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAutoScalingEnabled())
            {
                context.Writer.WritePropertyName("AutoScalingEnabled");
                context.Writer.WriteBooleanValue(requestObject.AutoScalingEnabled.Value);
            }

            if(requestObject.IsSetConfigurationType())
            {
                context.Writer.WritePropertyName("ConfigurationType");
                context.Writer.WriteStringValue(requestObject.ConfigurationType);
            }

            if(requestObject.IsSetParallelism())
            {
                context.Writer.WritePropertyName("Parallelism");
                context.Writer.WriteNumberValue(requestObject.Parallelism.Value);
            }

            if(requestObject.IsSetParallelismPerKPU())
            {
                context.Writer.WritePropertyName("ParallelismPerKPU");
                context.Writer.WriteNumberValue(requestObject.ParallelismPerKPU.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ParallelismConfigurationMarshaller Instance = new ParallelismConfigurationMarshaller();

    }
}