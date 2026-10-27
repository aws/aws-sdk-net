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
    /// The summary of the lifecycle policy preview request.
    /// </summary>
    public partial class LifecyclePolicyPreviewSummary
    {
        /// <summary>
        /// Gets and sets the property ExpiringImageTotalCount. 
        /// <para>
        /// The number of expiring images.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? ExpiringImageTotalCount { get; set; }

        /// <summary>
        /// Checks to see if the ExpiringImageTotalCount property is set.
        /// </summary>
        internal bool IsSetExpiringImageTotalCount() => this.ExpiringImageTotalCount.HasValue;

        /// <summary>
        /// Gets and sets the property TransitioningImageTotalCounts. 
        /// <para>
        /// The total count of images that will be transitioned to each storage class. This field
        /// is only present if at least one image will be transitoned in the summary.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TransitioningImageTotalCount> TransitioningImageTotalCounts { get; set; } = AWSConfigs.InitializeCollections ? new List<TransitioningImageTotalCount>() : null;

        /// <summary>
        /// Checks to see if the TransitioningImageTotalCounts property is set.
        /// </summary>
        internal bool IsSetTransitioningImageTotalCounts() => this.TransitioningImageTotalCounts != null && (this.TransitioningImageTotalCounts.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
