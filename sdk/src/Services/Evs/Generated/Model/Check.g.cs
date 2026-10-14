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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Evs.Model
{
    /// <summary>
    /// A check on the environment to identify environment health and validate VMware VCF
    /// licensing compliance.
    /// </summary>
    public partial class Check
    {
        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique ID for the check.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ImpairedSince. 
        /// <para>
        /// The time when environment health began to be impaired.
        /// </para>
        /// </summary>
        public DateTime? ImpairedSince { get; set; }

        /// <summary>
        /// Checks to see if the ImpairedSince property is set.
        /// </summary>
        internal bool IsSetImpairedSince() => this.ImpairedSince.HasValue;

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        ///  The check result.
        /// </para>
        /// </summary>
        public CheckResult Result { get; set; }

        /// <summary>
        /// Checks to see if the Result property is set.
        /// </summary>
        internal bool IsSetResult() => this.Result != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The check type. Amazon EVS performs the following checks:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>KEY_REUSE</c>: Verifies that the VCF license key is not used by another Amazon
        /// EVS environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KEY_COVERAGE</c>: Verifies that the VCF license key allocates sufficient vCPU
        /// cores for all deployed hosts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REACHABILITY</c>: Verifies that the Amazon EVS control plane has a persistent
        /// connection to SDDC Manager.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HOST_COUNT</c>: Verifies that the environment meets the minimum host count.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VCENTER_REACHABILITY</c>: Verifies vCenter Server reachability through the vCenter
        /// connector.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VCENTER_VM_SYNC</c>: Verifies that the vCenter connector can synchronize VM inventory
        /// from vCenter Server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VCENTER_VM_EVENT</c>: Verifies that the vCenter connector can receive VM lifecycle
        /// events from vCenter Server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OPERATIONS_MANAGER_REACHABILITY</c>: Verifies Operations Manager reachability
        /// through the Operations Manager connector.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SDDC_MANAGER_REACHABILITY</c>: Verifies SDDC Manager reachability through the
        /// SDDC Manager connector.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SDDC_MANAGER_HOST_COUNT</c>: Verifies that the host count reported by SDDC Manager
        /// meets Amazon EVS minimum requirements.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SDDC_MANAGER_KEY_COVERAGE</c>: Verifies that the VCF license key configured in
        /// SDDC Manager covers all deployed hosts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SDDC_MANAGER_KEY_REUSE</c>: Verifies that the VCF license key configured in SDDC
        /// Manager is not used by another Amazon EVS environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CONNECTOR_HEALTH</c>: Aggregate health across all connectors in the environment.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CheckType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
