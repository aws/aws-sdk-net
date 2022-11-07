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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Discovery configuration associated to the workload.
    /// </summary>
    public partial class WorkloadDiscoveryConfig
    {
        private TrustedAdvisorIntegrationStatus _trustedAdvisorIntegrationStatus;

        /// <summary>
        /// Gets and sets the property TrustedAdvisorIntegrationStatus. 
        /// <para>
        /// Discovery integration status in respect to Trusted Advisor for the workload.
        /// </para>
        /// </summary>
        public TrustedAdvisorIntegrationStatus TrustedAdvisorIntegrationStatus
        {
            get { return this._trustedAdvisorIntegrationStatus; }
            set { this._trustedAdvisorIntegrationStatus = value; }
        }

        // Check to see if TrustedAdvisorIntegrationStatus property is set
        internal bool IsSetTrustedAdvisorIntegrationStatus()
        {
            return this._trustedAdvisorIntegrationStatus != null;
        }

    }
}