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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribePrincipalIdFormat operation.
    /// Describes the ID format settings for the root user and all IAM roles and IAM users
    /// that have explicitly specified a longer ID (17-character ID) preference. 
    /// 
    ///  
    /// <para>
    /// By default, all IAM roles and IAM users default to the same ID settings as the root
    /// user, unless they explicitly override the settings. This request is useful for identifying
    /// those IAM users and IAM roles that have overridden the default ID settings.
    /// </para>
    ///  
    /// <para>
    /// The following resource types support longer IDs: <code>bundle</code> | <code>conversion-task</code>
    /// | <code>customer-gateway</code> | <code>dhcp-options</code> | <code>elastic-ip-allocation</code>
    /// | <code>elastic-ip-association</code> | <code>export-task</code> | <code>flow-log</code>
    /// | <code>image</code> | <code>import-task</code> | <code>instance</code> | <code>internet-gateway</code>
    /// | <code>network-acl</code> | <code>network-acl-association</code> | <code>network-interface</code>
    /// | <code>network-interface-attachment</code> | <code>prefix-list</code> | <code>reservation</code>
    /// | <code>route-table</code> | <code>route-table-association</code> | <code>security-group</code>
    /// | <code>snapshot</code> | <code>subnet</code> | <code>subnet-cidr-block-association</code>
    /// | <code>volume</code> | <code>vpc</code> | <code>vpc-cidr-block-association</code>
    /// | <code>vpc-endpoint</code> | <code>vpc-peering-connection</code> | <code>vpn-connection</code>
    /// | <code>vpn-gateway</code>. 
    /// </para>
    /// </summary>
    public partial class DescribePrincipalIdFormatRequest : AmazonEC2Request
    {
        private int? _maxResults;
        private string _nextToken;
        private List<string> _resources = new List<string>();

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call. To retrieve the remaining
        /// results, make another call with the returned NextToken value. 
        /// </para>
        /// </summary>
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
        /// The token to request the next page of results.
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
        /// Gets and sets the property Resources. 
        /// <para>
        /// The type of resource: <code>bundle</code> | <code>conversion-task</code> | <code>customer-gateway</code>
        /// | <code>dhcp-options</code> | <code>elastic-ip-allocation</code> | <code>elastic-ip-association</code>
        /// | <code>export-task</code> | <code>flow-log</code> | <code>image</code> | <code>import-task</code>
        /// | <code>instance</code> | <code>internet-gateway</code> | <code>network-acl</code>
        /// | <code>network-acl-association</code> | <code>network-interface</code> | <code>network-interface-attachment</code>
        /// | <code>prefix-list</code> | <code>reservation</code> | <code>route-table</code> |
        /// <code>route-table-association</code> | <code>security-group</code> | <code>snapshot</code>
        /// | <code>subnet</code> | <code>subnet-cidr-block-association</code> | <code>volume</code>
        /// | <code>vpc</code> | <code>vpc-cidr-block-association</code> | <code>vpc-endpoint</code>
        /// | <code>vpc-peering-connection</code> | <code>vpn-connection</code> | <code>vpn-gateway</code>
        /// 
        /// </para>
        /// </summary>
        public List<string> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && this._resources.Count > 0; 
        }

    }
}