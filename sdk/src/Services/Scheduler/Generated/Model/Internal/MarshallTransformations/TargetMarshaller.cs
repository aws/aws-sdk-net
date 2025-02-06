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
 * Do not modify this file. This file is generated from the scheduler-2021-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Scheduler.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Scheduler.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Target Marshaller
    /// </summary>
    public class TargetMarshaller : IRequestMarshaller<Target, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Target requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetArn())
            {
                context.Writer.WritePropertyName("Arn");
                context.Writer.WriteStringValue(requestObject.Arn);
            }

            if(requestObject.IsSetDeadLetterConfig())
            {
                context.Writer.WritePropertyName("DeadLetterConfig");
                context.Writer.WriteStartObject();

                var marshaller = DeadLetterConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.DeadLetterConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEcsParameters())
            {
                context.Writer.WritePropertyName("EcsParameters");
                context.Writer.WriteStartObject();

                var marshaller = EcsParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.EcsParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEventBridgeParameters())
            {
                context.Writer.WritePropertyName("EventBridgeParameters");
                context.Writer.WriteStartObject();

                var marshaller = EventBridgeParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.EventBridgeParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInput())
            {
                context.Writer.WritePropertyName("Input");
                context.Writer.WriteStringValue(requestObject.Input);
            }

            if(requestObject.IsSetKinesisParameters())
            {
                context.Writer.WritePropertyName("KinesisParameters");
                context.Writer.WriteStartObject();

                var marshaller = KinesisParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.KinesisParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRetryPolicy())
            {
                context.Writer.WritePropertyName("RetryPolicy");
                context.Writer.WriteStartObject();

                var marshaller = RetryPolicyMarshaller.Instance;
                marshaller.Marshall(requestObject.RetryPolicy, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.WriteStringValue(requestObject.RoleArn);
            }

            if(requestObject.IsSetSageMakerPipelineParameters())
            {
                context.Writer.WritePropertyName("SageMakerPipelineParameters");
                context.Writer.WriteStartObject();

                var marshaller = SageMakerPipelineParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.SageMakerPipelineParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSqsParameters())
            {
                context.Writer.WritePropertyName("SqsParameters");
                context.Writer.WriteStartObject();

                var marshaller = SqsParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.SqsParameters, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TargetMarshaller Instance = new TargetMarshaller();

    }
}