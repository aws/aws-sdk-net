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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies a crawler program that examines a data source and uses classifiers to try
    /// to determine its schema. If successful, the crawler records metadata concerning the
    /// data source in the Glue Data Catalog.
    /// </summary>
    public partial class Crawler
    {
        private List<string> _classifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _configuration;
        private long? _crawlElapsedTime;
        private string _crawlerSecurityConfiguration;
        private DateTime? _creationTime;
        private string _databaseName;
        private string _description;
        private LakeFormationConfiguration _lakeFormationConfiguration;
        private LastCrawlInfo _lastCrawl;
        private DateTime? _lastUpdated;
        private LineageConfiguration _lineageConfiguration;
        private string _name;
        private RecrawlPolicy _recrawlPolicy;
        private string _role;
        private Schedule _schedule;
        private SchemaChangePolicy _schemaChangePolicy;
        private CrawlerState _state;
        private string _tablePrefix;
        private CrawlerTargets _targets;
        private long? _version;

        /// <summary>
        /// Gets and sets the property Classifiers. 
        /// <para>
        /// A list of UTF-8 strings that specify the custom classifiers that are associated with
        /// the crawler.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Classifiers
        {
            get { return this._classifiers; }
            set { this._classifiers = value; }
        }

        // Check to see if Classifiers property is set
        internal bool IsSetClassifiers()
        {
            return this._classifiers != null && (this._classifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// Crawler configuration information. This versioned JSON string allows users to specify
        /// aspects of a crawler's behavior. For more information, see <a href="https://docs.aws.amazon.com/glue/latest/dg/crawler-configuration.html">Setting
        /// crawler configuration options</a>.
        /// </para>
        /// </summary>
        public string Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property CrawlElapsedTime. 
        /// <para>
        /// If the crawler is running, contains the total time elapsed since the last crawl began.
        /// </para>
        /// </summary>
        public long? CrawlElapsedTime
        {
            get { return this._crawlElapsedTime; }
            set { this._crawlElapsedTime = value; }
        }

        // Check to see if CrawlElapsedTime property is set
        internal bool IsSetCrawlElapsedTime()
        {
            return this._crawlElapsedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CrawlerSecurityConfiguration. 
        /// <para>
        /// The name of the <c>SecurityConfiguration</c> structure to be used by this crawler.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string CrawlerSecurityConfiguration
        {
            get { return this._crawlerSecurityConfiguration; }
            set { this._crawlerSecurityConfiguration = value; }
        }

        // Check to see if CrawlerSecurityConfiguration property is set
        internal bool IsSetCrawlerSecurityConfiguration()
        {
            return this._crawlerSecurityConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the crawler was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the database in which the crawler's output is stored.
        /// </para>
        /// </summary>
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the crawler.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property LakeFormationConfiguration. 
        /// <para>
        /// Specifies whether the crawler should use Lake Formation credentials for the crawler
        /// instead of the IAM role credentials.
        /// </para>
        /// </summary>
        public LakeFormationConfiguration LakeFormationConfiguration
        {
            get { return this._lakeFormationConfiguration; }
            set { this._lakeFormationConfiguration = value; }
        }

        // Check to see if LakeFormationConfiguration property is set
        internal bool IsSetLakeFormationConfiguration()
        {
            return this._lakeFormationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LastCrawl. 
        /// <para>
        /// The status of the last crawl, and potentially error information if an error occurred.
        /// </para>
        /// </summary>
        public LastCrawlInfo LastCrawl
        {
            get { return this._lastCrawl; }
            set { this._lastCrawl = value; }
        }

        // Check to see if LastCrawl property is set
        internal bool IsSetLastCrawl()
        {
            return this._lastCrawl != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// The time that the crawler was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdated
        {
            get { return this._lastUpdated; }
            set { this._lastUpdated = value; }
        }

        // Check to see if LastUpdated property is set
        internal bool IsSetLastUpdated()
        {
            return this._lastUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LineageConfiguration. 
        /// <para>
        /// A configuration that specifies whether data lineage is enabled for the crawler.
        /// </para>
        /// </summary>
        public LineageConfiguration LineageConfiguration
        {
            get { return this._lineageConfiguration; }
            set { this._lineageConfiguration = value; }
        }

        // Check to see if LineageConfiguration property is set
        internal bool IsSetLineageConfiguration()
        {
            return this._lineageConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the crawler.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RecrawlPolicy. 
        /// <para>
        /// A policy that specifies whether to crawl the entire dataset again, or to crawl only
        /// folders that were added since the last crawler run.
        /// </para>
        /// </summary>
        public RecrawlPolicy RecrawlPolicy
        {
            get { return this._recrawlPolicy; }
            set { this._recrawlPolicy = value; }
        }

        // Check to see if RecrawlPolicy property is set
        internal bool IsSetRecrawlPolicy()
        {
            return this._recrawlPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that's used to access customer resources,
        /// such as Amazon Simple Storage Service (Amazon S3) data.
        /// </para>
        /// </summary>
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// For scheduled crawlers, the schedule when the crawler runs.
        /// </para>
        /// </summary>
        public Schedule Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaChangePolicy. 
        /// <para>
        /// The policy that specifies update and delete behaviors for the crawler.
        /// </para>
        /// </summary>
        public SchemaChangePolicy SchemaChangePolicy
        {
            get { return this._schemaChangePolicy; }
            set { this._schemaChangePolicy = value; }
        }

        // Check to see if SchemaChangePolicy property is set
        internal bool IsSetSchemaChangePolicy()
        {
            return this._schemaChangePolicy != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Indicates whether the crawler is running, or whether a run is pending.
        /// </para>
        /// </summary>
        public CrawlerState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property TablePrefix. 
        /// <para>
        /// The prefix added to the names of tables that are created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string TablePrefix
        {
            get { return this._tablePrefix; }
            set { this._tablePrefix = value; }
        }

        // Check to see if TablePrefix property is set
        internal bool IsSetTablePrefix()
        {
            return this._tablePrefix != null;
        }

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// A collection of targets to crawl.
        /// </para>
        /// </summary>
        public CrawlerTargets Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the crawler.
        /// </para>
        /// </summary>
        public long? Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}