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
            if(requestObject.IsSetAddIdleTimeBetweenReads())
            {
                context.Writer.WritePropertyName("AddIdleTimeBetweenReads");
                context.Writer.Write(requestObject.AddIdleTimeBetweenReads);
            }

            if(requestObject.IsSetAddRecordTimestamp())
            {
                context.Writer.WritePropertyName("AddRecordTimestamp");
                context.Writer.Write(requestObject.AddRecordTimestamp);
            }

            if(requestObject.IsSetAvoidEmptyBatches())
            {
                context.Writer.WritePropertyName("AvoidEmptyBatches");
                context.Writer.Write(requestObject.AvoidEmptyBatches);
            }

            if(requestObject.IsSetClassification())
            {
                context.Writer.WritePropertyName("Classification");
                context.Writer.Write(requestObject.Classification);
            }

            if(requestObject.IsSetDelimiter())
            {
                context.Writer.WritePropertyName("Delimiter");
                context.Writer.Write(requestObject.Delimiter);
            }

            if(requestObject.IsSetDescribeShardInterval())
            {
                context.Writer.WritePropertyName("DescribeShardInterval");
                context.Writer.Write(requestObject.DescribeShardInterval);
            }

            if(requestObject.IsSetEmitConsumerLagMetrics())
            {
                context.Writer.WritePropertyName("EmitConsumerLagMetrics");
                context.Writer.Write(requestObject.EmitConsumerLagMetrics);
            }

            if(requestObject.IsSetEndpointUrl())
            {
                context.Writer.WritePropertyName("EndpointUrl");
                context.Writer.Write(requestObject.EndpointUrl);
            }

            if(requestObject.IsSetIdleTimeBetweenReadsInMs())
            {
                context.Writer.WritePropertyName("IdleTimeBetweenReadsInMs");
                context.Writer.Write(requestObject.IdleTimeBetweenReadsInMs);
            }

            if(requestObject.IsSetMaxFetchRecordsPerShard())
            {
                context.Writer.WritePropertyName("MaxFetchRecordsPerShard");
                context.Writer.Write(requestObject.MaxFetchRecordsPerShard);
            }

            if(requestObject.IsSetMaxFetchTimeInMs())
            {
                context.Writer.WritePropertyName("MaxFetchTimeInMs");
                context.Writer.Write(requestObject.MaxFetchTimeInMs);
            }

            if(requestObject.IsSetMaxRecordPerRead())
            {
                context.Writer.WritePropertyName("MaxRecordPerRead");
                context.Writer.Write(requestObject.MaxRecordPerRead);
            }

            if(requestObject.IsSetMaxRetryIntervalMs())
            {
                context.Writer.WritePropertyName("MaxRetryIntervalMs");
                context.Writer.Write(requestObject.MaxRetryIntervalMs);
            }

            if(requestObject.IsSetNumRetries())
            {
                context.Writer.WritePropertyName("NumRetries");
                context.Writer.Write(requestObject.NumRetries);
            }

            if(requestObject.IsSetRetryIntervalMs())
            {
                context.Writer.WritePropertyName("RetryIntervalMs");
                context.Writer.Write(requestObject.RetryIntervalMs);
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.Write(requestObject.RoleArn);
            }

            if(requestObject.IsSetRoleSessionName())
            {
                context.Writer.WritePropertyName("RoleSessionName");
                context.Writer.Write(requestObject.RoleSessionName);
            }

            if(requestObject.IsSetStartingPosition())
            {
                context.Writer.WritePropertyName("StartingPosition");
                context.Writer.Write(requestObject.StartingPosition);
            }

            if(requestObject.IsSetStreamArn())
            {
                context.Writer.WritePropertyName("StreamArn");
                context.Writer.Write(requestObject.StreamArn);
            }

            if(requestObject.IsSetStreamName())
            {
                context.Writer.WritePropertyName("StreamName");
                context.Writer.Write(requestObject.StreamName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static KinesisStreamingSourceOptionsMarshaller Instance = new KinesisStreamingSourceOptionsMarshaller();

    }
}