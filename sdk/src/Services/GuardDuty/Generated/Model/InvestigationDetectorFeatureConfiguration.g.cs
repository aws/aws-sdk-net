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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the configuration of a detector feature. Each member is
    /// optional.
    /// </summary>
    public partial class InvestigationDetectorFeatureConfiguration
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the feature. Possible values are <c>CLOUD_TRAIL</c>, <c>DNS_LOGS</c>,
        /// <c>FLOW_LOGS</c>, <c>S3_DATA_EVENTS</c>, <c>EKS_AUDIT_LOGS</c>, <c>EBS_MALWARE_PROTECTION</c>,
        /// <c>RDS_LOGIN_EVENTS</c>, <c>EKS_RUNTIME_MONITORING</c>, <c>EKS_ADDON_MANAGEMENT</c>,
        /// <c>LAMBDA_NETWORK_LOGS</c>, <c>RUNTIME_MONITORING</c>, <c>ECS_FARGATE_AGENT_MANAGEMENT</c>,
        /// and <c>EC2_AGENT_MANAGEMENT</c>.
        /// </para>
        /// </summary>
        public InvestigationDetectorFeature Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the feature. Possible values are <c>ENABLED</c> and <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public FeatureStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp at which the feature configuration was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
