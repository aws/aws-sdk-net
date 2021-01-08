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
    /// Specifies the page settings for the Confluence data source.
    /// </summary>
    public partial class ConfluencePageConfiguration
    {
        private List<ConfluencePageToIndexFieldMapping> _pageFieldMappings = new List<ConfluencePageToIndexFieldMapping>();

        /// <summary>
        /// Gets and sets the property PageFieldMappings. 
        /// <para>
        /// Defines how page metadata fields should be mapped to index fields. Before you can
        /// map a field, you must first create an index field with a matching type using the console
        /// or the <code>UpdateIndex</code> operation.
        /// </para>
        ///  
        /// <para>
        /// If you specify the <code>PageFieldMappings</code> parameter, you must specify at least
        /// one field mapping.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=12)]
        public List<ConfluencePageToIndexFieldMapping> PageFieldMappings
        {
            get { return this._pageFieldMappings; }
            set { this._pageFieldMappings = value; }
        }

        // Check to see if PageFieldMappings property is set
        internal bool IsSetPageFieldMappings()
        {
            return this._pageFieldMappings != null && this._pageFieldMappings.Count > 0; 
        }

    }
}