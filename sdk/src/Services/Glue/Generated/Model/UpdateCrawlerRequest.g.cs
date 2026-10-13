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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCrawler operation. Updates a crawler. If
    /// a crawler is running, you must stop it using <c>StopCrawler</c> before updating it.
    /// </summary>
    public partial class UpdateCrawlerRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog in which to store the crawler's output. If you omit this
        /// value, the existing value on the crawler is preserved.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CatalogId { get; set; }

        /// <summary>
        /// Checks to see if the CatalogId property is set.
        /// </summary>
        internal bool IsSetCatalogId() => this.CatalogId != null;

        /// <summary>
        /// Gets and sets the property Classifiers. 
        /// <para>
        /// A list of custom classifiers that the user has registered. By default, all built-in
        /// classifiers are included in a crawl, but these custom classifiers always override
        /// the default classifiers for a given classification.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Classifiers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Classifiers property is set.
        /// </summary>
        internal bool IsSetClassifiers() => this.Classifiers != null && (this.Classifiers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// Crawler configuration information. This versioned JSON string allows users to specify
        /// aspects of a crawler's behavior. For more information, see <a href="https://docs.aws.amazon.com/glue/latest/dg/crawler-configuration.html">Setting
        /// crawler configuration options</a>.
        /// </para>
        /// </summary>
        public string Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property CrawlerSecurityConfiguration. 
        /// <para>
        /// The name of the <c>SecurityConfiguration</c> structure to be used by this crawler.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string CrawlerSecurityConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CrawlerSecurityConfiguration property is set.
        /// </summary>
        internal bool IsSetCrawlerSecurityConfiguration() => this.CrawlerSecurityConfiguration != null;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The Glue database where results are stored, such as: <c>arn:aws:daylight:us-east-1::database/sometable/*</c>.
        /// </para>
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the new crawler.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LakeFormationConfiguration. 
        /// <para>
        /// Specifies Lake Formation configuration settings for the crawler.
        /// </para>
        /// </summary>
        public LakeFormationConfiguration LakeFormationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LakeFormationConfiguration property is set.
        /// </summary>
        internal bool IsSetLakeFormationConfiguration() => this.LakeFormationConfiguration != null;

        /// <summary>
        /// Gets and sets the property LineageConfiguration. 
        /// <para>
        /// Specifies data lineage configuration settings for the crawler.
        /// </para>
        /// </summary>
        public LineageConfiguration LineageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LineageConfiguration property is set.
        /// </summary>
        internal bool IsSetLineageConfiguration() => this.LineageConfiguration != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the new crawler.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RecrawlPolicy. 
        /// <para>
        /// A policy that specifies whether to crawl the entire dataset again, or to crawl only
        /// folders that were added since the last crawler run.
        /// </para>
        /// </summary>
        public RecrawlPolicy RecrawlPolicy { get; set; }

        /// <summary>
        /// Checks to see if the RecrawlPolicy property is set.
        /// </summary>
        internal bool IsSetRecrawlPolicy() => this.RecrawlPolicy != null;

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The IAM role or Amazon Resource Name (ARN) of an IAM role that is used by the new
        /// crawler to access customer resources.
        /// </para>
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// A <c>cron</c> expression used to specify the schedule (see <a href="https://docs.aws.amazon.com/glue/latest/dg/monitor-data-warehouse-schedule.html">Time-Based
        /// Schedules for Jobs and Crawlers</a>. For example, to run something every day at 12:15
        /// UTC, you would specify: <c>cron(15 12 * * ? *)</c>.
        /// </para>
        /// </summary>
        public string Schedule { get; set; }

        /// <summary>
        /// Checks to see if the Schedule property is set.
        /// </summary>
        internal bool IsSetSchedule() => this.Schedule != null;

        /// <summary>
        /// Gets and sets the property SchemaChangePolicy. 
        /// <para>
        /// The policy for the crawler's update and deletion behavior.
        /// </para>
        /// </summary>
        public SchemaChangePolicy SchemaChangePolicy { get; set; }

        /// <summary>
        /// Checks to see if the SchemaChangePolicy property is set.
        /// </summary>
        internal bool IsSetSchemaChangePolicy() => this.SchemaChangePolicy != null;

        /// <summary>
        /// Gets and sets the property TablePrefix. 
        /// <para>
        /// The table prefix used for catalog tables that are created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string TablePrefix { get; set; }

        /// <summary>
        /// Checks to see if the TablePrefix property is set.
        /// </summary>
        internal bool IsSetTablePrefix() => this.TablePrefix != null;

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// A list of targets to crawl.
        /// </para>
        /// </summary>
        public CrawlerTargets Targets { get; set; }

        /// <summary>
        /// Checks to see if the Targets property is set.
        /// </summary>
        internal bool IsSetTargets() => this.Targets != null;
    }
}
