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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.TimestreamInfluxDB.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.TimestreamInfluxDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InfluxDBv3EnterpriseParameters Object
    /// </summary>  
    public class InfluxDBv3EnterpriseParametersUnmarshaller : IJsonUnmarshaller<InfluxDBv3EnterpriseParameters, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public InfluxDBv3EnterpriseParameters Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            InfluxDBv3EnterpriseParameters unmarshalledObject = new InfluxDBv3EnterpriseParameters();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("catalogSyncInterval", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.CatalogSyncInterval = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("compactionCheckInterval", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.CompactionCheckInterval = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("compactionCleanupWait", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.CompactionCleanupWait = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("compactionGen2Duration", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.CompactionGen2Duration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("compactionMaxNumFilesPerPlan", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.CompactionMaxNumFilesPerPlan = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("compactionMultipliers", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CompactionMultipliers = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("compactionRowLimit", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.CompactionRowLimit = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataFusionConfig", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DataFusionConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataFusionMaxParquetFanout", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.DataFusionMaxParquetFanout = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataFusionNumThreads", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.DataFusionNumThreads = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataFusionRuntimeDisableLifoSlot", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.DataFusionRuntimeDisableLifoSlot = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataFusionRuntimeEventInterval", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.DataFusionRuntimeEventInterval = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataFusionRuntimeGlobalQueueInterval", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.DataFusionRuntimeGlobalQueueInterval = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataFusionRuntimeMaxBlockingThreads", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.DataFusionRuntimeMaxBlockingThreads = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataFusionRuntimeMaxIoEventsPerTick", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.DataFusionRuntimeMaxIoEventsPerTick = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataFusionRuntimeThreadKeepAlive", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.DataFusionRuntimeThreadKeepAlive = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataFusionRuntimeThreadPriority", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.DataFusionRuntimeThreadPriority = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataFusionRuntimeType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DataFusionRuntimeType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataFusionUseCachedParquetLoader", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.DataFusionUseCachedParquetLoader = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dedicatedCompactor", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.DedicatedCompactor = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("deleteGracePeriod", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.DeleteGracePeriod = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("disableParquetMemCache", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.DisableParquetMemCache = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("distinctCacheEvictionInterval", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.DistinctCacheEvictionInterval = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("distinctValueCacheDisableFromHistory", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.DistinctValueCacheDisableFromHistory = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("execMemPoolBytes", targetDepth))
                {
                    var unmarshaller = PercentOrAbsoluteLongUnmarshaller.Instance;
                    unmarshalledObject.ExecMemPoolBytes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("forceSnapshotMemThreshold", targetDepth))
                {
                    var unmarshaller = PercentOrAbsoluteLongUnmarshaller.Instance;
                    unmarshalledObject.ForceSnapshotMemThreshold = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("gen1Duration", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.Gen1Duration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("gen1LookbackDuration", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.Gen1LookbackDuration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("hardDeleteDefaultDuration", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.HardDeleteDefaultDuration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ingestQueryInstances", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.IngestQueryInstances = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lastCacheEvictionInterval", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.LastCacheEvictionInterval = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lastValueCacheDisableFromHistory", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.LastValueCacheDisableFromHistory = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("logFilter", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogFilter = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("logFormat", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogFormat = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("maxHttpRequestSize", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.MaxHttpRequestSize = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("parquetMemCachePruneInterval", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.ParquetMemCachePruneInterval = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("parquetMemCachePrunePercentage", targetDepth))
                {
                    var unmarshaller = NullableFloatUnmarshaller.Instance;
                    unmarshalledObject.ParquetMemCachePrunePercentage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("parquetMemCacheQueryPathDuration", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.ParquetMemCacheQueryPathDuration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("parquetMemCacheSize", targetDepth))
                {
                    var unmarshaller = PercentOrAbsoluteLongUnmarshaller.Instance;
                    unmarshalledObject.ParquetMemCacheSize = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("preemptiveCacheAge", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.PreemptiveCacheAge = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("queryFileLimit", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.QueryFileLimit = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("queryLogSize", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.QueryLogSize = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("queryOnlyInstances", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.QueryOnlyInstances = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("replicationInterval", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.ReplicationInterval = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("retentionCheckInterval", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.RetentionCheckInterval = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("snapshottedWalFilesToKeep", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.SnapshottedWalFilesToKeep = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("tableIndexCacheConcurrencyLimit", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.TableIndexCacheConcurrencyLimit = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("tableIndexCacheMaxEntries", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.TableIndexCacheMaxEntries = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("walMaxWriteBufferSize", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.WalMaxWriteBufferSize = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("walReplayConcurrencyLimit", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.WalReplayConcurrencyLimit = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("walReplayFailOnError", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.WalReplayFailOnError = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("walSnapshotSize", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.WalSnapshotSize = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static InfluxDBv3EnterpriseParametersUnmarshaller _instance = new InfluxDBv3EnterpriseParametersUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InfluxDBv3EnterpriseParametersUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}