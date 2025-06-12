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
    /// The following resource types support longer IDs: <c>bundle</c> | <c>conversion-task</c>
    /// | <c>customer-gateway</c> | <c>dhcp-options</c> | <c>elastic-ip-allocation</c> | <c>elastic-ip-association</c>
    /// | <c>export-task</c> | <c>flow-log</c> | <c>image</c> | <c>import-task</c> | <c>instance</c>
    /// | <c>internet-gateway</c> | <c>network-acl</c> | <c>network-acl-association</c> |
    /// <c>network-interface</c> | <c>network-interface-attachment</c> | <c>prefix-list</c>
    /// | <c>reservation</c> | <c>route-table</c> | <c>route-table-association</c> | <c>security-group</c>
    /// | <c>snapshot</c> | <c>subnet</c> | <c>subnet-cidr-block-association</c> | <c>volume</c>
    /// | <c>vpc</c> | <c>vpc-cidr-block-association</c> | <c>vpc-endpoint</c> | <c>vpc-peering-connection</c>
    /// | <c>vpn-connection</c> | <c>vpn-gateway</c>. 
    /// </para>
    /// </summary>
    public partial class DescribePrincipalIdFormatRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _resources = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        /// The maximum number of results to return in a single call. To retrieve the remaining
        /// results, make another call with the returned NextToken value. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// The type of resource: <c>bundle</c> | <c>conversion-task</c> | <c>customer-gateway</c>
        /// | <c>dhcp-options</c> | <c>elastic-ip-allocation</c> | <c>elastic-ip-association</c>
        /// | <c>export-task</c> | <c>flow-log</c> | <c>image</c> | <c>import-task</c> | <c>instance</c>
        /// | <c>internet-gateway</c> | <c>network-acl</c> | <c>network-acl-association</c> |
        /// <c>network-interface</c> | <c>network-interface-attachment</c> | <c>prefix-list</c>
        /// | <c>reservation</c> | <c>route-table</c> | <c>route-table-association</c> | <c>security-group</c>
        /// | <c>snapshot</c> | <c>subnet</c> | <c>subnet-cidr-block-association</c> | <c>volume</c>
        /// | <c>vpc</c> | <c>vpc-cidr-block-association</c> | <c>vpc-endpoint</c> | <c>vpc-peering-connection</c>
        /// | <c>vpn-connection</c> | <c>vpn-gateway</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && (this._resources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}