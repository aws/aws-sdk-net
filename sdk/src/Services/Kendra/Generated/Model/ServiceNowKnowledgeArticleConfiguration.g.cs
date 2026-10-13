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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides the configuration information for crawling knowledge articles in the ServiceNow
    /// site.
    /// </summary>
    public partial class ServiceNowKnowledgeArticleConfiguration
    {
        /// <summary>
        /// Gets and sets the property CrawlAttachments. 
        /// <para>
        ///  <c>TRUE</c> to index attachments to knowledge articles.
        /// </para>
        /// </summary>
        public bool? CrawlAttachments { get; set; }

        /// <summary>
        /// Checks to see if the CrawlAttachments property is set.
        /// </summary>
        internal bool IsSetCrawlAttachments() => this.CrawlAttachments.HasValue;

        /// <summary>
        /// Gets and sets the property DocumentDataFieldName. 
        /// <para>
        /// The name of the ServiceNow field that is mapped to the index document contents field
        /// in the Amazon Kendra index.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string DocumentDataFieldName { get; set; }

        /// <summary>
        /// Checks to see if the DocumentDataFieldName property is set.
        /// </summary>
        internal bool IsSetDocumentDataFieldName() => this.DocumentDataFieldName != null;

        /// <summary>
        /// Gets and sets the property DocumentTitleFieldName. 
        /// <para>
        /// The name of the ServiceNow field that is mapped to the index document title field.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string DocumentTitleFieldName { get; set; }

        /// <summary>
        /// Checks to see if the DocumentTitleFieldName property is set.
        /// </summary>
        internal bool IsSetDocumentTitleFieldName() => this.DocumentTitleFieldName != null;

        /// <summary>
        /// Gets and sets the property ExcludeAttachmentFilePatterns. 
        /// <para>
        /// A list of regular expression patterns applied to exclude certain knowledge article
        /// attachments. Attachments that match the patterns are excluded from the index. Items
        /// that don't match the patterns are included in the index. If an item matches both an
        /// inclusion and exclusion pattern, the exclusion pattern takes precedence and the item
        /// isn't included in the index.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 250)]
        public List<string> ExcludeAttachmentFilePatterns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExcludeAttachmentFilePatterns property is set.
        /// </summary>
        internal bool IsSetExcludeAttachmentFilePatterns() => this.ExcludeAttachmentFilePatterns != null && (this.ExcludeAttachmentFilePatterns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FieldMappings. 
        /// <para>
        /// Maps attributes or field names of knoweldge articles to Amazon Kendra index field
        /// names. To create custom fields, use the <c>UpdateIndex</c> API before you map to ServiceNow
        /// fields. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The ServiceNow data source field names must exist in your
        /// ServiceNow custom metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<DataSourceToIndexFieldMapping> FieldMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<DataSourceToIndexFieldMapping>() : null;

        /// <summary>
        /// Checks to see if the FieldMappings property is set.
        /// </summary>
        internal bool IsSetFieldMappings() => this.FieldMappings != null && (this.FieldMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FilterQuery. 
        /// <para>
        /// A query that selects the knowledge articles to index. The query can return articles
        /// from multiple knowledge bases, and the knowledge bases can be public or private.
        /// </para>
        ///  
        /// <para>
        /// The query string must be one generated by the ServiceNow console. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/servicenow-query.html">Specifying
        /// documents to index with a query</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string FilterQuery { get; set; }

        /// <summary>
        /// Checks to see if the FilterQuery property is set.
        /// </summary>
        internal bool IsSetFilterQuery() => this.FilterQuery != null;

        /// <summary>
        /// Gets and sets the property IncludeAttachmentFilePatterns. 
        /// <para>
        /// A list of regular expression patterns applied to include knowledge article attachments.
        /// Attachments that match the patterns are included in the index. Items that don't match
        /// the patterns are excluded from the index. If an item matches both an inclusion and
        /// exclusion pattern, the exclusion pattern takes precedence and the item isn't included
        /// in the index.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 250)]
        public List<string> IncludeAttachmentFilePatterns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the IncludeAttachmentFilePatterns property is set.
        /// </summary>
        internal bool IsSetIncludeAttachmentFilePatterns() => this.IncludeAttachmentFilePatterns != null && (this.IncludeAttachmentFilePatterns.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
