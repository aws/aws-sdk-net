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

namespace Amazon.DocDBElastic.Model
{
    /// <summary>
    /// Retrieves the details of maintenance actions that are pending.
    /// </summary>
    public partial class PendingMaintenanceActionDetails
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Displays the specific action of a pending maintenance action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property AutoAppliedAfterDate. 
        /// <para>
        /// Displays the date of the maintenance window when the action is applied. The maintenance
        /// action is applied to the resource during its first maintenance window after this date.
        /// If this date is specified, any <c>NEXT_MAINTENANCE</c> <c>optInType</c> requests are
        /// ignored.
        /// </para>
        /// </summary>
        public string AutoAppliedAfterDate { get; set; }

        /// <summary>
        /// Checks to see if the AutoAppliedAfterDate property is set.
        /// </summary>
        internal bool IsSetAutoAppliedAfterDate() => this.AutoAppliedAfterDate != null;

        /// <summary>
        /// Gets and sets the property CurrentApplyDate. 
        /// <para>
        /// Displays the effective date when the pending maintenance action is applied to the
        /// resource.
        /// </para>
        /// </summary>
        public string CurrentApplyDate { get; set; }

        /// <summary>
        /// Checks to see if the CurrentApplyDate property is set.
        /// </summary>
        internal bool IsSetCurrentApplyDate() => this.CurrentApplyDate != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Displays a description providing more detail about the maintenance action.
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
        /// Displays the date when the maintenance action is automatically applied. The maintenance
        /// action is applied to the resource on this date regardless of the maintenance window
        /// for the resource. If this date is specified, any <c>IMMEDIATE</c> <c>optInType</c>
        /// requests are ignored.
        /// </para>
        /// </summary>
        public string ForcedApplyDate { get; set; }

        /// <summary>
        /// Checks to see if the ForcedApplyDate property is set.
        /// </summary>
        internal bool IsSetForcedApplyDate() => this.ForcedApplyDate != null;

        /// <summary>
        /// Gets and sets the property OptInStatus. 
        /// <para>
        /// Displays the type of <c>optInType</c> request that has been received for the resource.
        /// </para>
        /// </summary>
        public string OptInStatus { get; set; }

        /// <summary>
        /// Checks to see if the OptInStatus property is set.
        /// </summary>
        internal bool IsSetOptInStatus() => this.OptInStatus != null;
    }
}
