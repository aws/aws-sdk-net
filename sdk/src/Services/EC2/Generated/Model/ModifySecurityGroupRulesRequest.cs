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
    /// Container for the parameters to the ModifySecurityGroupRules operation.
    /// Modifies the rules of a security group.
    /// </summary>
    public partial class ModifySecurityGroupRulesRequest : AmazonEC2Request
    {
        private string _groupId;
        private List<SecurityGroupRuleUpdate> _securityGroupRules = new List<SecurityGroupRuleUpdate>();

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The ID of the security group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupRules. 
        /// <para>
        /// Information about the security group properties to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<SecurityGroupRuleUpdate> SecurityGroupRules
        {
            get { return this._securityGroupRules; }
            set { this._securityGroupRules = value; }
        }

        // Check to see if SecurityGroupRules property is set
        internal bool IsSetSecurityGroupRules()
        {
            return this._securityGroupRules != null && this._securityGroupRules.Count > 0; 
        }

    }
}