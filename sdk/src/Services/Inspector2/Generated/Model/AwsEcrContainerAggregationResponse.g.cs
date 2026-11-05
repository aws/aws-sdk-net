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
    /// An aggregation of information about Amazon ECR containers.
    /// </summary>
    public partial class AwsEcrContainerAggregationResponse
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the account that owns the container.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The architecture of the container.
        /// </para>
        /// </summary>
        public string Architecture { get; set; }

        /// <summary>
        /// Checks to see if the Architecture property is set.
        /// </summary>
        internal bool IsSetArchitecture() => this.Architecture != null;

        /// <summary>
        /// Gets and sets the property ImageSha. 
        /// <para>
        /// The SHA value of the container image.
        /// </para>
        /// </summary>
        public string ImageSha { get; set; }

        /// <summary>
        /// Checks to see if the ImageSha property is set.
        /// </summary>
        internal bool IsSetImageSha() => this.ImageSha != null;

        /// <summary>
        /// Gets and sets the property ImageTags. 
        /// <para>
        /// The container image stags.
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
        /// Gets and sets the property Repository. 
        /// <para>
        /// The container repository.
        /// </para>
        /// </summary>
        public string Repository { get; set; }

        /// <summary>
        /// Checks to see if the Repository property is set.
        /// </summary>
        internal bool IsSetRepository() => this.Repository != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The resource ID of the container.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property SeverityCounts. 
        /// <para>
        /// The number of finding by severity.
        /// </para>
        /// </summary>
        public SeverityCounts SeverityCounts { get; set; }

        /// <summary>
        /// Checks to see if the SeverityCounts property is set.
        /// </summary>
        internal bool IsSetSeverityCounts() => this.SeverityCounts != null;
    }
}
