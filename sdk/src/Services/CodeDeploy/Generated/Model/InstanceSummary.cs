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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
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
namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about an instance in a deployment.
    /// </summary>
    [Obsolete("InstanceSummary is deprecated, use DeploymentTarget instead.")]
    public partial class InstanceSummary
    {
        private string _deploymentId;
        private string _instanceId;
        private InstanceType _instanceType;
        private DateTime? _lastUpdatedAt;
        private List<LifecycleEvent> _lifecycleEvents = AWSConfigs.InitializeCollections ? new List<LifecycleEvent>() : null;
        private InstanceStatus _status;

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        ///  The unique ID of a deployment. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The instance ID.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// Information about which environment an instance belongs to in a blue/green deployment.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// BLUE: The instance is part of the original environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// GREEN: The instance is part of the replacement environment.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// A timestamp that indicates when the instance information was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LifecycleEvents. 
        /// <para>
        /// A list of lifecycle events for this instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LifecycleEvent> LifecycleEvents
        {
            get { return this._lifecycleEvents; }
            set { this._lifecycleEvents = value; }
        }

        // Check to see if LifecycleEvents property is set
        internal bool IsSetLifecycleEvents()
        {
            return this._lifecycleEvents != null && (this._lifecycleEvents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The deployment status for this instance:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Pending</c>: The deployment is pending for this instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>In Progress</c>: The deployment is in progress for this instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Succeeded</c>: The deployment has succeeded for this instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c>: The deployment has failed for this instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Skipped</c>: The deployment has been skipped for this instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Unknown</c>: The deployment status is unknown for this instance.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InstanceStatus Status
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