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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
namespace Amazon.FMS.Model
{
    /// <summary>
    /// Container for the parameters to the ListThirdPartyFirewallFirewallPolicies operation.
    /// Retrieves a list of all of the third-party firewall policies that are associated with
    /// the third-party firewall administrator's account.
    /// </summary>
    public partial class ListThirdPartyFirewallFirewallPoliciesRequest : AmazonFMSRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private ThirdPartyFirewall _thirdPartyFirewall;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of third-party firewall policies that you want Firewall Manager
        /// to return. If the specified third-party firewall vendor is associated with more than
        /// <c>MaxResults</c> firewall policies, the response includes a <c>NextToken</c> element.
        /// <c>NextToken</c> contains an encrypted token that identifies the first third-party
        /// firewall policies that Firewall Manager will return if you submit another request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// If the previous response included a <c>NextToken</c> element, the specified third-party
        /// firewall vendor is associated with more third-party firewall policies. To get more
        /// third-party firewall policies, submit another <c>ListThirdPartyFirewallFirewallPoliciesRequest</c>
        /// request.
        /// </para>
        ///  
        /// <para>
        ///  For the value of <c>NextToken</c>, specify the value of <c>NextToken</c> from the
        /// previous response. If the previous response didn't include a <c>NextToken</c> element,
        /// there are no more third-party firewall policies to get. 
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
        /// Gets and sets the property ThirdPartyFirewall. 
        /// <para>
        /// The name of the third-party firewall vendor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ThirdPartyFirewall ThirdPartyFirewall
        {
            get { return this._thirdPartyFirewall; }
            set { this._thirdPartyFirewall = value; }
        }

        // Check to see if ThirdPartyFirewall property is set
        internal bool IsSetThirdPartyFirewall()
        {
            return this._thirdPartyFirewall != null;
        }

    }
}