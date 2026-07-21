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
    /// Response Unmarshaller for InfluxDBv3CoreParameters Object
    /// </summary>  
    public class InfluxDBv3CoreParametersUnmarshaller : IJsonUnmarshaller<InfluxDBv3CoreParameters, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public InfluxDBv3CoreParameters Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            InfluxDBv3CoreParameters unmarshalledObject = new InfluxDBv3CoreParameters();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("dataFusionConfig", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DataFusionConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataFusionMaxParquetFanout", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.DataFusionMaxParquetFanout = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataFusionNumThreads", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.DataFusionNumThreads = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataFusionRuntimeDisableLifoSlot", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.DataFusionRuntimeDisableLifoSlot = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataFusionRuntimeEventInterval", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.DataFusionRuntimeEventInterval = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataFusionRuntimeGlobalQueueInterval", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.DataFusionRuntimeGlobalQueueInterval = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataFusionRuntimeMaxBlockingThreads", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.DataFusionRuntimeMaxBlockingThreads = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataFusionRuntimeMaxIoEventsPerTick", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.DataFusionRuntimeMaxIoEventsPerTick = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataFusionRuntimeThreadKeepAlive", targetDepth, ref reader))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.DataFusionRuntimeThreadKeepAlive = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataFusionRuntimeThreadPriority", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.DataFusionRuntimeThreadPriority = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataFusionRuntimeType", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DataFusionRuntimeType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataFusionUseCachedParquetLoader", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.DataFusionUseCachedParquetLoader = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("deleteGracePeriod", targetDepth, ref reader))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.DeleteGracePeriod = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("disableParquetMemCache", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.DisableParquetMemCache = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("distinctCacheEvictionInterval", targetDepth, ref reader))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.DistinctCacheEvictionInterval = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("execMemPoolBytes", targetDepth, ref reader))
                {
                    var unmarshaller = PercentOrAbsoluteLongUnmarshaller.Instance;
                    unmarshalledObject.ExecMemPoolBytes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("forceSnapshotMemThreshold", targetDepth, ref reader))
                {
                    var unmarshaller = PercentOrAbsoluteLongUnmarshaller.Instance;
                    unmarshalledObject.ForceSnapshotMemThreshold = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("gen1Duration", targetDepth, ref reader))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.Gen1Duration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("gen1LookbackDuration", targetDepth, ref reader))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.Gen1LookbackDuration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("hardDeleteDefaultDuration", targetDepth, ref reader))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.HardDeleteDefaultDuration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lastCacheEvictionInterval", targetDepth, ref reader))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.LastCacheEvictionInterval = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("logFilter", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogFilter = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("logFormat", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogFormat = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("maxHttpRequestSize", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.MaxHttpRequestSize = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("parquetMemCachePruneInterval", targetDepth, ref reader))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.ParquetMemCachePruneInterval = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("parquetMemCachePrunePercentage", targetDepth, ref reader))
                {
                    var unmarshaller = NullableFloatUnmarshaller.Instance;
                    unmarshalledObject.ParquetMemCachePrunePercentage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("parquetMemCacheQueryPathDuration", targetDepth, ref reader))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.ParquetMemCacheQueryPathDuration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("parquetMemCacheSize", targetDepth, ref reader))
                {
                    var unmarshaller = PercentOrAbsoluteLongUnmarshaller.Instance;
                    unmarshalledObject.ParquetMemCacheSize = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("pluginRepositorySecretArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PluginRepositorySecretArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("pluginRepositoryUrl", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PluginRepositoryUrl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("preemptiveCacheAge", targetDepth, ref reader))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.PreemptiveCacheAge = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("queryFileLimit", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.QueryFileLimit = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("queryLogSize", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.QueryLogSize = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("retentionCheckInterval", targetDepth, ref reader))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.RetentionCheckInterval = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("snapshottedWalFilesToKeep", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.SnapshottedWalFilesToKeep = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("tableIndexCacheConcurrencyLimit", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.TableIndexCacheConcurrencyLimit = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("tableIndexCacheMaxEntries", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.TableIndexCacheMaxEntries = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("walMaxWriteBufferSize", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.WalMaxWriteBufferSize = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("walReplayConcurrencyLimit", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.WalReplayConcurrencyLimit = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("walReplayFailOnError", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.WalReplayFailOnError = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("walSnapshotSize", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.WalSnapshotSize = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static InfluxDBv3CoreParametersUnmarshaller _instance = new InfluxDBv3CoreParametersUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InfluxDBv3CoreParametersUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}