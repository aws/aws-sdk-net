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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Information on the Amazon ECR image metadata associated with a finding.
    /// </summary>
    public partial class EcrContainerImageMetadata
    {
        /// <summary>
        /// Gets and sets the property ImagePulledAt. 
        /// <para>
        /// The date an image was last pulled at.
        /// </para>
        /// </summary>
        public DateTime? ImagePulledAt { get; set; }

        /// <summary>
        /// Checks to see if the ImagePulledAt property is set.
        /// </summary>
        internal bool IsSetImagePulledAt() => this.ImagePulledAt.HasValue;

        /// <summary>
        /// Gets and sets the property InUseCount. 
        /// <para>
        /// The number of Amazon ECS tasks or Amazon EKS pods where the Amazon ECR container image
        /// is in use.
        /// </para>
        /// </summary>
        public long? InUseCount { get; set; }

        /// <summary>
        /// Checks to see if the InUseCount property is set.
        /// </summary>
        internal bool IsSetInUseCount() => this.InUseCount.HasValue;

        /// <summary>
        /// Gets and sets the property LastInUseAt. 
        /// <para>
        /// The last time an Amazon ECR image was used in an Amazon ECS task or Amazon EKS pod.
        /// </para>
        /// </summary>
        public DateTime? LastInUseAt { get; set; }

        /// <summary>
        /// Checks to see if the LastInUseAt property is set.
        /// </summary>
        internal bool IsSetLastInUseAt() => this.LastInUseAt.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags associated with the Amazon ECR image metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
