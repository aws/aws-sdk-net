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
    /// Container for the parameters to the DeregisterTargetFromMaintenanceWindow operation.
    /// Removes a target from a maintenance window.
    /// </summary>
    public partial class DeregisterTargetFromMaintenanceWindowRequest : AmazonSimpleSystemsManagementRequest
    {
        private bool? _safe;
        private string _windowId;
        private string _windowTargetId;

        /// <summary>
        /// Gets and sets the property Safe. 
        /// <para>
        /// The system checks if the target is being referenced by a task. If the target is being
        /// referenced, the system returns an error and does not deregister the target from the
        /// maintenance window.
        /// </para>
        /// </summary>
        public bool Safe
        {
            get { return this._safe.GetValueOrDefault(); }
            set { this._safe = value; }
        }

        // Check to see if Safe property is set
        internal bool IsSetSafe()
        {
            return this._safe.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WindowId. 
        /// <para>
        /// The ID of the maintenance window the target should be removed from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=20)]
        public string WindowId
        {
            get { return this._windowId; }
            set { this._windowId = value; }
        }

        // Check to see if WindowId property is set
        internal bool IsSetWindowId()
        {
            return this._windowId != null;
        }

        /// <summary>
        /// Gets and sets the property WindowTargetId. 
        /// <para>
        /// The ID of the target definition to remove.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string WindowTargetId
        {
            get { return this._windowTargetId; }
            set { this._windowTargetId = value; }
        }

        // Check to see if WindowTargetId property is set
        internal bool IsSetWindowTargetId()
        {
            return this._windowTargetId != null;
        }

    }
}