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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudSearchDomain.Model
{
    /// <summary>
    /// The collection of documents that match the search request.
    /// </summary>
    public partial class Hits
    {
        private string _cursor;
        private long? _found;
        private List<Hit> _hit = AWSConfigs.InitializeCollections ? new List<Hit>() : null;
        private long? _start;

        /// <summary>
        /// Gets and sets the property Cursor. 
        /// <para>
        /// A cursor that can be used to retrieve the next set of matching documents when you
        /// want to page through a large result set.
        /// </para>
        /// </summary>
        public string Cursor
        {
            get { return this._cursor; }
            set { this._cursor = value; }
        }

        // Check to see if Cursor property is set
        internal bool IsSetCursor()
        {
            return this._cursor != null;
        }

        /// <summary>
        /// Gets and sets the property Found. 
        /// <para>
        /// The total number of documents that match the search request.
        /// </para>
        /// </summary>
        public long? Found
        {
            get { return this._found; }
            set { this._found = value; }
        }

        // Check to see if Found property is set
        internal bool IsSetFound()
        {
            return this._found.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Hit. 
        /// <para>
        /// A document that matches the search request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Hit> Hit
        {
            get { return this._hit; }
            set { this._hit = value; }
        }

        // Check to see if Hit property is set
        internal bool IsSetHit()
        {
            return this._hit != null && (this._hit.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Start. 
        /// <para>
        /// The index of the first matching document.
        /// </para>
        /// </summary>
        public long? Start
        {
            get { return this._start; }
            set { this._start = value; }
        }

        // Check to see if Start property is set
        internal bool IsSetStart()
        {
            return this._start.HasValue; 
        }

    }
}