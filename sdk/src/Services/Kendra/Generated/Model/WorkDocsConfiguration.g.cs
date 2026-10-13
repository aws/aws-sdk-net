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
    /// Provides the configuration information to connect to WorkDocs as your data source.
    /// 
    ///  
    /// <para>
    /// WorkDocs connector is available in Oregon, North Virginia, Sydney, Singapore and Ireland
    /// regions.
    /// </para>
    /// </summary>
    public partial class WorkDocsConfiguration
    {
        /// <summary>
        /// Gets and sets the property CrawlComments. 
        /// <para>
        ///  <c>TRUE</c> to include comments on documents in your index. Including comments in
        /// your index means each comment is a document that can be searched on.
        /// </para>
        ///  
        /// <para>
        /// The default is set to <c>FALSE</c>.
        /// </para>
        /// </summary>
        public bool? CrawlComments { get; set; }

        /// <summary>
        /// Checks to see if the CrawlComments property is set.
        /// </summary>
        internal bool IsSetCrawlComments() => this.CrawlComments.HasValue;

        /// <summary>
        /// Gets and sets the property ExclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns to exclude certain files in your WorkDocs site
        /// repository. Files that match the patterns are excluded from the index. Files that
        /// don’t match the patterns are included in the index. If a file matches both an inclusion
        /// and exclusion pattern, the exclusion pattern takes precedence and the file isn't included
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
        public List<string> ExclusionPatterns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExclusionPatterns property is set.
        /// </summary>
        internal bool IsSetExclusionPatterns() => this.ExclusionPatterns != null && (this.ExclusionPatterns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FieldMappings. 
        /// <para>
        /// A list of <c>DataSourceToIndexFieldMapping</c> objects that map WorkDocs data source
        /// attributes or field names to Amazon Kendra index field names. To create custom fields,
        /// use the <c>UpdateIndex</c> API before you map to WorkDocs fields. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The WorkDocs data source field names must exist in your WorkDocs
        /// custom metadata.
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
        /// Gets and sets the property InclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns to include certain files in your WorkDocs site
        /// repository. Files that match the patterns are included in the index. Files that don't
        /// match the patterns are excluded from the index. If a file matches both an inclusion
        /// and exclusion pattern, the exclusion pattern takes precedence and the file isn't included
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
        public List<string> InclusionPatterns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InclusionPatterns property is set.
        /// </summary>
        internal bool IsSetInclusionPatterns() => this.InclusionPatterns != null && (this.InclusionPatterns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The identifier of the directory corresponding to your WorkDocs site repository.
        /// </para>
        ///  
        /// <para>
        /// You can find the organization ID in the <a href="https://console.aws.amazon.com/directoryservicev2/">Directory
        /// Service</a> by going to <b>Active Directory</b>, then <b>Directories</b>. Your WorkDocs
        /// site directory has an ID, which is the organization ID. You can also set up a new
        /// WorkDocs directory in the Directory Service console and enable a WorkDocs site for
        /// the directory in the WorkDocs console.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationId property is set.
        /// </summary>
        internal bool IsSetOrganizationId() => this.OrganizationId != null;

        /// <summary>
        /// Gets and sets the property UseChangeLog. 
        /// <para>
        ///  <c>TRUE</c> to use the WorkDocs change log to determine which documents require updating
        /// in the index. Depending on the change log's size, it may take longer for Amazon Kendra
        /// to use the change log than to scan all of your documents in WorkDocs.
        /// </para>
        /// </summary>
        public bool? UseChangeLog { get; set; }

        /// <summary>
        /// Checks to see if the UseChangeLog property is set.
        /// </summary>
        internal bool IsSetUseChangeLog() => this.UseChangeLog.HasValue;
    }
}
