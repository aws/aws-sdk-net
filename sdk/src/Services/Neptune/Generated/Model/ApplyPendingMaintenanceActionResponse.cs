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
    /// This is the response object from the ApplyPendingMaintenanceAction operation.
    /// </summary>
    public partial class ApplyPendingMaintenanceActionResponse : AmazonWebServiceResponse
    {
        private ResourcePendingMaintenanceActions _resourcePendingMaintenanceActions;

        /// <summary>
        /// Gets and sets the property ResourcePendingMaintenanceActions.
        /// </summary>
        public ResourcePendingMaintenanceActions ResourcePendingMaintenanceActions
        {
            get { return this._resourcePendingMaintenanceActions; }
            set { this._resourcePendingMaintenanceActions = value; }
        }

        // Check to see if ResourcePendingMaintenanceActions property is set
        internal bool IsSetResourcePendingMaintenanceActions()
        {
            return this._resourcePendingMaintenanceActions != null;
        }

    }
}