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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Discovery configuration associated to the workload.
    /// </summary>
    public partial class WorkloadDiscoveryConfig
    {
        private TrustedAdvisorIntegrationStatus _trustedAdvisorIntegrationStatus;
        private List<string> _workloadResourceDefinition = AWSConfigs.InitializeCollections ? new List<string>() : null;

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

        /// <summary>
        /// Gets and sets the property WorkloadResourceDefinition. 
        /// <para>
        /// The mode to use for identifying resources associated with the workload.
        /// </para>
        ///  
        /// <para>
        /// You can specify <c>WORKLOAD_METADATA</c>, <c>APP_REGISTRY</c>, or both.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> WorkloadResourceDefinition
        {
            get { return this._workloadResourceDefinition; }
            set { this._workloadResourceDefinition = value; }
        }

        // Check to see if WorkloadResourceDefinition property is set
        internal bool IsSetWorkloadResourceDefinition()
        {
            return this._workloadResourceDefinition != null && (this._workloadResourceDefinition.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}