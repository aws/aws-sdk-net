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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Specifies the blog settings for the Confluence data source. Blogs are always indexed
    /// unless filtered from the index by the <code>ExclusionPatterns</code> or <code>InclusionPatterns</code>
    /// fields in the data type.
    /// </summary>
    public partial class ConfluenceBlogConfiguration
    {
        private List<ConfluenceBlogToIndexFieldMapping> _blogFieldMappings = new List<ConfluenceBlogToIndexFieldMapping>();

        /// <summary>
        /// Gets and sets the property BlogFieldMappings. 
        /// <para>
        /// Defines how blog metadata fields should be mapped to index fields. Before you can
        /// map a field, you must first create an index field with a matching type using the console
        /// or the <code>UpdateIndex</code> operation.
        /// </para>
        ///  
        /// <para>
        /// If you specify the <code>BlogFieldMappings</code> parameter, you must specify at least
        /// one field mapping.
        /// </para>
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
            return this._blogFieldMappings != null && this._blogFieldMappings.Count > 0; 
        }

    }
}