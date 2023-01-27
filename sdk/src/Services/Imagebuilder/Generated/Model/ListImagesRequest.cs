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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Container for the parameters to the ListImages operation.
    /// Returns the list of images that you have access to. Newly created images can take
    /// up to two minutes to appear in the ListImages API Results.
    /// </summary>
    public partial class ListImagesRequest : AmazonImagebuilderRequest
    {
        private bool? _byName;
        private List<Filter> _filters = new List<Filter>();
        private bool? _includeDeprecated;
        private int? _maxResults;
        private string _nextToken;
        private Ownership _owner;

        /// <summary>
        /// Gets and sets the property ByName. 
        /// <para>
        /// Requests a list of images with a specific recipe name.
        /// </para>
        /// </summary>
        public bool ByName
        {
            get { return this._byName.GetValueOrDefault(); }
            set { this._byName = value; }
        }

        // Check to see if ByName property is set
        internal bool IsSetByName()
        {
            return this._byName.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Use the following filters to streamline results:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>name</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>osVersion</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>platform</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>type</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>version</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IncludeDeprecated. 
        /// <para>
        /// Includes deprecated images in the response list.
        /// </para>
        /// </summary>
        public bool IncludeDeprecated
        {
            get { return this._includeDeprecated.GetValueOrDefault(); }
            set { this._includeDeprecated = value; }
        }

        // Check to see if IncludeDeprecated property is set
        internal bool IsSetIncludeDeprecated()
        {
            return this._includeDeprecated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum items to return in a request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to specify where to start paginating. This is the NextToken from a previously
        /// truncated response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner defines which images you want to list. By default, this request will only
        /// show images owned by your account. You can use this field to specify if you want to
        /// view images owned by yourself, by Amazon, or those images that have been shared with
        /// you by other customers.
        /// </para>
        /// </summary>
        public Ownership Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

    }
}