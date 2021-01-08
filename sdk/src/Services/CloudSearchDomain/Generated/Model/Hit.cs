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
 * Do not modify this file. This file is generated from the cloudsearchdomain-2013-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudSearchDomain.Model
{
    /// <summary>
    /// Information about a document that matches the search request.
    /// </summary>
    public partial class Hit
    {
        private Dictionary<string, string> _exprs = new Dictionary<string, string>();
        private Dictionary<string, List<string>> _fields = new Dictionary<string, List<string>>();
        private Dictionary<string, string> _highlights = new Dictionary<string, string>();
        private string _id;

        /// <summary>
        /// Gets and sets the property Exprs. 
        /// <para>
        /// The expressions returned from a document that matches the search request.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Exprs
        {
            get { return this._exprs; }
            set { this._exprs = value; }
        }

        // Check to see if Exprs property is set
        internal bool IsSetExprs()
        {
            return this._exprs != null && this._exprs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// The fields returned from a document that matches the search request.
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> Fields
        {
            get { return this._fields; }
            set { this._fields = value; }
        }

        // Check to see if Fields property is set
        internal bool IsSetFields()
        {
            return this._fields != null && this._fields.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Highlights. 
        /// <para>
        /// The highlights returned from a document that matches the search request.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Highlights
        {
            get { return this._highlights; }
            set { this._highlights = value; }
        }

        // Check to see if Highlights property is set
        internal bool IsSetHighlights()
        {
            return this._highlights != null && this._highlights.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The document ID of a document that matches the search request.
        /// </para>
        /// </summary>
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

    }
}