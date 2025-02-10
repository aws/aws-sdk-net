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
    /// PipeSourceParameters Marshaller
    /// </summary>
    public class PipeSourceParametersMarshaller : IRequestMarshaller<PipeSourceParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PipeSourceParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetActiveMQBrokerParameters())
            {
                context.Writer.WritePropertyName("ActiveMQBrokerParameters");
                context.Writer.WriteStartObject();

                var marshaller = PipeSourceActiveMQBrokerParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.ActiveMQBrokerParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDynamoDBStreamParameters())
            {
                context.Writer.WritePropertyName("DynamoDBStreamParameters");
                context.Writer.WriteStartObject();

                var marshaller = PipeSourceDynamoDBStreamParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.DynamoDBStreamParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFilterCriteria())
            {
                context.Writer.WritePropertyName("FilterCriteria");
                context.Writer.WriteStartObject();

                var marshaller = FilterCriteriaMarshaller.Instance;
                marshaller.Marshall(requestObject.FilterCriteria, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetKinesisStreamParameters())
            {
                context.Writer.WritePropertyName("KinesisStreamParameters");
                context.Writer.WriteStartObject();

                var marshaller = PipeSourceKinesisStreamParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.KinesisStreamParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetManagedStreamingKafkaParameters())
            {
                context.Writer.WritePropertyName("ManagedStreamingKafkaParameters");
                context.Writer.WriteStartObject();

                var marshaller = PipeSourceManagedStreamingKafkaParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.ManagedStreamingKafkaParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRabbitMQBrokerParameters())
            {
                context.Writer.WritePropertyName("RabbitMQBrokerParameters");
                context.Writer.WriteStartObject();

                var marshaller = PipeSourceRabbitMQBrokerParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.RabbitMQBrokerParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSelfManagedKafkaParameters())
            {
                context.Writer.WritePropertyName("SelfManagedKafkaParameters");
                context.Writer.WriteStartObject();

                var marshaller = PipeSourceSelfManagedKafkaParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.SelfManagedKafkaParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSqsQueueParameters())
            {
                context.Writer.WritePropertyName("SqsQueueParameters");
                context.Writer.WriteStartObject();

                var marshaller = PipeSourceSqsQueueParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.SqsQueueParameters, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PipeSourceParametersMarshaller Instance = new PipeSourceParametersMarshaller();

    }
}