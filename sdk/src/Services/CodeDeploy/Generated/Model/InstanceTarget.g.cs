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
    /// A target Amazon EC2 or on-premises instance during a deployment that uses the EC2/On-premises
    /// compute platform.
    /// </summary>
    public partial class InstanceTarget
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
        /// Gets and sets the property InstanceLabel. 
        /// <para>
        ///  A label that identifies whether the instance is an original target (<c>BLUE</c>)
        /// or a replacement target (<c>GREEN</c>). 
        /// </para>
        /// </summary>
        public TargetLabel InstanceLabel { get; set; }

        /// <summary>
        /// Checks to see if the InstanceLabel property is set.
        /// </summary>
        internal bool IsSetInstanceLabel() => this.InstanceLabel != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        ///  The date and time when the target instance was updated by a deployment. 
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
        ///  The lifecycle events of the deployment to this target instance. 
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
        ///  The status an EC2/On-premises deployment's target instance. 
        /// </para>
        /// </summary>
        public TargetStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the target. 
        /// </para>
        /// </summary>
        public string TargetArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetArn property is set.
        /// </summary>
        internal bool IsSetTargetArn() => this.TargetArn != null;

        /// <summary>
        /// Gets and sets the property TargetId. 
        /// <para>
        ///  The unique ID of a deployment target that has a type of <c>instanceTarget</c>. 
        /// </para>
        /// </summary>
        public string TargetId { get; set; }

        /// <summary>
        /// Checks to see if the TargetId property is set.
        /// </summary>
        internal bool IsSetTargetId() => this.TargetId != null;
    }
}
