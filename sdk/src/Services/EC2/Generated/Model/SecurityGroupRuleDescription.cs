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
    /// Describes the description of a security group rule.
    /// 
    ///  
    /// <para>
    /// You can use this when you want to update the security group rule description for either
    /// an inbound or outbound rule.
    /// </para>
    /// </summary>
    public partial class SecurityGroupRuleDescription
    {
        private string _description;
        private string _securityGroupRuleId;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the security group rule.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupRuleId. 
        /// <para>
        /// The ID of the security group rule.
        /// </para>
        /// </summary>
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