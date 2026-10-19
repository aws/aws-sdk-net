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
    /// All the customer-modifiable InfluxDB v3 Enterprise parameters in Timestream for InfluxDB.
    /// </summary>
    public partial class InfluxDBv3EnterpriseParameters
    {
        /// <summary>
        /// Gets and sets the property CatalogSyncInterval. 
        /// <para>
        /// Defines how often the catalog synchronizes across cluster nodes.
        /// </para>
        ///  
        /// <para>
        /// Default: 10s
        /// </para>
        /// </summary>
        public Duration CatalogSyncInterval { get; set; }

        /// <summary>
        /// Checks to see if the CatalogSyncInterval property is set.
        /// </summary>
        internal bool IsSetCatalogSyncInterval() => this.CatalogSyncInterval != null;

        /// <summary>
        /// Gets and sets the property CompactionCheckInterval. 
        /// <para>
        /// Specifies how often the compactor checks for new compaction work to perform.
        /// </para>
        ///  
        /// <para>
        /// Default: 10s
        /// </para>
        /// </summary>
        public Duration CompactionCheckInterval { get; set; }

        /// <summary>
        /// Checks to see if the CompactionCheckInterval property is set.
        /// </summary>
        internal bool IsSetCompactionCheckInterval() => this.CompactionCheckInterval != null;

        /// <summary>
        /// Gets and sets the property CompactionCleanupWait. 
        /// <para>
        /// Specifies the amount of time that the compactor waits after finishing a compaction
        /// run to delete files marked as needing deletion during that compaction run.
        /// </para>
        ///  
        /// <para>
        /// Default: 10m
        /// </para>
        /// </summary>
        public Duration CompactionCleanupWait { get; set; }

        /// <summary>
        /// Checks to see if the CompactionCleanupWait property is set.
        /// </summary>
        internal bool IsSetCompactionCleanupWait() => this.CompactionCleanupWait != null;

        /// <summary>
        /// Gets and sets the property CompactionGen2Duration. 
        /// <para>
        /// Specifies the duration of the first level of compaction (gen2). Later levels of compaction
        /// are multiples of this duration. This value should be equal to or greater than the
        /// gen1 duration.
        /// </para>
        ///  
        /// <para>
        /// Default: 20m
        /// </para>
        /// </summary>
        public Duration CompactionGen2Duration { get; set; }

        /// <summary>
        /// Checks to see if the CompactionGen2Duration property is set.
        /// </summary>
        internal bool IsSetCompactionGen2Duration() => this.CompactionGen2Duration != null;

        /// <summary>
        /// Gets and sets the property CompactionMaxNumFilesPerPlan. 
        /// <para>
        /// Sets the maximum number of files included in any compaction plan.
        /// </para>
        ///  
        /// <para>
        /// Default: 500
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10000)]
        public int? CompactionMaxNumFilesPerPlan { get; set; }

        /// <summary>
        /// Checks to see if the CompactionMaxNumFilesPerPlan property is set.
        /// </summary>
        internal bool IsSetCompactionMaxNumFilesPerPlan() => this.CompactionMaxNumFilesPerPlan.HasValue;

        /// <summary>
        /// Gets and sets the property CompactionMultipliers. 
        /// <para>
        /// Specifies a comma-separated list of multiples defining the duration of each level
        /// of compaction. The number of elements in the list determines the number of compaction
        /// levels. The first element specifies the duration of the first level (gen3); subsequent
        /// levels are multiples of the previous level.
        /// </para>
        ///  
        /// <para>
        /// Default: 3,4,6,5
        /// </para>
        /// </summary>
        [AWSProperty(Min = 7, Max = 16)]
        public string CompactionMultipliers { get; set; }

        /// <summary>
        /// Checks to see if the CompactionMultipliers property is set.
        /// </summary>
        internal bool IsSetCompactionMultipliers() => this.CompactionMultipliers != null;

        /// <summary>
        /// Gets and sets the property CompactionRowLimit. 
        /// <para>
        /// Specifies the soft limit for the number of rows per file that the compactor writes.
        /// The compactor may write more rows than this limit.
        /// </para>
        ///  
        /// <para>
        /// Default: 1000000
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100000000)]
        public int? CompactionRowLimit { get; set; }

        /// <summary>
        /// Checks to see if the CompactionRowLimit property is set.
        /// </summary>
        internal bool IsSetCompactionRowLimit() => this.CompactionRowLimit.HasValue;

        /// <summary>
        /// Gets and sets the property DataFusionConfig. 
        /// <para>
        /// Provides custom configuration to DataFusion as a comma-separated list of key:value
        /// pairs.
        /// </para>
        /// </summary>
        public string DataFusionConfig { get; set; }

        /// <summary>
        /// Checks to see if the DataFusionConfig property is set.
        /// </summary>
        internal bool IsSetDataFusionConfig() => this.DataFusionConfig != null;

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
        [AWSProperty(Min = 1, Max = 1000000)]
        public int? DataFusionMaxParquetFanout { get; set; }

        /// <summary>
        /// Checks to see if the DataFusionMaxParquetFanout property is set.
        /// </summary>
        internal bool IsSetDataFusionMaxParquetFanout() => this.DataFusionMaxParquetFanout.HasValue;

        /// <summary>
        /// Gets and sets the property DataFusionNumThreads. 
        /// <para>
        /// Sets the maximum number of DataFusion runtime threads to use.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public int? DataFusionNumThreads { get; set; }

        /// <summary>
        /// Checks to see if the DataFusionNumThreads property is set.
        /// </summary>
        internal bool IsSetDataFusionNumThreads() => this.DataFusionNumThreads.HasValue;

        /// <summary>
        /// Gets and sets the property DataFusionRuntimeDisableLifoSlot. 
        /// <para>
        /// Disables the LIFO slot of the DataFusion runtime.
        /// </para>
        /// </summary>
        public bool? DataFusionRuntimeDisableLifoSlot { get; set; }

        /// <summary>
        /// Checks to see if the DataFusionRuntimeDisableLifoSlot property is set.
        /// </summary>
        internal bool IsSetDataFusionRuntimeDisableLifoSlot() => this.DataFusionRuntimeDisableLifoSlot.HasValue;

        /// <summary>
        /// Gets and sets the property DataFusionRuntimeEventInterval. 
        /// <para>
        /// Sets the number of scheduler ticks after which the scheduler of the DataFusion tokio
        /// runtime polls for external events–for example: timers, I/O.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public int? DataFusionRuntimeEventInterval { get; set; }

        /// <summary>
        /// Checks to see if the DataFusionRuntimeEventInterval property is set.
        /// </summary>
        internal bool IsSetDataFusionRuntimeEventInterval() => this.DataFusionRuntimeEventInterval.HasValue;

        /// <summary>
        /// Gets and sets the property DataFusionRuntimeGlobalQueueInterval. 
        /// <para>
        /// Sets the number of scheduler ticks after which the scheduler of the DataFusion runtime
        /// polls the global task queue.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public int? DataFusionRuntimeGlobalQueueInterval { get; set; }

        /// <summary>
        /// Checks to see if the DataFusionRuntimeGlobalQueueInterval property is set.
        /// </summary>
        internal bool IsSetDataFusionRuntimeGlobalQueueInterval() => this.DataFusionRuntimeGlobalQueueInterval.HasValue;

        /// <summary>
        /// Gets and sets the property DataFusionRuntimeMaxBlockingThreads. 
        /// <para>
        /// Specifies the limit for additional threads spawned by the DataFusion runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public int? DataFusionRuntimeMaxBlockingThreads { get; set; }

        /// <summary>
        /// Checks to see if the DataFusionRuntimeMaxBlockingThreads property is set.
        /// </summary>
        internal bool IsSetDataFusionRuntimeMaxBlockingThreads() => this.DataFusionRuntimeMaxBlockingThreads.HasValue;

        /// <summary>
        /// Gets and sets the property DataFusionRuntimeMaxIoEventsPerTick. 
        /// <para>
        /// Configures the maximum number of events processed per tick by the tokio DataFusion
        /// runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public int? DataFusionRuntimeMaxIoEventsPerTick { get; set; }

        /// <summary>
        /// Checks to see if the DataFusionRuntimeMaxIoEventsPerTick property is set.
        /// </summary>
        internal bool IsSetDataFusionRuntimeMaxIoEventsPerTick() => this.DataFusionRuntimeMaxIoEventsPerTick.HasValue;

        /// <summary>
        /// Gets and sets the property DataFusionRuntimeThreadKeepAlive. 
        /// <para>
        /// Sets a custom timeout for a thread in the blocking pool of the tokio DataFusion runtime.
        /// </para>
        /// </summary>
        public Duration DataFusionRuntimeThreadKeepAlive { get; set; }

        /// <summary>
        /// Checks to see if the DataFusionRuntimeThreadKeepAlive property is set.
        /// </summary>
        internal bool IsSetDataFusionRuntimeThreadKeepAlive() => this.DataFusionRuntimeThreadKeepAlive != null;

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
        [AWSProperty(Min = -20, Max = 19)]
        public int? DataFusionRuntimeThreadPriority { get; set; }

        /// <summary>
        /// Checks to see if the DataFusionRuntimeThreadPriority property is set.
        /// </summary>
        internal bool IsSetDataFusionRuntimeThreadPriority() => this.DataFusionRuntimeThreadPriority.HasValue;

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
        public DataFusionRuntimeType DataFusionRuntimeType { get; set; }

        /// <summary>
        /// Checks to see if the DataFusionRuntimeType property is set.
        /// </summary>
        internal bool IsSetDataFusionRuntimeType() => this.DataFusionRuntimeType != null;

        /// <summary>
        /// Gets and sets the property DataFusionUseCachedParquetLoader. 
        /// <para>
        /// Uses a cached parquet loader when reading parquet files from the object store.
        /// </para>
        /// </summary>
        public bool? DataFusionUseCachedParquetLoader { get; set; }

        /// <summary>
        /// Checks to see if the DataFusionUseCachedParquetLoader property is set.
        /// </summary>
        internal bool IsSetDataFusionUseCachedParquetLoader() => this.DataFusionUseCachedParquetLoader.HasValue;

        /// <summary>
        /// Gets and sets the property DedicatedCompactor. 
        /// <para>
        /// Specifies if the compactor instance should be a standalone instance or not.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? DedicatedCompactor { get; set; }

        /// <summary>
        /// Checks to see if the DedicatedCompactor property is set.
        /// </summary>
        internal bool IsSetDedicatedCompactor() => this.DedicatedCompactor.HasValue;

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
        public Duration DeleteGracePeriod { get; set; }

        /// <summary>
        /// Checks to see if the DeleteGracePeriod property is set.
        /// </summary>
        internal bool IsSetDeleteGracePeriod() => this.DeleteGracePeriod != null;

        /// <summary>
        /// Gets and sets the property DisableParquetMemCache. 
        /// <para>
        /// Disables the in-memory Parquet cache. By default, the cache is enabled.
        /// </para>
        /// </summary>
        public bool? DisableParquetMemCache { get; set; }

        /// <summary>
        /// Checks to see if the DisableParquetMemCache property is set.
        /// </summary>
        internal bool IsSetDisableParquetMemCache() => this.DisableParquetMemCache.HasValue;

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
        public Duration DistinctCacheEvictionInterval { get; set; }

        /// <summary>
        /// Checks to see if the DistinctCacheEvictionInterval property is set.
        /// </summary>
        internal bool IsSetDistinctCacheEvictionInterval() => this.DistinctCacheEvictionInterval != null;

        /// <summary>
        /// Gets and sets the property DistinctValueCacheDisableFromHistory. 
        /// <para>
        /// Disables populating the distinct value cache from historical data. If disabled, the
        /// cache is still populated with data from the write-ahead log (WAL).
        /// </para>
        /// </summary>
        public bool? DistinctValueCacheDisableFromHistory { get; set; }

        /// <summary>
        /// Checks to see if the DistinctValueCacheDisableFromHistory property is set.
        /// </summary>
        internal bool IsSetDistinctValueCacheDisableFromHistory() => this.DistinctValueCacheDisableFromHistory.HasValue;

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
        public PercentOrAbsoluteLong ExecMemPoolBytes { get; set; }

        /// <summary>
        /// Checks to see if the ExecMemPoolBytes property is set.
        /// </summary>
        internal bool IsSetExecMemPoolBytes() => this.ExecMemPoolBytes != null;

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
        public PercentOrAbsoluteLong ForceSnapshotMemThreshold { get; set; }

        /// <summary>
        /// Checks to see if the ForceSnapshotMemThreshold property is set.
        /// </summary>
        internal bool IsSetForceSnapshotMemThreshold() => this.ForceSnapshotMemThreshold != null;

        /// <summary>
        /// Gets and sets the property Gen1Duration. 
        /// <para>
        /// Specifies the duration that Parquet files are arranged into. Data timestamps land
        /// each row into a file of this duration. Supported durations are 1m, 5m, and 10m. These
        /// files are known as “generation 1” files, which the compactor can merge into larger
        /// generations.
        /// </para>
        ///  
        /// <para>
        /// Default: 10m
        /// </para>
        /// </summary>
        public Duration Gen1Duration { get; set; }

        /// <summary>
        /// Checks to see if the Gen1Duration property is set.
        /// </summary>
        internal bool IsSetGen1Duration() => this.Gen1Duration != null;

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
        public Duration Gen1LookbackDuration { get; set; }

        /// <summary>
        /// Checks to see if the Gen1LookbackDuration property is set.
        /// </summary>
        internal bool IsSetGen1LookbackDuration() => this.Gen1LookbackDuration != null;

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
        public Duration HardDeleteDefaultDuration { get; set; }

        /// <summary>
        /// Checks to see if the HardDeleteDefaultDuration property is set.
        /// </summary>
        internal bool IsSetHardDeleteDefaultDuration() => this.HardDeleteDefaultDuration != null;

        /// <summary>
        /// Gets and sets the property IngestQueryInstances. 
        /// <para>
        /// Specifies number of instances in the DbCluster which can both ingest and query.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4)]
        public int? IngestQueryInstances { get; set; }

        /// <summary>
        /// Checks to see if the IngestQueryInstances property is set.
        /// </summary>
        internal bool IsSetIngestQueryInstances() => this.IngestQueryInstances.HasValue;

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
        public Duration LastCacheEvictionInterval { get; set; }

        /// <summary>
        /// Checks to see if the LastCacheEvictionInterval property is set.
        /// </summary>
        internal bool IsSetLastCacheEvictionInterval() => this.LastCacheEvictionInterval != null;

        /// <summary>
        /// Gets and sets the property LastValueCacheDisableFromHistory. 
        /// <para>
        /// Disables populating the last-N-value cache from historical data. If disabled, the
        /// cache is still populated with data from the write-ahead log (WAL).
        /// </para>
        /// </summary>
        public bool? LastValueCacheDisableFromHistory { get; set; }

        /// <summary>
        /// Checks to see if the LastValueCacheDisableFromHistory property is set.
        /// </summary>
        internal bool IsSetLastValueCacheDisableFromHistory() => this.LastValueCacheDisableFromHistory.HasValue;

        /// <summary>
        /// Gets and sets the property LogFilter. 
        /// <para>
        /// Sets the filter directive for logs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string LogFilter { get; set; }

        /// <summary>
        /// Checks to see if the LogFilter property is set.
        /// </summary>
        internal bool IsSetLogFilter() => this.LogFilter != null;

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
        public LogFormats LogFormat { get; set; }

        /// <summary>
        /// Checks to see if the LogFormat property is set.
        /// </summary>
        internal bool IsSetLogFormat() => this.LogFormat != null;

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
        [AWSProperty(Min = 1024, Max = 16777216)]
        public long? MaxHttpRequestSize { get; set; }

        /// <summary>
        /// Checks to see if the MaxHttpRequestSize property is set.
        /// </summary>
        internal bool IsSetMaxHttpRequestSize() => this.MaxHttpRequestSize.HasValue;

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
        public Duration ParquetMemCachePruneInterval { get; set; }

        /// <summary>
        /// Checks to see if the ParquetMemCachePruneInterval property is set.
        /// </summary>
        internal bool IsSetParquetMemCachePruneInterval() => this.ParquetMemCachePruneInterval != null;

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
        [AWSProperty(Min = 0, Max = 1)]
        public float? ParquetMemCachePrunePercentage { get; set; }

        /// <summary>
        /// Checks to see if the ParquetMemCachePrunePercentage property is set.
        /// </summary>
        internal bool IsSetParquetMemCachePrunePercentage() => this.ParquetMemCachePrunePercentage.HasValue;

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
        public Duration ParquetMemCacheQueryPathDuration { get; set; }

        /// <summary>
        /// Checks to see if the ParquetMemCacheQueryPathDuration property is set.
        /// </summary>
        internal bool IsSetParquetMemCacheQueryPathDuration() => this.ParquetMemCacheQueryPathDuration != null;

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
        public PercentOrAbsoluteLong ParquetMemCacheSize { get; set; }

        /// <summary>
        /// Checks to see if the ParquetMemCacheSize property is set.
        /// </summary>
        internal bool IsSetParquetMemCacheSize() => this.ParquetMemCacheSize != null;

        /// <summary>
        /// Gets and sets the property PluginRepositorySecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Secrets Manager secret that holds your repository
        /// access token.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string PluginRepositorySecretArn { get; set; }

        /// <summary>
        /// Checks to see if the PluginRepositorySecretArn property is set.
        /// </summary>
        internal bool IsSetPluginRepositorySecretArn() => this.PluginRepositorySecretArn != null;

        /// <summary>
        /// Gets and sets the property PluginRepositoryUrl. 
        /// <para>
        /// Specifies the URL of the repository that InfluxDB downloads plugins from.
        /// </para>
        /// </summary>
        public string PluginRepositoryUrl { get; set; }

        /// <summary>
        /// Checks to see if the PluginRepositoryUrl property is set.
        /// </summary>
        internal bool IsSetPluginRepositoryUrl() => this.PluginRepositoryUrl != null;

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
        public Duration PreemptiveCacheAge { get; set; }

        /// <summary>
        /// Checks to see if the PreemptiveCacheAge property is set.
        /// </summary>
        internal bool IsSetPreemptiveCacheAge() => this.PreemptiveCacheAge != null;

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
        [AWSProperty(Min = 0, Max = 1024)]
        public int? QueryFileLimit { get; set; }

        /// <summary>
        /// Checks to see if the QueryFileLimit property is set.
        /// </summary>
        internal bool IsSetQueryFileLimit() => this.QueryFileLimit.HasValue;

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
        [AWSProperty(Min = 1, Max = 10000)]
        public int? QueryLogSize { get; set; }

        /// <summary>
        /// Checks to see if the QueryLogSize property is set.
        /// </summary>
        internal bool IsSetQueryLogSize() => this.QueryLogSize.HasValue;

        /// <summary>
        /// Gets and sets the property QueryOnlyInstances. 
        /// <para>
        /// Specifies number of instances in the DbCluster which can only query.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10)]
        public int? QueryOnlyInstances { get; set; }

        /// <summary>
        /// Checks to see if the QueryOnlyInstances property is set.
        /// </summary>
        internal bool IsSetQueryOnlyInstances() => this.QueryOnlyInstances.HasValue;

        /// <summary>
        /// Gets and sets the property ReplicationInterval. 
        /// <para>
        /// Specifies the interval at which data replication occurs between cluster nodes.
        /// </para>
        ///  
        /// <para>
        /// Default: 250ms
        /// </para>
        /// </summary>
        public Duration ReplicationInterval { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationInterval property is set.
        /// </summary>
        internal bool IsSetReplicationInterval() => this.ReplicationInterval != null;

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
        public Duration RetentionCheckInterval { get; set; }

        /// <summary>
        /// Checks to see if the RetentionCheckInterval property is set.
        /// </summary>
        internal bool IsSetRetentionCheckInterval() => this.RetentionCheckInterval != null;

        /// <summary>
        /// Gets and sets the property SnapshotDuration. 
        /// <para>
        /// The time-based trigger that controls how often the ingester creates snapshots. This
        /// value is also used on query nodes as the bucket rotation interval for the replica
        /// buffer.
        /// </para>
        /// </summary>
        public Duration SnapshotDuration { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotDuration property is set.
        /// </summary>
        internal bool IsSetSnapshotDuration() => this.SnapshotDuration != null;

        /// <summary>
        /// Gets and sets the property SnapshotSize. 
        /// <para>
        /// The maximum size of the active snapshot bucket before it is rotated for snapshotting.
        /// </para>
        /// </summary>
        public PercentOrAbsoluteLong SnapshotSize { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotSize property is set.
        /// </summary>
        internal bool IsSetSnapshotSize() => this.SnapshotSize != null;

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
        [AWSProperty(Min = 0, Max = 10000)]
        public int? SnapshottedWalFilesToKeep { get; set; }

        /// <summary>
        /// Checks to see if the SnapshottedWalFilesToKeep property is set.
        /// </summary>
        internal bool IsSetSnapshottedWalFilesToKeep() => this.SnapshottedWalFilesToKeep.HasValue;

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
        [AWSProperty(Min = 1, Max = 100)]
        public int? TableIndexCacheConcurrencyLimit { get; set; }

        /// <summary>
        /// Checks to see if the TableIndexCacheConcurrencyLimit property is set.
        /// </summary>
        internal bool IsSetTableIndexCacheConcurrencyLimit() => this.TableIndexCacheConcurrencyLimit.HasValue;

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
        [AWSProperty(Min = 1, Max = 1000)]
        public int? TableIndexCacheMaxEntries { get; set; }

        /// <summary>
        /// Checks to see if the TableIndexCacheMaxEntries property is set.
        /// </summary>
        internal bool IsSetTableIndexCacheMaxEntries() => this.TableIndexCacheMaxEntries.HasValue;

        /// <summary>
        /// Gets and sets the property UpgradePachaTree. 
        /// <para>
        /// Specifies whether to migrate the cluster from the Parquet storage engine to PachaTree.
        /// This action cannot be reversed. To create a new cluster on Parquet, set this to false.
        /// </para>
        /// </summary>
        public bool? UpgradePachaTree { get; set; }

        /// <summary>
        /// Checks to see if the UpgradePachaTree property is set.
        /// </summary>
        internal bool IsSetUpgradePachaTree() => this.UpgradePachaTree.HasValue;

        /// <summary>
        /// Gets and sets the property WalBufferSize. 
        /// <para>
        /// The maximum size, in bytes, of the in-memory WAL buffer before a flush is triggered
        /// regardless of the flush interval. Increase this value if WAL files are flushed before
        /// the interval elapses.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1073741824)]
        public long? WalBufferSize { get; set; }

        /// <summary>
        /// Checks to see if the WalBufferSize property is set.
        /// </summary>
        internal bool IsSetWalBufferSize() => this.WalBufferSize.HasValue;

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
        [AWSProperty(Min = 1, Max = 1000000)]
        public int? WalMaxWriteBufferSize { get; set; }

        /// <summary>
        /// Checks to see if the WalMaxWriteBufferSize property is set.
        /// </summary>
        internal bool IsSetWalMaxWriteBufferSize() => this.WalMaxWriteBufferSize.HasValue;

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
        [AWSProperty(Min = 1, Max = 100)]
        public int? WalReplayConcurrencyLimit { get; set; }

        /// <summary>
        /// Checks to see if the WalReplayConcurrencyLimit property is set.
        /// </summary>
        internal bool IsSetWalReplayConcurrencyLimit() => this.WalReplayConcurrencyLimit.HasValue;

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
        public bool? WalReplayFailOnError { get; set; }

        /// <summary>
        /// Checks to see if the WalReplayFailOnError property is set.
        /// </summary>
        internal bool IsSetWalReplayFailOnError() => this.WalReplayFailOnError.HasValue;

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
        [AWSProperty(Min = 1, Max = 10000)]
        public int? WalSnapshotSize { get; set; }

        /// <summary>
        /// Checks to see if the WalSnapshotSize property is set.
        /// </summary>
        internal bool IsSetWalSnapshotSize() => this.WalSnapshotSize.HasValue;
    }
}
