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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeWorkspaceBundles operation.
    /// Retrieves a list that describes the available WorkSpace bundles.
    /// 
    ///  
    /// <para>
    /// You can filter the results using either bundle ID or owner, but not both.
    /// </para>
    /// </summary>
    public partial class DescribeWorkspaceBundlesRequest : AmazonWorkSpacesRequest
    {
        private List<string> _bundleIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _nextToken;
        private string _owner;

        /// <summary>
        /// Gets and sets the property BundleIds. 
        /// <para>
        /// The identifiers of the bundles. You cannot combine this parameter with any other filter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public List<string> BundleIds
        {
            get { return this._bundleIds; }
            set { this._bundleIds = value; }
        }

        // Check to see if BundleIds property is set
        internal bool IsSetBundleIds()
        {
            return this._bundleIds != null && (this._bundleIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. (You received this token from a previous call.)
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// The owner of the bundles. You cannot combine this parameter with any other filter.
        /// </para>
        ///  
        /// <para>
        /// To describe the bundles provided by Amazon Web Services, specify <c>AMAZON</c>. To
        /// describe the bundles that belong to your account, don't specify a value.
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