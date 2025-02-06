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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EventBridge.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EventBridge.Model.Internal.MarshallTransformations
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
            if(requestObject.IsSetAppSyncParameters())
            {
                context.Writer.WritePropertyName("AppSyncParameters");
                context.Writer.WriteStartObject();

                var marshaller = AppSyncParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.AppSyncParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetArn())
            {
                context.Writer.WritePropertyName("Arn");
                context.Writer.WriteStringValue(requestObject.Arn);
            }

            if(requestObject.IsSetBatchParameters())
            {
                context.Writer.WritePropertyName("BatchParameters");
                context.Writer.WriteStartObject();

                var marshaller = BatchParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.BatchParameters, context);

                context.Writer.WriteEndObject();
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

            if(requestObject.IsSetHttpParameters())
            {
                context.Writer.WritePropertyName("HttpParameters");
                context.Writer.WriteStartObject();

                var marshaller = HttpParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.HttpParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("Id");
                context.Writer.WriteStringValue(requestObject.Id);
            }

            if(requestObject.IsSetInput())
            {
                context.Writer.WritePropertyName("Input");
                context.Writer.WriteStringValue(requestObject.Input);
            }

            if(requestObject.IsSetInputPath())
            {
                context.Writer.WritePropertyName("InputPath");
                context.Writer.WriteStringValue(requestObject.InputPath);
            }

            if(requestObject.IsSetInputTransformer())
            {
                context.Writer.WritePropertyName("InputTransformer");
                context.Writer.WriteStartObject();

                var marshaller = InputTransformerMarshaller.Instance;
                marshaller.Marshall(requestObject.InputTransformer, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetKinesisParameters())
            {
                context.Writer.WritePropertyName("KinesisParameters");
                context.Writer.WriteStartObject();

                var marshaller = KinesisParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.KinesisParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRedshiftDataParameters())
            {
                context.Writer.WritePropertyName("RedshiftDataParameters");
                context.Writer.WriteStartObject();

                var marshaller = RedshiftDataParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.RedshiftDataParameters, context);

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

            if(requestObject.IsSetRunCommandParameters())
            {
                context.Writer.WritePropertyName("RunCommandParameters");
                context.Writer.WriteStartObject();

                var marshaller = RunCommandParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.RunCommandParameters, context);

                context.Writer.WriteEndObject();
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