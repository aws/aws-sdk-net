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
    /// The details about the container image a service revision uses. 
    /// 
    ///  
    /// <para>
    /// To ensure that all tasks in a service use the same container image, Amazon ECS resolves
    /// container image names and any image tags specified in the task definition to container
    /// image digests. 
    /// </para>
    ///  
    /// <para>
    /// After the container image digest has been established, Amazon ECS uses the digest
    /// to start any other desired tasks, and for any future service and service revision
    /// updates. This leads to all tasks in a service always running identical container images,
    /// resulting in version consistency for your software. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-type-ecs.html#deployment-container-image-stability">Container
    /// image resolution</a> in the Amazon ECS Developer Guide.
    /// </para>
    /// </summary>
    public partial class ContainerImage
    {
        /// <summary>
        /// Gets and sets the property ContainerName. 
        /// <para>
        /// The name of the container.
        /// </para>
        /// </summary>
        public string ContainerName { get; set; }

        /// <summary>
        /// Checks to see if the ContainerName property is set.
        /// </summary>
        internal bool IsSetContainerName() => this.ContainerName != null;

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The container image. 
        /// </para>
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Checks to see if the Image property is set.
        /// </summary>
        internal bool IsSetImage() => this.Image != null;

        /// <summary>
        /// Gets and sets the property ImageDigest. 
        /// <para>
        /// The container image digest.
        /// </para>
        /// </summary>
        public string ImageDigest { get; set; }

        /// <summary>
        /// Checks to see if the ImageDigest property is set.
        /// </summary>
        internal bool IsSetImageDigest() => this.ImageDigest != null;
    }
}
