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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Container for the parameters to the ListImages operation.
    /// Returns the list of images that you have access to.
    /// </summary>
    public partial class ListImagesRequest : AmazonImagebuilderRequest
    {
        private bool? _byName;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private bool? _includeDeprecated;
        private int? _maxResults;
        private string _nextToken;
        private Ownership _owner;

        /// <summary>
        /// Gets and sets the property ByName. 
        /// <para>
        /// Specifies whether to return one entry per image name, with all versions of each image
        /// aggregated. Defaults to <c>false</c>, which returns one entry per image version. You
        /// can't combine this option with the <c>version</c> filter.
        /// </para>
        /// </summary>
        public bool? ByName
        {
            get { return this._byName; }
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
        ///  <c>name</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>osVersion</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>platform</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>type</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>version</c> 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncludeDeprecated. 
        /// <para>
        /// Specifies whether to include deprecated Amazon-managed images in the results. Deprecated
        /// images that you own are always returned. Defaults to <c>false</c>.
        /// </para>
        /// </summary>
        public bool? IncludeDeprecated
        {
            get { return this._includeDeprecated; }
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
        /// The maximum number of items to return in a single request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        /// A token to specify where to start paginating. Use the <c>nextToken</c> value from
        /// a previously truncated response.
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
        /// Filters the list to images owned by you, by Amazon, or shared with you by other accounts.
        /// By default, only your account's images are returned.
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