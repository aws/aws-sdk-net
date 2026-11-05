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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Contains details for a resource that the runtime instance of the lifecycle policy
    /// identified for action.
    /// </summary>
    public partial class LifecycleExecutionResource
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account that owns the impacted resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to take for the identified resource.
        /// </para>
        /// </summary>
        public LifecycleExecutionResourceAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The ending timestamp from the lifecycle action that was applied to the resource.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ImageUris. 
        /// <para>
        /// For an impacted container image, this identifies a list of URIs for associated container
        /// images distributed to ECR repositories.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ImageUris { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ImageUris property is set.
        /// </summary>
        internal bool IsSetImageUris() => this.ImageUris != null && (this.ImageUris.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region where the lifecycle execution resource is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// Identifies the impacted resource. The resource ID depends on the type of resource,
        /// as follows.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Image Builder image resources: Amazon Resource Name (ARN)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Distributed AMIs: AMI ID
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Container images distributed to an ECR repository: image URI or SHA Digest
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property Snapshots. 
        /// <para>
        /// A list of associated resource snapshots for the impacted resource if it’s an AMI.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LifecycleExecutionSnapshotResource> Snapshots { get; set; } = AWSConfigs.InitializeCollections ? new List<LifecycleExecutionSnapshotResource>() : null;

        /// <summary>
        /// Checks to see if the Snapshots property is set.
        /// </summary>
        internal bool IsSetSnapshots() => this.Snapshots != null && (this.Snapshots.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The starting timestamp from the lifecycle action that was applied to the resource.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The runtime state of the lifecycle action for this resource.
        /// </para>
        /// </summary>
        public LifecycleExecutionResourceState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
