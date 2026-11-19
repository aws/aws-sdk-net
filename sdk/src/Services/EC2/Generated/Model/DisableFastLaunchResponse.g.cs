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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the DisableFastLaunch operation.
    /// </summary>
    public partial class DisableFastLaunchResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the image for which Windows fast launch was disabled.
        /// </para>
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        /// Checks to see if the ImageId property is set.
        /// </summary>
        internal bool IsSetImageId() => this.ImageId != null;

        /// <summary>
        /// Gets and sets the property LaunchTemplate. 
        /// <para>
        /// The launch template that was used to launch Windows instances from pre-provisioned
        /// snapshots.
        /// </para>
        /// </summary>
        public FastLaunchLaunchTemplateSpecificationResponse LaunchTemplate { get; set; }

        /// <summary>
        /// Checks to see if the LaunchTemplate property is set.
        /// </summary>
        internal bool IsSetLaunchTemplate() => this.LaunchTemplate != null;

        /// <summary>
        /// Gets and sets the property MaxParallelLaunches. 
        /// <para>
        /// The maximum number of instances that Amazon EC2 can launch at the same time to create
        /// pre-provisioned snapshots for Windows fast launch.
        /// </para>
        /// </summary>
        public int? MaxParallelLaunches { get; set; }

        /// <summary>
        /// Checks to see if the MaxParallelLaunches property is set.
        /// </summary>
        internal bool IsSetMaxParallelLaunches() => this.MaxParallelLaunches.HasValue;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The owner of the Windows AMI for which Windows fast launch was disabled.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The pre-provisioning resource type that must be cleaned after turning off Windows
        /// fast launch for the Windows AMI. Supported values include: <c>snapshot</c>.
        /// </para>
        /// </summary>
        public FastLaunchResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property SnapshotConfiguration. 
        /// <para>
        /// Parameters that were used for Windows fast launch for the Windows AMI before Windows
        /// fast launch was disabled. This informs the clean-up process.
        /// </para>
        /// </summary>
        public FastLaunchSnapshotConfigurationResponse SnapshotConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotConfiguration property is set.
        /// </summary>
        internal bool IsSetSnapshotConfiguration() => this.SnapshotConfiguration != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of Windows fast launch for the specified Windows AMI.
        /// </para>
        /// </summary>
        public FastLaunchStateCode State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateTransitionReason. 
        /// <para>
        /// The reason that the state changed for Windows fast launch for the Windows AMI.
        /// </para>
        /// </summary>
        public string StateTransitionReason { get; set; }

        /// <summary>
        /// Checks to see if the StateTransitionReason property is set.
        /// </summary>
        internal bool IsSetStateTransitionReason() => this.StateTransitionReason != null;

        /// <summary>
        /// Gets and sets the property StateTransitionTime. 
        /// <para>
        /// The time that the state changed for Windows fast launch for the Windows AMI.
        /// </para>
        /// </summary>
        public DateTime? StateTransitionTime { get; set; }

        /// <summary>
        /// Checks to see if the StateTransitionTime property is set.
        /// </summary>
        internal bool IsSetStateTransitionTime() => this.StateTransitionTime.HasValue;
    }
}
