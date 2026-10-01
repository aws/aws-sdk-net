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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container details related to a finding.
    /// </summary>
    public partial class ContainerDetails
    {
        /// <summary>
        /// Gets and sets the property ContainerRuntime. 
        /// <para>
        /// The runtime of the container. 
        /// </para>
        /// </summary>
        public string ContainerRuntime { get; set; }

        /// <summary>
        /// Checks to see if the ContainerRuntime property is set.
        /// </summary>
        internal bool IsSetContainerRuntime() => this.ContainerRuntime != null;

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The identifier of the container image related to a finding.
        /// </para>
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        /// Checks to see if the ImageId property is set.
        /// </summary>
        internal bool IsSetImageId() => this.ImageId != null;

        /// <summary>
        /// Gets and sets the property ImageName. 
        /// <para>
        /// The name of the container image related to a finding.
        /// </para>
        /// </summary>
        public string ImageName { get; set; }

        /// <summary>
        /// Checks to see if the ImageName property is set.
        /// </summary>
        internal bool IsSetImageName() => this.ImageName != null;

        /// <summary>
        /// Gets and sets the property LaunchedAt. 
        /// <para>
        /// Indicates when the container started.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string LaunchedAt { get; set; }

        /// <summary>
        /// Checks to see if the LaunchedAt property is set.
        /// </summary>
        internal bool IsSetLaunchedAt() => this.LaunchedAt != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the container related to a finding.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Privileged. 
        /// <para>
        /// When this parameter is <c>true</c>, the container is given elevated privileges on
        /// the host container instance (similar to the root user). 
        /// </para>
        /// </summary>
        public bool? Privileged { get; set; }

        /// <summary>
        /// Checks to see if the Privileged property is set.
        /// </summary>
        internal bool IsSetPrivileged() => this.Privileged.HasValue;

        /// <summary>
        /// Gets and sets the property VolumeMounts. 
        /// <para>
        /// Provides information about the mounting of a volume in a container. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VolumeMount> VolumeMounts { get; set; } = AWSConfigs.InitializeCollections ? new List<VolumeMount>() : null;

        /// <summary>
        /// Checks to see if the VolumeMounts property is set.
        /// </summary>
        internal bool IsSetVolumeMounts() => this.VolumeMounts != null && (this.VolumeMounts.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
