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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about an instance in a deployment.
    /// </summary>
    public partial class InstanceSummary
    {
        private string _deploymentId;
        private string _instanceId;
        private DateTime? _lastUpdatedAt;
        private List<LifecycleEvent> _lifecycleEvents = new List<LifecycleEvent>();
        private InstanceStatus _status;

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        /// The deployment ID.
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
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// A timestamp indicating when the instance information was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedAt
        {
            get { return this._lastUpdatedAt.GetValueOrDefault(); }
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
        /// </summary>
        public List<LifecycleEvent> LifecycleEvents
        {
            get { return this._lifecycleEvents; }
            set { this._lifecycleEvents = value; }
        }

        // Check to see if LifecycleEvents property is set
        internal bool IsSetLifecycleEvents()
        {
            return this._lifecycleEvents != null && this._lifecycleEvents.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The deployment status for this instance:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Pending: The deployment is pending for this instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In Progress: The deployment is in progress for this instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Succeeded: The deployment has succeeded for this instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Failed: The deployment has failed for this instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Skipped: The deployment has been skipped for this instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Unknown: The deployment status is unknown for this instance.
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