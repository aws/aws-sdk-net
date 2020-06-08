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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// The structures that contain summary information about the specified stack set.
    /// </summary>
    public partial class StackSetSummary
    {
        private AutoDeployment _autoDeployment;
        private string _description;
        private StackDriftStatus _driftStatus;
        private DateTime? _lastDriftCheckTimestamp;
        private PermissionModels _permissionModel;
        private string _stackSetId;
        private string _stackSetName;
        private StackSetStatus _status;

        /// <summary>
        /// Gets and sets the property AutoDeployment. 
        /// <para>
        /// [<code>Service-managed</code> permissions] Describes whether StackSets automatically
        /// deploys to AWS Organizations accounts that are added to a target organizational unit
        /// (OU).
        /// </para>
        /// </summary>
        public AutoDeployment AutoDeployment
        {
            get { return this._autoDeployment; }
            set { this._autoDeployment = value; }
        }

        // Check to see if AutoDeployment property is set
        internal bool IsSetAutoDeployment()
        {
            return this._autoDeployment != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the stack set that you specify when the stack set is created or updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property DriftStatus. 
        /// <para>
        /// Status of the stack set's actual configuration compared to its expected template and
        /// parameter configuration. A stack set is considered to have drifted if one or more
        /// of its stack instances have drifted from their expected template and parameter configuration.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DRIFTED</code>: One or more of the stack instances belonging to the stack set
        /// stack differs from the expected template and parameter configuration. A stack instance
        /// is considered to have drifted if one or more of the resources in the associated stack
        /// have drifted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NOT_CHECKED</code>: AWS CloudFormation has not checked the stack set for drift.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IN_SYNC</code>: All of the stack instances belonging to the stack set stack
        /// match from the expected template and parameter configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UNKNOWN</code>: This value is reserved for future use.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StackDriftStatus DriftStatus
        {
            get { return this._driftStatus; }
            set { this._driftStatus = value; }
        }

        // Check to see if DriftStatus property is set
        internal bool IsSetDriftStatus()
        {
            return this._driftStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastDriftCheckTimestamp. 
        /// <para>
        /// Most recent time when CloudFormation performed a drift detection operation on the
        /// stack set. This value will be <code>NULL</code> for any stack set on which drift detection
        /// has not yet been performed.
        /// </para>
        /// </summary>
        public DateTime LastDriftCheckTimestamp
        {
            get { return this._lastDriftCheckTimestamp.GetValueOrDefault(); }
            set { this._lastDriftCheckTimestamp = value; }
        }

        // Check to see if LastDriftCheckTimestamp property is set
        internal bool IsSetLastDriftCheckTimestamp()
        {
            return this._lastDriftCheckTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PermissionModel. 
        /// <para>
        /// Describes how the IAM roles required for stack set operations are created.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// With <code>self-managed</code> permissions, you must create the administrator and
        /// execution roles required to deploy to target accounts. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-prereqs-self-managed.html">Grant
        /// Self-Managed Stack Set Permissions</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// With <code>service-managed</code> permissions, StackSets automatically creates the
        /// IAM roles required to deploy to accounts managed by AWS Organizations. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-prereqs-service-managed.html">Grant
        /// Service-Managed Stack Set Permissions</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PermissionModels PermissionModel
        {
            get { return this._permissionModel; }
            set { this._permissionModel = value; }
        }

        // Check to see if PermissionModel property is set
        internal bool IsSetPermissionModel()
        {
            return this._permissionModel != null;
        }

        /// <summary>
        /// Gets and sets the property StackSetId. 
        /// <para>
        /// The ID of the stack set.
        /// </para>
        /// </summary>
        public string StackSetId
        {
            get { return this._stackSetId; }
            set { this._stackSetId = value; }
        }

        // Check to see if StackSetId property is set
        internal bool IsSetStackSetId()
        {
            return this._stackSetId != null;
        }

        /// <summary>
        /// Gets and sets the property StackSetName. 
        /// <para>
        /// The name of the stack set.
        /// </para>
        /// </summary>
        public string StackSetName
        {
            get { return this._stackSetName; }
            set { this._stackSetName = value; }
        }

        // Check to see if StackSetName property is set
        internal bool IsSetStackSetName()
        {
            return this._stackSetName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the stack set.
        /// </para>
        /// </summary>
        public StackSetStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}