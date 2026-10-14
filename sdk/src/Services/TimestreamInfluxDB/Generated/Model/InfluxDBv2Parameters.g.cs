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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.TimestreamInfluxDB.Model
{
    /// <summary>
    /// All the customer-modifiable InfluxDB v2 parameters in Timestream for InfluxDB.
    /// </summary>
    public partial class InfluxDBv2Parameters
    {
        /// <summary>
        /// Gets and sets the property FluxLogEnabled. 
        /// <para>
        /// Include option to show detailed logs for Flux queries.
        /// </para>
        ///  
        /// <para>
        /// Default: false
        /// </para>
        /// </summary>
        public bool? FluxLogEnabled { get; set; }

        /// <summary>
        /// Checks to see if the FluxLogEnabled property is set.
        /// </summary>
        internal bool IsSetFluxLogEnabled() => this.FluxLogEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property HttpIdleTimeout. 
        /// <para>
        /// Maximum duration the server should keep established connections alive while waiting
        /// for new requests. Set to 0 for no timeout.
        /// </para>
        ///  
        /// <para>
        /// Default: 3 minutes
        /// </para>
        /// </summary>
        public Duration HttpIdleTimeout { get; set; }

        /// <summary>
        /// Checks to see if the HttpIdleTimeout property is set.
        /// </summary>
        internal bool IsSetHttpIdleTimeout() => this.HttpIdleTimeout != null;

        /// <summary>
        /// Gets and sets the property HttpReadHeaderTimeout. 
        /// <para>
        /// Maximum duration the server should try to read HTTP headers for new requests. Set
        /// to 0 for no timeout.
        /// </para>
        ///  
        /// <para>
        /// Default: 10 seconds
        /// </para>
        /// </summary>
        public Duration HttpReadHeaderTimeout { get; set; }

        /// <summary>
        /// Checks to see if the HttpReadHeaderTimeout property is set.
        /// </summary>
        internal bool IsSetHttpReadHeaderTimeout() => this.HttpReadHeaderTimeout != null;

        /// <summary>
        /// Gets and sets the property HttpReadTimeout. 
        /// <para>
        /// Maximum duration the server should try to read the entirety of new requests. Set to
        /// 0 for no timeout.
        /// </para>
        ///  
        /// <para>
        /// Default: 0
        /// </para>
        /// </summary>
        public Duration HttpReadTimeout { get; set; }

        /// <summary>
        /// Checks to see if the HttpReadTimeout property is set.
        /// </summary>
        internal bool IsSetHttpReadTimeout() => this.HttpReadTimeout != null;

        /// <summary>
        /// Gets and sets the property HttpWriteTimeout. 
        /// <para>
        /// Maximum duration the server should spend processing and responding to write requests.
        /// Set to 0 for no timeout.
        /// </para>
        ///  
        /// <para>
        /// Default: 0
        /// </para>
        /// </summary>
        public Duration HttpWriteTimeout { get; set; }

        /// <summary>
        /// Checks to see if the HttpWriteTimeout property is set.
        /// </summary>
        internal bool IsSetHttpWriteTimeout() => this.HttpWriteTimeout != null;

        /// <summary>
        /// Gets and sets the property InfluxqlMaxSelectBuckets. 
        /// <para>
        /// Maximum number of group by time buckets a SELECT statement can create. 0 allows an
        /// unlimited number of buckets.
        /// </para>
        ///  
        /// <para>
        /// Default: 0
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000000000000)]
        public long? InfluxqlMaxSelectBuckets { get; set; }

        /// <summary>
        /// Checks to see if the InfluxqlMaxSelectBuckets property is set.
        /// </summary>
        internal bool IsSetInfluxqlMaxSelectBuckets() => this.InfluxqlMaxSelectBuckets.HasValue;

        /// <summary>
        /// Gets and sets the property InfluxqlMaxSelectPoint. 
        /// <para>
        /// Maximum number of points a SELECT statement can process. 0 allows an unlimited number
        /// of points. InfluxDB checks the point count every second (so queries exceeding the
        /// maximum aren’t immediately aborted).
        /// </para>
        ///  
        /// <para>
        /// Default: 0
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000000000000)]
        public long? InfluxqlMaxSelectPoint { get; set; }

        /// <summary>
        /// Checks to see if the InfluxqlMaxSelectPoint property is set.
        /// </summary>
        internal bool IsSetInfluxqlMaxSelectPoint() => this.InfluxqlMaxSelectPoint.HasValue;

        /// <summary>
        /// Gets and sets the property InfluxqlMaxSelectSeries. 
        /// <para>
        /// Maximum number of series a SELECT statement can return. 0 allows an unlimited number
        /// of series.
        /// </para>
        ///  
        /// <para>
        /// Default: 0
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000000000000)]
        public long? InfluxqlMaxSelectSeries { get; set; }

        /// <summary>
        /// Checks to see if the InfluxqlMaxSelectSeries property is set.
        /// </summary>
        internal bool IsSetInfluxqlMaxSelectSeries() => this.InfluxqlMaxSelectSeries.HasValue;

        /// <summary>
        /// Gets and sets the property LogLevel. 
        /// <para>
        /// Log output level. InfluxDB outputs log entries with severity levels greater than or
        /// equal to the level specified.
        /// </para>
        ///  
        /// <para>
        /// Default: info
        /// </para>
        /// </summary>
        public LogLevel LogLevel { get; set; }

        /// <summary>
        /// Checks to see if the LogLevel property is set.
        /// </summary>
        internal bool IsSetLogLevel() => this.LogLevel != null;

        /// <summary>
        /// Gets and sets the property MetricsDisabled. 
        /// <para>
        /// Disable the HTTP /metrics endpoint which exposes <a href="https://docs.influxdata.com/influxdb/v2/reference/internals/metrics/">internal
        /// InfluxDB metrics</a>.
        /// </para>
        ///  
        /// <para>
        /// Default: false
        /// </para>
        /// </summary>
        public bool? MetricsDisabled { get; set; }

        /// <summary>
        /// Checks to see if the MetricsDisabled property is set.
        /// </summary>
        internal bool IsSetMetricsDisabled() => this.MetricsDisabled.HasValue;

        /// <summary>
        /// Gets and sets the property NoTasks. 
        /// <para>
        /// Disable the task scheduler. If problematic tasks prevent InfluxDB from starting, use
        /// this option to start InfluxDB without scheduling or executing tasks.
        /// </para>
        ///  
        /// <para>
        /// Default: false
        /// </para>
        /// </summary>
        public bool? NoTasks { get; set; }

        /// <summary>
        /// Checks to see if the NoTasks property is set.
        /// </summary>
        internal bool IsSetNoTasks() => this.NoTasks.HasValue;

        /// <summary>
        /// Gets and sets the property PprofDisabled. 
        /// <para>
        /// Disable the /debug/pprof HTTP endpoint. This endpoint provides runtime profiling data
        /// and can be helpful when debugging.
        /// </para>
        ///  
        /// <para>
        /// Default: true
        /// </para>
        /// </summary>
        public bool? PprofDisabled { get; set; }

        /// <summary>
        /// Checks to see if the PprofDisabled property is set.
        /// </summary>
        internal bool IsSetPprofDisabled() => this.PprofDisabled.HasValue;

        /// <summary>
        /// Gets and sets the property QueryConcurrency. 
        /// <para>
        /// Number of queries allowed to execute concurrently. Setting to 0 allows an unlimited
        /// number of concurrent queries.
        /// </para>
        ///  
        /// <para>
        /// Default: 0
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public int? QueryConcurrency { get; set; }

        /// <summary>
        /// Checks to see if the QueryConcurrency property is set.
        /// </summary>
        internal bool IsSetQueryConcurrency() => this.QueryConcurrency.HasValue;

        /// <summary>
        /// Gets and sets the property QueryInitialMemoryBytes. 
        /// <para>
        /// Initial bytes of memory allocated for a query.
        /// </para>
        ///  
        /// <para>
        /// Default: 0
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000000000000)]
        public long? QueryInitialMemoryBytes { get; set; }

        /// <summary>
        /// Checks to see if the QueryInitialMemoryBytes property is set.
        /// </summary>
        internal bool IsSetQueryInitialMemoryBytes() => this.QueryInitialMemoryBytes.HasValue;

        /// <summary>
        /// Gets and sets the property QueryMaxMemoryBytes. 
        /// <para>
        /// Maximum total bytes of memory allowed for all running queries. When this limit is
        /// reached, new queries are rejected. Setting to 0 allows unlimited memory usage.
        /// </para>
        ///  
        /// <para>
        /// Default: 0
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000000000000)]
        public long? QueryMaxMemoryBytes { get; set; }

        /// <summary>
        /// Checks to see if the QueryMaxMemoryBytes property is set.
        /// </summary>
        internal bool IsSetQueryMaxMemoryBytes() => this.QueryMaxMemoryBytes.HasValue;

        /// <summary>
        /// Gets and sets the property QueryMemoryBytes. 
        /// <para>
        /// Maximum bytes of memory allowed for a single query. Must be greater or equal to queryInitialMemoryBytes.
        /// </para>
        ///  
        /// <para>
        /// Default: 0
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000000000000)]
        public long? QueryMemoryBytes { get; set; }

        /// <summary>
        /// Checks to see if the QueryMemoryBytes property is set.
        /// </summary>
        internal bool IsSetQueryMemoryBytes() => this.QueryMemoryBytes.HasValue;

        /// <summary>
        /// Gets and sets the property QueryQueueSize. 
        /// <para>
        /// Maximum number of queries allowed in execution queue. When queue limit is reached,
        /// new queries are rejected. Setting to 0 allows an unlimited number of queries in the
        /// queue.
        /// </para>
        ///  
        /// <para>
        /// Default: 0
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public int? QueryQueueSize { get; set; }

        /// <summary>
        /// Checks to see if the QueryQueueSize property is set.
        /// </summary>
        internal bool IsSetQueryQueueSize() => this.QueryQueueSize.HasValue;

        /// <summary>
        /// Gets and sets the property SessionLength. 
        /// <para>
        /// Specifies the Time to Live (TTL) in minutes for newly created user sessions.
        /// </para>
        ///  
        /// <para>
        /// Default: 60
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2880)]
        public int? SessionLength { get; set; }

        /// <summary>
        /// Checks to see if the SessionLength property is set.
        /// </summary>
        internal bool IsSetSessionLength() => this.SessionLength.HasValue;

        /// <summary>
        /// Gets and sets the property SessionRenewDisabled. 
        /// <para>
        /// Disables automatically extending a user’s session TTL on each request. By default,
        /// every request sets the session’s expiration time to five minutes from now. When disabled,
        /// sessions expire after the specified <a href="https://docs.influxdata.com/influxdb/v2/reference/config-options/#session-length">session
        /// length</a> and the user is redirected to the login page, even if recently active.
        /// </para>
        ///  
        /// <para>
        /// Default: false
        /// </para>
        /// </summary>
        public bool? SessionRenewDisabled { get; set; }

        /// <summary>
        /// Checks to see if the SessionRenewDisabled property is set.
        /// </summary>
        internal bool IsSetSessionRenewDisabled() => this.SessionRenewDisabled.HasValue;

        /// <summary>
        /// Gets and sets the property StorageCacheMaxMemorySize. 
        /// <para>
        /// Maximum size (in bytes) a shard’s cache can reach before it starts rejecting writes.
        /// Must be greater than storageCacheSnapShotMemorySize and lower than instance’s total
        /// memory capacity. We recommend setting it to below 15% of the total memory capacity.
        /// </para>
        ///  
        /// <para>
        /// Default: 1073741824
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000000000000)]
        public long? StorageCacheMaxMemorySize { get; set; }

        /// <summary>
        /// Checks to see if the StorageCacheMaxMemorySize property is set.
        /// </summary>
        internal bool IsSetStorageCacheMaxMemorySize() => this.StorageCacheMaxMemorySize.HasValue;

        /// <summary>
        /// Gets and sets the property StorageCacheSnapshotMemorySize. 
        /// <para>
        /// Size (in bytes) at which the storage engine will snapshot the cache and write it to
        /// a TSM file to make more memory available. Must not be greater than storageCacheMaxMemorySize.
        /// </para>
        ///  
        /// <para>
        /// Default: 26214400
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000000000000)]
        public long? StorageCacheSnapshotMemorySize { get; set; }

        /// <summary>
        /// Checks to see if the StorageCacheSnapshotMemorySize property is set.
        /// </summary>
        internal bool IsSetStorageCacheSnapshotMemorySize() => this.StorageCacheSnapshotMemorySize.HasValue;

        /// <summary>
        /// Gets and sets the property StorageCacheSnapshotWriteColdDuration. 
        /// <para>
        /// Duration at which the storage engine will snapshot the cache and write it to a new
        /// TSM file if the shard hasn’t received writes or deletes.
        /// </para>
        ///  
        /// <para>
        /// Default: 10 minutes
        /// </para>
        /// </summary>
        public Duration StorageCacheSnapshotWriteColdDuration { get; set; }

        /// <summary>
        /// Checks to see if the StorageCacheSnapshotWriteColdDuration property is set.
        /// </summary>
        internal bool IsSetStorageCacheSnapshotWriteColdDuration() => this.StorageCacheSnapshotWriteColdDuration != null;

        /// <summary>
        /// Gets and sets the property StorageCompactFullWriteColdDuration. 
        /// <para>
        /// Duration at which the storage engine will compact all TSM files in a shard if it hasn't
        /// received writes or deletes.
        /// </para>
        ///  
        /// <para>
        /// Default: 4 hours
        /// </para>
        /// </summary>
        public Duration StorageCompactFullWriteColdDuration { get; set; }

        /// <summary>
        /// Checks to see if the StorageCompactFullWriteColdDuration property is set.
        /// </summary>
        internal bool IsSetStorageCompactFullWriteColdDuration() => this.StorageCompactFullWriteColdDuration != null;

        /// <summary>
        /// Gets and sets the property StorageCompactThroughputBurst. 
        /// <para>
        /// Rate limit (in bytes per second) that TSM compactions can write to disk.
        /// </para>
        ///  
        /// <para>
        /// Default: 50331648
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000000000000)]
        public long? StorageCompactThroughputBurst { get; set; }

        /// <summary>
        /// Checks to see if the StorageCompactThroughputBurst property is set.
        /// </summary>
        internal bool IsSetStorageCompactThroughputBurst() => this.StorageCompactThroughputBurst.HasValue;

        /// <summary>
        /// Gets and sets the property StorageMaxConcurrentCompactions. 
        /// <para>
        /// Maximum number of full and level compactions that can run concurrently. A value of
        /// 0 results in 50% of runtime.GOMAXPROCS(0) used at runtime. Any number greater than
        /// zero limits compactions to that value. This setting does not apply to cache snapshotting.
        /// </para>
        ///  
        /// <para>
        /// Default: 0
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public int? StorageMaxConcurrentCompactions { get; set; }

        /// <summary>
        /// Checks to see if the StorageMaxConcurrentCompactions property is set.
        /// </summary>
        internal bool IsSetStorageMaxConcurrentCompactions() => this.StorageMaxConcurrentCompactions.HasValue;

        /// <summary>
        /// Gets and sets the property StorageMaxIndexLogFileSize. 
        /// <para>
        /// Size (in bytes) at which an index write-ahead log (WAL) file will compact into an
        /// index file. Lower sizes will cause log files to be compacted more quickly and result
        /// in lower heap usage at the expense of write throughput.
        /// </para>
        ///  
        /// <para>
        /// Default: 1048576
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000000000000)]
        public long? StorageMaxIndexLogFileSize { get; set; }

        /// <summary>
        /// Checks to see if the StorageMaxIndexLogFileSize property is set.
        /// </summary>
        internal bool IsSetStorageMaxIndexLogFileSize() => this.StorageMaxIndexLogFileSize.HasValue;

        /// <summary>
        /// Gets and sets the property StorageNoValidateFieldSize. 
        /// <para>
        /// Skip field size validation on incoming write requests.
        /// </para>
        ///  
        /// <para>
        /// Default: false
        /// </para>
        /// </summary>
        public bool? StorageNoValidateFieldSize { get; set; }

        /// <summary>
        /// Checks to see if the StorageNoValidateFieldSize property is set.
        /// </summary>
        internal bool IsSetStorageNoValidateFieldSize() => this.StorageNoValidateFieldSize.HasValue;

        /// <summary>
        /// Gets and sets the property StorageRetentionCheckInterval. 
        /// <para>
        /// Interval of retention policy enforcement checks. Must be greater than 0.
        /// </para>
        ///  
        /// <para>
        /// Default: 30 minutes
        /// </para>
        /// </summary>
        public Duration StorageRetentionCheckInterval { get; set; }

        /// <summary>
        /// Checks to see if the StorageRetentionCheckInterval property is set.
        /// </summary>
        internal bool IsSetStorageRetentionCheckInterval() => this.StorageRetentionCheckInterval != null;

        /// <summary>
        /// Gets and sets the property StorageSeriesFileMaxConcurrentSnapshotCompactions. 
        /// <para>
        /// Maximum number of snapshot compactions that can run concurrently across all series
        /// partitions in a database.
        /// </para>
        ///  
        /// <para>
        /// Default: 0
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public int? StorageSeriesFileMaxConcurrentSnapshotCompactions { get; set; }

        /// <summary>
        /// Checks to see if the StorageSeriesFileMaxConcurrentSnapshotCompactions property is set.
        /// </summary>
        internal bool IsSetStorageSeriesFileMaxConcurrentSnapshotCompactions() => this.StorageSeriesFileMaxConcurrentSnapshotCompactions.HasValue;

        /// <summary>
        /// Gets and sets the property StorageSeriesIdSetCacheSize. 
        /// <para>
        /// Size of the internal cache used in the TSI index to store previously calculated series
        /// results. Cached results are returned quickly rather than needing to be recalculated
        /// when a subsequent query with the same tag key/value predicate is executed. Setting
        /// this value to 0 will disable the cache and may decrease query performance.
        /// </para>
        ///  
        /// <para>
        /// Default: 100
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000000000000)]
        public long? StorageSeriesIdSetCacheSize { get; set; }

        /// <summary>
        /// Checks to see if the StorageSeriesIdSetCacheSize property is set.
        /// </summary>
        internal bool IsSetStorageSeriesIdSetCacheSize() => this.StorageSeriesIdSetCacheSize.HasValue;

        /// <summary>
        /// Gets and sets the property StorageWalMaxConcurrentWrites. 
        /// <para>
        /// Maximum number writes to the WAL directory to attempt at the same time. Setting this
        /// value to 0 results in number of processing units available x2.
        /// </para>
        ///  
        /// <para>
        /// Default: 0
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public int? StorageWalMaxConcurrentWrites { get; set; }

        /// <summary>
        /// Checks to see if the StorageWalMaxConcurrentWrites property is set.
        /// </summary>
        internal bool IsSetStorageWalMaxConcurrentWrites() => this.StorageWalMaxConcurrentWrites.HasValue;

        /// <summary>
        /// Gets and sets the property StorageWalMaxWriteDelay. 
        /// <para>
        /// Maximum amount of time a write request to the WAL directory will wait when the <a
        /// href="https://docs.influxdata.com/influxdb/v2/reference/config-options/#storage-wal-max-concurrent-writes">maximum
        /// number of concurrent active writes to the WAL directory has been met</a>. Set to 0
        /// to disable the timeout.
        /// </para>
        ///  
        /// <para>
        /// Default: 10 minutes
        /// </para>
        /// </summary>
        public Duration StorageWalMaxWriteDelay { get; set; }

        /// <summary>
        /// Checks to see if the StorageWalMaxWriteDelay property is set.
        /// </summary>
        internal bool IsSetStorageWalMaxWriteDelay() => this.StorageWalMaxWriteDelay != null;

        /// <summary>
        /// Gets and sets the property TracingType. 
        /// <para>
        /// Enable tracing in InfluxDB and specifies the tracing type. Tracing is disabled by
        /// default.
        /// </para>
        /// </summary>
        public TracingType TracingType { get; set; }

        /// <summary>
        /// Checks to see if the TracingType property is set.
        /// </summary>
        internal bool IsSetTracingType() => this.TracingType != null;

        /// <summary>
        /// Gets and sets the property UiDisabled. 
        /// <para>
        /// Disable the InfluxDB user interface (UI). The UI is enabled by default.
        /// </para>
        ///  
        /// <para>
        /// Default: false
        /// </para>
        /// </summary>
        public bool? UiDisabled { get; set; }

        /// <summary>
        /// Checks to see if the UiDisabled property is set.
        /// </summary>
        internal bool IsSetUiDisabled() => this.UiDisabled.HasValue;
    }
}
