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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeInstanceInformation operation.
    /// Describes one or more of your managed nodes, including information about the operating
    /// system platform, the version of SSM Agent installed on the managed node, node status,
    /// and so on.
    /// 
    ///  
    /// <para>
    /// If you specify one or more managed node IDs, it returns information for those managed
    /// nodes. If you don't specify node IDs, it returns information for all your managed
    /// nodes. If you specify a node ID that isn't valid or a node that you don't own, you
    /// receive an error.
    /// </para>
    ///  <note> 
    /// <para>
    /// The <code>IamRole</code> field for this API operation is the Identity and Access Management
    /// (IAM) role assigned to on-premises managed nodes. This call doesn't return the IAM
    /// role for EC2 instances.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeInstanceInformationRequest : AmazonSimpleSystemsManagementRequest
    {
        private List<InstanceInformationStringFilter> _filters = new List<InstanceInformationStringFilter>();
        private List<InstanceInformationFilter> _instanceInformationFilterList = new List<InstanceInformationFilter>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters. Use a filter to return a more specific list of managed nodes.
        /// You can filter based on tags applied to your managed nodes. Use this <code>Filters</code>
        /// data type instead of <code>InstanceInformationFilterList</code>, which is deprecated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public List<InstanceInformationStringFilter> Filters
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
        /// Gets and sets the property InstanceInformationFilterList. 
        /// <para>
        /// This is a legacy method. We recommend that you don't use this method. Instead, use
        /// the <code>Filters</code> data type. <code>Filters</code> enables you to return node
        /// information by filtering based on tags applied to managed nodes.
        /// </para>
        ///  <note> 
        /// <para>
        /// Attempting to use <code>InstanceInformationFilterList</code> and <code>Filters</code>
        /// leads to an exception error. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0)]
        public List<InstanceInformationFilter> InstanceInformationFilterList
        {
            get { return this._instanceInformationFilterList; }
            set { this._instanceInformationFilterList = value; }
        }

        // Check to see if InstanceInformationFilterList property is set
        internal bool IsSetInstanceInformationFilterList()
        {
            return this._instanceInformationFilterList != null && this._instanceInformationFilterList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this call. The call also returns a token
        /// that you can specify in a subsequent call to get the next set of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=50)]
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
        /// The token for the next set of items to return. (You received this token from a previous
        /// call.)
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

    }
}