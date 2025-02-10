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
 * Do not modify this file. This file is generated from the kafkaconnect-2021-09-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KafkaConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.KafkaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AutoScalingUpdate Marshaller
    /// </summary>
    public class AutoScalingUpdateMarshaller : IRequestMarshaller<AutoScalingUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AutoScalingUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetMaxWorkerCount())
            {
                context.Writer.WritePropertyName("maxWorkerCount");
                context.Writer.WriteNumberValue(requestObject.MaxWorkerCount.Value);
            }

            if(requestObject.IsSetMcuCount())
            {
                context.Writer.WritePropertyName("mcuCount");
                context.Writer.WriteNumberValue(requestObject.McuCount.Value);
            }

            if(requestObject.IsSetMinWorkerCount())
            {
                context.Writer.WritePropertyName("minWorkerCount");
                context.Writer.WriteNumberValue(requestObject.MinWorkerCount.Value);
            }

            if(requestObject.IsSetScaleInPolicy())
            {
                context.Writer.WritePropertyName("scaleInPolicy");
                context.Writer.WriteStartObject();

                var marshaller = ScaleInPolicyUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.ScaleInPolicy, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetScaleOutPolicy())
            {
                context.Writer.WritePropertyName("scaleOutPolicy");
                context.Writer.WriteStartObject();

                var marshaller = ScaleOutPolicyUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.ScaleOutPolicy, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AutoScalingUpdateMarshaller Instance = new AutoScalingUpdateMarshaller();

    }
}