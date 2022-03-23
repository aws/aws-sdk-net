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
 * Do not modify this file. This file is generated from the gamesparks-2021-08-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameSparks.Model
{
    /// <summary>
    /// Properties that provide details of a stage deployment.
    /// </summary>
    public partial class StageDeploymentDetails
    {
        private DateTime? _created;
        private DeploymentAction _deploymentAction;
        private string _deploymentId;
        private DeploymentState _deploymentState;
        private DateTime? _lastUpdated;
        private string _snapshotId;

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The timestamp of when the stage deployment was created.
        /// </para>
        /// </summary>
        public DateTime Created
        {
            get { return this._created.GetValueOrDefault(); }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeploymentAction. 
        /// <para>
        /// The type of action of the stage deployment.
        /// </para>
        /// </summary>
        public DeploymentAction DeploymentAction
        {
            get { return this._deploymentAction; }
            set { this._deploymentAction = value; }
        }

        // Check to see if DeploymentAction property is set
        internal bool IsSetDeploymentAction()
        {
            return this._deploymentAction != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        /// The identifier of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string DeploymentId
        {
            get { return this._deploymentId; }
            set { this._deploymentId = value; }
        }

        // Check to see if DeploymentId property is set
        internal bool IsSetDeploymentId()
        {
            return this._deploymentId != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentState. 
        /// <para>
        /// The state of the deployment.
        /// </para>
        /// </summary>
        public DeploymentState DeploymentState
        {
            get { return this._deploymentState; }
            set { this._deploymentState = value; }
        }

        // Check to see if DeploymentState property is set
        internal bool IsSetDeploymentState()
        {
            return this._deploymentState != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// The timestamp of when the deployment was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdated
        {
            get { return this._lastUpdated.GetValueOrDefault(); }
            set { this._lastUpdated = value; }
        }

        // Check to see if LastUpdated property is set
        internal bool IsSetLastUpdated()
        {
            return this._lastUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The identifier of the snapshot associated with the stage deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=33, Max=36)]
        public string SnapshotId
        {
            get { return this._snapshotId; }
            set { this._snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this._snapshotId != null;
        }

    }
}