/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCrawler operation.
    /// Updates a crawler. If a crawler is running, you must stop it using <code>StopCrawler</code>
    /// before updating it.
    /// </summary>
    public partial class UpdateCrawlerRequest : AmazonGlueRequest
    {
        private List<string> _classifiers = new List<string>();
        private string _configuration;
        private string _databaseName;
        private string _description;
        private string _name;
        private string _role;
        private string _schedule;
        private SchemaChangePolicy _schemaChangePolicy;
        private string _tablePrefix;
        private CrawlerTargets _targets;

        /// <summary>
        /// Gets and sets the property Classifiers. 
        /// <para>
        /// A list of custom classifiers that the user has registered. By default, all classifiers
        /// are included in a crawl, but these custom classifiers always override the default
        /// classifiers for a given classification.
        /// </para>
        /// </summary>
        public List<string> Classifiers
        {
            get { return this._classifiers; }
            set { this._classifiers = value; }
        }

        // Check to see if Classifiers property is set
        internal bool IsSetClassifiers()
        {
            return this._classifiers != null && this._classifiers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// Crawler configuration information. This versioned JSON string allows users to specify
        /// aspects of a Crawler's behavior.
        /// </para>
        ///  
        /// <para>
        /// You can use this field to force partitions to inherit metadata such as classification,
        /// input format, output format, serde information, and schema from their parent table,
        /// rather than detect this information separately for each partition. Use the following
        /// JSON string to specify that behavior:
        /// </para>
        ///  
        /// <para>
        /// Example: <code>'{ "Version": 1.0, "CrawlerOutput": { "Partitions": { "AddOrUpdateBehavior":
        /// "InheritFromTable" } } }'</code> 
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
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The AWS Glue database where results are stored, such as: <code>arn:aws:daylight:us-east-1::database/sometable/*</code>.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the new crawler.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Role. 
        /// <para>
        /// The IAM role (or ARN of an IAM role) used by the new crawler to access customer resources.
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
        /// A <code>cron</code> expression used to specify the schedule (see <a href="http://docs.aws.amazon.com/glue/latest/dg/monitor-data-warehouse-schedule.html">Time-Based
        /// Schedules for Jobs and Crawlers</a>. For example, to run something every day at 12:15
        /// UTC, you would specify: <code>cron(15 12 * * ? *)</code>.
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
        /// Policy for the crawler's update and deletion behavior.
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
        /// A list of targets to crawl.
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

    }
}