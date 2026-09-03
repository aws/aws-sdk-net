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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object that represents a container instance host device.
    /// 
    ///  <note> 
    /// <para>
    /// This object isn't applicable to jobs that are running on Fargate resources and shouldn't
    /// be provided.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class Device
    {
        /// <summary>
        /// Gets and sets the property ContainerPath. 
        /// <para>
        /// The path inside the container that's used to expose the host device. By default, the
        /// <c>hostPath</c> value is used.
        /// </para>
        /// </summary>
        public string ContainerPath { get; set; }

        /// <summary>
        /// Checks to see if the ContainerPath property is set.
        /// </summary>
        internal bool IsSetContainerPath() => this.ContainerPath != null;

        /// <summary>
        /// Gets and sets the property HostPath. 
        /// <para>
        /// The path for the device on the host container instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string HostPath { get; set; }

        /// <summary>
        /// Checks to see if the HostPath property is set.
        /// </summary>
        internal bool IsSetHostPath() => this.HostPath != null;

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// The explicit permissions to provide to the container for the device. By default, the
        /// container has permissions for <c>read</c>, <c>write</c>, and <c>mknod</c> for the
        /// device.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Permissions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Permissions property is set.
        /// </summary>
        internal bool IsSetPermissions() => this.Permissions != null && (this.Permissions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
