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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about Amazon ECS task involved in a GuardDuty finding, including
    /// task definition and container identifiers.
    /// </summary>
    public partial class EcsTask
    {
        /// <summary>
        /// Gets and sets the property ContainerUids. 
        /// <para>
        /// A list of unique identifiers for the containers associated with the Amazon ECS task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ContainerUids { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ContainerUids property is set.
        /// </summary>
        internal bool IsSetContainerUids() => this.ContainerUids != null && (this.ContainerUids.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp indicating when the Amazon ECS task was created, in UTC format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LaunchType. 
        /// <para>
        /// The infrastructure type on which the Amazon ECS task runs.
        /// </para>
        /// </summary>
        public EcsLaunchType LaunchType { get; set; }

        /// <summary>
        /// Checks to see if the LaunchType property is set.
        /// </summary>
        internal bool IsSetLaunchType() => this.LaunchType != null;

        /// <summary>
        /// Gets and sets the property TaskDefinitionArn. 
        /// <para>
        /// The ARN of task definition which describes the container and volume definitions of
        /// the Amazon ECS task.
        /// </para>
        /// </summary>
        public string TaskDefinitionArn { get; set; }

        /// <summary>
        /// Checks to see if the TaskDefinitionArn property is set.
        /// </summary>
        internal bool IsSetTaskDefinitionArn() => this.TaskDefinitionArn != null;
    }
}
