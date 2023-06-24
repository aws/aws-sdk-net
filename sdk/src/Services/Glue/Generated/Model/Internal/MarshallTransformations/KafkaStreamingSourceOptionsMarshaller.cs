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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetAddRecordTimestamp())
            {
                context.Writer.WritePropertyName("AddRecordTimestamp");
                context.Writer.Write(requestObject.AddRecordTimestamp);
            }

            if(requestObject.IsSetAssign())
            {
                context.Writer.WritePropertyName("Assign");
                context.Writer.Write(requestObject.Assign);
            }

            if(requestObject.IsSetBootstrapServers())
            {
                context.Writer.WritePropertyName("BootstrapServers");
                context.Writer.Write(requestObject.BootstrapServers);
            }

            if(requestObject.IsSetClassification())
            {
                context.Writer.WritePropertyName("Classification");
                context.Writer.Write(requestObject.Classification);
            }

            if(requestObject.IsSetConnectionName())
            {
                context.Writer.WritePropertyName("ConnectionName");
                context.Writer.Write(requestObject.ConnectionName);
            }

            if(requestObject.IsSetDelimiter())
            {
                context.Writer.WritePropertyName("Delimiter");
                context.Writer.Write(requestObject.Delimiter);
            }

            if(requestObject.IsSetEmitConsumerLagMetrics())
            {
                context.Writer.WritePropertyName("EmitConsumerLagMetrics");
                context.Writer.Write(requestObject.EmitConsumerLagMetrics);
            }

            if(requestObject.IsSetEndingOffsets())
            {
                context.Writer.WritePropertyName("EndingOffsets");
                context.Writer.Write(requestObject.EndingOffsets);
            }

            if(requestObject.IsSetIncludeHeaders())
            {
                context.Writer.WritePropertyName("IncludeHeaders");
                context.Writer.Write(requestObject.IncludeHeaders);
            }

            if(requestObject.IsSetMaxOffsetsPerTrigger())
            {
                context.Writer.WritePropertyName("MaxOffsetsPerTrigger");
                context.Writer.Write(requestObject.MaxOffsetsPerTrigger);
            }

            if(requestObject.IsSetMinPartitions())
            {
                context.Writer.WritePropertyName("MinPartitions");
                context.Writer.Write(requestObject.MinPartitions);
            }

            if(requestObject.IsSetNumRetries())
            {
                context.Writer.WritePropertyName("NumRetries");
                context.Writer.Write(requestObject.NumRetries);
            }

            if(requestObject.IsSetPollTimeoutMs())
            {
                context.Writer.WritePropertyName("PollTimeoutMs");
                context.Writer.Write(requestObject.PollTimeoutMs);
            }

            if(requestObject.IsSetRetryIntervalMs())
            {
                context.Writer.WritePropertyName("RetryIntervalMs");
                context.Writer.Write(requestObject.RetryIntervalMs);
            }

            if(requestObject.IsSetSecurityProtocol())
            {
                context.Writer.WritePropertyName("SecurityProtocol");
                context.Writer.Write(requestObject.SecurityProtocol);
            }

            if(requestObject.IsSetStartingOffsets())
            {
                context.Writer.WritePropertyName("StartingOffsets");
                context.Writer.Write(requestObject.StartingOffsets);
            }

            if(requestObject.IsSetSubscribePattern())
            {
                context.Writer.WritePropertyName("SubscribePattern");
                context.Writer.Write(requestObject.SubscribePattern);
            }

            if(requestObject.IsSetTopicName())
            {
                context.Writer.WritePropertyName("TopicName");
                context.Writer.Write(requestObject.TopicName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static KafkaStreamingSourceOptionsMarshaller Instance = new KafkaStreamingSourceOptionsMarshaller();

    }
}