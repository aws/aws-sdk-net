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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePatchBaseline operation.
    /// Modifies an existing patch baseline. Fields not specified in the request are left
    /// unchanged.
    /// 
    ///  <note> 
    /// <para>
    /// For information about valid key and value pairs in <code>PatchFilters</code> for each
    /// supported operating system type, see <a href="http://docs.aws.amazon.com/systems-manager/latest/APIReference/API_PatchFilter.html">PatchFilter</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdatePatchBaselineRequest : AmazonSimpleSystemsManagementRequest
    {
        private PatchRuleGroup _approvalRules;
        private List<string> _approvedPatches = new List<string>();
        private PatchComplianceLevel _approvedPatchesComplianceLevel;
        private bool? _approvedPatchesEnableNonSecurity;
        private string _baselineId;
        private string _description;
        private PatchFilterGroup _globalFilters;
        private string _name;
        private List<string> _rejectedPatches = new List<string>();
        private PatchAction _rejectedPatchesAction;
        private bool? _replace;
        private List<PatchSource> _sources = new List<PatchSource>();

        /// <summary>
        /// Gets and sets the property ApprovalRules. 
        /// <para>
        /// A set of rules used to include patches in the baseline.
        /// </para>
        /// </summary>
        public PatchRuleGroup ApprovalRules
        {
            get { return this._approvalRules; }
            set { this._approvalRules = value; }
        }

        // Check to see if ApprovalRules property is set
        internal bool IsSetApprovalRules()
        {
            return this._approvalRules != null;
        }

        /// <summary>
        /// Gets and sets the property ApprovedPatches. 
        /// <para>
        /// A list of explicitly approved patches for the baseline.
        /// </para>
        ///  
        /// <para>
        /// For information about accepted formats for lists of approved patches and rejected
        /// patches, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/patch-manager-approved-rejected-package-name-formats.html">About
        /// package name formats for approved and rejected patch lists</a> in the <i>AWS Systems
        /// Manager User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> ApprovedPatches
        {
            get { return this._approvedPatches; }
            set { this._approvedPatches = value; }
        }

        // Check to see if ApprovedPatches property is set
        internal bool IsSetApprovedPatches()
        {
            return this._approvedPatches != null && this._approvedPatches.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ApprovedPatchesComplianceLevel. 
        /// <para>
        /// Assigns a new compliance severity level to an existing patch baseline.
        /// </para>
        /// </summary>
        public PatchComplianceLevel ApprovedPatchesComplianceLevel
        {
            get { return this._approvedPatchesComplianceLevel; }
            set { this._approvedPatchesComplianceLevel = value; }
        }

        // Check to see if ApprovedPatchesComplianceLevel property is set
        internal bool IsSetApprovedPatchesComplianceLevel()
        {
            return this._approvedPatchesComplianceLevel != null;
        }

        /// <summary>
        /// Gets and sets the property ApprovedPatchesEnableNonSecurity. 
        /// <para>
        /// Indicates whether the list of approved patches includes non-security updates that
        /// should be applied to the instances. The default value is 'false'. Applies to Linux
        /// instances only.
        /// </para>
        /// </summary>
        public bool ApprovedPatchesEnableNonSecurity
        {
            get { return this._approvedPatchesEnableNonSecurity.GetValueOrDefault(); }
            set { this._approvedPatchesEnableNonSecurity = value; }
        }

        // Check to see if ApprovedPatchesEnableNonSecurity property is set
        internal bool IsSetApprovedPatchesEnableNonSecurity()
        {
            return this._approvedPatchesEnableNonSecurity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BaselineId. 
        /// <para>
        /// The ID of the patch baseline to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=128)]
        public string BaselineId
        {
            get { return this._baselineId; }
            set { this._baselineId = value; }
        }

        // Check to see if BaselineId property is set
        internal bool IsSetBaselineId()
        {
            return this._baselineId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the patch baseline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property GlobalFilters. 
        /// <para>
        /// A set of global filters used to include patches in the baseline.
        /// </para>
        /// </summary>
        public PatchFilterGroup GlobalFilters
        {
            get { return this._globalFilters; }
            set { this._globalFilters = value; }
        }

        // Check to see if GlobalFilters property is set
        internal bool IsSetGlobalFilters()
        {
            return this._globalFilters != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the patch baseline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RejectedPatches. 
        /// <para>
        /// A list of explicitly rejected patches for the baseline.
        /// </para>
        ///  
        /// <para>
        /// For information about accepted formats for lists of approved patches and rejected
        /// patches, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/patch-manager-approved-rejected-package-name-formats.html">About
        /// package name formats for approved and rejected patch lists</a> in the <i>AWS Systems
        /// Manager User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> RejectedPatches
        {
            get { return this._rejectedPatches; }
            set { this._rejectedPatches = value; }
        }

        // Check to see if RejectedPatches property is set
        internal bool IsSetRejectedPatches()
        {
            return this._rejectedPatches != null && this._rejectedPatches.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RejectedPatchesAction. 
        /// <para>
        /// The action for Patch Manager to take on patches included in the RejectedPackages list.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>ALLOW_AS_DEPENDENCY</b>: A package in the Rejected patches list is installed only
        /// if it is a dependency of another package. It is considered compliant with the patch
        /// baseline, and its status is reported as <i>InstalledOther</i>. This is the default
        /// action if no option is specified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>BLOCK</b>: Packages in the RejectedPatches list, and packages that include them
        /// as dependencies, are not installed under any circumstances. If a package was installed
        /// before it was added to the Rejected patches list, it is considered non-compliant with
        /// the patch baseline, and its status is reported as <i>InstalledRejected</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PatchAction RejectedPatchesAction
        {
            get { return this._rejectedPatchesAction; }
            set { this._rejectedPatchesAction = value; }
        }

        // Check to see if RejectedPatchesAction property is set
        internal bool IsSetRejectedPatchesAction()
        {
            return this._rejectedPatchesAction != null;
        }

        /// <summary>
        /// Gets and sets the property Replace. 
        /// <para>
        /// If True, then all fields that are required by the CreatePatchBaseline action are also
        /// required for this API request. Optional fields that are not specified are set to null.
        /// </para>
        /// </summary>
        public bool Replace
        {
            get { return this._replace.GetValueOrDefault(); }
            set { this._replace = value; }
        }

        // Check to see if Replace property is set
        internal bool IsSetReplace()
        {
            return this._replace.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// Information about the patches to use to update the instances, including target operating
        /// systems and source repositories. Applies to Linux instances only.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<PatchSource> Sources
        {
            get { return this._sources; }
            set { this._sources = value; }
        }

        // Check to see if Sources property is set
        internal bool IsSetSources()
        {
            return this._sources != null && this._sources.Count > 0; 
        }

    }
}