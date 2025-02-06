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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// KafkaStreamingSourceOptions Marshaller
    /// </summary>
    public class KafkaStreamingSourceOptionsMarshaller : IRequestMarshaller<KafkaStreamingSourceOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(KafkaStreamingSourceOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAddRecordTimestamp())
            {
                context.Writer.WritePropertyName("AddRecordTimestamp");
                context.Writer.WriteStringValue(requestObject.AddRecordTimestamp);
            }

            if(requestObject.IsSetAssign())
            {
                context.Writer.WritePropertyName("Assign");
                context.Writer.WriteStringValue(requestObject.Assign);
            }

            if(requestObject.IsSetBootstrapServers())
            {
                context.Writer.WritePropertyName("BootstrapServers");
                context.Writer.WriteStringValue(requestObject.BootstrapServers);
            }

            if(requestObject.IsSetClassification())
            {
                context.Writer.WritePropertyName("Classification");
                context.Writer.WriteStringValue(requestObject.Classification);
            }

            if(requestObject.IsSetConnectionName())
            {
                context.Writer.WritePropertyName("ConnectionName");
                context.Writer.WriteStringValue(requestObject.ConnectionName);
            }

            if(requestObject.IsSetDelimiter())
            {
                context.Writer.WritePropertyName("Delimiter");
                context.Writer.WriteStringValue(requestObject.Delimiter);
            }

            if(requestObject.IsSetEmitConsumerLagMetrics())
            {
                context.Writer.WritePropertyName("EmitConsumerLagMetrics");
                context.Writer.WriteStringValue(requestObject.EmitConsumerLagMetrics);
            }

            if(requestObject.IsSetEndingOffsets())
            {
                context.Writer.WritePropertyName("EndingOffsets");
                context.Writer.WriteStringValue(requestObject.EndingOffsets);
            }

            if(requestObject.IsSetIncludeHeaders())
            {
                context.Writer.WritePropertyName("IncludeHeaders");
                context.Writer.WriteBooleanValue(requestObject.IncludeHeaders.Value);
            }

            if(requestObject.IsSetMaxOffsetsPerTrigger())
            {
                context.Writer.WritePropertyName("MaxOffsetsPerTrigger");
                context.Writer.WriteNumberValue(requestObject.MaxOffsetsPerTrigger.Value);
            }

            if(requestObject.IsSetMinPartitions())
            {
                context.Writer.WritePropertyName("MinPartitions");
                context.Writer.WriteNumberValue(requestObject.MinPartitions.Value);
            }

            if(requestObject.IsSetNumRetries())
            {
                context.Writer.WritePropertyName("NumRetries");
                context.Writer.WriteNumberValue(requestObject.NumRetries.Value);
            }

            if(requestObject.IsSetPollTimeoutMs())
            {
                context.Writer.WritePropertyName("PollTimeoutMs");
                context.Writer.WriteNumberValue(requestObject.PollTimeoutMs.Value);
            }

            if(requestObject.IsSetRetryIntervalMs())
            {
                context.Writer.WritePropertyName("RetryIntervalMs");
                context.Writer.WriteNumberValue(requestObject.RetryIntervalMs.Value);
            }

            if(requestObject.IsSetSecurityProtocol())
            {
                context.Writer.WritePropertyName("SecurityProtocol");
                context.Writer.WriteStringValue(requestObject.SecurityProtocol);
            }

            if(requestObject.IsSetStartingOffsets())
            {
                context.Writer.WritePropertyName("StartingOffsets");
                context.Writer.WriteStringValue(requestObject.StartingOffsets);
            }

            if(requestObject.IsSetStartingTimestamp())
            {
                context.Writer.WritePropertyName("StartingTimestamp");
                context.Writer.WriteStringValue(StringUtils.FromDateTimeToISO8601WithOptionalMs(requestObject.StartingTimestamp));
            }

            if(requestObject.IsSetSubscribePattern())
            {
                context.Writer.WritePropertyName("SubscribePattern");
                context.Writer.WriteStringValue(requestObject.SubscribePattern);
            }

            if(requestObject.IsSetTopicName())
            {
                context.Writer.WritePropertyName("TopicName");
                context.Writer.WriteStringValue(requestObject.TopicName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static KafkaStreamingSourceOptionsMarshaller Instance = new KafkaStreamingSourceOptionsMarshaller();

    }
}