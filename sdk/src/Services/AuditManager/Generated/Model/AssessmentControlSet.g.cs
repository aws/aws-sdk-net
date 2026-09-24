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

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// Represents a set of controls in an Audit Manager assessment.
    /// </summary>
    public partial class AssessmentControlSet
    {
        /// <summary>
        /// Gets and sets the property Controls. 
        /// <para>
        ///  The list of controls that's contained with the control set. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssessmentControl> Controls { get; set; } = AWSConfigs.InitializeCollections ? new List<AssessmentControl>() : null;

        /// <summary>
        /// Checks to see if the Controls property is set.
        /// </summary>
        internal bool IsSetControls() => this.Controls != null && (this.Controls.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Delegations. 
        /// <para>
        ///  The delegations that are associated with the control set. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Delegation> Delegations { get; set; } = AWSConfigs.InitializeCollections ? new List<Delegation>() : null;

        /// <summary>
        /// Checks to see if the Delegations property is set.
        /// </summary>
        internal bool IsSetDelegations() => this.Delegations != null && (this.Delegations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description for the control set. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The identifier of the control set in the assessment. This is the control set name
        /// in a plain string format. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ManualEvidenceCount. 
        /// <para>
        ///  The total number of evidence objects that are uploaded manually to the control set.
        /// 
        /// </para>
        /// </summary>
        public int? ManualEvidenceCount { get; set; }

        /// <summary>
        /// Checks to see if the ManualEvidenceCount property is set.
        /// </summary>
        internal bool IsSetManualEvidenceCount() => this.ManualEvidenceCount.HasValue;

        /// <summary>
        /// Gets and sets the property Roles. 
        /// <para>
        ///  The roles that are associated with the control set. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public List<Role> Roles { get; set; } = AWSConfigs.InitializeCollections ? new List<Role>() : null;

        /// <summary>
        /// Checks to see if the Roles property is set.
        /// </summary>
        internal bool IsSetRoles() => this.Roles != null && (this.Roles.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current status of the control set. 
        /// </para>
        /// </summary>
        public ControlSetStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SystemEvidenceCount. 
        /// <para>
        ///  The total number of evidence objects that are retrieved automatically for the control
        /// set. 
        /// </para>
        /// </summary>
        public int? SystemEvidenceCount { get; set; }

        /// <summary>
        /// Checks to see if the SystemEvidenceCount property is set.
        /// </summary>
        internal bool IsSetSystemEvidenceCount() => this.SystemEvidenceCount.HasValue;
    }
}
