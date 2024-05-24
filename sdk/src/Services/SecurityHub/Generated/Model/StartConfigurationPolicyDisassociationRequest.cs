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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the StartConfigurationPolicyDisassociation operation.
    /// Disassociates a target account, organizational unit, or the root from a specified
    /// configuration. When you disassociate a configuration from its target, the target inherits
    /// the configuration of the closest parent. If there’s no configuration to inherit, the
    /// target retains its settings but becomes a self-managed account. A target can be disassociated
    /// from a configuration policy or self-managed behavior. Only the Security Hub delegated
    /// administrator can invoke this operation from the home Region.
    /// </summary>
    public partial class StartConfigurationPolicyDisassociationRequest : AmazonSecurityHubRequest
    {
        private string _configurationPolicyIdentifier;
        private Target _target;

        /// <summary>
        /// Gets and sets the property ConfigurationPolicyIdentifier. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of a configuration policy, the universally unique
        /// identifier (UUID) of a configuration policy, or a value of <c>SELF_MANAGED_SECURITY_HUB</c>
        /// for a self-managed configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConfigurationPolicyIdentifier
        {
            get { return this._configurationPolicyIdentifier; }
            set { this._configurationPolicyIdentifier = value; }
        }

        // Check to see if ConfigurationPolicyIdentifier property is set
        internal bool IsSetConfigurationPolicyIdentifier()
        {
            return this._configurationPolicyIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        ///  The identifier of the target account, organizational unit, or the root to disassociate
        /// from the specified configuration. 
        /// </para>
        /// </summary>
        public Target Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

    }
}