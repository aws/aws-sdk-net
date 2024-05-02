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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
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
namespace Amazon.Panorama.Model
{
    /// <summary>
    /// Container for the parameters to the ListNodes operation.
    /// Returns a list of nodes.
    /// </summary>
    public partial class ListNodesRequest : AmazonPanoramaRequest
    {
        private NodeCategory _category;
        private int? _maxResults;
        private string _nextToken;
        private string _ownerAccount;
        private string _packageName;
        private string _packageVersion;
        private string _patchVersion;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// Search for nodes by category.
        /// </para>
        /// </summary>
        public NodeCategory Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of nodes to return in one page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
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
        /// Specify the pagination token from a previous request to retrieve the next page of
        /// results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
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
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// Search for nodes by the account ID of the nodes' owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=12)]
        public string OwnerAccount
        {
            get { return this._ownerAccount; }
            set { this._ownerAccount = value; }
        }

        // Check to see if OwnerAccount property is set
        internal bool IsSetOwnerAccount()
        {
            return this._ownerAccount != null;
        }

        /// <summary>
        /// Gets and sets the property PackageName. 
        /// <para>
        /// Search for nodes by name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string PackageName
        {
            get { return this._packageName; }
            set { this._packageName = value; }
        }

        // Check to see if PackageName property is set
        internal bool IsSetPackageName()
        {
            return this._packageName != null;
        }

        /// <summary>
        /// Gets and sets the property PackageVersion. 
        /// <para>
        /// Search for nodes by version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string PackageVersion
        {
            get { return this._packageVersion; }
            set { this._packageVersion = value; }
        }

        // Check to see if PackageVersion property is set
        internal bool IsSetPackageVersion()
        {
            return this._packageVersion != null;
        }

        /// <summary>
        /// Gets and sets the property PatchVersion. 
        /// <para>
        /// Search for nodes by patch version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string PatchVersion
        {
            get { return this._patchVersion; }
            set { this._patchVersion = value; }
        }

        // Check to see if PatchVersion property is set
        internal bool IsSetPatchVersion()
        {
            return this._patchVersion != null;
        }

    }
}