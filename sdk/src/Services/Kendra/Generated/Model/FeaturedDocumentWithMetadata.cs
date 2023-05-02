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
    /// A featured document with its metadata information. This document is displayed at the
    /// top of the search results page, placed above all other results for certain queries.
    /// If there's an exact match of a query, then the document is featured in the search
    /// results.
    /// </summary>
    public partial class FeaturedDocumentWithMetadata
    {
        private string _id;
        private string _title;
        private string _uri;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the featured document with its metadata. You can use the <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_Query.html">Query</a>
        /// API to search for specific documents with their document IDs included in the result
        /// items, or you can use the console.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The main title of the featured document.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property URI. 
        /// <para>
        /// The source URI location of the featured document.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string URI
        {
            get { return this._uri; }
            set { this._uri = value; }
        }

        // Check to see if URI property is set
        internal bool IsSetURI()
        {
            return this._uri != null;
        }

    }
}