/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Defines an approval rule for a patch baseline.
    /// </summary>
    public partial class PatchRule
    {
        private int? _approveAfterDays;
        private PatchComplianceLevel _complianceLevel;
        private bool? _enableNonSecurity;
        private PatchFilterGroup _patchFilterGroup;

        /// <summary>
        /// Gets and sets the property ApproveAfterDays. 
        /// <para>
        /// The number of days after the release date of each patch matched by the rule the patch
        /// is marked as approved in the patch baseline.
        /// </para>
        /// </summary>
        public int ApproveAfterDays
        {
            get { return this._approveAfterDays.GetValueOrDefault(); }
            set { this._approveAfterDays = value; }
        }

        // Check to see if ApproveAfterDays property is set
        internal bool IsSetApproveAfterDays()
        {
            return this._approveAfterDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ComplianceLevel. 
        /// <para>
        /// A compliance severity level for all approved patches in a patch baseline. Valid compliance
        /// severity levels include the following: Unspecified, Critical, High, Medium, Low, and
        /// Informational.
        /// </para>
        /// </summary>
        public PatchComplianceLevel ComplianceLevel
        {
            get { return this._complianceLevel; }
            set { this._complianceLevel = value; }
        }

        // Check to see if ComplianceLevel property is set
        internal bool IsSetComplianceLevel()
        {
            return this._complianceLevel != null;
        }

        /// <summary>
        /// Gets and sets the property EnableNonSecurity. 
        /// <para>
        /// For instances identified by the approval rule filters, enables a patch baseline to
        /// apply non-security updates available in the specified repository. The default value
        /// is 'false'. Applies to Linux instances only.
        /// </para>
        /// </summary>
        public bool EnableNonSecurity
        {
            get { return this._enableNonSecurity.GetValueOrDefault(); }
            set { this._enableNonSecurity = value; }
        }

        // Check to see if EnableNonSecurity property is set
        internal bool IsSetEnableNonSecurity()
        {
            return this._enableNonSecurity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PatchFilterGroup. 
        /// <para>
        /// The patch filter group that defines the criteria for the rule.
        /// </para>
        /// </summary>
        public PatchFilterGroup PatchFilterGroup
        {
            get { return this._patchFilterGroup; }
            set { this._patchFilterGroup = value; }
        }

        // Check to see if PatchFilterGroup property is set
        internal bool IsSetPatchFilterGroup()
        {
            return this._patchFilterGroup != null;
        }

    }
}