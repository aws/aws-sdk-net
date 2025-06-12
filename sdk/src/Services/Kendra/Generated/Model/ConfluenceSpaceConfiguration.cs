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
    /// Configuration information for indexing Confluence spaces.
    /// </summary>
    public partial class ConfluenceSpaceConfiguration
    {
        private bool? _crawlArchivedSpaces;
        private bool? _crawlPersonalSpaces;
        private List<string> _excludeSpaces = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _includeSpaces = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<ConfluenceSpaceToIndexFieldMapping> _spaceFieldMappings = AWSConfigs.InitializeCollections ? new List<ConfluenceSpaceToIndexFieldMapping>() : null;

        /// <summary>
        /// Gets and sets the property CrawlArchivedSpaces. 
        /// <para>
        ///  <c>TRUE</c> to index archived spaces.
        /// </para>
        /// </summary>
        public bool? CrawlArchivedSpaces
        {
            get { return this._crawlArchivedSpaces; }
            set { this._crawlArchivedSpaces = value; }
        }

        // Check to see if CrawlArchivedSpaces property is set
        internal bool IsSetCrawlArchivedSpaces()
        {
            return this._crawlArchivedSpaces.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CrawlPersonalSpaces. 
        /// <para>
        ///  <c>TRUE</c> to index personal spaces. You can add restrictions to items in personal
        /// spaces. If personal spaces are indexed, queries without user context information may
        /// return restricted items from a personal space in their results. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/user-context-filter.html">Filtering
        /// on user context</a>.
        /// </para>
        /// </summary>
        public bool? CrawlPersonalSpaces
        {
            get { return this._crawlPersonalSpaces; }
            set { this._crawlPersonalSpaces = value; }
        }

        // Check to see if CrawlPersonalSpaces property is set
        internal bool IsSetCrawlPersonalSpaces()
        {
            return this._crawlPersonalSpaces.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExcludeSpaces. 
        /// <para>
        /// A list of space keys of Confluence spaces. If you include a key, the blogs, documents,
        /// and attachments in the space are not indexed. If a space is in both the <c>ExcludeSpaces</c>
        /// and the <c>IncludeSpaces</c> list, the space is excluded.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> ExcludeSpaces
        {
            get { return this._excludeSpaces; }
            set { this._excludeSpaces = value; }
        }

        // Check to see if ExcludeSpaces property is set
        internal bool IsSetExcludeSpaces()
        {
            return this._excludeSpaces != null && (this._excludeSpaces.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncludeSpaces. 
        /// <para>
        /// A list of space keys for Confluence spaces. If you include a key, the blogs, documents,
        /// and attachments in the space are indexed. Spaces that aren't in the list aren't indexed.
        /// A space in the list must exist. Otherwise, Amazon Kendra logs an error when the data
        /// source is synchronized. If a space is in both the <c>IncludeSpaces</c> and the <c>ExcludeSpaces</c>
        /// list, the space is excluded.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> IncludeSpaces
        {
            get { return this._includeSpaces; }
            set { this._includeSpaces = value; }
        }

        // Check to see if IncludeSpaces property is set
        internal bool IsSetIncludeSpaces()
        {
            return this._includeSpaces != null && (this._includeSpaces.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SpaceFieldMappings. 
        /// <para>
        /// Maps attributes or field names of Confluence spaces to Amazon Kendra index field names.
        /// To create custom fields, use the <c>UpdateIndex</c> API before you map to Confluence
        /// fields. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The Confluence data source field names must exist in your
        /// Confluence custom metadata.
        /// </para>
        ///  
        /// <para>
        /// If you specify the <c>SpaceFieldMappings</c> parameter, you must specify at least
        /// one field mapping.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public List<ConfluenceSpaceToIndexFieldMapping> SpaceFieldMappings
        {
            get { return this._spaceFieldMappings; }
            set { this._spaceFieldMappings = value; }
        }

        // Check to see if SpaceFieldMappings property is set
        internal bool IsSetSpaceFieldMappings()
        {
            return this._spaceFieldMappings != null && (this._spaceFieldMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}