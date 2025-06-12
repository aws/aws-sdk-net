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
    /// Container for the parameters to the CreateCrawler operation.
    /// Creates a new crawler with specified targets, role, configuration, and optional schedule.
    /// At least one crawl target must be specified, in the <c>s3Targets</c> field, the <c>jdbcTargets</c>
    /// field, or the <c>DynamoDBTargets</c> field.
    /// </summary>
    public partial class CreateCrawlerRequest : AmazonGlueRequest
    {
        private List<string> _classifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _configuration;
        private string _crawlerSecurityConfiguration;
        private string _databaseName;
        private string _description;
        private LakeFormationConfiguration _lakeFormationConfiguration;
        private LineageConfiguration _lineageConfiguration;
        private string _name;
        private RecrawlPolicy _recrawlPolicy;
        private string _role;
        private string _schedule;
        private SchemaChangePolicy _schemaChangePolicy;
        private string _tablePrefix;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private CrawlerTargets _targets;

        /// <summary>
        /// Gets and sets the property Classifiers. 
        /// <para>
        /// A list of custom classifiers that the user has registered. By default, all built-in
        /// classifiers are included in a crawl, but these custom classifiers always override
        /// the default classifiers for a given classification.
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
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The Glue database where results are written, such as: <c>arn:aws:daylight:us-east-1::database/sometable/*</c>.
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
        /// A description of the new crawler.
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
        /// Specifies Lake Formation configuration settings for the crawler.
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
        /// Gets and sets the property LineageConfiguration. 
        /// <para>
        /// Specifies data lineage configuration settings for the crawler.
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
        /// Name of the new crawler.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// The IAM role or Amazon Resource Name (ARN) of an IAM role used by the new crawler
        /// to access customer resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// A <c>cron</c> expression used to specify the schedule (see <a href="https://docs.aws.amazon.com/glue/latest/dg/monitor-data-warehouse-schedule.html">Time-Based
        /// Schedules for Jobs and Crawlers</a>. For example, to run something every day at 12:15
        /// UTC, you would specify: <c>cron(15 12 * * ? *)</c>.
        /// </para>
        /// </summary>
        public string Schedule
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
        /// The policy for the crawler's update and deletion behavior.
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
        /// Gets and sets the property TablePrefix. 
        /// <para>
        /// The table prefix used for catalog tables that are created.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to use with this crawler request. You may use tags to limit access to the
        /// crawler. For more information about tags in Glue, see <a href="https://docs.aws.amazon.com/glue/latest/dg/monitor-tags.html">Amazon
        /// Web Services Tags in Glue</a> in the developer guide.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// A list of collection of targets to crawl.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}