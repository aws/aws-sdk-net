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
    /// Provides the configuration information to connect to Amazon WorkDocs as your data
    /// source.
    /// 
    ///  
    /// <para>
    /// Amazon WorkDocs connector is available in Oregon, North Virginia, Sydney, Singapore
    /// and Ireland regions.
    /// </para>
    /// </summary>
    public partial class WorkDocsConfiguration
    {
        private bool? _crawlComments;
        private List<string> _exclusionPatterns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<DataSourceToIndexFieldMapping> _fieldMappings = AWSConfigs.InitializeCollections ? new List<DataSourceToIndexFieldMapping>() : null;
        private List<string> _inclusionPatterns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _organizationId;
        private bool? _useChangeLog;

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
        public bool? CrawlComments
        {
            get { return this._crawlComments; }
            set { this._crawlComments = value; }
        }

        // Check to see if CrawlComments property is set
        internal bool IsSetCrawlComments()
        {
            return this._crawlComments.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns to exclude certain files in your Amazon WorkDocs
        /// site repository. Files that match the patterns are excluded from the index. Files
        /// that don’t match the patterns are included in the index. If a file matches both an
        /// inclusion and exclusion pattern, the exclusion pattern takes precedence and the file
        /// isn't included in the index.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=250)]
        public List<string> ExclusionPatterns
        {
            get { return this._exclusionPatterns; }
            set { this._exclusionPatterns = value; }
        }

        // Check to see if ExclusionPatterns property is set
        internal bool IsSetExclusionPatterns()
        {
            return this._exclusionPatterns != null && (this._exclusionPatterns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FieldMappings. 
        /// <para>
        /// A list of <c>DataSourceToIndexFieldMapping</c> objects that map Amazon WorkDocs data
        /// source attributes or field names to Amazon Kendra index field names. To create custom
        /// fields, use the <c>UpdateIndex</c> API before you map to Amazon WorkDocs fields. For
        /// more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The Amazon WorkDocs data source field names must exist in
        /// your Amazon WorkDocs custom metadata.
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
        /// Gets and sets the property InclusionPatterns. 
        /// <para>
        /// A list of regular expression patterns to include certain files in your Amazon WorkDocs
        /// site repository. Files that match the patterns are included in the index. Files that
        /// don't match the patterns are excluded from the index. If a file matches both an inclusion
        /// and exclusion pattern, the exclusion pattern takes precedence and the file isn't included
        /// in the index.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=250)]
        public List<string> InclusionPatterns
        {
            get { return this._inclusionPatterns; }
            set { this._inclusionPatterns = value; }
        }

        // Check to see if InclusionPatterns property is set
        internal bool IsSetInclusionPatterns()
        {
            return this._inclusionPatterns != null && (this._inclusionPatterns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The identifier of the directory corresponding to your Amazon WorkDocs site repository.
        /// </para>
        ///  
        /// <para>
        /// You can find the organization ID in the <a href="https://console.aws.amazon.com/directoryservicev2/">Directory
        /// Service</a> by going to <b>Active Directory</b>, then <b>Directories</b>. Your Amazon
        /// WorkDocs site directory has an ID, which is the organization ID. You can also set
        /// up a new Amazon WorkDocs directory in the Directory Service console and enable a Amazon
        /// WorkDocs site for the directory in the Amazon WorkDocs console.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string OrganizationId
        {
            get { return this._organizationId; }
            set { this._organizationId = value; }
        }

        // Check to see if OrganizationId property is set
        internal bool IsSetOrganizationId()
        {
            return this._organizationId != null;
        }

        /// <summary>
        /// Gets and sets the property UseChangeLog. 
        /// <para>
        ///  <c>TRUE</c> to use the Amazon WorkDocs change log to determine which documents require
        /// updating in the index. Depending on the change log's size, it may take longer for
        /// Amazon Kendra to use the change log than to scan all of your documents in Amazon WorkDocs.
        /// </para>
        /// </summary>
        public bool? UseChangeLog
        {
            get { return this._useChangeLog; }
            set { this._useChangeLog = value; }
        }

        // Check to see if UseChangeLog property is set
        internal bool IsSetUseChangeLog()
        {
            return this._useChangeLog.HasValue; 
        }

    }
}