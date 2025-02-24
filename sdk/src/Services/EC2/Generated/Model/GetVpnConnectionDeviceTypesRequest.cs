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
    /// Container for the parameters to the GetVpnConnectionDeviceTypes operation.
    /// Obtain a list of customer gateway devices for which sample configuration files can
    /// be provided. The request has no additional parameters. You can also see the list of
    /// device types with sample configuration files available under <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/your-cgw.html">Your
    /// customer gateway device</a> in the <i>Amazon Web Services Site-to-Site VPN User Guide</i>.
    /// </summary>
    public partial class GetVpnConnectionDeviceTypesRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results returned by <c>GetVpnConnectionDeviceTypes</c> in paginated
        /// output. When this parameter is used, <c>GetVpnConnectionDeviceTypes</c> only returns
        /// <c>MaxResults</c> results in a single page along with a <c>NextToken</c> response
        /// element. The remaining results of the initial request can be seen by sending another
        /// <c>GetVpnConnectionDeviceTypes</c> request with the returned <c>NextToken</c> value.
        /// This value can be between 200 and 1000. If this parameter is not used, then <c>GetVpnConnectionDeviceTypes</c>
        /// returns all results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=200, Max=1000)]
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
        /// The <c>NextToken</c> value returned from a previous paginated <c>GetVpnConnectionDeviceTypes</c>
        /// request where <c>MaxResults</c> was used and the results exceeded the value of that
        /// parameter. Pagination continues from the end of the previous results that returned
        /// the <c>NextToken</c> value. This value is null when there are no more results to return.
        /// 
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