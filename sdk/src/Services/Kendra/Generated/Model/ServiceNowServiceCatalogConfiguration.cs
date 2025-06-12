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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
    /// Provides the configuration information for crawling service catalog items in the ServiceNow
    /// site
    /// </summary>
    public partial class ServiceNowServiceCatalogConfiguration
    {
        private bool? _crawlAttachments;
        private string _documentDataFieldName;
        private string _documentTitleFieldName;
        private List<string> _excludeAttachmentFilePatterns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<DataSourceToIndexFieldMapping> _fieldMappings = AWSConfigs.InitializeCollections ? new List<DataSourceToIndexFieldMapping>() : null;
        private List<string> _includeAttachmentFilePatterns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CrawlAttachments. 
        /// <para>
        ///  <c>TRUE</c> to index attachments to service catalog items.
        /// </para>
        /// </summary>
        public bool? CrawlAttachments
        {
            get { return this._crawlAttachments; }
            set { this._crawlAttachments = value; }
        }

        // Check to see if CrawlAttachments property is set
        internal bool IsSetCrawlAttachments()
        {
            return this._crawlAttachments.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DocumentDataFieldName. 
        /// <para>
        /// The name of the ServiceNow field that is mapped to the index document contents field
        /// in the Amazon Kendra index.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string DocumentDataFieldName
        {
            get { return this._documentDataFieldName; }
            set { this._documentDataFieldName = value; }
        }

        // Check to see if DocumentDataFieldName property is set
        internal bool IsSetDocumentDataFieldName()
        {
            return this._documentDataFieldName != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentTitleFieldName. 
        /// <para>
        /// The name of the ServiceNow field that is mapped to the index document title field.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string DocumentTitleFieldName
        {
            get { return this._documentTitleFieldName; }
            set { this._documentTitleFieldName = value; }
        }

        // Check to see if DocumentTitleFieldName property is set
        internal bool IsSetDocumentTitleFieldName()
        {
            return this._documentTitleFieldName != null;
        }

        /// <summary>
        /// Gets and sets the property ExcludeAttachmentFilePatterns. 
        /// <para>
        /// A list of regular expression patterns to exclude certain attachments of catalogs in
        /// your ServiceNow. Item that match the patterns are excluded from the index. Items that
        /// don't match the patterns are included in the index. If an item matches both an inclusion
        /// and exclusion pattern, the exclusion pattern takes precedence and the item isn't included
        /// in the index.
        /// </para>
        ///  
        /// <para>
        /// The regex is applied to the file name of the attachment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=250)]
        public List<string> ExcludeAttachmentFilePatterns
        {
            get { return this._excludeAttachmentFilePatterns; }
            set { this._excludeAttachmentFilePatterns = value; }
        }

        // Check to see if ExcludeAttachmentFilePatterns property is set
        internal bool IsSetExcludeAttachmentFilePatterns()
        {
            return this._excludeAttachmentFilePatterns != null && (this._excludeAttachmentFilePatterns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FieldMappings. 
        /// <para>
        /// Maps attributes or field names of catalogs to Amazon Kendra index field names. To
        /// create custom fields, use the <c>UpdateIndex</c> API before you map to ServiceNow
        /// fields. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The ServiceNow data source field names must exist in your
        /// ServiceNow custom metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<DataSourceToIndexFieldMapping> FieldMappings
        {
            get { return this._fieldMappings; }
            set { this._fieldMappings = value; }
        }

        // Check to see if FieldMappings property is set
        internal bool IsSetFieldMappings()
        {
            return this._fieldMappings != null && (this._fieldMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncludeAttachmentFilePatterns. 
        /// <para>
        /// A list of regular expression patterns to include certain attachments of catalogs in
        /// your ServiceNow. Item that match the patterns are included in the index. Items that
        /// don't match the patterns are excluded from the index. If an item matches both an inclusion
        /// and exclusion pattern, the exclusion pattern takes precedence and the item isn't included
        /// in the index.
        /// </para>
        ///  
        /// <para>
        /// The regex is applied to the file name of the attachment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=250)]
        public List<string> IncludeAttachmentFilePatterns
        {
            get { return this._includeAttachmentFilePatterns; }
            set { this._includeAttachmentFilePatterns = value; }
        }

        // Check to see if IncludeAttachmentFilePatterns property is set
        internal bool IsSetIncludeAttachmentFilePatterns()
        {
            return this._includeAttachmentFilePatterns != null && (this._includeAttachmentFilePatterns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}