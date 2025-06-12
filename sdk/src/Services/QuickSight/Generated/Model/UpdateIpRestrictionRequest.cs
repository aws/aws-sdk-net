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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateIpRestriction operation.
    /// Updates the content and status of IP rules. Traffic from a source is allowed when
    /// the source satisfies either the <c>IpRestrictionRule</c>, <c>VpcIdRestrictionRule</c>,
    /// or <c>VpcEndpointIdRestrictionRule</c>. To use this operation, you must provide the
    /// entire map of rules. You can use the <c>DescribeIpRestriction</c> operation to get
    /// the current rule map.
    /// </summary>
    public partial class UpdateIpRestrictionRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private bool? _enabled;
        private Dictionary<string, string> _ipRestrictionRuleMap = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _vpcEndpointIdRestrictionRuleMap = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _vpcIdRestrictionRuleMap = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the IP rules.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// A value that specifies whether IP rules are turned on.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IpRestrictionRuleMap. 
        /// <para>
        /// A map that describes the updated IP rules with CIDR ranges and descriptions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> IpRestrictionRuleMap
        {
            get { return this._ipRestrictionRuleMap; }
            set { this._ipRestrictionRuleMap = value; }
        }

        // Check to see if IpRestrictionRuleMap property is set
        internal bool IsSetIpRestrictionRuleMap()
        {
            return this._ipRestrictionRuleMap != null && (this._ipRestrictionRuleMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointIdRestrictionRuleMap. 
        /// <para>
        /// A map of allowed VPC endpoint IDs and their corresponding rule descriptions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> VpcEndpointIdRestrictionRuleMap
        {
            get { return this._vpcEndpointIdRestrictionRuleMap; }
            set { this._vpcEndpointIdRestrictionRuleMap = value; }
        }

        // Check to see if VpcEndpointIdRestrictionRuleMap property is set
        internal bool IsSetVpcEndpointIdRestrictionRuleMap()
        {
            return this._vpcEndpointIdRestrictionRuleMap != null && (this._vpcEndpointIdRestrictionRuleMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcIdRestrictionRuleMap. 
        /// <para>
        /// A map of VPC IDs and their corresponding rules. When you configure this parameter,
        /// traffic from all VPC endpoints that are present in the specified VPC is allowed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> VpcIdRestrictionRuleMap
        {
            get { return this._vpcIdRestrictionRuleMap; }
            set { this._vpcIdRestrictionRuleMap = value; }
        }

        // Check to see if VpcIdRestrictionRuleMap property is set
        internal bool IsSetVpcIdRestrictionRuleMap()
        {
            return this._vpcIdRestrictionRuleMap != null && (this._vpcIdRestrictionRuleMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}