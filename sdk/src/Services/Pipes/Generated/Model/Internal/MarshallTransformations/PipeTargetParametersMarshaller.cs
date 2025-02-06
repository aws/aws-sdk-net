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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pipes.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Pipes.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PipeTargetParameters Marshaller
    /// </summary>
    public class PipeTargetParametersMarshaller : IRequestMarshaller<PipeTargetParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PipeTargetParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBatchJobParameters())
            {
                context.Writer.WritePropertyName("BatchJobParameters");
                context.Writer.WriteStartObject();

                var marshaller = PipeTargetBatchJobParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.BatchJobParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCloudWatchLogsParameters())
            {
                context.Writer.WritePropertyName("CloudWatchLogsParameters");
                context.Writer.WriteStartObject();

                var marshaller = PipeTargetCloudWatchLogsParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.CloudWatchLogsParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEcsTaskParameters())
            {
                context.Writer.WritePropertyName("EcsTaskParameters");
                context.Writer.WriteStartObject();

                var marshaller = PipeTargetEcsTaskParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.EcsTaskParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEventBridgeEventBusParameters())
            {
                context.Writer.WritePropertyName("EventBridgeEventBusParameters");
                context.Writer.WriteStartObject();

                var marshaller = PipeTargetEventBridgeEventBusParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.EventBridgeEventBusParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHttpParameters())
            {
                context.Writer.WritePropertyName("HttpParameters");
                context.Writer.WriteStartObject();

                var marshaller = PipeTargetHttpParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.HttpParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInputTemplate())
            {
                context.Writer.WritePropertyName("InputTemplate");
                context.Writer.WriteStringValue(requestObject.InputTemplate);
            }

            if(requestObject.IsSetKinesisStreamParameters())
            {
                context.Writer.WritePropertyName("KinesisStreamParameters");
                context.Writer.WriteStartObject();

                var marshaller = PipeTargetKinesisStreamParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.KinesisStreamParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLambdaFunctionParameters())
            {
                context.Writer.WritePropertyName("LambdaFunctionParameters");
                context.Writer.WriteStartObject();

                var marshaller = PipeTargetLambdaFunctionParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.LambdaFunctionParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRedshiftDataParameters())
            {
                context.Writer.WritePropertyName("RedshiftDataParameters");
                context.Writer.WriteStartObject();

                var marshaller = PipeTargetRedshiftDataParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.RedshiftDataParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSageMakerPipelineParameters())
            {
                context.Writer.WritePropertyName("SageMakerPipelineParameters");
                context.Writer.WriteStartObject();

                var marshaller = PipeTargetSageMakerPipelineParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.SageMakerPipelineParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSqsQueueParameters())
            {
                context.Writer.WritePropertyName("SqsQueueParameters");
                context.Writer.WriteStartObject();

                var marshaller = PipeTargetSqsQueueParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.SqsQueueParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStepFunctionStateMachineParameters())
            {
                context.Writer.WritePropertyName("StepFunctionStateMachineParameters");
                context.Writer.WriteStartObject();

                var marshaller = PipeTargetStateMachineParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.StepFunctionStateMachineParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTimestreamParameters())
            {
                context.Writer.WritePropertyName("TimestreamParameters");
                context.Writer.WriteStartObject();

                var marshaller = PipeTargetTimestreamParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.TimestreamParameters, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PipeTargetParametersMarshaller Instance = new PipeTargetParametersMarshaller();

    }
}