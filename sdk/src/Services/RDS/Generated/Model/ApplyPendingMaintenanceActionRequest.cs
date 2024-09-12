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
    /// Container for the parameters to the ApplyPendingMaintenanceAction operation.
    /// Applies a pending maintenance action to a resource (for example, to a DB instance).
    /// </summary>
    public partial class ApplyPendingMaintenanceActionRequest : AmazonRDSRequest
    {
        private string _applyAction;
        private string _optInType;
        private string _resourceIdentifier;

        /// <summary>
        /// Gets and sets the property ApplyAction. 
        /// <para>
        /// The pending maintenance action to apply to this resource.
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
        /// A value that specifies the type of opt-in request, or undoes an opt-in request. An
        /// opt-in request of type <c>immediate</c> can't be undone.
        /// </para>
        ///  
        /// <para>
        /// Valid Values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>immediate</c> - Apply the maintenance action immediately.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>next-maintenance</c> - Apply the maintenance action during the next maintenance
        /// window for the resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>undo-opt-in</c> - Cancel any existing <c>next-maintenance</c> opt-in requests.
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
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// The RDS Amazon Resource Name (ARN) of the resource that the pending maintenance action
        /// applies to. For information about creating an ARN, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_Tagging.ARN.html#USER_Tagging.ARN.Constructing">
        /// Constructing an RDS Amazon Resource Name (ARN)</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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