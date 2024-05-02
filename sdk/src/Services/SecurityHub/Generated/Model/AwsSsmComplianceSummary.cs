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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private string _complianceType;
        private int? _compliantCriticalCount;
        private int? _compliantHighCount;
        private int? _compliantInformationalCount;
        private int? _compliantLowCount;
        private int? _compliantMediumCount;
        private int? _compliantUnspecifiedCount;
        private string _executionType;
        private int? _nonCompliantCriticalCount;
        private int? _nonCompliantHighCount;
        private int? _nonCompliantInformationalCount;
        private int? _nonCompliantLowCount;
        private int? _nonCompliantMediumCount;
        private int? _nonCompliantUnspecifiedCount;
        private string _overallSeverity;
        private string _patchBaselineId;
        private string _patchGroup;
        private string _status;

        /// <summary>
        /// Gets and sets the property ComplianceType. 
        /// <para>
        /// The type of resource for which the compliance was determined. For <c>AwsSsmPatchCompliance</c>,
        /// <c>ComplianceType</c> is <c>Patch</c>. 
        /// </para>
        /// </summary>
        public string ComplianceType
        {
            get { return this._complianceType; }
            set { this._complianceType = value; }
        }

        // Check to see if ComplianceType property is set
        internal bool IsSetComplianceType()
        {
            return this._complianceType != null;
        }

        /// <summary>
        /// Gets and sets the property CompliantCriticalCount. 
        /// <para>
        /// For the patches that are compliant, the number that have a severity of <c>CRITICAL</c>.
        /// </para>
        /// </summary>
        public int? CompliantCriticalCount
        {
            get { return this._compliantCriticalCount; }
            set { this._compliantCriticalCount = value; }
        }

        // Check to see if CompliantCriticalCount property is set
        internal bool IsSetCompliantCriticalCount()
        {
            return this._compliantCriticalCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CompliantHighCount. 
        /// <para>
        /// For the patches that are compliant, the number that have a severity of <c>HIGH</c>.
        /// </para>
        /// </summary>
        public int? CompliantHighCount
        {
            get { return this._compliantHighCount; }
            set { this._compliantHighCount = value; }
        }

        // Check to see if CompliantHighCount property is set
        internal bool IsSetCompliantHighCount()
        {
            return this._compliantHighCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CompliantInformationalCount. 
        /// <para>
        /// For the patches that are compliant, the number that have a severity of <c>INFORMATIONAL</c>.
        /// </para>
        /// </summary>
        public int? CompliantInformationalCount
        {
            get { return this._compliantInformationalCount; }
            set { this._compliantInformationalCount = value; }
        }

        // Check to see if CompliantInformationalCount property is set
        internal bool IsSetCompliantInformationalCount()
        {
            return this._compliantInformationalCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CompliantLowCount. 
        /// <para>
        /// For the patches that are compliant, the number that have a severity of <c>LOW</c>.
        /// </para>
        /// </summary>
        public int? CompliantLowCount
        {
            get { return this._compliantLowCount; }
            set { this._compliantLowCount = value; }
        }

        // Check to see if CompliantLowCount property is set
        internal bool IsSetCompliantLowCount()
        {
            return this._compliantLowCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CompliantMediumCount. 
        /// <para>
        /// For the patches that are compliant, the number that have a severity of <c>MEDIUM</c>.
        /// </para>
        /// </summary>
        public int? CompliantMediumCount
        {
            get { return this._compliantMediumCount; }
            set { this._compliantMediumCount = value; }
        }

        // Check to see if CompliantMediumCount property is set
        internal bool IsSetCompliantMediumCount()
        {
            return this._compliantMediumCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CompliantUnspecifiedCount. 
        /// <para>
        /// For the patches that are compliant, the number that have a severity of <c>UNSPECIFIED</c>.
        /// </para>
        /// </summary>
        public int? CompliantUnspecifiedCount
        {
            get { return this._compliantUnspecifiedCount; }
            set { this._compliantUnspecifiedCount = value; }
        }

        // Check to see if CompliantUnspecifiedCount property is set
        internal bool IsSetCompliantUnspecifiedCount()
        {
            return this._compliantUnspecifiedCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionType. 
        /// <para>
        /// The type of execution that was used determine compliance.
        /// </para>
        /// </summary>
        public string ExecutionType
        {
            get { return this._executionType; }
            set { this._executionType = value; }
        }

        // Check to see if ExecutionType property is set
        internal bool IsSetExecutionType()
        {
            return this._executionType != null;
        }

        /// <summary>
        /// Gets and sets the property NonCompliantCriticalCount. 
        /// <para>
        /// For the patch items that are noncompliant, the number of items that have a severity
        /// of <c>CRITICAL</c>.
        /// </para>
        /// </summary>
        public int? NonCompliantCriticalCount
        {
            get { return this._nonCompliantCriticalCount; }
            set { this._nonCompliantCriticalCount = value; }
        }

        // Check to see if NonCompliantCriticalCount property is set
        internal bool IsSetNonCompliantCriticalCount()
        {
            return this._nonCompliantCriticalCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NonCompliantHighCount. 
        /// <para>
        /// For the patches that are noncompliant, the number that have a severity of <c>HIGH</c>.
        /// </para>
        /// </summary>
        public int? NonCompliantHighCount
        {
            get { return this._nonCompliantHighCount; }
            set { this._nonCompliantHighCount = value; }
        }

        // Check to see if NonCompliantHighCount property is set
        internal bool IsSetNonCompliantHighCount()
        {
            return this._nonCompliantHighCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NonCompliantInformationalCount. 
        /// <para>
        /// For the patches that are noncompliant, the number that have a severity of <c>INFORMATIONAL</c>.
        /// </para>
        /// </summary>
        public int? NonCompliantInformationalCount
        {
            get { return this._nonCompliantInformationalCount; }
            set { this._nonCompliantInformationalCount = value; }
        }

        // Check to see if NonCompliantInformationalCount property is set
        internal bool IsSetNonCompliantInformationalCount()
        {
            return this._nonCompliantInformationalCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NonCompliantLowCount. 
        /// <para>
        /// For the patches that are noncompliant, the number that have a severity of <c>LOW</c>.
        /// </para>
        /// </summary>
        public int? NonCompliantLowCount
        {
            get { return this._nonCompliantLowCount; }
            set { this._nonCompliantLowCount = value; }
        }

        // Check to see if NonCompliantLowCount property is set
        internal bool IsSetNonCompliantLowCount()
        {
            return this._nonCompliantLowCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NonCompliantMediumCount. 
        /// <para>
        /// For the patches that are noncompliant, the number that have a severity of <c>MEDIUM</c>.
        /// </para>
        /// </summary>
        public int? NonCompliantMediumCount
        {
            get { return this._nonCompliantMediumCount; }
            set { this._nonCompliantMediumCount = value; }
        }

        // Check to see if NonCompliantMediumCount property is set
        internal bool IsSetNonCompliantMediumCount()
        {
            return this._nonCompliantMediumCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NonCompliantUnspecifiedCount. 
        /// <para>
        /// For the patches that are noncompliant, the number that have a severity of <c>UNSPECIFIED</c>.
        /// </para>
        /// </summary>
        public int? NonCompliantUnspecifiedCount
        {
            get { return this._nonCompliantUnspecifiedCount; }
            set { this._nonCompliantUnspecifiedCount = value; }
        }

        // Check to see if NonCompliantUnspecifiedCount property is set
        internal bool IsSetNonCompliantUnspecifiedCount()
        {
            return this._nonCompliantUnspecifiedCount.HasValue; 
        }

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
        public string OverallSeverity
        {
            get { return this._overallSeverity; }
            set { this._overallSeverity = value; }
        }

        // Check to see if OverallSeverity property is set
        internal bool IsSetOverallSeverity()
        {
            return this._overallSeverity != null;
        }

        /// <summary>
        /// Gets and sets the property PatchBaselineId. 
        /// <para>
        /// The identifier of the patch baseline. The patch baseline lists the patches that are
        /// approved for installation.
        /// </para>
        /// </summary>
        public string PatchBaselineId
        {
            get { return this._patchBaselineId; }
            set { this._patchBaselineId = value; }
        }

        // Check to see if PatchBaselineId property is set
        internal bool IsSetPatchBaselineId()
        {
            return this._patchBaselineId != null;
        }

        /// <summary>
        /// Gets and sets the property PatchGroup. 
        /// <para>
        /// The identifier of the patch group for which compliance was determined. A patch group
        /// uses tags to group EC2 instances that should have the same patch compliance.
        /// </para>
        /// </summary>
        public string PatchGroup
        {
            get { return this._patchGroup; }
            set { this._patchGroup = value; }
        }

        // Check to see if PatchGroup property is set
        internal bool IsSetPatchGroup()
        {
            return this._patchGroup != null;
        }

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
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}