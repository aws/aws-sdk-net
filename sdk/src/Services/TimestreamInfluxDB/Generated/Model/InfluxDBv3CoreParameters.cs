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
    /// All the customer-modifiable InfluxDB v3 Core parameters in Timestream for InfluxDB.
    /// </summary>
    public partial class InfluxDBv3CoreParameters
    {
        private string _dataFusionConfig;
        private int? _dataFusionMaxParquetFanout;
        private int? _dataFusionNumThreads;
        private bool? _dataFusionRuntimeDisableLifoSlot;
        private int? _dataFusionRuntimeEventInterval;
        private int? _dataFusionRuntimeGlobalQueueInterval;
        private int? _dataFusionRuntimeMaxBlockingThreads;
        private int? _dataFusionRuntimeMaxIoEventsPerTick;
        private Duration _dataFusionRuntimeThreadKeepAlive;
        private int? _dataFusionRuntimeThreadPriority;
        private DataFusionRuntimeType _dataFusionRuntimeType;
        private bool? _dataFusionUseCachedParquetLoader;
        private Duration _deleteGracePeriod;
        private bool? _disableParquetMemCache;
        private Duration _distinctCacheEvictionInterval;
        private PercentOrAbsoluteLong _execMemPoolBytes;
        private PercentOrAbsoluteLong _forceSnapshotMemThreshold;
        private Duration _gen1Duration;
        private Duration _gen1LookbackDuration;
        private Duration _hardDeleteDefaultDuration;
        private Duration _lastCacheEvictionInterval;
        private string _logFilter;
        private LogFormats _logFormat;
        private long? _maxHttpRequestSize;
        private Duration _parquetMemCachePruneInterval;
        private float? _parquetMemCachePrunePercentage;
        private Duration _parquetMemCacheQueryPathDuration;
        private PercentOrAbsoluteLong _parquetMemCacheSize;
        private Duration _preemptiveCacheAge;
        private int? _queryFileLimit;
        private int? _queryLogSize;
        private Duration _retentionCheckInterval;
        private int? _snapshottedWalFilesToKeep;
        private int? _tableIndexCacheConcurrencyLimit;
        private int? _tableIndexCacheMaxEntries;
        private int? _walMaxWriteBufferSize;
        private int? _walReplayConcurrencyLimit;
        private bool? _walReplayFailOnError;
        private int? _walSnapshotSize;

        /// <summary>
        /// Gets and sets the property DataFusionConfig. 
        /// <para>
        /// Provides custom configuration to DataFusion as a comma-separated list of key:value
        /// pairs.
        /// </para>
        /// </summary>
        public string DataFusionConfig
        {
            get { return this._dataFusionConfig; }
            set { this._dataFusionConfig = value; }
        }

        // Check to see if DataFusionConfig property is set
        internal bool IsSetDataFusionConfig()
        {
            return this._dataFusionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property DataFusionMaxParquetFanout. 
        /// <para>
        /// When multiple parquet files are required in a sorted way (deduplication for example),
        /// specifies the maximum fanout.
        /// </para>
        ///  
        /// <para>
        /// Default: 1000
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000000)]
        public int DataFusionMaxParquetFanout
        {
            get { return this._dataFusionMaxParquetFanout.GetValueOrDefault(); }
            set { this._dataFusionMaxParquetFanout = value; }
        }

        // Check to see if DataFusionMaxParquetFanout property is set
        internal bool IsSetDataFusionMaxParquetFanout()
        {
            return this._dataFusionMaxParquetFanout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataFusionNumThreads. 
        /// <para>
        /// Sets the maximum number of DataFusion runtime threads to use.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public int DataFusionNumThreads
        {
            get { return this._dataFusionNumThreads.GetValueOrDefault(); }
            set { this._dataFusionNumThreads = value; }
        }

        // Check to see if DataFusionNumThreads property is set
        internal bool IsSetDataFusionNumThreads()
        {
            return this._dataFusionNumThreads.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataFusionRuntimeDisableLifoSlot. 
        /// <para>
        /// Disables the LIFO slot of the DataFusion runtime.
        /// </para>
        /// </summary>
        public bool DataFusionRuntimeDisableLifoSlot
        {
            get { return this._dataFusionRuntimeDisableLifoSlot.GetValueOrDefault(); }
            set { this._dataFusionRuntimeDisableLifoSlot = value; }
        }

        // Check to see if DataFusionRuntimeDisableLifoSlot property is set
        internal bool IsSetDataFusionRuntimeDisableLifoSlot()
        {
            return this._dataFusionRuntimeDisableLifoSlot.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataFusionRuntimeEventInterval. 
        /// <para>
        /// Sets the number of scheduler ticks after which the scheduler of the DataFusion tokio
        /// runtime polls for external events–for example: timers, I/O.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public int DataFusionRuntimeEventInterval
        {
            get { return this._dataFusionRuntimeEventInterval.GetValueOrDefault(); }
            set { this._dataFusionRuntimeEventInterval = value; }
        }

        // Check to see if DataFusionRuntimeEventInterval property is set
        internal bool IsSetDataFusionRuntimeEventInterval()
        {
            return this._dataFusionRuntimeEventInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataFusionRuntimeGlobalQueueInterval. 
        /// <para>
        /// Sets the number of scheduler ticks after which the scheduler of the DataFusion runtime
        /// polls the global task queue.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public int DataFusionRuntimeGlobalQueueInterval
        {
            get { return this._dataFusionRuntimeGlobalQueueInterval.GetValueOrDefault(); }
            set { this._dataFusionRuntimeGlobalQueueInterval = value; }
        }

        // Check to see if DataFusionRuntimeGlobalQueueInterval property is set
        internal bool IsSetDataFusionRuntimeGlobalQueueInterval()
        {
            return this._dataFusionRuntimeGlobalQueueInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataFusionRuntimeMaxBlockingThreads. 
        /// <para>
        /// Specifies the limit for additional threads spawned by the DataFusion runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public int DataFusionRuntimeMaxBlockingThreads
        {
            get { return this._dataFusionRuntimeMaxBlockingThreads.GetValueOrDefault(); }
            set { this._dataFusionRuntimeMaxBlockingThreads = value; }
        }

        // Check to see if DataFusionRuntimeMaxBlockingThreads property is set
        internal bool IsSetDataFusionRuntimeMaxBlockingThreads()
        {
            return this._dataFusionRuntimeMaxBlockingThreads.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataFusionRuntimeMaxIoEventsPerTick. 
        /// <para>
        /// Configures the maximum number of events processed per tick by the tokio DataFusion
        /// runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public int DataFusionRuntimeMaxIoEventsPerTick
        {
            get { return this._dataFusionRuntimeMaxIoEventsPerTick.GetValueOrDefault(); }
            set { this._dataFusionRuntimeMaxIoEventsPerTick = value; }
        }

        // Check to see if DataFusionRuntimeMaxIoEventsPerTick property is set
        internal bool IsSetDataFusionRuntimeMaxIoEventsPerTick()
        {
            return this._dataFusionRuntimeMaxIoEventsPerTick.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataFusionRuntimeThreadKeepAlive. 
        /// <para>
        /// Sets a custom timeout for a thread in the blocking pool of the tokio DataFusion runtime.
        /// </para>
        /// </summary>
        public Duration DataFusionRuntimeThreadKeepAlive
        {
            get { return this._dataFusionRuntimeThreadKeepAlive; }
            set { this._dataFusionRuntimeThreadKeepAlive = value; }
        }

        // Check to see if DataFusionRuntimeThreadKeepAlive property is set
        internal bool IsSetDataFusionRuntimeThreadKeepAlive()
        {
            return this._dataFusionRuntimeThreadKeepAlive != null;
        }

        /// <summary>
        /// Gets and sets the property DataFusionRuntimeThreadPriority. 
        /// <para>
        /// Sets the thread priority for tokio DataFusion runtime workers.
        /// </para>
        ///  
        /// <para>
        /// Default: 10
        /// </para>
        /// </summary>
        [AWSProperty(Min=-20, Max=19)]
        public int DataFusionRuntimeThreadPriority
        {
            get { return this._dataFusionRuntimeThreadPriority.GetValueOrDefault(); }
            set { this._dataFusionRuntimeThreadPriority = value; }
        }

        // Check to see if DataFusionRuntimeThreadPriority property is set
        internal bool IsSetDataFusionRuntimeThreadPriority()
        {
            return this._dataFusionRuntimeThreadPriority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataFusionRuntimeType. 
        /// <para>
        /// Specifies the DataFusion tokio runtime type.
        /// </para>
        ///  
        /// <para>
        /// Default: multi-thread
        /// </para>
        /// </summary>
        public DataFusionRuntimeType DataFusionRuntimeType
        {
            get { return this._dataFusionRuntimeType; }
            set { this._dataFusionRuntimeType = value; }
        }

        // Check to see if DataFusionRuntimeType property is set
        internal bool IsSetDataFusionRuntimeType()
        {
            return this._dataFusionRuntimeType != null;
        }

        /// <summary>
        /// Gets and sets the property DataFusionUseCachedParquetLoader. 
        /// <para>
        /// Uses a cached parquet loader when reading parquet files from the object store.
        /// </para>
        /// </summary>
        public bool DataFusionUseCachedParquetLoader
        {
            get { return this._dataFusionUseCachedParquetLoader.GetValueOrDefault(); }
            set { this._dataFusionUseCachedParquetLoader = value; }
        }

        // Check to see if DataFusionUseCachedParquetLoader property is set
        internal bool IsSetDataFusionUseCachedParquetLoader()
        {
            return this._dataFusionUseCachedParquetLoader.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeleteGracePeriod. 
        /// <para>
        /// Specifies the grace period before permanently deleting data.
        /// </para>
        ///  
        /// <para>
        /// Default: 24h
        /// </para>
        /// </summary>
        public Duration DeleteGracePeriod
        {
            get { return this._deleteGracePeriod; }
            set { this._deleteGracePeriod = value; }
        }

        // Check to see if DeleteGracePeriod property is set
        internal bool IsSetDeleteGracePeriod()
        {
            return this._deleteGracePeriod != null;
        }

        /// <summary>
        /// Gets and sets the property DisableParquetMemCache. 
        /// <para>
        /// Disables the in-memory Parquet cache. By default, the cache is enabled.
        /// </para>
        /// </summary>
        public bool DisableParquetMemCache
        {
            get { return this._disableParquetMemCache.GetValueOrDefault(); }
            set { this._disableParquetMemCache = value; }
        }

        // Check to see if DisableParquetMemCache property is set
        internal bool IsSetDisableParquetMemCache()
        {
            return this._disableParquetMemCache.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DistinctCacheEvictionInterval. 
        /// <para>
        /// Specifies the interval to evict expired entries from the distinct value cache, expressed
        /// as a human-readable duration–for example: 20s, 1m, 1h.
        /// </para>
        ///  
        /// <para>
        /// Default: 10s
        /// </para>
        /// </summary>
        public Duration DistinctCacheEvictionInterval
        {
            get { return this._distinctCacheEvictionInterval; }
            set { this._distinctCacheEvictionInterval = value; }
        }

        // Check to see if DistinctCacheEvictionInterval property is set
        internal bool IsSetDistinctCacheEvictionInterval()
        {
            return this._distinctCacheEvictionInterval != null;
        }

        /// <summary>
        /// Gets and sets the property ExecMemPoolBytes. 
        /// <para>
        /// Specifies the size of memory pool used during query execution. Can be given as absolute
        /// value in bytes or as a percentage of the total available memory–for example: 8000000000
        /// or 10%.
        /// </para>
        ///  
        /// <para>
        /// Default: 20%
        /// </para>
        /// </summary>
        public PercentOrAbsoluteLong ExecMemPoolBytes
        {
            get { return this._execMemPoolBytes; }
            set { this._execMemPoolBytes = value; }
        }

        // Check to see if ExecMemPoolBytes property is set
        internal bool IsSetExecMemPoolBytes()
        {
            return this._execMemPoolBytes != null;
        }

        /// <summary>
        /// Gets and sets the property ForceSnapshotMemThreshold. 
        /// <para>
        /// Specifies the threshold for the internal memory buffer. Supports either a percentage
        /// (portion of available memory) or absolute value in MB–for example: 70% or 100
        /// </para>
        ///  
        /// <para>
        /// Default: 70%
        /// </para>
        /// </summary>
        public PercentOrAbsoluteLong ForceSnapshotMemThreshold
        {
            get { return this._forceSnapshotMemThreshold; }
            set { this._forceSnapshotMemThreshold = value; }
        }

        // Check to see if ForceSnapshotMemThreshold property is set
        internal bool IsSetForceSnapshotMemThreshold()
        {
            return this._forceSnapshotMemThreshold != null;
        }

        /// <summary>
        /// Gets and sets the property Gen1Duration. 
        /// <para>
        /// Specifies the duration that Parquet files are arranged into. Data timestamps land
        /// each row into a file of this duration. Supported durations are 1m, 5m, and 10m. These
        /// files are known as “generation 1” files that the compactor in InfluxDB 3 Enterprise
        /// can merge into larger generations.
        /// </para>
        ///  
        /// <para>
        /// Default: 10m
        /// </para>
        /// </summary>
        public Duration Gen1Duration
        {
            get { return this._gen1Duration; }
            set { this._gen1Duration = value; }
        }

        // Check to see if Gen1Duration property is set
        internal bool IsSetGen1Duration()
        {
            return this._gen1Duration != null;
        }

        /// <summary>
        /// Gets and sets the property Gen1LookbackDuration. 
        /// <para>
        /// Specifies how far back to look when creating generation 1 Parquet files.
        /// </para>
        ///  
        /// <para>
        /// Default: 24h
        /// </para>
        /// </summary>
        public Duration Gen1LookbackDuration
        {
            get { return this._gen1LookbackDuration; }
            set { this._gen1LookbackDuration = value; }
        }

        // Check to see if Gen1LookbackDuration property is set
        internal bool IsSetGen1LookbackDuration()
        {
            return this._gen1LookbackDuration != null;
        }

        /// <summary>
        /// Gets and sets the property HardDeleteDefaultDuration. 
        /// <para>
        /// Sets the default duration for hard deletion of data.
        /// </para>
        ///  
        /// <para>
        /// Default: 90d
        /// </para>
        /// </summary>
        public Duration HardDeleteDefaultDuration
        {
            get { return this._hardDeleteDefaultDuration; }
            set { this._hardDeleteDefaultDuration = value; }
        }

        // Check to see if HardDeleteDefaultDuration property is set
        internal bool IsSetHardDeleteDefaultDuration()
        {
            return this._hardDeleteDefaultDuration != null;
        }

        /// <summary>
        /// Gets and sets the property LastCacheEvictionInterval. 
        /// <para>
        /// Specifies the interval to evict expired entries from the Last-N-Value cache, expressed
        /// as a human-readable duration–for example: 20s, 1m, 1h.
        /// </para>
        ///  
        /// <para>
        /// Default: 10s
        /// </para>
        /// </summary>
        public Duration LastCacheEvictionInterval
        {
            get { return this._lastCacheEvictionInterval; }
            set { this._lastCacheEvictionInterval = value; }
        }

        // Check to see if LastCacheEvictionInterval property is set
        internal bool IsSetLastCacheEvictionInterval()
        {
            return this._lastCacheEvictionInterval != null;
        }

        /// <summary>
        /// Gets and sets the property LogFilter. 
        /// <para>
        /// Sets the filter directive for logs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string LogFilter
        {
            get { return this._logFilter; }
            set { this._logFilter = value; }
        }

        // Check to see if LogFilter property is set
        internal bool IsSetLogFilter()
        {
            return this._logFilter != null;
        }

        /// <summary>
        /// Gets and sets the property LogFormat. 
        /// <para>
        /// Defines the message format for logs.
        /// </para>
        ///  
        /// <para>
        /// Default: full
        /// </para>
        /// </summary>
        public LogFormats LogFormat
        {
            get { return this._logFormat; }
            set { this._logFormat = value; }
        }

        // Check to see if LogFormat property is set
        internal bool IsSetLogFormat()
        {
            return this._logFormat != null;
        }

        /// <summary>
        /// Gets and sets the property MaxHttpRequestSize. 
        /// <para>
        /// Specifies the maximum size of HTTP requests.
        /// </para>
        ///  
        /// <para>
        /// Default: 10485760
        /// </para>
        /// </summary>
        [AWSProperty(Min=1024, Max=16777216)]
        public long MaxHttpRequestSize
        {
            get { return this._maxHttpRequestSize.GetValueOrDefault(); }
            set { this._maxHttpRequestSize = value; }
        }

        // Check to see if MaxHttpRequestSize property is set
        internal bool IsSetMaxHttpRequestSize()
        {
            return this._maxHttpRequestSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParquetMemCachePruneInterval. 
        /// <para>
        /// Sets the interval to check if the in-memory Parquet cache needs to be pruned.
        /// </para>
        ///  
        /// <para>
        /// Default: 1s
        /// </para>
        /// </summary>
        public Duration ParquetMemCachePruneInterval
        {
            get { return this._parquetMemCachePruneInterval; }
            set { this._parquetMemCachePruneInterval = value; }
        }

        // Check to see if ParquetMemCachePruneInterval property is set
        internal bool IsSetParquetMemCachePruneInterval()
        {
            return this._parquetMemCachePruneInterval != null;
        }

        /// <summary>
        /// Gets and sets the property ParquetMemCachePrunePercentage. 
        /// <para>
        /// Specifies the percentage of entries to prune during a prune operation on the in-memory
        /// Parquet cache.
        /// </para>
        ///  
        /// <para>
        /// Default: 0.1
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public float ParquetMemCachePrunePercentage
        {
            get { return this._parquetMemCachePrunePercentage.GetValueOrDefault(); }
            set { this._parquetMemCachePrunePercentage = value; }
        }

        // Check to see if ParquetMemCachePrunePercentage property is set
        internal bool IsSetParquetMemCachePrunePercentage()
        {
            return this._parquetMemCachePrunePercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParquetMemCacheQueryPathDuration. 
        /// <para>
        /// Specifies the time window for caching recent Parquet files in memory.
        /// </para>
        ///  
        /// <para>
        /// Default: 5h
        /// </para>
        /// </summary>
        public Duration ParquetMemCacheQueryPathDuration
        {
            get { return this._parquetMemCacheQueryPathDuration; }
            set { this._parquetMemCacheQueryPathDuration = value; }
        }

        // Check to see if ParquetMemCacheQueryPathDuration property is set
        internal bool IsSetParquetMemCacheQueryPathDuration()
        {
            return this._parquetMemCacheQueryPathDuration != null;
        }

        /// <summary>
        /// Gets and sets the property ParquetMemCacheSize. 
        /// <para>
        /// Specifies the size of the in-memory Parquet cache in megabytes or percentage of total
        /// available memory.
        /// </para>
        ///  
        /// <para>
        /// Default: 20%
        /// </para>
        /// </summary>
        public PercentOrAbsoluteLong ParquetMemCacheSize
        {
            get { return this._parquetMemCacheSize; }
            set { this._parquetMemCacheSize = value; }
        }

        // Check to see if ParquetMemCacheSize property is set
        internal bool IsSetParquetMemCacheSize()
        {
            return this._parquetMemCacheSize != null;
        }

        /// <summary>
        /// Gets and sets the property PreemptiveCacheAge. 
        /// <para>
        /// Specifies the interval to prefetch into the Parquet cache during compaction.
        /// </para>
        ///  
        /// <para>
        /// Default: 3d
        /// </para>
        /// </summary>
        public Duration PreemptiveCacheAge
        {
            get { return this._preemptiveCacheAge; }
            set { this._preemptiveCacheAge = value; }
        }

        // Check to see if PreemptiveCacheAge property is set
        internal bool IsSetPreemptiveCacheAge()
        {
            return this._preemptiveCacheAge != null;
        }

        /// <summary>
        /// Gets and sets the property QueryFileLimit. 
        /// <para>
        /// Limits the number of Parquet files a query can access. If a query attempts to read
        /// more than this limit, InfluxDB 3 returns an error.
        /// </para>
        ///  
        /// <para>
        /// Default: 432
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public int QueryFileLimit
        {
            get { return this._queryFileLimit.GetValueOrDefault(); }
            set { this._queryFileLimit = value; }
        }

        // Check to see if QueryFileLimit property is set
        internal bool IsSetQueryFileLimit()
        {
            return this._queryFileLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryLogSize. 
        /// <para>
        /// Defines the size of the query log. Up to this many queries remain in the log before
        /// older queries are evicted to make room for new ones.
        /// </para>
        ///  
        /// <para>
        /// Default: 1000
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public int QueryLogSize
        {
            get { return this._queryLogSize.GetValueOrDefault(); }
            set { this._queryLogSize = value; }
        }

        // Check to see if QueryLogSize property is set
        internal bool IsSetQueryLogSize()
        {
            return this._queryLogSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetentionCheckInterval. 
        /// <para>
        /// The interval at which retention policies are checked and enforced. Enter as a human-readable
        /// time–for example: 30m or 1h.
        /// </para>
        ///  
        /// <para>
        /// Default: 30m
        /// </para>
        /// </summary>
        public Duration RetentionCheckInterval
        {
            get { return this._retentionCheckInterval; }
            set { this._retentionCheckInterval = value; }
        }

        // Check to see if RetentionCheckInterval property is set
        internal bool IsSetRetentionCheckInterval()
        {
            return this._retentionCheckInterval != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshottedWalFilesToKeep. 
        /// <para>
        /// Specifies the number of snapshotted WAL files to retain in the object store. Flushing
        /// the WAL files does not clear the WAL files immediately; they are deleted when the
        /// number of snapshotted WAL files exceeds this number.
        /// </para>
        ///  
        /// <para>
        /// Default: 300
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10000)]
        public int SnapshottedWalFilesToKeep
        {
            get { return this._snapshottedWalFilesToKeep.GetValueOrDefault(); }
            set { this._snapshottedWalFilesToKeep = value; }
        }

        // Check to see if SnapshottedWalFilesToKeep property is set
        internal bool IsSetSnapshottedWalFilesToKeep()
        {
            return this._snapshottedWalFilesToKeep.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TableIndexCacheConcurrencyLimit. 
        /// <para>
        /// Limits the concurrency level for table index cache operations.
        /// </para>
        ///  
        /// <para>
        /// Default: 8
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int TableIndexCacheConcurrencyLimit
        {
            get { return this._tableIndexCacheConcurrencyLimit.GetValueOrDefault(); }
            set { this._tableIndexCacheConcurrencyLimit = value; }
        }

        // Check to see if TableIndexCacheConcurrencyLimit property is set
        internal bool IsSetTableIndexCacheConcurrencyLimit()
        {
            return this._tableIndexCacheConcurrencyLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TableIndexCacheMaxEntries. 
        /// <para>
        /// Specifies the maximum number of entries in the table index cache.
        /// </para>
        ///  
        /// <para>
        /// Default: 1000
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int TableIndexCacheMaxEntries
        {
            get { return this._tableIndexCacheMaxEntries.GetValueOrDefault(); }
            set { this._tableIndexCacheMaxEntries = value; }
        }

        // Check to see if TableIndexCacheMaxEntries property is set
        internal bool IsSetTableIndexCacheMaxEntries()
        {
            return this._tableIndexCacheMaxEntries.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WalMaxWriteBufferSize. 
        /// <para>
        /// Specifies the maximum number of write requests that can be buffered before a flush
        /// must be executed and succeed.
        /// </para>
        ///  
        /// <para>
        /// Default: 100000
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000000)]
        public int WalMaxWriteBufferSize
        {
            get { return this._walMaxWriteBufferSize.GetValueOrDefault(); }
            set { this._walMaxWriteBufferSize = value; }
        }

        // Check to see if WalMaxWriteBufferSize property is set
        internal bool IsSetWalMaxWriteBufferSize()
        {
            return this._walMaxWriteBufferSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WalReplayConcurrencyLimit. 
        /// <para>
        /// Concurrency limit during WAL replay. Setting this number too high can lead to OOM.
        /// The default is dynamically determined.
        /// </para>
        ///  
        /// <para>
        /// Default: max(num_cpus, 10)
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int WalReplayConcurrencyLimit
        {
            get { return this._walReplayConcurrencyLimit.GetValueOrDefault(); }
            set { this._walReplayConcurrencyLimit = value; }
        }

        // Check to see if WalReplayConcurrencyLimit property is set
        internal bool IsSetWalReplayConcurrencyLimit()
        {
            return this._walReplayConcurrencyLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WalReplayFailOnError. 
        /// <para>
        /// Determines whether WAL replay should fail when encountering errors.
        /// </para>
        ///  
        /// <para>
        /// Default: false
        /// </para>
        /// </summary>
        public bool WalReplayFailOnError
        {
            get { return this._walReplayFailOnError.GetValueOrDefault(); }
            set { this._walReplayFailOnError = value; }
        }

        // Check to see if WalReplayFailOnError property is set
        internal bool IsSetWalReplayFailOnError()
        {
            return this._walReplayFailOnError.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WalSnapshotSize. 
        /// <para>
        /// Defines the number of WAL files to attempt to remove in a snapshot. This, multiplied
        /// by the interval, determines how often snapshots are taken.
        /// </para>
        ///  
        /// <para>
        /// Default: 600
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public int WalSnapshotSize
        {
            get { return this._walSnapshotSize.GetValueOrDefault(); }
            set { this._walSnapshotSize = value; }
        }

        // Check to see if WalSnapshotSize property is set
        internal bool IsSetWalSnapshotSize()
        {
            return this._walSnapshotSize.HasValue; 
        }

    }
}