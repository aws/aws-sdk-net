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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Configuration settings for the task volume that was <c>configuredAtLaunch</c> that
    /// weren't set during <c>RegisterTaskDef</c>.
    /// </summary>
    public partial class TaskVolumeConfiguration
    {
        /// <summary>
        /// Gets and sets the property ManagedEBSVolume. 
        /// <para>
        /// The configuration for the Amazon EBS volume that Amazon ECS creates and manages on
        /// your behalf. These settings are used to create each Amazon EBS volume, with one volume
        /// created for each task. The Amazon EBS volumes are visible in your account in the Amazon
        /// EC2 console once they are created.
        /// </para>
        /// </summary>
        public TaskManagedEBSVolumeConfiguration ManagedEBSVolume { get; set; }

        /// <summary>
        /// Checks to see if the ManagedEBSVolume property is set.
        /// </summary>
        internal bool IsSetManagedEBSVolume() => this.ManagedEBSVolume != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the volume. This value must match the volume name from the <c>Volume</c>
        /// object in the task definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
