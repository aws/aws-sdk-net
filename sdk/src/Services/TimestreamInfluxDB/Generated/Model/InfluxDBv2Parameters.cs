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
        private bool? _fluxLogEnabled;
        private Duration _httpIdleTimeout;
        private Duration _httpReadHeaderTimeout;
        private Duration _httpReadTimeout;
        private Duration _httpWriteTimeout;
        private long? _influxqlMaxSelectBuckets;
        private long? _influxqlMaxSelectPoint;
        private long? _influxqlMaxSelectSeries;
        private LogLevel _logLevel;
        private bool? _metricsDisabled;
        private bool? _noTasks;
        private bool? _pprofDisabled;
        private int? _queryConcurrency;
        private long? _queryInitialMemoryBytes;
        private long? _queryMaxMemoryBytes;
        private long? _queryMemoryBytes;
        private int? _queryQueueSize;
        private int? _sessionLength;
        private bool? _sessionRenewDisabled;
        private long? _storageCacheMaxMemorySize;
        private long? _storageCacheSnapshotMemorySize;
        private Duration _storageCacheSnapshotWriteColdDuration;
        private Duration _storageCompactFullWriteColdDuration;
        private long? _storageCompactThroughputBurst;
        private int? _storageMaxConcurrentCompactions;
        private long? _storageMaxIndexLogFileSize;
        private bool? _storageNoValidateFieldSize;
        private Duration _storageRetentionCheckInterval;
        private int? _storageSeriesFileMaxConcurrentSnapshotCompactions;
        private long? _storageSeriesIdSetCacheSize;
        private int? _storageWalMaxConcurrentWrites;
        private Duration _storageWalMaxWriteDelay;
        private TracingType _tracingType;
        private bool? _uiDisabled;

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
        public bool? FluxLogEnabled
        {
            get { return this._fluxLogEnabled; }
            set { this._fluxLogEnabled = value; }
        }

        // Check to see if FluxLogEnabled property is set
        internal bool IsSetFluxLogEnabled()
        {
            return this._fluxLogEnabled.HasValue; 
        }

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
        public Duration HttpIdleTimeout
        {
            get { return this._httpIdleTimeout; }
            set { this._httpIdleTimeout = value; }
        }

        // Check to see if HttpIdleTimeout property is set
        internal bool IsSetHttpIdleTimeout()
        {
            return this._httpIdleTimeout != null;
        }

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
        public Duration HttpReadHeaderTimeout
        {
            get { return this._httpReadHeaderTimeout; }
            set { this._httpReadHeaderTimeout = value; }
        }

        // Check to see if HttpReadHeaderTimeout property is set
        internal bool IsSetHttpReadHeaderTimeout()
        {
            return this._httpReadHeaderTimeout != null;
        }

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
        public Duration HttpReadTimeout
        {
            get { return this._httpReadTimeout; }
            set { this._httpReadTimeout = value; }
        }

        // Check to see if HttpReadTimeout property is set
        internal bool IsSetHttpReadTimeout()
        {
            return this._httpReadTimeout != null;
        }

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
        public Duration HttpWriteTimeout
        {
            get { return this._httpWriteTimeout; }
            set { this._httpWriteTimeout = value; }
        }

        // Check to see if HttpWriteTimeout property is set
        internal bool IsSetHttpWriteTimeout()
        {
            return this._httpWriteTimeout != null;
        }

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
        [AWSProperty(Min=0, Max=1000000000000)]
        public long? InfluxqlMaxSelectBuckets
        {
            get { return this._influxqlMaxSelectBuckets; }
            set { this._influxqlMaxSelectBuckets = value; }
        }

        // Check to see if InfluxqlMaxSelectBuckets property is set
        internal bool IsSetInfluxqlMaxSelectBuckets()
        {
            return this._influxqlMaxSelectBuckets.HasValue; 
        }

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
        [AWSProperty(Min=0, Max=1000000000000)]
        public long? InfluxqlMaxSelectPoint
        {
            get { return this._influxqlMaxSelectPoint; }
            set { this._influxqlMaxSelectPoint = value; }
        }

        // Check to see if InfluxqlMaxSelectPoint property is set
        internal bool IsSetInfluxqlMaxSelectPoint()
        {
            return this._influxqlMaxSelectPoint.HasValue; 
        }

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
        [AWSProperty(Min=0, Max=1000000000000)]
        public long? InfluxqlMaxSelectSeries
        {
            get { return this._influxqlMaxSelectSeries; }
            set { this._influxqlMaxSelectSeries = value; }
        }

        // Check to see if InfluxqlMaxSelectSeries property is set
        internal bool IsSetInfluxqlMaxSelectSeries()
        {
            return this._influxqlMaxSelectSeries.HasValue; 
        }

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
        public LogLevel LogLevel
        {
            get { return this._logLevel; }
            set { this._logLevel = value; }
        }

        // Check to see if LogLevel property is set
        internal bool IsSetLogLevel()
        {
            return this._logLevel != null;
        }

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
        public bool? MetricsDisabled
        {
            get { return this._metricsDisabled; }
            set { this._metricsDisabled = value; }
        }

        // Check to see if MetricsDisabled property is set
        internal bool IsSetMetricsDisabled()
        {
            return this._metricsDisabled.HasValue; 
        }

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
        public bool? NoTasks
        {
            get { return this._noTasks; }
            set { this._noTasks = value; }
        }

        // Check to see if NoTasks property is set
        internal bool IsSetNoTasks()
        {
            return this._noTasks.HasValue; 
        }

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
        public bool? PprofDisabled
        {
            get { return this._pprofDisabled; }
            set { this._pprofDisabled = value; }
        }

        // Check to see if PprofDisabled property is set
        internal bool IsSetPprofDisabled()
        {
            return this._pprofDisabled.HasValue; 
        }

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
        [AWSProperty(Min=0, Max=256)]
        public int? QueryConcurrency
        {
            get { return this._queryConcurrency; }
            set { this._queryConcurrency = value; }
        }

        // Check to see if QueryConcurrency property is set
        internal bool IsSetQueryConcurrency()
        {
            return this._queryConcurrency.HasValue; 
        }

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
        [AWSProperty(Min=0, Max=1000000000000)]
        public long? QueryInitialMemoryBytes
        {
            get { return this._queryInitialMemoryBytes; }
            set { this._queryInitialMemoryBytes = value; }
        }

        // Check to see if QueryInitialMemoryBytes property is set
        internal bool IsSetQueryInitialMemoryBytes()
        {
            return this._queryInitialMemoryBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryMaxMemoryBytes. 
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
        [AWSProperty(Min=0, Max=1000000000000)]
        public long? QueryMaxMemoryBytes
        {
            get { return this._queryMaxMemoryBytes; }
            set { this._queryMaxMemoryBytes = value; }
        }

        // Check to see if QueryMaxMemoryBytes property is set
        internal bool IsSetQueryMaxMemoryBytes()
        {
            return this._queryMaxMemoryBytes.HasValue; 
        }

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
        [AWSProperty(Min=0, Max=1000000000000)]
        public long? QueryMemoryBytes
        {
            get { return this._queryMemoryBytes; }
            set { this._queryMemoryBytes = value; }
        }

        // Check to see if QueryMemoryBytes property is set
        internal bool IsSetQueryMemoryBytes()
        {
            return this._queryMemoryBytes.HasValue; 
        }

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
        [AWSProperty(Min=0, Max=256)]
        public int? QueryQueueSize
        {
            get { return this._queryQueueSize; }
            set { this._queryQueueSize = value; }
        }

        // Check to see if QueryQueueSize property is set
        internal bool IsSetQueryQueueSize()
        {
            return this._queryQueueSize.HasValue; 
        }

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
        [AWSProperty(Min=1, Max=2880)]
        public int? SessionLength
        {
            get { return this._sessionLength; }
            set { this._sessionLength = value; }
        }

        // Check to see if SessionLength property is set
        internal bool IsSetSessionLength()
        {
            return this._sessionLength.HasValue; 
        }

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
        public bool? SessionRenewDisabled
        {
            get { return this._sessionRenewDisabled; }
            set { this._sessionRenewDisabled = value; }
        }

        // Check to see if SessionRenewDisabled property is set
        internal bool IsSetSessionRenewDisabled()
        {
            return this._sessionRenewDisabled.HasValue; 
        }

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
        [AWSProperty(Min=0, Max=1000000000000)]
        public long? StorageCacheMaxMemorySize
        {
            get { return this._storageCacheMaxMemorySize; }
            set { this._storageCacheMaxMemorySize = value; }
        }

        // Check to see if StorageCacheMaxMemorySize property is set
        internal bool IsSetStorageCacheMaxMemorySize()
        {
            return this._storageCacheMaxMemorySize.HasValue; 
        }

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
        [AWSProperty(Min=0, Max=1000000000000)]
        public long? StorageCacheSnapshotMemorySize
        {
            get { return this._storageCacheSnapshotMemorySize; }
            set { this._storageCacheSnapshotMemorySize = value; }
        }

        // Check to see if StorageCacheSnapshotMemorySize property is set
        internal bool IsSetStorageCacheSnapshotMemorySize()
        {
            return this._storageCacheSnapshotMemorySize.HasValue; 
        }

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
        public Duration StorageCacheSnapshotWriteColdDuration
        {
            get { return this._storageCacheSnapshotWriteColdDuration; }
            set { this._storageCacheSnapshotWriteColdDuration = value; }
        }

        // Check to see if StorageCacheSnapshotWriteColdDuration property is set
        internal bool IsSetStorageCacheSnapshotWriteColdDuration()
        {
            return this._storageCacheSnapshotWriteColdDuration != null;
        }

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
        public Duration StorageCompactFullWriteColdDuration
        {
            get { return this._storageCompactFullWriteColdDuration; }
            set { this._storageCompactFullWriteColdDuration = value; }
        }

        // Check to see if StorageCompactFullWriteColdDuration property is set
        internal bool IsSetStorageCompactFullWriteColdDuration()
        {
            return this._storageCompactFullWriteColdDuration != null;
        }

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
        [AWSProperty(Min=0, Max=1000000000000)]
        public long? StorageCompactThroughputBurst
        {
            get { return this._storageCompactThroughputBurst; }
            set { this._storageCompactThroughputBurst = value; }
        }

        // Check to see if StorageCompactThroughputBurst property is set
        internal bool IsSetStorageCompactThroughputBurst()
        {
            return this._storageCompactThroughputBurst.HasValue; 
        }

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
        [AWSProperty(Min=0, Max=64)]
        public int? StorageMaxConcurrentCompactions
        {
            get { return this._storageMaxConcurrentCompactions; }
            set { this._storageMaxConcurrentCompactions = value; }
        }

        // Check to see if StorageMaxConcurrentCompactions property is set
        internal bool IsSetStorageMaxConcurrentCompactions()
        {
            return this._storageMaxConcurrentCompactions.HasValue; 
        }

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
        [AWSProperty(Min=0, Max=1000000000000)]
        public long? StorageMaxIndexLogFileSize
        {
            get { return this._storageMaxIndexLogFileSize; }
            set { this._storageMaxIndexLogFileSize = value; }
        }

        // Check to see if StorageMaxIndexLogFileSize property is set
        internal bool IsSetStorageMaxIndexLogFileSize()
        {
            return this._storageMaxIndexLogFileSize.HasValue; 
        }

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
        public bool? StorageNoValidateFieldSize
        {
            get { return this._storageNoValidateFieldSize; }
            set { this._storageNoValidateFieldSize = value; }
        }

        // Check to see if StorageNoValidateFieldSize property is set
        internal bool IsSetStorageNoValidateFieldSize()
        {
            return this._storageNoValidateFieldSize.HasValue; 
        }

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
        public Duration StorageRetentionCheckInterval
        {
            get { return this._storageRetentionCheckInterval; }
            set { this._storageRetentionCheckInterval = value; }
        }

        // Check to see if StorageRetentionCheckInterval property is set
        internal bool IsSetStorageRetentionCheckInterval()
        {
            return this._storageRetentionCheckInterval != null;
        }

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
        [AWSProperty(Min=0, Max=64)]
        public int? StorageSeriesFileMaxConcurrentSnapshotCompactions
        {
            get { return this._storageSeriesFileMaxConcurrentSnapshotCompactions; }
            set { this._storageSeriesFileMaxConcurrentSnapshotCompactions = value; }
        }

        // Check to see if StorageSeriesFileMaxConcurrentSnapshotCompactions property is set
        internal bool IsSetStorageSeriesFileMaxConcurrentSnapshotCompactions()
        {
            return this._storageSeriesFileMaxConcurrentSnapshotCompactions.HasValue; 
        }

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
        [AWSProperty(Min=0, Max=1000000000000)]
        public long? StorageSeriesIdSetCacheSize
        {
            get { return this._storageSeriesIdSetCacheSize; }
            set { this._storageSeriesIdSetCacheSize = value; }
        }

        // Check to see if StorageSeriesIdSetCacheSize property is set
        internal bool IsSetStorageSeriesIdSetCacheSize()
        {
            return this._storageSeriesIdSetCacheSize.HasValue; 
        }

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
        [AWSProperty(Min=0, Max=256)]
        public int? StorageWalMaxConcurrentWrites
        {
            get { return this._storageWalMaxConcurrentWrites; }
            set { this._storageWalMaxConcurrentWrites = value; }
        }

        // Check to see if StorageWalMaxConcurrentWrites property is set
        internal bool IsSetStorageWalMaxConcurrentWrites()
        {
            return this._storageWalMaxConcurrentWrites.HasValue; 
        }

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
        public Duration StorageWalMaxWriteDelay
        {
            get { return this._storageWalMaxWriteDelay; }
            set { this._storageWalMaxWriteDelay = value; }
        }

        // Check to see if StorageWalMaxWriteDelay property is set
        internal bool IsSetStorageWalMaxWriteDelay()
        {
            return this._storageWalMaxWriteDelay != null;
        }

        /// <summary>
        /// Gets and sets the property TracingType. 
        /// <para>
        /// Enable tracing in InfluxDB and specifies the tracing type. Tracing is disabled by
        /// default.
        /// </para>
        /// </summary>
        public TracingType TracingType
        {
            get { return this._tracingType; }
            set { this._tracingType = value; }
        }

        // Check to see if TracingType property is set
        internal bool IsSetTracingType()
        {
            return this._tracingType != null;
        }

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
        public bool? UiDisabled
        {
            get { return this._uiDisabled; }
            set { this._uiDisabled = value; }
        }

        // Check to see if UiDisabled property is set
        internal bool IsSetUiDisabled()
        {
            return this._uiDisabled.HasValue; 
        }

    }
}