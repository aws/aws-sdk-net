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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Compliance summary information for a specific resource.
    /// </summary>
    public partial class ResourceComplianceSummaryItem
    {
        /// <summary>
        /// Gets and sets the property ComplianceType. 
        /// <para>
        /// The compliance type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ComplianceType { get; set; }

        /// <summary>
        /// Checks to see if the ComplianceType property is set.
        /// </summary>
        internal bool IsSetComplianceType() => this.ComplianceType != null;

        /// <summary>
        /// Gets and sets the property CompliantSummary. 
        /// <para>
        /// A list of items that are compliant for the resource.
        /// </para>
        /// </summary>
        public CompliantSummary CompliantSummary { get; set; }

        /// <summary>
        /// Checks to see if the CompliantSummary property is set.
        /// </summary>
        internal bool IsSetCompliantSummary() => this.CompliantSummary != null;

        /// <summary>
        /// Gets and sets the property ExecutionSummary. 
        /// <para>
        /// Information about the execution.
        /// </para>
        /// </summary>
        public ComplianceExecutionSummary ExecutionSummary { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionSummary property is set.
        /// </summary>
        internal bool IsSetExecutionSummary() => this.ExecutionSummary != null;

        /// <summary>
        /// Gets and sets the property NonCompliantSummary. 
        /// <para>
        /// A list of items that aren't compliant for the resource.
        /// </para>
        /// </summary>
        public NonCompliantSummary NonCompliantSummary { get; set; }

        /// <summary>
        /// Checks to see if the NonCompliantSummary property is set.
        /// </summary>
        internal bool IsSetNonCompliantSummary() => this.NonCompliantSummary != null;

        /// <summary>
        /// Gets and sets the property OverallSeverity. 
        /// <para>
        /// The highest severity item found for the resource. The resource is compliant for this
        /// item.
        /// </para>
        /// </summary>
        public ComplianceSeverity OverallSeverity { get; set; }

        /// <summary>
        /// Checks to see if the OverallSeverity property is set.
        /// </summary>
        internal bool IsSetOverallSeverity() => this.OverallSeverity != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The resource ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The compliance status for the resource.
        /// </para>
        /// </summary>
        public ComplianceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
