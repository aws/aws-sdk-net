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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// Represents a set of controls in an Audit Manager assessment.
    /// </summary>
    public partial class AssessmentControlSet
    {
        private List<AssessmentControl> _controls = new List<AssessmentControl>();
        private List<Delegation> _delegations = new List<Delegation>();
        private string _description;
        private string _id;
        private int? _manualEvidenceCount;
        private List<Role> _roles = new List<Role>();
        private ControlSetStatus _status;
        private int? _systemEvidenceCount;

        /// <summary>
        /// Gets and sets the property Controls. 
        /// <para>
        ///  The list of controls that's contained with the control set. 
        /// </para>
        /// </summary>
        public List<AssessmentControl> Controls
        {
            get { return this._controls; }
            set { this._controls = value; }
        }

        // Check to see if Controls property is set
        internal bool IsSetControls()
        {
            return this._controls != null && this._controls.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Delegations. 
        /// <para>
        ///  The delegations that are associated with the control set. 
        /// </para>
        /// </summary>
        public List<Delegation> Delegations
        {
            get { return this._delegations; }
            set { this._delegations = value; }
        }

        // Check to see if Delegations property is set
        internal bool IsSetDelegations()
        {
            return this._delegations != null && this._delegations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description for the control set. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property Id. 
        /// <para>
        ///  The identifier of the control set in the assessment. This is the control set name
        /// in a plain string format. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property ManualEvidenceCount. 
        /// <para>
        ///  The total number of evidence objects that are uploaded manually to the control set.
        /// 
        /// </para>
        /// </summary>
        public int ManualEvidenceCount
        {
            get { return this._manualEvidenceCount.GetValueOrDefault(); }
            set { this._manualEvidenceCount = value; }
        }

        // Check to see if ManualEvidenceCount property is set
        internal bool IsSetManualEvidenceCount()
        {
            return this._manualEvidenceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Roles. 
        /// <para>
        ///  The roles that are associated with the control set. 
        /// </para>
        /// </summary>
        public List<Role> Roles
        {
            get { return this._roles; }
            set { this._roles = value; }
        }

        // Check to see if Roles property is set
        internal bool IsSetRoles()
        {
            return this._roles != null && this._roles.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current status of the control set. 
        /// </para>
        /// </summary>
        public ControlSetStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SystemEvidenceCount. 
        /// <para>
        ///  The total number of evidence objects that are retrieved automatically for the control
        /// set. 
        /// </para>
        /// </summary>
        public int SystemEvidenceCount
        {
            get { return this._systemEvidenceCount.GetValueOrDefault(); }
            set { this._systemEvidenceCount = value; }
        }

        // Check to see if SystemEvidenceCount property is set
        internal bool IsSetSystemEvidenceCount()
        {
            return this._systemEvidenceCount.HasValue; 
        }

    }
}