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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeIpamExternalResourceVerificationTokens operation.
    /// Describe verification tokens. A verification token is an Amazon Web Services-generated
    /// random value that you can use to prove ownership of an external resource. For example,
    /// you can use a verification token to validate that you control a public IP address
    /// range when you bring an IP address range to Amazon Web Services (BYOIP).
    /// </summary>
    public partial class DescribeIpamExternalResourceVerificationTokensRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private List<string> _ipamExternalResourceVerificationTokenIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// A check for whether you have the required permissions for the action without actually
        /// making the request and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters for the request. For more information about filtering, see <a
        /// href="https://docs.aws.amazon.com/cli/latest/userguide/cli-usage-filter.html">Filtering
        /// CLI output</a>.
        /// </para>
        ///  
        /// <para>
        /// Available filters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ipam-arn</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ipam-external-resource-verification-token-arn</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ipam-external-resource-verification-token-id</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ipam-id</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ipam-region</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>state</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>status</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>token-name</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>token-value</c> 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Gets and sets the property IpamExternalResourceVerificationTokenIds. 
        /// <para>
        /// Verification token IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IpamExternalResourceVerificationTokenIds
        {
            get { return this._ipamExternalResourceVerificationTokenIds; }
            set { this._ipamExternalResourceVerificationTokenIds = value; }
        }

        // Check to see if IpamExternalResourceVerificationTokenIds property is set
        internal bool IsSetIpamExternalResourceVerificationTokenIds()
        {
            return this._ipamExternalResourceVerificationTokenIds != null && (this._ipamExternalResourceVerificationTokenIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of tokens to return in one page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1000)]
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
        /// The token for the next page of results.
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