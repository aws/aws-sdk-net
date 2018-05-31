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
 * Do not modify this file. This file is generated from the neptune-2018-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Describes the pending maintenance actions for a resource.
    /// </summary>
    public partial class ResourcePendingMaintenanceActions
    {
        private List<PendingMaintenanceAction> _pendingMaintenanceActionDetails = new List<PendingMaintenanceAction>();
        private string _resourceIdentifier;

        /// <summary>
        /// Gets and sets the property PendingMaintenanceActionDetails. 
        /// <para>
        /// A list that provides details about the pending maintenance actions for the resource.
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
        /// The ARN of the resource that has pending maintenance actions.
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