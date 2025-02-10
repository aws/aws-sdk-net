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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Provides information about a pending maintenance action for a resource.
    /// </summary>
    public partial class PendingMaintenanceAction
    {
        private string _action;
        private DateTime? _autoAppliedAfterDate;
        private DateTime? _currentApplyDate;
        private string _description;
        private DateTime? _forcedApplyDate;
        private string _optInStatus;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The type of pending maintenance action that is available for the resource. 
        /// </para>
        ///  
        /// <para>
        /// For more information about maintenance actions, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_UpgradeDBInstance.Maintenance.html">Maintaining
        /// a DB instance</a>.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ca-certificate-rotation</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>db-upgrade</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>hardware-maintenance</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>os-upgrade</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>system-update</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about these actions, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_UpgradeDBInstance.Maintenance.html#maintenance-actions-aurora">Maintenance
        /// actions for Amazon Aurora</a> or <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_UpgradeDBInstance.Maintenance.html#maintenance-actions-rds">Maintenance
        /// actions for Amazon RDS</a>.
        /// </para>
        /// </summary>
        public string Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property AutoAppliedAfterDate. 
        /// <para>
        /// The date of the maintenance window when the action is applied. The maintenance action
        /// is applied to the resource during its first maintenance window after this date.
        /// </para>
        /// </summary>
        public DateTime? AutoAppliedAfterDate
        {
            get { return this._autoAppliedAfterDate; }
            set { this._autoAppliedAfterDate = value; }
        }

        // Check to see if AutoAppliedAfterDate property is set
        internal bool IsSetAutoAppliedAfterDate()
        {
            return this._autoAppliedAfterDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrentApplyDate. 
        /// <para>
        /// The effective date when the pending maintenance action is applied to the resource.
        /// This date takes into account opt-in requests received from the <c>ApplyPendingMaintenanceAction</c>
        /// API, the <c>AutoAppliedAfterDate</c>, and the <c>ForcedApplyDate</c>. This value is
        /// blank if an opt-in request has not been received and nothing has been specified as
        /// <c>AutoAppliedAfterDate</c> or <c>ForcedApplyDate</c>.
        /// </para>
        /// </summary>
        public DateTime? CurrentApplyDate
        {
            get { return this._currentApplyDate; }
            set { this._currentApplyDate = value; }
        }

        // Check to see if CurrentApplyDate property is set
        internal bool IsSetCurrentApplyDate()
        {
            return this._currentApplyDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description providing more detail about the maintenance action.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ForcedApplyDate. 
        /// <para>
        /// The date when the maintenance action is automatically applied.
        /// </para>
        ///  
        /// <para>
        /// On this date, the maintenance action is applied to the resource as soon as possible,
        /// regardless of the maintenance window for the resource. There might be a delay of one
        /// or more days from this date before the maintenance action is applied.
        /// </para>
        /// </summary>
        public DateTime? ForcedApplyDate
        {
            get { return this._forcedApplyDate; }
            set { this._forcedApplyDate = value; }
        }

        // Check to see if ForcedApplyDate property is set
        internal bool IsSetForcedApplyDate()
        {
            return this._forcedApplyDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OptInStatus. 
        /// <para>
        /// Indicates the type of opt-in request that has been received for the resource.
        /// </para>
        /// </summary>
        public string OptInStatus
        {
            get { return this._optInStatus; }
            set { this._optInStatus = value; }
        }

        // Check to see if OptInStatus property is set
        internal bool IsSetOptInStatus()
        {
            return this._optInStatus != null;
        }

    }
}