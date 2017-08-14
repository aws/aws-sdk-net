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
    /// Container for the parameters to the CreateCrawler operation.
    /// Creates a new <code>Crawler</code> with specified targets, role, configuration, and
    /// optional schedule. At least one crawl target must be specified, in either the <i>s3Targets</i>
    /// or the <i>jdbcTargets</i> field.
    /// </summary>
    public partial class CreateCrawlerRequest : AmazonGlueRequest
    {
        private List<string> _classifiers = new List<string>();
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
        /// A list of custom <code>Classifier</code> names that the user has registered. By default,
        /// all AWS classifiers are included in a crawl, but these custom classifiers always override
        /// the default classifiers for a given classification.
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
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The Glue <code>Database</code> where results will be stored, such as: <code>arn:aws:daylight:us-east-1::database/sometable/*</code>.
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
        /// A description of the new <code>Crawler</code>.
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
        /// Name of the new <code>Crawler</code>.
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
        /// The AWS ARN of the IAM role used by the new <code>Crawler</code> to access customer
        /// resources.
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
        /// A cron expression that can be used as a Cloudwatch event (see <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/events/ScheduledEvents.html">CloudWatch
        /// Schedule Expression Syntax</a>. For example, to run every day at 12:15 UTC, specify:
        /// <code>cron(15 12 * * ? *)</code>.
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
        /// The table prefix used for catalog tables created.
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
        /// A list of collection of targets to crawl.
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