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
    /// Response Unmarshaller for InfluxDBv2Parameters Object
    /// </summary>  
    public class InfluxDBv2ParametersUnmarshaller : IUnmarshaller<InfluxDBv2Parameters, XmlUnmarshallerContext>, IUnmarshaller<InfluxDBv2Parameters, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        InfluxDBv2Parameters IUnmarshaller<InfluxDBv2Parameters, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public InfluxDBv2Parameters Unmarshall(JsonUnmarshallerContext context)
        {
            InfluxDBv2Parameters unmarshalledObject = new InfluxDBv2Parameters();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("fluxLogEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.FluxLogEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("httpIdleTimeout", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.HttpIdleTimeout = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("httpReadHeaderTimeout", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.HttpReadHeaderTimeout = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("httpReadTimeout", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.HttpReadTimeout = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("httpWriteTimeout", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.HttpWriteTimeout = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("influxqlMaxSelectBuckets", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.InfluxqlMaxSelectBuckets = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("influxqlMaxSelectPoint", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.InfluxqlMaxSelectPoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("influxqlMaxSelectSeries", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.InfluxqlMaxSelectSeries = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("logLevel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogLevel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("metricsDisabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.MetricsDisabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("noTasks", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.NoTasks = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pprofDisabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.PprofDisabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("queryConcurrency", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.QueryConcurrency = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("queryInitialMemoryBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.QueryInitialMemoryBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("queryMaxMemoryBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.QueryMaxMemoryBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("queryMemoryBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.QueryMemoryBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("queryQueueSize", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.QueryQueueSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sessionLength", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SessionLength = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sessionRenewDisabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.SessionRenewDisabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("storageCacheMaxMemorySize", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.StorageCacheMaxMemorySize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("storageCacheSnapshotMemorySize", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.StorageCacheSnapshotMemorySize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("storageCacheSnapshotWriteColdDuration", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.StorageCacheSnapshotWriteColdDuration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("storageCompactFullWriteColdDuration", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.StorageCompactFullWriteColdDuration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("storageCompactThroughputBurst", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.StorageCompactThroughputBurst = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("storageMaxConcurrentCompactions", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.StorageMaxConcurrentCompactions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("storageMaxIndexLogFileSize", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.StorageMaxIndexLogFileSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("storageNoValidateFieldSize", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.StorageNoValidateFieldSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("storageRetentionCheckInterval", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.StorageRetentionCheckInterval = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("storageSeriesFileMaxConcurrentSnapshotCompactions", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.StorageSeriesFileMaxConcurrentSnapshotCompactions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("storageSeriesIdSetCacheSize", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.StorageSeriesIdSetCacheSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("storageWalMaxConcurrentWrites", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.StorageWalMaxConcurrentWrites = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("storageWalMaxWriteDelay", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.StorageWalMaxWriteDelay = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tracingType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TracingType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("uiDisabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.UiDisabled = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static InfluxDBv2ParametersUnmarshaller _instance = new InfluxDBv2ParametersUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InfluxDBv2ParametersUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}