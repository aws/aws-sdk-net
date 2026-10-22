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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Describes a maintenance action pending for an DMS resource, including when and how
    /// it will be applied. This data type is a response element to the <c>DescribePendingMaintenanceActions</c>
    /// operation.
    /// </summary>
    public partial class PendingMaintenanceAction
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The type of pending maintenance action that is available for the resource.
        /// </para>
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property AutoAppliedAfterDate. 
        /// <para>
        /// The date of the maintenance window when the action is to be applied. The maintenance
        /// action is applied to the resource during its first maintenance window after this date.
        /// If this date is specified, any <c>next-maintenance</c> opt-in requests are ignored.
        /// </para>
        /// </summary>
        public DateTime? AutoAppliedAfterDate { get; set; }

        /// <summary>
        /// Checks to see if the AutoAppliedAfterDate property is set.
        /// </summary>
        internal bool IsSetAutoAppliedAfterDate() => this.AutoAppliedAfterDate.HasValue;

        /// <summary>
        /// Gets and sets the property CurrentApplyDate. 
        /// <para>
        /// The effective date when the pending maintenance action will be applied to the resource.
        /// This date takes into account opt-in requests received from the <c>ApplyPendingMaintenanceAction</c>
        /// API operation, and also the <c>AutoAppliedAfterDate</c> and <c>ForcedApplyDate</c>
        /// parameter values. This value is blank if an opt-in request has not been received and
        /// nothing has been specified for <c>AutoAppliedAfterDate</c> or <c>ForcedApplyDate</c>.
        /// </para>
        /// </summary>
        public DateTime? CurrentApplyDate { get; set; }

        /// <summary>
        /// Checks to see if the CurrentApplyDate property is set.
        /// </summary>
        internal bool IsSetCurrentApplyDate() => this.CurrentApplyDate.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description providing more detail about the maintenance action.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ForcedApplyDate. 
        /// <para>
        /// The date when the maintenance action will be automatically applied. The maintenance
        /// action is applied to the resource on this date regardless of the maintenance window
        /// for the resource. If this date is specified, any <c>immediate</c> opt-in requests
        /// are ignored.
        /// </para>
        /// </summary>
        public DateTime? ForcedApplyDate { get; set; }

        /// <summary>
        /// Checks to see if the ForcedApplyDate property is set.
        /// </summary>
        internal bool IsSetForcedApplyDate() => this.ForcedApplyDate.HasValue;

        /// <summary>
        /// Gets and sets the property OptInStatus. 
        /// <para>
        /// The type of opt-in request that has been received for the resource.
        /// </para>
        /// </summary>
        public string OptInStatus { get; set; }

        /// <summary>
        /// Checks to see if the OptInStatus property is set.
        /// </summary>
        internal bool IsSetOptInStatus() => this.OptInStatus != null;
    }
}
