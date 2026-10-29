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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        ///  The unique ID of a deployment. 
        /// </para>
        /// </summary>
        public string DeploymentId { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentId property is set.
        /// </summary>
        internal bool IsSetDeploymentId() => this.DeploymentId != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The instance ID.
        /// </para>
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

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
        public InstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// A timestamp that indicates when the instance information was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LifecycleEvents. 
        /// <para>
        /// A list of lifecycle events for this instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LifecycleEvent> LifecycleEvents { get; set; } = AWSConfigs.InitializeCollections ? new List<LifecycleEvent>() : null;

        /// <summary>
        /// Checks to see if the LifecycleEvents property is set.
        /// </summary>
        internal bool IsSetLifecycleEvents() => this.LifecycleEvents != null && (this.LifecycleEvents.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public InstanceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
