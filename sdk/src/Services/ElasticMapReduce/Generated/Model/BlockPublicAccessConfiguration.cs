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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// A configuration for Amazon EMR block public access. When <code>BlockPublicSecurityGroupRules</code>
    /// is set to <code>true</code>, Amazon EMR prevents cluster creation if one of the cluster's
    /// security groups has a rule that allows inbound traffic from 0.0.0.0/0 or ::/0 on a
    /// port, unless the port is specified as an exception using <code>PermittedPublicSecurityGroupRuleRanges</code>.
    /// </summary>
    public partial class BlockPublicAccessConfiguration
    {
        private bool? _blockPublicSecurityGroupRules;
        private List<PortRange> _permittedPublicSecurityGroupRuleRanges = new List<PortRange>();

        /// <summary>
        /// Gets and sets the property BlockPublicSecurityGroupRules. 
        /// <para>
        /// Indicates whether Amazon EMR block public access is enabled (<code>true</code>) or
        /// disabled (<code>false</code>). By default, the value is <code>false</code> for accounts
        /// that have created EMR clusters before July 2019. For accounts created after this,
        /// the default is <code>true</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool BlockPublicSecurityGroupRules
        {
            get { return this._blockPublicSecurityGroupRules.GetValueOrDefault(); }
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
        /// specified for <code>PermittedPublicSecurityGroupRuleRanges</code>, Amazon EMR allows
        /// cluster creation if a security group associated with the cluster has a rule that allows
        /// inbound traffic on Port 23 from IPv4 0.0.0.0/0 or IPv6 port ::/0 as the source.
        /// </para>
        ///  
        /// <para>
        /// By default, Port 22, which is used for SSH access to the cluster EC2 instances, is
        /// in the list of <code>PermittedPublicSecurityGroupRuleRanges</code>.
        /// </para>
        /// </summary>
        public List<PortRange> PermittedPublicSecurityGroupRuleRanges
        {
            get { return this._permittedPublicSecurityGroupRuleRanges; }
            set { this._permittedPublicSecurityGroupRuleRanges = value; }
        }

        // Check to see if PermittedPublicSecurityGroupRuleRanges property is set
        internal bool IsSetPermittedPublicSecurityGroupRuleRanges()
        {
            return this._permittedPublicSecurityGroupRuleRanges != null && this._permittedPublicSecurityGroupRuleRanges.Count > 0; 
        }

    }
}