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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
    /// Defines an approval rule for a patch baseline.
    /// </summary>
    public partial class PatchRule
    {
        private int? _approveAfterDays;
        private string _approveUntilDate;
        private PatchComplianceLevel _complianceLevel;
        private bool? _enableNonSecurity;
        private PatchFilterGroup _patchFilterGroup;

        /// <summary>
        /// Gets and sets the property ApproveAfterDays. 
        /// <para>
        /// The number of days after the release date of each patch matched by the rule that the
        /// patch is marked as approved in the patch baseline. For example, a value of <c>7</c>
        /// means that patches are approved seven days after they are released.
        /// </para>
        ///  
        /// <para>
        /// This parameter is marked as <c>Required: No</c>, but your request must include a value
        /// for either <c>ApproveAfterDays</c> or <c>ApproveUntilDate</c>.
        /// </para>
        ///  
        /// <para>
        /// Not supported for Debian Server or Ubuntu Server.
        /// </para>
        ///  <important> 
        /// <para>
        /// Use caution when setting this value for Windows Server patch baselines. Because patch
        /// updates that are replaced by later updates are removed, setting too broad a value
        /// for this parameter can result in crucial patches not being installed. For more information,
        /// see the <b>Windows Server</b> tab in the topic <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/patch-manager-selecting-patches.html">How
        /// security patches are selected</a> in the <i>Amazon Web Services Systems Manager User
        /// Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=0, Max=360)]
        public int? ApproveAfterDays
        {
            get { return this._approveAfterDays; }
            set { this._approveAfterDays = value; }
        }

        // Check to see if ApproveAfterDays property is set
        internal bool IsSetApproveAfterDays()
        {
            return this._approveAfterDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ApproveUntilDate. 
        /// <para>
        /// The cutoff date for auto approval of released patches. Any patches released on or
        /// before this date are installed automatically.
        /// </para>
        ///  
        /// <para>
        /// Enter dates in the format <c>YYYY-MM-DD</c>. For example, <c>2024-12-31</c>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is marked as <c>Required: No</c>, but your request must include a value
        /// for either <c>ApproveUntilDate</c> or <c>ApproveAfterDays</c>.
        /// </para>
        ///  
        /// <para>
        /// Not supported for Debian Server or Ubuntu Server.
        /// </para>
        ///  <important> 
        /// <para>
        /// Use caution when setting this value for Windows Server patch baselines. Because patch
        /// updates that are replaced by later updates are removed, setting too broad a value
        /// for this parameter can result in crucial patches not being installed. For more information,
        /// see the <b>Windows Server</b> tab in the topic <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/patch-manager-selecting-patches.html">How
        /// security patches are selected</a> in the <i>Amazon Web Services Systems Manager User
        /// Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public string ApproveUntilDate
        {
            get { return this._approveUntilDate; }
            set { this._approveUntilDate = value; }
        }

        // Check to see if ApproveUntilDate property is set
        internal bool IsSetApproveUntilDate()
        {
            return this._approveUntilDate != null;
        }

        /// <summary>
        /// Gets and sets the property ComplianceLevel. 
        /// <para>
        /// A compliance severity level for all approved patches in a patch baseline.
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
        /// For managed nodes identified by the approval rule filters, enables a patch baseline
        /// to apply non-security updates available in the specified repository. The default value
        /// is <c>false</c>. Applies to Linux managed nodes only.
        /// </para>
        /// </summary>
        public bool? EnableNonSecurity
        {
            get { return this._enableNonSecurity; }
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
        [AWSProperty(Required=true)]
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