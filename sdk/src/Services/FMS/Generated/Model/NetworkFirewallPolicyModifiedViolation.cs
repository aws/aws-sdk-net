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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
namespace Amazon.FMS.Model
{
    /// <summary>
    /// Violation detail for Network Firewall for a firewall policy that has a different <a>NetworkFirewallPolicyDescription</a>
    /// than is required by the Firewall Manager policy.
    /// </summary>
    public partial class NetworkFirewallPolicyModifiedViolation
    {
        private NetworkFirewallPolicyDescription _currentPolicyDescription;
        private NetworkFirewallPolicyDescription _expectedPolicyDescription;
        private string _violationTarget;

        /// <summary>
        /// Gets and sets the property CurrentPolicyDescription. 
        /// <para>
        /// The policy that's currently in use in the individual account. 
        /// </para>
        /// </summary>
        public NetworkFirewallPolicyDescription CurrentPolicyDescription
        {
            get { return this._currentPolicyDescription; }
            set { this._currentPolicyDescription = value; }
        }

        // Check to see if CurrentPolicyDescription property is set
        internal bool IsSetCurrentPolicyDescription()
        {
            return this._currentPolicyDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedPolicyDescription. 
        /// <para>
        /// The policy that should be in use in the individual account in order to be compliant.
        /// 
        /// </para>
        /// </summary>
        public NetworkFirewallPolicyDescription ExpectedPolicyDescription
        {
            get { return this._expectedPolicyDescription; }
            set { this._expectedPolicyDescription = value; }
        }

        // Check to see if ExpectedPolicyDescription property is set
        internal bool IsSetExpectedPolicyDescription()
        {
            return this._expectedPolicyDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ViolationTarget. 
        /// <para>
        /// The ID of the Network Firewall or VPC resource that's in violation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ViolationTarget
        {
            get { return this._violationTarget; }
            set { this._violationTarget = value; }
        }

        // Check to see if ViolationTarget property is set
        internal bool IsSetViolationTarget()
        {
            return this._violationTarget != null;
        }

    }
}