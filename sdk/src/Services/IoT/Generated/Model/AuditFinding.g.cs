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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// The findings (results) of the audit.
    /// </summary>
    public partial class AuditFinding
    {
        /// <summary>
        /// Gets and sets the property CheckName. 
        /// <para>
        /// The audit check that generated this result.
        /// </para>
        /// </summary>
        public string CheckName { get; set; }

        /// <summary>
        /// Checks to see if the CheckName property is set.
        /// </summary>
        internal bool IsSetCheckName() => this.CheckName != null;

        /// <summary>
        /// Gets and sets the property FindingId. 
        /// <para>
        /// A unique identifier for this set of audit findings. This identifier is used to apply
        /// mitigation tasks to one or more sets of findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string FindingId { get; set; }

        /// <summary>
        /// Checks to see if the FindingId property is set.
        /// </summary>
        internal bool IsSetFindingId() => this.FindingId != null;

        /// <summary>
        /// Gets and sets the property FindingTime. 
        /// <para>
        /// The time the result (finding) was discovered.
        /// </para>
        /// </summary>
        public DateTime? FindingTime { get; set; }

        /// <summary>
        /// Checks to see if the FindingTime property is set.
        /// </summary>
        internal bool IsSetFindingTime() => this.FindingTime.HasValue;

        /// <summary>
        /// Gets and sets the property IsSuppressed. 
        /// <para>
        ///  Indicates whether the audit finding was suppressed or not during reporting. 
        /// </para>
        /// </summary>
        public bool? IsSuppressed { get; set; }

        /// <summary>
        /// Checks to see if the IsSuppressed property is set.
        /// </summary>
        internal bool IsSetIsSuppressed() => this.IsSuppressed.HasValue;

        /// <summary>
        /// Gets and sets the property NonCompliantResource. 
        /// <para>
        /// The resource that was found to be noncompliant with the audit check.
        /// </para>
        /// </summary>
        public NonCompliantResource NonCompliantResource { get; set; }

        /// <summary>
        /// Checks to see if the NonCompliantResource property is set.
        /// </summary>
        internal bool IsSetNonCompliantResource() => this.NonCompliantResource != null;

        /// <summary>
        /// Gets and sets the property ReasonForNonCompliance. 
        /// <para>
        /// The reason the resource was noncompliant.
        /// </para>
        /// </summary>
        public string ReasonForNonCompliance { get; set; }

        /// <summary>
        /// Checks to see if the ReasonForNonCompliance property is set.
        /// </summary>
        internal bool IsSetReasonForNonCompliance() => this.ReasonForNonCompliance != null;

        /// <summary>
        /// Gets and sets the property ReasonForNonComplianceCode. 
        /// <para>
        /// A code that indicates the reason that the resource was noncompliant.
        /// </para>
        /// </summary>
        public string ReasonForNonComplianceCode { get; set; }

        /// <summary>
        /// Checks to see if the ReasonForNonComplianceCode property is set.
        /// </summary>
        internal bool IsSetReasonForNonComplianceCode() => this.ReasonForNonComplianceCode != null;

        /// <summary>
        /// Gets and sets the property RelatedResources. 
        /// <para>
        /// The list of related resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RelatedResource> RelatedResources { get; set; } = AWSConfigs.InitializeCollections ? new List<RelatedResource>() : null;

        /// <summary>
        /// Checks to see if the RelatedResources property is set.
        /// </summary>
        internal bool IsSetRelatedResources() => this.RelatedResources != null && (this.RelatedResources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the result (finding).
        /// </para>
        /// </summary>
        public AuditFindingSeverity Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The ID of the audit that generated this result (finding).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 40)]
        public string TaskId { get; set; }

        /// <summary>
        /// Checks to see if the TaskId property is set.
        /// </summary>
        internal bool IsSetTaskId() => this.TaskId != null;

        /// <summary>
        /// Gets and sets the property TaskStartTime. 
        /// <para>
        /// The time the audit started.
        /// </para>
        /// </summary>
        public DateTime? TaskStartTime { get; set; }

        /// <summary>
        /// Checks to see if the TaskStartTime property is set.
        /// </summary>
        internal bool IsSetTaskStartTime() => this.TaskStartTime.HasValue;
    }
}
