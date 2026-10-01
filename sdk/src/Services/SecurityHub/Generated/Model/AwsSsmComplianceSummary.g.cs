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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides the details about the compliance status for a patch.
    /// </summary>
    public partial class AwsSsmComplianceSummary
    {
        /// <summary>
        /// Gets and sets the property ComplianceType. 
        /// <para>
        /// The type of resource for which the compliance was determined. For <c>AwsSsmPatchCompliance</c>,
        /// <c>ComplianceType</c> is <c>Patch</c>. 
        /// </para>
        /// </summary>
        public string ComplianceType { get; set; }

        /// <summary>
        /// Checks to see if the ComplianceType property is set.
        /// </summary>
        internal bool IsSetComplianceType() => this.ComplianceType != null;

        /// <summary>
        /// Gets and sets the property CompliantCriticalCount. 
        /// <para>
        /// For the patches that are compliant, the number that have a severity of <c>CRITICAL</c>.
        /// </para>
        /// </summary>
        public int? CompliantCriticalCount { get; set; }

        /// <summary>
        /// Checks to see if the CompliantCriticalCount property is set.
        /// </summary>
        internal bool IsSetCompliantCriticalCount() => this.CompliantCriticalCount.HasValue;

        /// <summary>
        /// Gets and sets the property CompliantHighCount. 
        /// <para>
        /// For the patches that are compliant, the number that have a severity of <c>HIGH</c>.
        /// </para>
        /// </summary>
        public int? CompliantHighCount { get; set; }

        /// <summary>
        /// Checks to see if the CompliantHighCount property is set.
        /// </summary>
        internal bool IsSetCompliantHighCount() => this.CompliantHighCount.HasValue;

        /// <summary>
        /// Gets and sets the property CompliantInformationalCount. 
        /// <para>
        /// For the patches that are compliant, the number that have a severity of <c>INFORMATIONAL</c>.
        /// </para>
        /// </summary>
        public int? CompliantInformationalCount { get; set; }

        /// <summary>
        /// Checks to see if the CompliantInformationalCount property is set.
        /// </summary>
        internal bool IsSetCompliantInformationalCount() => this.CompliantInformationalCount.HasValue;

        /// <summary>
        /// Gets and sets the property CompliantLowCount. 
        /// <para>
        /// For the patches that are compliant, the number that have a severity of <c>LOW</c>.
        /// </para>
        /// </summary>
        public int? CompliantLowCount { get; set; }

        /// <summary>
        /// Checks to see if the CompliantLowCount property is set.
        /// </summary>
        internal bool IsSetCompliantLowCount() => this.CompliantLowCount.HasValue;

        /// <summary>
        /// Gets and sets the property CompliantMediumCount. 
        /// <para>
        /// For the patches that are compliant, the number that have a severity of <c>MEDIUM</c>.
        /// </para>
        /// </summary>
        public int? CompliantMediumCount { get; set; }

        /// <summary>
        /// Checks to see if the CompliantMediumCount property is set.
        /// </summary>
        internal bool IsSetCompliantMediumCount() => this.CompliantMediumCount.HasValue;

        /// <summary>
        /// Gets and sets the property CompliantUnspecifiedCount. 
        /// <para>
        /// For the patches that are compliant, the number that have a severity of <c>UNSPECIFIED</c>.
        /// </para>
        /// </summary>
        public int? CompliantUnspecifiedCount { get; set; }

        /// <summary>
        /// Checks to see if the CompliantUnspecifiedCount property is set.
        /// </summary>
        internal bool IsSetCompliantUnspecifiedCount() => this.CompliantUnspecifiedCount.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionType. 
        /// <para>
        /// The type of execution that was used determine compliance.
        /// </para>
        /// </summary>
        public string ExecutionType { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionType property is set.
        /// </summary>
        internal bool IsSetExecutionType() => this.ExecutionType != null;

        /// <summary>
        /// Gets and sets the property NonCompliantCriticalCount. 
        /// <para>
        /// For the patch items that are noncompliant, the number of items that have a severity
        /// of <c>CRITICAL</c>.
        /// </para>
        /// </summary>
        public int? NonCompliantCriticalCount { get; set; }

        /// <summary>
        /// Checks to see if the NonCompliantCriticalCount property is set.
        /// </summary>
        internal bool IsSetNonCompliantCriticalCount() => this.NonCompliantCriticalCount.HasValue;

        /// <summary>
        /// Gets and sets the property NonCompliantHighCount. 
        /// <para>
        /// For the patches that are noncompliant, the number that have a severity of <c>HIGH</c>.
        /// </para>
        /// </summary>
        public int? NonCompliantHighCount { get; set; }

        /// <summary>
        /// Checks to see if the NonCompliantHighCount property is set.
        /// </summary>
        internal bool IsSetNonCompliantHighCount() => this.NonCompliantHighCount.HasValue;

        /// <summary>
        /// Gets and sets the property NonCompliantInformationalCount. 
        /// <para>
        /// For the patches that are noncompliant, the number that have a severity of <c>INFORMATIONAL</c>.
        /// </para>
        /// </summary>
        public int? NonCompliantInformationalCount { get; set; }

        /// <summary>
        /// Checks to see if the NonCompliantInformationalCount property is set.
        /// </summary>
        internal bool IsSetNonCompliantInformationalCount() => this.NonCompliantInformationalCount.HasValue;

        /// <summary>
        /// Gets and sets the property NonCompliantLowCount. 
        /// <para>
        /// For the patches that are noncompliant, the number that have a severity of <c>LOW</c>.
        /// </para>
        /// </summary>
        public int? NonCompliantLowCount { get; set; }

        /// <summary>
        /// Checks to see if the NonCompliantLowCount property is set.
        /// </summary>
        internal bool IsSetNonCompliantLowCount() => this.NonCompliantLowCount.HasValue;

        /// <summary>
        /// Gets and sets the property NonCompliantMediumCount. 
        /// <para>
        /// For the patches that are noncompliant, the number that have a severity of <c>MEDIUM</c>.
        /// </para>
        /// </summary>
        public int? NonCompliantMediumCount { get; set; }

        /// <summary>
        /// Checks to see if the NonCompliantMediumCount property is set.
        /// </summary>
        internal bool IsSetNonCompliantMediumCount() => this.NonCompliantMediumCount.HasValue;

        /// <summary>
        /// Gets and sets the property NonCompliantUnspecifiedCount. 
        /// <para>
        /// For the patches that are noncompliant, the number that have a severity of <c>UNSPECIFIED</c>.
        /// </para>
        /// </summary>
        public int? NonCompliantUnspecifiedCount { get; set; }

        /// <summary>
        /// Checks to see if the NonCompliantUnspecifiedCount property is set.
        /// </summary>
        internal bool IsSetNonCompliantUnspecifiedCount() => this.NonCompliantUnspecifiedCount.HasValue;

        /// <summary>
        /// Gets and sets the property OverallSeverity. 
        /// <para>
        /// The highest severity for the patches. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CRITICAL</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HIGH</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MEDIUM</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LOW</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INFORMATIONAL</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNSPECIFIED</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string OverallSeverity { get; set; }

        /// <summary>
        /// Checks to see if the OverallSeverity property is set.
        /// </summary>
        internal bool IsSetOverallSeverity() => this.OverallSeverity != null;

        /// <summary>
        /// Gets and sets the property PatchBaselineId. 
        /// <para>
        /// The identifier of the patch baseline. The patch baseline lists the patches that are
        /// approved for installation.
        /// </para>
        /// </summary>
        public string PatchBaselineId { get; set; }

        /// <summary>
        /// Checks to see if the PatchBaselineId property is set.
        /// </summary>
        internal bool IsSetPatchBaselineId() => this.PatchBaselineId != null;

        /// <summary>
        /// Gets and sets the property PatchGroup. 
        /// <para>
        /// The identifier of the patch group for which compliance was determined. A patch group
        /// uses tags to group EC2 instances that should have the same patch compliance.
        /// </para>
        /// </summary>
        public string PatchGroup { get; set; }

        /// <summary>
        /// Checks to see if the PatchGroup property is set.
        /// </summary>
        internal bool IsSetPatchGroup() => this.PatchGroup != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current patch compliance status. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>COMPLIANT</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NON_COMPLIANT</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNSPECIFIED_DATA</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
