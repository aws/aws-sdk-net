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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// A configuration for Amazon EMR block public access. When <c>BlockPublicSecurityGroupRules</c>
    /// is set to <c>true</c>, Amazon EMR prevents cluster creation if one of the cluster's
    /// security groups has a rule that allows inbound traffic from 0.0.0.0/0 or ::/0 on a
    /// port, unless the port is specified as an exception using <c>PermittedPublicSecurityGroupRuleRanges</c>.
    /// </summary>
    public partial class BlockPublicAccessConfiguration
    {
        private bool? _blockPublicSecurityGroupRules;
        private List<PortRange> _permittedPublicSecurityGroupRuleRanges = AWSConfigs.InitializeCollections ? new List<PortRange>() : null;

        /// <summary>
        /// Gets and sets the property BlockPublicSecurityGroupRules. 
        /// <para>
        /// Indicates whether Amazon EMR block public access is enabled (<c>true</c>) or disabled
        /// (<c>false</c>). By default, the value is <c>false</c> for accounts that have created
        /// Amazon EMR clusters before July 2019. For accounts created after this, the default
        /// is <c>true</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? BlockPublicSecurityGroupRules
        {
            get { return this._blockPublicSecurityGroupRules; }
            set { this._blockPublicSecurityGroupRules = value; }
        }

        // Check to see if BlockPublicSecurityGroupRules property is set
        internal bool IsSetBlockPublicSecurityGroupRules()
        {
            return this._blockPublicSecurityGroupRules.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PermittedPublicSecurityGroupRuleRanges. 
        /// <para>
        /// Specifies ports and port ranges that are permitted to have security group rules that
        /// allow inbound traffic from all public sources. For example, if Port 23 (Telnet) is
        /// specified for <c>PermittedPublicSecurityGroupRuleRanges</c>, Amazon EMR allows cluster
        /// creation if a security group associated with the cluster has a rule that allows inbound
        /// traffic on Port 23 from IPv4 0.0.0.0/0 or IPv6 port ::/0 as the source.
        /// </para>
        ///  
        /// <para>
        /// By default, Port 22, which is used for SSH access to the cluster Amazon EC2 instances,
        /// is in the list of <c>PermittedPublicSecurityGroupRuleRanges</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PortRange> PermittedPublicSecurityGroupRuleRanges
        {
            get { return this._permittedPublicSecurityGroupRuleRanges; }
            set { this._permittedPublicSecurityGroupRuleRanges = value; }
        }

        // Check to see if PermittedPublicSecurityGroupRuleRanges property is set
        internal bool IsSetPermittedPublicSecurityGroupRuleRanges()
        {
            return this._permittedPublicSecurityGroupRuleRanges != null && (this._permittedPublicSecurityGroupRuleRanges.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}