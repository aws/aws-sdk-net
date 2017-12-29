/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeWorkspaceBundles operation.
    /// Describes the available WorkSpace bundles.
    /// 
    ///  
    /// <para>
    /// You can filter the results using either bundle ID or owner, but not both.
    /// </para>
    /// </summary>
    public partial class DescribeWorkspaceBundlesRequest : AmazonWorkSpacesRequest
    {
        private List<string> _bundleIds = new List<string>();
        private string _nextToken;
        private string _owner;

        /// <summary>
        /// Gets and sets the property BundleIds. 
        /// <para>
        /// The IDs of the bundles. This parameter cannot be combined with any other filter.
        /// </para>
        /// </summary>
        public List<string> BundleIds
        {
            get { return this._bundleIds; }
            set { this._bundleIds = value; }
        }

        // Check to see if BundleIds property is set
        internal bool IsSetBundleIds()
        {
            return this._bundleIds != null && this._bundleIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. (You received this token from a previous call.)
        /// </para>
        /// </summary>
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
        /// The owner of the bundles. This parameter cannot be combined with any other filter.
        /// </para>
        ///  
        /// <para>
        /// Specify <code>AMAZON</code> to describe the bundles provided by AWS or null to describe
        /// the bundles that belong to your account.
        /// </para>
        /// </summary>
        public string Owner
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