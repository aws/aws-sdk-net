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
    /// Container for the parameters to the ApplyPendingMaintenanceAction operation.
    /// Applies a pending maintenance action to a resource (for example, to a replication
    /// instance).
    /// </summary>
    public partial class ApplyPendingMaintenanceActionRequest : AmazonDatabaseMigrationServiceRequest
    {
        private string _applyAction;
        private string _optInType;
        private string _replicationInstanceArn;

        /// <summary>
        /// Gets and sets the property ApplyAction. 
        /// <para>
        /// The pending maintenance action to apply to this resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplyAction
        {
            get { return this._applyAction; }
            set { this._applyAction = value; }
        }

        // Check to see if ApplyAction property is set
        internal bool IsSetApplyAction()
        {
            return this._applyAction != null;
        }

        /// <summary>
        /// Gets and sets the property OptInType. 
        /// <para>
        /// A value that specifies the type of opt-in request, or undoes an opt-in request. You
        /// can't undo an opt-in request of type <code>immediate</code>.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>immediate</code> - Apply the maintenance action immediately.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>next-maintenance</code> - Apply the maintenance action during the next maintenance
        /// window for the resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>undo-opt-in</code> - Cancel any existing <code>next-maintenance</code> opt-in
        /// requests.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OptInType
        {
            get { return this._optInType; }
            set { this._optInType = value; }
        }

        // Check to see if OptInType property is set
        internal bool IsSetOptInType()
        {
            return this._optInType != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS DMS resource that the pending maintenance
        /// action applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReplicationInstanceArn
        {
            get { return this._replicationInstanceArn; }
            set { this._replicationInstanceArn = value; }
        }

        // Check to see if ReplicationInstanceArn property is set
        internal bool IsSetReplicationInstanceArn()
        {
            return this._replicationInstanceArn != null;
        }

    }
}