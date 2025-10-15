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
    /// InfluxDBv3CoreParameters Marshaller
    /// </summary>
    public class InfluxDBv3CoreParametersMarshaller : IRequestMarshaller<InfluxDBv3CoreParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InfluxDBv3CoreParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDataFusionConfig())
            {
                context.Writer.WritePropertyName("dataFusionConfig");
                context.Writer.Write(requestObject.DataFusionConfig);
            }

            if(requestObject.IsSetDataFusionMaxParquetFanout())
            {
                context.Writer.WritePropertyName("dataFusionMaxParquetFanout");
                context.Writer.Write(requestObject.DataFusionMaxParquetFanout);
            }

            if(requestObject.IsSetDataFusionNumThreads())
            {
                context.Writer.WritePropertyName("dataFusionNumThreads");
                context.Writer.Write(requestObject.DataFusionNumThreads);
            }

            if(requestObject.IsSetDataFusionRuntimeDisableLifoSlot())
            {
                context.Writer.WritePropertyName("dataFusionRuntimeDisableLifoSlot");
                context.Writer.Write(requestObject.DataFusionRuntimeDisableLifoSlot);
            }

            if(requestObject.IsSetDataFusionRuntimeEventInterval())
            {
                context.Writer.WritePropertyName("dataFusionRuntimeEventInterval");
                context.Writer.Write(requestObject.DataFusionRuntimeEventInterval);
            }

            if(requestObject.IsSetDataFusionRuntimeGlobalQueueInterval())
            {
                context.Writer.WritePropertyName("dataFusionRuntimeGlobalQueueInterval");
                context.Writer.Write(requestObject.DataFusionRuntimeGlobalQueueInterval);
            }

            if(requestObject.IsSetDataFusionRuntimeMaxBlockingThreads())
            {
                context.Writer.WritePropertyName("dataFusionRuntimeMaxBlockingThreads");
                context.Writer.Write(requestObject.DataFusionRuntimeMaxBlockingThreads);
            }

            if(requestObject.IsSetDataFusionRuntimeMaxIoEventsPerTick())
            {
                context.Writer.WritePropertyName("dataFusionRuntimeMaxIoEventsPerTick");
                context.Writer.Write(requestObject.DataFusionRuntimeMaxIoEventsPerTick);
            }

            if(requestObject.IsSetDataFusionRuntimeThreadKeepAlive())
            {
                context.Writer.WritePropertyName("dataFusionRuntimeThreadKeepAlive");
                context.Writer.WriteObjectStart();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DataFusionRuntimeThreadKeepAlive, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDataFusionRuntimeThreadPriority())
            {
                context.Writer.WritePropertyName("dataFusionRuntimeThreadPriority");
                context.Writer.Write(requestObject.DataFusionRuntimeThreadPriority);
            }

            if(requestObject.IsSetDataFusionRuntimeType())
            {
                context.Writer.WritePropertyName("dataFusionRuntimeType");
                context.Writer.Write(requestObject.DataFusionRuntimeType);
            }

            if(requestObject.IsSetDataFusionUseCachedParquetLoader())
            {
                context.Writer.WritePropertyName("dataFusionUseCachedParquetLoader");
                context.Writer.Write(requestObject.DataFusionUseCachedParquetLoader);
            }

            if(requestObject.IsSetDeleteGracePeriod())
            {
                context.Writer.WritePropertyName("deleteGracePeriod");
                context.Writer.WriteObjectStart();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DeleteGracePeriod, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDisableParquetMemCache())
            {
                context.Writer.WritePropertyName("disableParquetMemCache");
                context.Writer.Write(requestObject.DisableParquetMemCache);
            }

            if(requestObject.IsSetDistinctCacheEvictionInterval())
            {
                context.Writer.WritePropertyName("distinctCacheEvictionInterval");
                context.Writer.WriteObjectStart();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DistinctCacheEvictionInterval, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetExecMemPoolBytes())
            {
                context.Writer.WritePropertyName("execMemPoolBytes");
                context.Writer.WriteObjectStart();

                var marshaller = PercentOrAbsoluteLongMarshaller.Instance;
                marshaller.Marshall(requestObject.ExecMemPoolBytes, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetForceSnapshotMemThreshold())
            {
                context.Writer.WritePropertyName("forceSnapshotMemThreshold");
                context.Writer.WriteObjectStart();

                var marshaller = PercentOrAbsoluteLongMarshaller.Instance;
                marshaller.Marshall(requestObject.ForceSnapshotMemThreshold, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetGen1Duration())
            {
                context.Writer.WritePropertyName("gen1Duration");
                context.Writer.WriteObjectStart();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Gen1Duration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetGen1LookbackDuration())
            {
                context.Writer.WritePropertyName("gen1LookbackDuration");
                context.Writer.WriteObjectStart();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Gen1LookbackDuration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHardDeleteDefaultDuration())
            {
                context.Writer.WritePropertyName("hardDeleteDefaultDuration");
                context.Writer.WriteObjectStart();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.HardDeleteDefaultDuration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLastCacheEvictionInterval())
            {
                context.Writer.WritePropertyName("lastCacheEvictionInterval");
                context.Writer.WriteObjectStart();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.LastCacheEvictionInterval, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLogFilter())
            {
                context.Writer.WritePropertyName("logFilter");
                context.Writer.Write(requestObject.LogFilter);
            }

            if(requestObject.IsSetLogFormat())
            {
                context.Writer.WritePropertyName("logFormat");
                context.Writer.Write(requestObject.LogFormat);
            }

            if(requestObject.IsSetMaxHttpRequestSize())
            {
                context.Writer.WritePropertyName("maxHttpRequestSize");
                context.Writer.Write(requestObject.MaxHttpRequestSize);
            }

            if(requestObject.IsSetParquetMemCachePruneInterval())
            {
                context.Writer.WritePropertyName("parquetMemCachePruneInterval");
                context.Writer.WriteObjectStart();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ParquetMemCachePruneInterval, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetParquetMemCachePrunePercentage())
            {
                context.Writer.WritePropertyName("parquetMemCachePrunePercentage");
                if(StringUtils.IsSpecialFloatValue(requestObject.ParquetMemCachePrunePercentage))
                {
                    context.Writer.Write(StringUtils.FromSpecialFloatValue(requestObject.ParquetMemCachePrunePercentage));
                }
                else
                {
                    context.Writer.Write(requestObject.ParquetMemCachePrunePercentage);
                }
            }

            if(requestObject.IsSetParquetMemCacheQueryPathDuration())
            {
                context.Writer.WritePropertyName("parquetMemCacheQueryPathDuration");
                context.Writer.WriteObjectStart();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ParquetMemCacheQueryPathDuration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetParquetMemCacheSize())
            {
                context.Writer.WritePropertyName("parquetMemCacheSize");
                context.Writer.WriteObjectStart();

                var marshaller = PercentOrAbsoluteLongMarshaller.Instance;
                marshaller.Marshall(requestObject.ParquetMemCacheSize, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPreemptiveCacheAge())
            {
                context.Writer.WritePropertyName("preemptiveCacheAge");
                context.Writer.WriteObjectStart();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.PreemptiveCacheAge, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetQueryFileLimit())
            {
                context.Writer.WritePropertyName("queryFileLimit");
                context.Writer.Write(requestObject.QueryFileLimit);
            }

            if(requestObject.IsSetQueryLogSize())
            {
                context.Writer.WritePropertyName("queryLogSize");
                context.Writer.Write(requestObject.QueryLogSize);
            }

            if(requestObject.IsSetRetentionCheckInterval())
            {
                context.Writer.WritePropertyName("retentionCheckInterval");
                context.Writer.WriteObjectStart();

                var marshaller = DurationMarshaller.Instance;
                marshaller.Marshall(requestObject.RetentionCheckInterval, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSnapshottedWalFilesToKeep())
            {
                context.Writer.WritePropertyName("snapshottedWalFilesToKeep");
                context.Writer.Write(requestObject.SnapshottedWalFilesToKeep);
            }

            if(requestObject.IsSetTableIndexCacheConcurrencyLimit())
            {
                context.Writer.WritePropertyName("tableIndexCacheConcurrencyLimit");
                context.Writer.Write(requestObject.TableIndexCacheConcurrencyLimit);
            }

            if(requestObject.IsSetTableIndexCacheMaxEntries())
            {
                context.Writer.WritePropertyName("tableIndexCacheMaxEntries");
                context.Writer.Write(requestObject.TableIndexCacheMaxEntries);
            }

            if(requestObject.IsSetWalMaxWriteBufferSize())
            {
                context.Writer.WritePropertyName("walMaxWriteBufferSize");
                context.Writer.Write(requestObject.WalMaxWriteBufferSize);
            }

            if(requestObject.IsSetWalReplayConcurrencyLimit())
            {
                context.Writer.WritePropertyName("walReplayConcurrencyLimit");
                context.Writer.Write(requestObject.WalReplayConcurrencyLimit);
            }

            if(requestObject.IsSetWalReplayFailOnError())
            {
                context.Writer.WritePropertyName("walReplayFailOnError");
                context.Writer.Write(requestObject.WalReplayFailOnError);
            }

            if(requestObject.IsSetWalSnapshotSize())
            {
                context.Writer.WritePropertyName("walSnapshotSize");
                context.Writer.Write(requestObject.WalSnapshotSize);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InfluxDBv3CoreParametersMarshaller Instance = new InfluxDBv3CoreParametersMarshaller();

    }
}