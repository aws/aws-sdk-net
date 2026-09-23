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
    /// AWS WAF-specific policy configuration settings.
    /// </summary>
    public partial class WafConfig
    {
        private WAFConflictResolutionOptions _conflictResolution;
        private ExistingCustomerWebACLResolution _existingCustomerWebACLResolution;

        /// <summary>
        /// Gets and sets the property ConflictResolution. 
        /// <para>
        /// The conflict-resolution strategy for AWS WAF policies. Required for AWS WAF policies.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WAFConflictResolutionOptions ConflictResolution
        {
            get { return this._conflictResolution; }
            set { this._conflictResolution = value; }
        }

        // Check to see if ConflictResolution property is set
        internal bool IsSetConflictResolution()
        {
            return this._conflictResolution != null;
        }

        /// <summary>
        /// Gets and sets the property ExistingCustomerWebACLResolution. 
        /// <para>
        /// Determines how AWS Network Security Manager handles remediation when a resource already
        /// has a customer-created web ACL. Required for AWS WAF policies.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExistingCustomerWebACLResolution ExistingCustomerWebACLResolution
        {
            get { return this._existingCustomerWebACLResolution; }
            set { this._existingCustomerWebACLResolution = value; }
        }

        // Check to see if ExistingCustomerWebACLResolution property is set
        internal bool IsSetExistingCustomerWebACLResolution()
        {
            return this._existingCustomerWebACLResolution != null;
        }

    }
}