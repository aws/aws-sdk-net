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
    /// Obtains information about the WorkSpace bundles that are available to your account
    /// in the specified region.
    /// 
    ///  
    /// <para>
    /// You can filter the results with either the <code>BundleIds</code> parameter, or the
    /// <code>Owner</code> parameter, but not both.
    /// </para>
    ///  
    /// <para>
    /// This operation supports pagination with the use of the <code>NextToken</code> request
    /// and response parameters. If more results are available, the <code>NextToken</code>
    /// response member contains a token that you pass in the next call to this operation
    /// to retrieve the next set of items.
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
        /// An array of strings that contains the identifiers of the bundles to retrieve. This
        /// parameter cannot be combined with any other filter parameter.
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
        /// The <code>NextToken</code> value from a previous call to this operation. Pass null
        /// if this is the first call.
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
        /// The owner of the bundles to retrieve. This parameter cannot be combined with any other
        /// filter parameter.
        /// </para>
        ///  
        /// <para>
        /// This contains one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// null- Retrieves the bundles that belong to the account making the call.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AMAZON</code>- Retrieves the bundles that are provided by AWS.
        /// </para>
        ///  </li> </ul>
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