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
    /// Configuration of blog settings for the Confluence data source. Blogs are always indexed
    /// unless filtered from the index by the <c>ExclusionPatterns</c> or <c>InclusionPatterns</c>
    /// fields in the <c>ConfluenceConfiguration</c> object.
    /// </summary>
    public partial class ConfluenceBlogConfiguration
    {
        private List<ConfluenceBlogToIndexFieldMapping> _blogFieldMappings = AWSConfigs.InitializeCollections ? new List<ConfluenceBlogToIndexFieldMapping>() : null;

        /// <summary>
        /// Gets and sets the property BlogFieldMappings. 
        /// <para>
        /// Maps attributes or field names of Confluence blogs to Amazon Kendra index field names.
        /// To create custom fields, use the <c>UpdateIndex</c> API before you map to Confluence
        /// fields. For more information, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/field-mapping.html">Mapping
        /// data source fields</a>. The Confluence data source field names must exist in your
        /// Confluence custom metadata.
        /// </para>
        ///  
        /// <para>
        /// If you specify the <c>BlogFieldMappings</c> parameter, you must specify at least one
        /// field mapping.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=9)]
        public List<ConfluenceBlogToIndexFieldMapping> BlogFieldMappings
        {
            get { return this._blogFieldMappings; }
            set { this._blogFieldMappings = value; }
        }

        // Check to see if BlogFieldMappings property is set
        internal bool IsSetBlogFieldMappings()
        {
            return this._blogFieldMappings != null && (this._blogFieldMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}