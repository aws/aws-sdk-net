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
#pragma warning disable CS0612,CS0618
namespace Amazon.TimestreamInfluxDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InfluxDBv3EnterpriseParameters Marshaller
    /// </summary>
    public class InfluxDBv3EnterpriseParametersMarshaller : IRequestMarshaller<InfluxDBv3EnterpriseParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InfluxDBv3EnterpriseParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCatalogSyncInterval())
            {
                context.Writer.WritePropertyName("catalogSyncInterval");
                context.Writer.WriteStartObject();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.CatalogSyncInterval, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCompactionCheckInterval())
            {
                context.Writer.WritePropertyName("compactionCheckInterval");
                context.Writer.WriteStartObject();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.CompactionCheckInterval, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCompactionCleanupWait())
            {
                context.Writer.WritePropertyName("compactionCleanupWait");
                context.Writer.WriteStartObject();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.CompactionCleanupWait, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCompactionGen2Duration())
            {
                context.Writer.WritePropertyName("compactionGen2Duration");
                context.Writer.WriteStartObject();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.CompactionGen2Duration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCompactionMaxNumFilesPerPlan())
            {
                context.Writer.WritePropertyName("compactionMaxNumFilesPerPlan");
                context.Writer.WriteNumberValue(requestObject.CompactionMaxNumFilesPerPlan.Value);
            }

            if(requestObject.IsSetCompactionMultipliers())
            {
                context.Writer.WritePropertyName("compactionMultipliers");
                context.Writer.WriteStringValue(requestObject.CompactionMultipliers);
            }

            if(requestObject.IsSetCompactionRowLimit())
            {
                context.Writer.WritePropertyName("compactionRowLimit");
                context.Writer.WriteNumberValue(requestObject.CompactionRowLimit.Value);
            }

            if(requestObject.IsSetDataFusionConfig())
            {
                context.Writer.WritePropertyName("dataFusionConfig");
                context.Writer.WriteStringValue(requestObject.DataFusionConfig);
            }

            if(requestObject.IsSetDataFusionMaxParquetFanout())
            {
                context.Writer.WritePropertyName("dataFusionMaxParquetFanout");
                context.Writer.WriteNumberValue(requestObject.DataFusionMaxParquetFanout.Value);
            }

            if(requestObject.IsSetDataFusionNumThreads())
            {
                context.Writer.WritePropertyName("dataFusionNumThreads");
                context.Writer.WriteNumberValue(requestObject.DataFusionNumThreads.Value);
            }

            if(requestObject.IsSetDataFusionRuntimeDisableLifoSlot())
            {
                context.Writer.WritePropertyName("dataFusionRuntimeDisableLifoSlot");
                context.Writer.WriteBooleanValue(requestObject.DataFusionRuntimeDisableLifoSlot.Value);
            }

            if(requestObject.IsSetDataFusionRuntimeEventInterval())
            {
                context.Writer.WritePropertyName("dataFusionRuntimeEventInterval");
                context.Writer.WriteNumberValue(requestObject.DataFusionRuntimeEventInterval.Value);
            }

            if(requestObject.IsSetDataFusionRuntimeGlobalQueueInterval())
            {
                context.Writer.WritePropertyName("dataFusionRuntimeGlobalQueueInterval");
                context.Writer.WriteNumberValue(requestObject.DataFusionRuntimeGlobalQueueInterval.Value);
            }

            if(requestObject.IsSetDataFusionRuntimeMaxBlockingThreads())
            {
                context.Writer.WritePropertyName("dataFusionRuntimeMaxBlockingThreads");
                context.Writer.WriteNumberValue(requestObject.DataFusionRuntimeMaxBlockingThreads.Value);
            }

            if(requestObject.IsSetDataFusionRuntimeMaxIoEventsPerTick())
            {
                context.Writer.WritePropertyName("dataFusionRuntimeMaxIoEventsPerTick");
                context.Writer.WriteNumberValue(requestObject.DataFusionRuntimeMaxIoEventsPerTick.Value);
            }

            if(requestObject.IsSetDataFusionRuntimeThreadKeepAlive())
            {
                context.Writer.WritePropertyName("dataFusionRuntimeThreadKeepAlive");
                context.Writer.WriteStartObject();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DataFusionRuntimeThreadKeepAlive, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDataFusionRuntimeThreadPriority())
            {
                context.Writer.WritePropertyName("dataFusionRuntimeThreadPriority");
                context.Writer.WriteNumberValue(requestObject.DataFusionRuntimeThreadPriority.Value);
            }

            if(requestObject.IsSetDataFusionRuntimeType())
            {
                context.Writer.WritePropertyName("dataFusionRuntimeType");
                context.Writer.WriteStringValue(requestObject.DataFusionRuntimeType);
            }

            if(requestObject.IsSetDataFusionUseCachedParquetLoader())
            {
                context.Writer.WritePropertyName("dataFusionUseCachedParquetLoader");
                context.Writer.WriteBooleanValue(requestObject.DataFusionUseCachedParquetLoader.Value);
            }

            if(requestObject.IsSetDedicatedCompactor())
            {
                context.Writer.WritePropertyName("dedicatedCompactor");
                context.Writer.WriteBooleanValue(requestObject.DedicatedCompactor.Value);
            }

            if(requestObject.IsSetDeleteGracePeriod())
            {
                context.Writer.WritePropertyName("deleteGracePeriod");
                context.Writer.WriteStartObject();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DeleteGracePeriod, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDisableParquetMemCache())
            {
                context.Writer.WritePropertyName("disableParquetMemCache");
                context.Writer.WriteBooleanValue(requestObject.DisableParquetMemCache.Value);
            }

            if(requestObject.IsSetDistinctCacheEvictionInterval())
            {
                context.Writer.WritePropertyName("distinctCacheEvictionInterval");
                context.Writer.WriteStartObject();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DistinctCacheEvictionInterval, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDistinctValueCacheDisableFromHistory())
            {
                context.Writer.WritePropertyName("distinctValueCacheDisableFromHistory");
                context.Writer.WriteBooleanValue(requestObject.DistinctValueCacheDisableFromHistory.Value);
            }

            if(requestObject.IsSetExecMemPoolBytes())
            {
                context.Writer.WritePropertyName("execMemPoolBytes");
                context.Writer.WriteStartObject();

                var marshaller = PercentOrAbsoluteLongMarshaller.Instance;
                marshaller.Marshall(requestObject.ExecMemPoolBytes, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetForceSnapshotMemThreshold())
            {
                context.Writer.WritePropertyName("forceSnapshotMemThreshold");
                context.Writer.WriteStartObject();

                var marshaller = PercentOrAbsoluteLongMarshaller.Instance;
                marshaller.Marshall(requestObject.ForceSnapshotMemThreshold, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGen1Duration())
            {
                context.Writer.WritePropertyName("gen1Duration");
                context.Writer.WriteStartObject();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Gen1Duration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGen1LookbackDuration())
            {
                context.Writer.WritePropertyName("gen1LookbackDuration");
                context.Writer.WriteStartObject();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Gen1LookbackDuration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHardDeleteDefaultDuration())
            {
                context.Writer.WritePropertyName("hardDeleteDefaultDuration");
                context.Writer.WriteStartObject();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.HardDeleteDefaultDuration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIngestQueryInstances())
            {
                context.Writer.WritePropertyName("ingestQueryInstances");
                context.Writer.WriteNumberValue(requestObject.IngestQueryInstances.Value);
            }

            if(requestObject.IsSetLastCacheEvictionInterval())
            {
                context.Writer.WritePropertyName("lastCacheEvictionInterval");
                context.Writer.WriteStartObject();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.LastCacheEvictionInterval, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLastValueCacheDisableFromHistory())
            {
                context.Writer.WritePropertyName("lastValueCacheDisableFromHistory");
                context.Writer.WriteBooleanValue(requestObject.LastValueCacheDisableFromHistory.Value);
            }

            if(requestObject.IsSetLogFilter())
            {
                context.Writer.WritePropertyName("logFilter");
                context.Writer.WriteStringValue(requestObject.LogFilter);
            }

            if(requestObject.IsSetLogFormat())
            {
                context.Writer.WritePropertyName("logFormat");
                context.Writer.WriteStringValue(requestObject.LogFormat);
            }

            if(requestObject.IsSetMaxHttpRequestSize())
            {
                context.Writer.WritePropertyName("maxHttpRequestSize");
                context.Writer.WriteNumberValue(requestObject.MaxHttpRequestSize.Value);
            }

            if(requestObject.IsSetParquetMemCachePruneInterval())
            {
                context.Writer.WritePropertyName("parquetMemCachePruneInterval");
                context.Writer.WriteStartObject();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ParquetMemCachePruneInterval, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetParquetMemCachePrunePercentage())
            {
                context.Writer.WritePropertyName("parquetMemCachePrunePercentage");
                if(StringUtils.IsSpecialFloatValue(requestObject.ParquetMemCachePrunePercentage.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(requestObject.ParquetMemCachePrunePercentage.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.ParquetMemCachePrunePercentage.Value);
                }
            }

            if(requestObject.IsSetParquetMemCacheQueryPathDuration())
            {
                context.Writer.WritePropertyName("parquetMemCacheQueryPathDuration");
                context.Writer.WriteStartObject();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ParquetMemCacheQueryPathDuration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetParquetMemCacheSize())
            {
                context.Writer.WritePropertyName("parquetMemCacheSize");
                context.Writer.WriteStartObject();

                var marshaller = PercentOrAbsoluteLongMarshaller.Instance;
                marshaller.Marshall(requestObject.ParquetMemCacheSize, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPreemptiveCacheAge())
            {
                context.Writer.WritePropertyName("preemptiveCacheAge");
                context.Writer.WriteStartObject();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.PreemptiveCacheAge, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetQueryFileLimit())
            {
                context.Writer.WritePropertyName("queryFileLimit");
                context.Writer.WriteNumberValue(requestObject.QueryFileLimit.Value);
            }

            if(requestObject.IsSetQueryLogSize())
            {
                context.Writer.WritePropertyName("queryLogSize");
                context.Writer.WriteNumberValue(requestObject.QueryLogSize.Value);
            }

            if(requestObject.IsSetQueryOnlyInstances())
            {
                context.Writer.WritePropertyName("queryOnlyInstances");
                context.Writer.WriteNumberValue(requestObject.QueryOnlyInstances.Value);
            }

            if(requestObject.IsSetReplicationInterval())
            {
                context.Writer.WritePropertyName("replicationInterval");
                context.Writer.WriteStartObject();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ReplicationInterval, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRetentionCheckInterval())
            {
                context.Writer.WritePropertyName("retentionCheckInterval");
                context.Writer.WriteStartObject();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.RetentionCheckInterval, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSnapshottedWalFilesToKeep())
            {
                context.Writer.WritePropertyName("snapshottedWalFilesToKeep");
                context.Writer.WriteNumberValue(requestObject.SnapshottedWalFilesToKeep.Value);
            }

            if(requestObject.IsSetTableIndexCacheConcurrencyLimit())
            {
                context.Writer.WritePropertyName("tableIndexCacheConcurrencyLimit");
                context.Writer.WriteNumberValue(requestObject.TableIndexCacheConcurrencyLimit.Value);
            }

            if(requestObject.IsSetTableIndexCacheMaxEntries())
            {
                context.Writer.WritePropertyName("tableIndexCacheMaxEntries");
                context.Writer.WriteNumberValue(requestObject.TableIndexCacheMaxEntries.Value);
            }

            if(requestObject.IsSetWalMaxWriteBufferSize())
            {
                context.Writer.WritePropertyName("walMaxWriteBufferSize");
                context.Writer.WriteNumberValue(requestObject.WalMaxWriteBufferSize.Value);
            }

            if(requestObject.IsSetWalReplayConcurrencyLimit())
            {
                context.Writer.WritePropertyName("walReplayConcurrencyLimit");
                context.Writer.WriteNumberValue(requestObject.WalReplayConcurrencyLimit.Value);
            }

            if(requestObject.IsSetWalReplayFailOnError())
            {
                context.Writer.WritePropertyName("walReplayFailOnError");
                context.Writer.WriteBooleanValue(requestObject.WalReplayFailOnError.Value);
            }

            if(requestObject.IsSetWalSnapshotSize())
            {
                context.Writer.WritePropertyName("walSnapshotSize");
                context.Writer.WriteNumberValue(requestObject.WalSnapshotSize.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InfluxDBv3EnterpriseParametersMarshaller Instance = new InfluxDBv3EnterpriseParametersMarshaller();

    }
}