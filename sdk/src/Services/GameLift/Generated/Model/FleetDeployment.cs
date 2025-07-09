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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
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
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Describes a container fleet deployment with updates to the fleet.
    /// </summary>
    public partial class FleetDeployment
    {
        private DateTime? _creationTime;
        private DeploymentConfiguration _deploymentConfiguration;
        private string _deploymentId;
        private DeploymentStatus _deploymentStatus;
        private string _fleetId;
        private string _gameServerBinaryArn;
        private string _perInstanceBinaryArn;
        private string _rollbackGameServerBinaryArn;
        private string _rollbackPerInstanceBinaryArn;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A time stamp indicating when this data object was created. Format is a number expressed
        /// in Unix time as milliseconds (for example <c>"1469498468.057"</c>).
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeploymentConfiguration. 
        /// <para>
        /// Instructions for how to deploy updates to a container fleet and what actions to take
        /// if the deployment fails.
        /// </para>
        /// </summary>
        public DeploymentConfiguration DeploymentConfiguration
        {
            get { return this._deploymentConfiguration; }
            set { this._deploymentConfiguration = value; }
        }

        // Check to see if DeploymentConfiguration property is set
        internal bool IsSetDeploymentConfiguration()
        {
            return this._deploymentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        /// A unique identifier for the deployment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property DeploymentStatus. 
        /// <para>
        /// The status of fleet deployment activity in the location. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c> -- The deployment is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IMPAIRED</c> -- The deployment failed and the fleet has some impaired containers.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETE</c> -- The deployment has completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ROLLBACK_IN_PROGRESS</c> -- The deployment failed and rollback has been initiated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ROLLBACK_IN_COMPLETE</c> -- The deployment failed and rollback has been completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANCELLED</c> -- The deployment was cancelled.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DeploymentStatus DeploymentStatus
        {
            get { return this._deploymentStatus; }
            set { this._deploymentStatus = value; }
        }

        // Check to see if DeploymentStatus property is set
        internal bool IsSetDeploymentStatus()
        {
            return this._deploymentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the container fleet. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

        /// <summary>
        /// Gets and sets the property GameServerBinaryArn. 
        /// <para>
        /// The unique identifier for the version of the game server container group definition
        /// that is being deployed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string GameServerBinaryArn
        {
            get { return this._gameServerBinaryArn; }
            set { this._gameServerBinaryArn = value; }
        }

        // Check to see if GameServerBinaryArn property is set
        internal bool IsSetGameServerBinaryArn()
        {
            return this._gameServerBinaryArn != null;
        }

        /// <summary>
        /// Gets and sets the property PerInstanceBinaryArn. 
        /// <para>
        /// The unique identifier for the version of the per-instance container group definition
        /// that is being deployed. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string PerInstanceBinaryArn
        {
            get { return this._perInstanceBinaryArn; }
            set { this._perInstanceBinaryArn = value; }
        }

        // Check to see if PerInstanceBinaryArn property is set
        internal bool IsSetPerInstanceBinaryArn()
        {
            return this._perInstanceBinaryArn != null;
        }

        /// <summary>
        /// Gets and sets the property RollbackGameServerBinaryArn. 
        /// <para>
        /// The unique identifier for the version of the game server container group definition
        /// to roll back to if deployment fails. Amazon GameLift Servers sets this property to
        /// the container group definition version that the fleet used when it was last active.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string RollbackGameServerBinaryArn
        {
            get { return this._rollbackGameServerBinaryArn; }
            set { this._rollbackGameServerBinaryArn = value; }
        }

        // Check to see if RollbackGameServerBinaryArn property is set
        internal bool IsSetRollbackGameServerBinaryArn()
        {
            return this._rollbackGameServerBinaryArn != null;
        }

        /// <summary>
        /// Gets and sets the property RollbackPerInstanceBinaryArn. 
        /// <para>
        /// The unique identifier for the version of the per-instance container group definition
        /// to roll back to if deployment fails. Amazon GameLift Servers sets this property to
        /// the container group definition version that the fleet used when it was last active.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string RollbackPerInstanceBinaryArn
        {
            get { return this._rollbackPerInstanceBinaryArn; }
            set { this._rollbackPerInstanceBinaryArn = value; }
        }

        // Check to see if RollbackPerInstanceBinaryArn property is set
        internal bool IsSetRollbackPerInstanceBinaryArn()
        {
            return this._rollbackPerInstanceBinaryArn != null;
        }

    }
}