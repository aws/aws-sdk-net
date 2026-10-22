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
    /// Details of a container.
    /// </summary>
    public partial class Container
    {
        /// <summary>
        /// Gets and sets the property ContainerRuntime. 
        /// <para>
        /// The container runtime (such as, Docker or containerd) used to run the container.
        /// </para>
        /// </summary>
        public string ContainerRuntime { get; set; }

        /// <summary>
        /// Checks to see if the ContainerRuntime property is set.
        /// </summary>
        internal bool IsSetContainerRuntime() => this.ContainerRuntime != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Container ID.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// Container image.
        /// </para>
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Checks to see if the Image property is set.
        /// </summary>
        internal bool IsSetImage() => this.Image != null;

        /// <summary>
        /// Gets and sets the property ImagePrefix. 
        /// <para>
        /// Part of the image name before the last slash. For example, imagePrefix for public.ecr.aws/amazonlinux/amazonlinux:latest
        /// would be public.ecr.aws/amazonlinux. If the image name is relative and does not have
        /// a slash, this field is empty.
        /// </para>
        /// </summary>
        public string ImagePrefix { get; set; }

        /// <summary>
        /// Checks to see if the ImagePrefix property is set.
        /// </summary>
        internal bool IsSetImagePrefix() => this.ImagePrefix != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Container name.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SecurityContext. 
        /// <para>
        /// Container security context.
        /// </para>
        /// </summary>
        public SecurityContext SecurityContext { get; set; }

        /// <summary>
        /// Checks to see if the SecurityContext property is set.
        /// </summary>
        internal bool IsSetSecurityContext() => this.SecurityContext != null;

        /// <summary>
        /// Gets and sets the property VolumeMounts. 
        /// <para>
        /// Container volume mounts.
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
