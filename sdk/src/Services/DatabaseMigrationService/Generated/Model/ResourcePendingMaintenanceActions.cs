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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Identifies an AWS DMS resource and any pending actions for it.
    /// </summary>
    public partial class ResourcePendingMaintenanceActions
    {
        private List<PendingMaintenanceAction> _pendingMaintenanceActionDetails = new List<PendingMaintenanceAction>();
        private string _resourceIdentifier;

        /// <summary>
        /// Gets and sets the property PendingMaintenanceActionDetails. 
        /// <para>
        /// Detailed information about the pending maintenance action.
        /// </para>
        /// </summary>
        public List<PendingMaintenanceAction> PendingMaintenanceActionDetails
        {
            get { return this._pendingMaintenanceActionDetails; }
            set { this._pendingMaintenanceActionDetails = value; }
        }

        // Check to see if PendingMaintenanceActionDetails property is set
        internal bool IsSetPendingMaintenanceActionDetails()
        {
            return this._pendingMaintenanceActionDetails != null && this._pendingMaintenanceActionDetails.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the DMS resource that the pending maintenance action
        /// applies to. For information about creating an ARN, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Introduction.AWS.ARN.html">
        /// Constructing an Amazon Resource Name (ARN) for AWS DMS</a> in the DMS documentation.
        /// </para>
        /// </summary>
        public string ResourceIdentifier
        {
            get { return this._resourceIdentifier; }
            set { this._resourceIdentifier = value; }
        }

        // Check to see if ResourceIdentifier property is set
        internal bool IsSetResourceIdentifier()
        {
            return this._resourceIdentifier != null;
        }

    }
}