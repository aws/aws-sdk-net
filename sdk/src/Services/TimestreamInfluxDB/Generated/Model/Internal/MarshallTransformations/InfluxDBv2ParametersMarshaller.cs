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
 * Do not modify this file. This file is generated from the timestream-influxdb-2023-01-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.TimestreamInfluxDB.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.TimestreamInfluxDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InfluxDBv2Parameters Marshaller
    /// </summary>
    public class InfluxDBv2ParametersMarshaller : IRequestMarshaller<InfluxDBv2Parameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InfluxDBv2Parameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFluxLogEnabled())
            {
                context.Writer.WritePropertyName("fluxLogEnabled");
                context.Writer.Write(requestObject.FluxLogEnabled);
            }

            if(requestObject.IsSetHttpIdleTimeout())
            {
                context.Writer.WritePropertyName("httpIdleTimeout");
                context.Writer.WriteObjectStart();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.HttpIdleTimeout, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHttpReadHeaderTimeout())
            {
                context.Writer.WritePropertyName("httpReadHeaderTimeout");
                context.Writer.WriteObjectStart();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.HttpReadHeaderTimeout, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHttpReadTimeout())
            {
                context.Writer.WritePropertyName("httpReadTimeout");
                context.Writer.WriteObjectStart();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.HttpReadTimeout, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHttpWriteTimeout())
            {
                context.Writer.WritePropertyName("httpWriteTimeout");
                context.Writer.WriteObjectStart();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.HttpWriteTimeout, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetInfluxqlMaxSelectBuckets())
            {
                context.Writer.WritePropertyName("influxqlMaxSelectBuckets");
                context.Writer.Write(requestObject.InfluxqlMaxSelectBuckets);
            }

            if(requestObject.IsSetInfluxqlMaxSelectPoint())
            {
                context.Writer.WritePropertyName("influxqlMaxSelectPoint");
                context.Writer.Write(requestObject.InfluxqlMaxSelectPoint);
            }

            if(requestObject.IsSetInfluxqlMaxSelectSeries())
            {
                context.Writer.WritePropertyName("influxqlMaxSelectSeries");
                context.Writer.Write(requestObject.InfluxqlMaxSelectSeries);
            }

            if(requestObject.IsSetLogLevel())
            {
                context.Writer.WritePropertyName("logLevel");
                context.Writer.Write(requestObject.LogLevel);
            }

            if(requestObject.IsSetMetricsDisabled())
            {
                context.Writer.WritePropertyName("metricsDisabled");
                context.Writer.Write(requestObject.MetricsDisabled);
            }

            if(requestObject.IsSetNoTasks())
            {
                context.Writer.WritePropertyName("noTasks");
                context.Writer.Write(requestObject.NoTasks);
            }

            if(requestObject.IsSetPprofDisabled())
            {
                context.Writer.WritePropertyName("pprofDisabled");
                context.Writer.Write(requestObject.PprofDisabled);
            }

            if(requestObject.IsSetQueryConcurrency())
            {
                context.Writer.WritePropertyName("queryConcurrency");
                context.Writer.Write(requestObject.QueryConcurrency);
            }

            if(requestObject.IsSetQueryInitialMemoryBytes())
            {
                context.Writer.WritePropertyName("queryInitialMemoryBytes");
                context.Writer.Write(requestObject.QueryInitialMemoryBytes);
            }

            if(requestObject.IsSetQueryMaxMemoryBytes())
            {
                context.Writer.WritePropertyName("queryMaxMemoryBytes");
                context.Writer.Write(requestObject.QueryMaxMemoryBytes);
            }

            if(requestObject.IsSetQueryMemoryBytes())
            {
                context.Writer.WritePropertyName("queryMemoryBytes");
                context.Writer.Write(requestObject.QueryMemoryBytes);
            }

            if(requestObject.IsSetQueryQueueSize())
            {
                context.Writer.WritePropertyName("queryQueueSize");
                context.Writer.Write(requestObject.QueryQueueSize);
            }

            if(requestObject.IsSetSessionLength())
            {
                context.Writer.WritePropertyName("sessionLength");
                context.Writer.Write(requestObject.SessionLength);
            }

            if(requestObject.IsSetSessionRenewDisabled())
            {
                context.Writer.WritePropertyName("sessionRenewDisabled");
                context.Writer.Write(requestObject.SessionRenewDisabled);
            }

            if(requestObject.IsSetStorageCacheMaxMemorySize())
            {
                context.Writer.WritePropertyName("storageCacheMaxMemorySize");
                context.Writer.Write(requestObject.StorageCacheMaxMemorySize);
            }

            if(requestObject.IsSetStorageCacheSnapshotMemorySize())
            {
                context.Writer.WritePropertyName("storageCacheSnapshotMemorySize");
                context.Writer.Write(requestObject.StorageCacheSnapshotMemorySize);
            }

            if(requestObject.IsSetStorageCacheSnapshotWriteColdDuration())
            {
                context.Writer.WritePropertyName("storageCacheSnapshotWriteColdDuration");
                context.Writer.WriteObjectStart();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.StorageCacheSnapshotWriteColdDuration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStorageCompactFullWriteColdDuration())
            {
                context.Writer.WritePropertyName("storageCompactFullWriteColdDuration");
                context.Writer.WriteObjectStart();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.StorageCompactFullWriteColdDuration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStorageCompactThroughputBurst())
            {
                context.Writer.WritePropertyName("storageCompactThroughputBurst");
                context.Writer.Write(requestObject.StorageCompactThroughputBurst);
            }

            if(requestObject.IsSetStorageMaxConcurrentCompactions())
            {
                context.Writer.WritePropertyName("storageMaxConcurrentCompactions");
                context.Writer.Write(requestObject.StorageMaxConcurrentCompactions);
            }

            if(requestObject.IsSetStorageMaxIndexLogFileSize())
            {
                context.Writer.WritePropertyName("storageMaxIndexLogFileSize");
                context.Writer.Write(requestObject.StorageMaxIndexLogFileSize);
            }

            if(requestObject.IsSetStorageNoValidateFieldSize())
            {
                context.Writer.WritePropertyName("storageNoValidateFieldSize");
                context.Writer.Write(requestObject.StorageNoValidateFieldSize);
            }

            if(requestObject.IsSetStorageRetentionCheckInterval())
            {
                context.Writer.WritePropertyName("storageRetentionCheckInterval");
                context.Writer.WriteObjectStart();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.StorageRetentionCheckInterval, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStorageSeriesFileMaxConcurrentSnapshotCompactions())
            {
                context.Writer.WritePropertyName("storageSeriesFileMaxConcurrentSnapshotCompactions");
                context.Writer.Write(requestObject.StorageSeriesFileMaxConcurrentSnapshotCompactions);
            }

            if(requestObject.IsSetStorageSeriesIdSetCacheSize())
            {
                context.Writer.WritePropertyName("storageSeriesIdSetCacheSize");
                context.Writer.Write(requestObject.StorageSeriesIdSetCacheSize);
            }

            if(requestObject.IsSetStorageWalMaxConcurrentWrites())
            {
                context.Writer.WritePropertyName("storageWalMaxConcurrentWrites");
                context.Writer.Write(requestObject.StorageWalMaxConcurrentWrites);
            }

            if(requestObject.IsSetStorageWalMaxWriteDelay())
            {
                context.Writer.WritePropertyName("storageWalMaxWriteDelay");
                context.Writer.WriteObjectStart();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.StorageWalMaxWriteDelay, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTracingType())
            {
                context.Writer.WritePropertyName("tracingType");
                context.Writer.Write(requestObject.TracingType);
            }

            if(requestObject.IsSetUiDisabled())
            {
                context.Writer.WritePropertyName("uiDisabled");
                context.Writer.Write(requestObject.UiDisabled);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InfluxDBv2ParametersMarshaller Instance = new InfluxDBv2ParametersMarshaller();

    }
}