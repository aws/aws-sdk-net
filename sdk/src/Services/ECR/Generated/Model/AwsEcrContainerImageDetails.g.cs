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

namespace Amazon.ECR.Model
{
    /// <summary>
    /// The image details of the Amazon ECR container image.
    /// </summary>
    public partial class AwsEcrContainerImageDetails
    {
        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The architecture of the Amazon ECR container image.
        /// </para>
        /// </summary>
        public string Architecture { get; set; }

        /// <summary>
        /// Checks to see if the Architecture property is set.
        /// </summary>
        internal bool IsSetArchitecture() => this.Architecture != null;

        /// <summary>
        /// Gets and sets the property Author. 
        /// <para>
        /// The image author of the Amazon ECR container image.
        /// </para>
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Checks to see if the Author property is set.
        /// </summary>
        internal bool IsSetAuthor() => this.Author != null;

        /// <summary>
        /// Gets and sets the property ImageHash. 
        /// <para>
        /// The image hash of the Amazon ECR container image.
        /// </para>
        /// </summary>
        public string ImageHash { get; set; }

        /// <summary>
        /// Checks to see if the ImageHash property is set.
        /// </summary>
        internal bool IsSetImageHash() => this.ImageHash != null;

        /// <summary>
        /// Gets and sets the property ImageTags. 
        /// <para>
        /// The image tags attached to the Amazon ECR container image.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ImageTags { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ImageTags property is set.
        /// </summary>
        internal bool IsSetImageTags() => this.ImageTags != null && (this.ImageTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InUseCount. 
        /// <para>
        /// The number of Amazon ECS or Amazon EKS clusters currently running the image.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? InUseCount { get; set; }

        /// <summary>
        /// Checks to see if the InUseCount property is set.
        /// </summary>
        internal bool IsSetInUseCount() => this.InUseCount.HasValue;

        /// <summary>
        /// Gets and sets the property LastInUseAt. 
        /// <para>
        /// The most recent date and time a cluster was running the image.
        /// </para>
        /// </summary>
        public DateTime? LastInUseAt { get; set; }

        /// <summary>
        /// Checks to see if the LastInUseAt property is set.
        /// </summary>
        internal bool IsSetLastInUseAt() => this.LastInUseAt.HasValue;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform of the Amazon ECR container image.
        /// </para>
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property PushedAt. 
        /// <para>
        /// The date and time the Amazon ECR container image was pushed.
        /// </para>
        /// </summary>
        public DateTime? PushedAt { get; set; }

        /// <summary>
        /// Checks to see if the PushedAt property is set.
        /// </summary>
        internal bool IsSetPushedAt() => this.PushedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Registry. 
        /// <para>
        /// The registry the Amazon ECR container image belongs to.
        /// </para>
        /// </summary>
        public string Registry { get; set; }

        /// <summary>
        /// Checks to see if the Registry property is set.
        /// </summary>
        internal bool IsSetRegistry() => this.Registry != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository the Amazon ECR container image resides in.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 256)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;
    }
}
