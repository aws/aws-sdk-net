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
    /// Specifies a crawler program that examines a data source and uses classifiers to try
    /// to determine its schema. If successful, the crawler records metadata concerning the
    /// data source in the Glue Data Catalog.
    /// </summary>
    public partial class Crawler
    {
        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog in which the crawler's output is stored.
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
        /// A list of UTF-8 strings that specify the custom classifiers that are associated with
        /// the crawler.
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
        /// Gets and sets the property CrawlElapsedTime. 
        /// <para>
        /// If the crawler is running, contains the total time elapsed since the last crawl began.
        /// </para>
        /// </summary>
        public long? CrawlElapsedTime { get; set; }

        /// <summary>
        /// Checks to see if the CrawlElapsedTime property is set.
        /// </summary>
        internal bool IsSetCrawlElapsedTime() => this.CrawlElapsedTime.HasValue;

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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the crawler was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the database in which the crawler's output is stored.
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
        /// A description of the crawler.
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
        /// Specifies whether the crawler should use Lake Formation credentials for the crawler
        /// instead of the IAM role credentials.
        /// </para>
        /// </summary>
        public LakeFormationConfiguration LakeFormationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LakeFormationConfiguration property is set.
        /// </summary>
        internal bool IsSetLakeFormationConfiguration() => this.LakeFormationConfiguration != null;

        /// <summary>
        /// Gets and sets the property LastCrawl. 
        /// <para>
        /// The status of the last crawl, and potentially error information if an error occurred.
        /// </para>
        /// </summary>
        public LastCrawlInfo LastCrawl { get; set; }

        /// <summary>
        /// Checks to see if the LastCrawl property is set.
        /// </summary>
        internal bool IsSetLastCrawl() => this.LastCrawl != null;

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// The time that the crawler was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdated property is set.
        /// </summary>
        internal bool IsSetLastUpdated() => this.LastUpdated.HasValue;

        /// <summary>
        /// Gets and sets the property LineageConfiguration. 
        /// <para>
        /// A configuration that specifies whether data lineage is enabled for the crawler.
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
        /// The name of the crawler.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
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
        /// The Amazon Resource Name (ARN) of an IAM role that's used to access customer resources,
        /// such as Amazon Simple Storage Service (Amazon S3) data.
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
        /// For scheduled crawlers, the schedule when the crawler runs.
        /// </para>
        /// </summary>
        public Schedule Schedule { get; set; }

        /// <summary>
        /// Checks to see if the Schedule property is set.
        /// </summary>
        internal bool IsSetSchedule() => this.Schedule != null;

        /// <summary>
        /// Gets and sets the property SchemaChangePolicy. 
        /// <para>
        /// The policy that specifies update and delete behaviors for the crawler.
        /// </para>
        /// </summary>
        public SchemaChangePolicy SchemaChangePolicy { get; set; }

        /// <summary>
        /// Checks to see if the SchemaChangePolicy property is set.
        /// </summary>
        internal bool IsSetSchemaChangePolicy() => this.SchemaChangePolicy != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Indicates whether the crawler is running, or whether a run is pending.
        /// </para>
        /// </summary>
        public CrawlerState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property TablePrefix. 
        /// <para>
        /// The prefix added to the names of tables that are created.
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
        /// A collection of targets to crawl.
        /// </para>
        /// </summary>
        public CrawlerTargets Targets { get; set; }

        /// <summary>
        /// Checks to see if the Targets property is set.
        /// </summary>
        internal bool IsSetTargets() => this.Targets != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the crawler.
        /// </para>
        /// </summary>
        public long? Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version.HasValue;
    }
}
