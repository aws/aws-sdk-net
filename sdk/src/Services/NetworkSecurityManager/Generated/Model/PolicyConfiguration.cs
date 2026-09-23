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
 * Do not modify this file. This file is generated from the network-security-manager-2025-10-30.normal.json service model.
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
namespace Amazon.NetworkSecurityManager.Model
{
    /// <summary>
    /// Configuration settings that control a policy's behavior.
    /// </summary>
    public partial class PolicyConfiguration
    {
        private bool? _remediationEnabled;
        private bool? _resourcesCleanUp;
        private WafConfig _wafConfig;

        /// <summary>
        /// Gets and sets the property RemediationEnabled. 
        /// <para>
        /// Specifies whether AWS Network Security Manager automatically remediates noncompliant
        /// resources. Default: <c>false</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? RemediationEnabled
        {
            get { return this._remediationEnabled; }
            set { this._remediationEnabled = value; }
        }

        // Check to see if RemediationEnabled property is set
        internal bool IsSetRemediationEnabled()
        {
            return this._remediationEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourcesCleanUp. 
        /// <para>
        /// Specifies whether AWS Network Security Manager automatically removes the resources
        /// it created when they are no longer needed. Default: <c>false</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? ResourcesCleanUp
        {
            get { return this._resourcesCleanUp; }
            set { this._resourcesCleanUp = value; }
        }

        // Check to see if ResourcesCleanUp property is set
        internal bool IsSetResourcesCleanUp()
        {
            return this._resourcesCleanUp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WafConfig. 
        /// <para>
        /// AWS WAF-specific policy settings. This is populated only for AWS WAF policies.
        /// </para>
        /// </summary>
        public WafConfig WafConfig
        {
            get { return this._wafConfig; }
            set { this._wafConfig = value; }
        }

        // Check to see if WafConfig property is set
        internal bool IsSetWafConfig()
        {
            return this._wafConfig != null;
        }

    }
}