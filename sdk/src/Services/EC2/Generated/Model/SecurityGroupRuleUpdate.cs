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
    /// Describes an update to a security group rule.
    /// </summary>
    public partial class SecurityGroupRuleUpdate
    {
        private SecurityGroupRuleRequest _securityGroupRule;
        private string _securityGroupRuleId;

        /// <summary>
        /// Gets and sets the property SecurityGroupRule. 
        /// <para>
        /// Information about the security group rule.
        /// </para>
        /// </summary>
        public SecurityGroupRuleRequest SecurityGroupRule
        {
            get { return this._securityGroupRule; }
            set { this._securityGroupRule = value; }
        }

        // Check to see if SecurityGroupRule property is set
        internal bool IsSetSecurityGroupRule()
        {
            return this._securityGroupRule != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupRuleId. 
        /// <para>
        /// The ID of the security group rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SecurityGroupRuleId
        {
            get { return this._securityGroupRuleId; }
            set { this._securityGroupRuleId = value; }
        }

        // Check to see if SecurityGroupRuleId property is set
        internal bool IsSetSecurityGroupRuleId()
        {
            return this._securityGroupRuleId != null;
        }

    }
}