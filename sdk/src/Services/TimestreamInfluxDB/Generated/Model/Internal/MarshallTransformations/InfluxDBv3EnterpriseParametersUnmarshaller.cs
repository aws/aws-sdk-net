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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.TimestreamInfluxDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InfluxDBv3EnterpriseParameters Object
    /// </summary>  
    public class InfluxDBv3EnterpriseParametersUnmarshaller : IUnmarshaller<InfluxDBv3EnterpriseParameters, XmlUnmarshallerContext>, IUnmarshaller<InfluxDBv3EnterpriseParameters, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        InfluxDBv3EnterpriseParameters IUnmarshaller<InfluxDBv3EnterpriseParameters, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public InfluxDBv3EnterpriseParameters Unmarshall(JsonUnmarshallerContext context)
        {
            InfluxDBv3EnterpriseParameters unmarshalledObject = new InfluxDBv3EnterpriseParameters();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("catalogSyncInterval", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.CatalogSyncInterval = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("compactionCheckInterval", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.CompactionCheckInterval = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("compactionCleanupWait", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.CompactionCleanupWait = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("compactionGen2Duration", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.CompactionGen2Duration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("compactionMaxNumFilesPerPlan", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.CompactionMaxNumFilesPerPlan = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("compactionMultipliers", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CompactionMultipliers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("compactionRowLimit", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.CompactionRowLimit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dataFusionConfig", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DataFusionConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dataFusionMaxParquetFanout", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DataFusionMaxParquetFanout = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dataFusionNumThreads", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DataFusionNumThreads = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dataFusionRuntimeDisableLifoSlot", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DataFusionRuntimeDisableLifoSlot = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dataFusionRuntimeEventInterval", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DataFusionRuntimeEventInterval = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dataFusionRuntimeGlobalQueueInterval", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DataFusionRuntimeGlobalQueueInterval = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dataFusionRuntimeMaxBlockingThreads", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DataFusionRuntimeMaxBlockingThreads = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dataFusionRuntimeMaxIoEventsPerTick", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DataFusionRuntimeMaxIoEventsPerTick = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dataFusionRuntimeThreadKeepAlive", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.DataFusionRuntimeThreadKeepAlive = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dataFusionRuntimeThreadPriority", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DataFusionRuntimeThreadPriority = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dataFusionRuntimeType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DataFusionRuntimeType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dataFusionUseCachedParquetLoader", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DataFusionUseCachedParquetLoader = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dedicatedCompactor", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DedicatedCompactor = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("deleteGracePeriod", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.DeleteGracePeriod = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("disableParquetMemCache", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DisableParquetMemCache = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("distinctCacheEvictionInterval", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.DistinctCacheEvictionInterval = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("distinctValueCacheDisableFromHistory", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DistinctValueCacheDisableFromHistory = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("execMemPoolBytes", targetDepth))
                {
                    var unmarshaller = PercentOrAbsoluteLongUnmarshaller.Instance;
                    unmarshalledObject.ExecMemPoolBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("forceSnapshotMemThreshold", targetDepth))
                {
                    var unmarshaller = PercentOrAbsoluteLongUnmarshaller.Instance;
                    unmarshalledObject.ForceSnapshotMemThreshold = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("gen1Duration", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.Gen1Duration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("gen1LookbackDuration", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.Gen1LookbackDuration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("hardDeleteDefaultDuration", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.HardDeleteDefaultDuration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ingestQueryInstances", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.IngestQueryInstances = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastCacheEvictionInterval", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.LastCacheEvictionInterval = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastValueCacheDisableFromHistory", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.LastValueCacheDisableFromHistory = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("logFilter", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogFilter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("logFormat", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogFormat = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maxHttpRequestSize", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.MaxHttpRequestSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("parquetMemCachePruneInterval", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.ParquetMemCachePruneInterval = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("parquetMemCachePrunePercentage", targetDepth))
                {
                    var unmarshaller = FloatUnmarshaller.Instance;
                    unmarshalledObject.ParquetMemCachePrunePercentage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("parquetMemCacheQueryPathDuration", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.ParquetMemCacheQueryPathDuration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("parquetMemCacheSize", targetDepth))
                {
                    var unmarshaller = PercentOrAbsoluteLongUnmarshaller.Instance;
                    unmarshalledObject.ParquetMemCacheSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("preemptiveCacheAge", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.PreemptiveCacheAge = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("queryFileLimit", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.QueryFileLimit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("queryLogSize", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.QueryLogSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("queryOnlyInstances", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.QueryOnlyInstances = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("replicationInterval", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.ReplicationInterval = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("retentionCheckInterval", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.RetentionCheckInterval = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("snapshottedWalFilesToKeep", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SnapshottedWalFilesToKeep = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tableIndexCacheConcurrencyLimit", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TableIndexCacheConcurrencyLimit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tableIndexCacheMaxEntries", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TableIndexCacheMaxEntries = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("walMaxWriteBufferSize", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.WalMaxWriteBufferSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("walReplayConcurrencyLimit", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.WalReplayConcurrencyLimit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("walReplayFailOnError", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.WalReplayFailOnError = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("walSnapshotSize", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.WalSnapshotSize = unmarshaller.Unmarshall(context);
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