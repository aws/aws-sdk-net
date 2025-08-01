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
    /// KinesisStreamingSourceOptions Marshaller
    /// </summary>
    public class KinesisStreamingSourceOptionsMarshaller : IRequestMarshaller<KinesisStreamingSourceOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(KinesisStreamingSourceOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAddIdleTimeBetweenReads())
            {
                context.Writer.WritePropertyName("AddIdleTimeBetweenReads");
                context.Writer.WriteBooleanValue(requestObject.AddIdleTimeBetweenReads.Value);
            }

            if(requestObject.IsSetAddRecordTimestamp())
            {
                context.Writer.WritePropertyName("AddRecordTimestamp");
                context.Writer.WriteStringValue(requestObject.AddRecordTimestamp);
            }

            if(requestObject.IsSetAvoidEmptyBatches())
            {
                context.Writer.WritePropertyName("AvoidEmptyBatches");
                context.Writer.WriteBooleanValue(requestObject.AvoidEmptyBatches.Value);
            }

            if(requestObject.IsSetClassification())
            {
                context.Writer.WritePropertyName("Classification");
                context.Writer.WriteStringValue(requestObject.Classification);
            }

            if(requestObject.IsSetDelimiter())
            {
                context.Writer.WritePropertyName("Delimiter");
                context.Writer.WriteStringValue(requestObject.Delimiter);
            }

            if(requestObject.IsSetDescribeShardInterval())
            {
                context.Writer.WritePropertyName("DescribeShardInterval");
                context.Writer.WriteNumberValue(requestObject.DescribeShardInterval.Value);
            }

            if(requestObject.IsSetEmitConsumerLagMetrics())
            {
                context.Writer.WritePropertyName("EmitConsumerLagMetrics");
                context.Writer.WriteStringValue(requestObject.EmitConsumerLagMetrics);
            }

            if(requestObject.IsSetEndpointUrl())
            {
                context.Writer.WritePropertyName("EndpointUrl");
                context.Writer.WriteStringValue(requestObject.EndpointUrl);
            }

            if(requestObject.IsSetFanoutConsumerARN())
            {
                context.Writer.WritePropertyName("FanoutConsumerARN");
                context.Writer.WriteStringValue(requestObject.FanoutConsumerARN);
            }

            if(requestObject.IsSetIdleTimeBetweenReadsInMs())
            {
                context.Writer.WritePropertyName("IdleTimeBetweenReadsInMs");
                context.Writer.WriteNumberValue(requestObject.IdleTimeBetweenReadsInMs.Value);
            }

            if(requestObject.IsSetMaxFetchRecordsPerShard())
            {
                context.Writer.WritePropertyName("MaxFetchRecordsPerShard");
                context.Writer.WriteNumberValue(requestObject.MaxFetchRecordsPerShard.Value);
            }

            if(requestObject.IsSetMaxFetchTimeInMs())
            {
                context.Writer.WritePropertyName("MaxFetchTimeInMs");
                context.Writer.WriteNumberValue(requestObject.MaxFetchTimeInMs.Value);
            }

            if(requestObject.IsSetMaxRecordPerRead())
            {
                context.Writer.WritePropertyName("MaxRecordPerRead");
                context.Writer.WriteNumberValue(requestObject.MaxRecordPerRead.Value);
            }

            if(requestObject.IsSetMaxRetryIntervalMs())
            {
                context.Writer.WritePropertyName("MaxRetryIntervalMs");
                context.Writer.WriteNumberValue(requestObject.MaxRetryIntervalMs.Value);
            }

            if(requestObject.IsSetNumRetries())
            {
                context.Writer.WritePropertyName("NumRetries");
                context.Writer.WriteNumberValue(requestObject.NumRetries.Value);
            }

            if(requestObject.IsSetRetryIntervalMs())
            {
                context.Writer.WritePropertyName("RetryIntervalMs");
                context.Writer.WriteNumberValue(requestObject.RetryIntervalMs.Value);
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.WriteStringValue(requestObject.RoleArn);
            }

            if(requestObject.IsSetRoleSessionName())
            {
                context.Writer.WritePropertyName("RoleSessionName");
                context.Writer.WriteStringValue(requestObject.RoleSessionName);
            }

            if(requestObject.IsSetStartingPosition())
            {
                context.Writer.WritePropertyName("StartingPosition");
                context.Writer.WriteStringValue(requestObject.StartingPosition);
            }

            if(requestObject.IsSetStartingTimestamp())
            {
                context.Writer.WritePropertyName("StartingTimestamp");
                context.Writer.WriteStringValue(StringUtils.FromDateTimeToISO8601WithOptionalMs(requestObject.StartingTimestamp));
            }

            if(requestObject.IsSetStreamArn())
            {
                context.Writer.WritePropertyName("StreamArn");
                context.Writer.WriteStringValue(requestObject.StreamArn);
            }

            if(requestObject.IsSetStreamName())
            {
                context.Writer.WritePropertyName("StreamName");
                context.Writer.WriteStringValue(requestObject.StreamName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static KinesisStreamingSourceOptionsMarshaller Instance = new KinesisStreamingSourceOptionsMarshaller();

    }
}