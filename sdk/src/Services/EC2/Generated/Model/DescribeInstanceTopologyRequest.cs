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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeInstanceTopology operation.
    /// Describes a tree-based hierarchy that represents the physical host placement of your
    /// EC2 instances within an Availability Zone or Local Zone. You can use this information
    /// to determine the relative proximity of your EC2 instances within the Amazon Web Services
    /// network to support your tightly coupled workloads.
    /// 
    ///  
    /// <para>
    ///  <b>Limitations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Supported zones
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Availability Zone
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Local Zone
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Supported instance types
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>hpc6a.48xlarge</c> | <c>hpc6id.32xlarge</c> | <c>hpc7a.12xlarge</c> | <c>hpc7a.24xlarge</c>
    /// | <c>hpc7a.48xlarge</c> | <c>hpc7a.96xlarge</c> | <c>hpc7g.4xlarge</c> | <c>hpc7g.8xlarge</c>
    /// | <c>hpc7g.16xlarge</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>p3dn.24xlarge</c> | <c>p4d.24xlarge</c> | <c>p4de.24xlarge</c> | <c>p5.48xlarge</c>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>trn1.2xlarge</c> | <c>trn1.32xlarge</c> | <c>trn1n.32xlarge</c> 
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-topology.html">Amazon
    /// EC2 instance topology</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeInstanceTopologyRequest : AmazonEC2Request
    {
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private List<string> _groupNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _instanceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>availability-zone</c> - The name of the Availability Zone (for example, <c>us-west-2a</c>)
        /// or Local Zone (for example, <c>us-west-2-lax-1b</c>) that the instance is in.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instance-type</c> - The instance type (for example, <c>p4d.24xlarge</c>) or instance
        /// family (for example, <c>p4d*</c>). You can use the <c>*</c> wildcard to match zero
        /// or more characters, or the <c>?</c> wildcard to match zero or one character.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>zone-id</c> - The ID of the Availability Zone (for example, <c>usw2-az2</c>) or
        /// Local Zone (for example, <c>usw2-lax1-az1</c>) that the instance is in.
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        /// Gets and sets the property GroupNames. 
        /// <para>
        /// The name of the placement group that each instance is in.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Maximum 100 explicitly specified placement group names.
        /// </para>
        /// </summary>
        public List<string> GroupNames
        {
            get { return this._groupNames; }
            set { this._groupNames = value; }
        }

        // Check to see if GroupNames property is set
        internal bool IsSetGroupNames()
        {
            return this._groupNames != null && (this._groupNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstanceIds. 
        /// <para>
        /// The instance IDs.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all your instances.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Maximum 100 explicitly specified instance IDs.
        /// </para>
        /// </summary>
        public List<string> InstanceIds
        {
            get { return this._instanceIds; }
            set { this._instanceIds = value; }
        }

        // Check to see if InstanceIds property is set
        internal bool IsSetInstanceIds()
        {
            return this._instanceIds != null && (this._instanceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
        /// </para>
        ///  
        /// <para>
        /// You can't specify this parameter and the instance IDs parameter in the same request.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>20</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// The token returned from a previous paginated request. Pagination continues from the
        /// end of the items returned by the previous request.
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