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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Metadata information about an evaluation review.
    /// </summary>
    public partial class EvaluationReviewMetadata
    {
        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The user who created the evaluation review.
        /// </para>
        /// </summary>
        [Obsolete("CreatedBy is deprecated.")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp when the evaluation review was created.
        /// </para>
        /// </summary>
        [Obsolete("CreatedTime is deprecated.")]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property RequestedBy. 
        /// <para>
        /// The user who requested the evaluation review.
        /// </para>
        /// </summary>
        public string RequestedBy { get; set; }

        /// <summary>
        /// Checks to see if the RequestedBy property is set.
        /// </summary>
        internal bool IsSetRequestedBy() => this.RequestedBy != null;

        /// <summary>
        /// Gets and sets the property RequestedTime. 
        /// <para>
        /// The timestamp when the evaluation review was requested.
        /// </para>
        /// </summary>
        public DateTime? RequestedTime { get; set; }

        /// <summary>
        /// Checks to see if the RequestedTime property is set.
        /// </summary>
        internal bool IsSetRequestedTime() => this.RequestedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ReviewId. 
        /// <para>
        /// The unique identifier for the evaluation review.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string ReviewId { get; set; }

        /// <summary>
        /// Checks to see if the ReviewId property is set.
        /// </summary>
        internal bool IsSetReviewId() => this.ReviewId != null;

        /// <summary>
        /// Gets and sets the property ReviewRequestComments. 
        /// <para>
        /// Comments provided when requesting the evaluation review.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1)]
        public List<EvaluationReviewRequestComment> ReviewRequestComments { get; set; } = AWSConfigs.InitializeCollections ? new List<EvaluationReviewRequestComment>() : null;

        /// <summary>
        /// Checks to see if the ReviewRequestComments property is set.
        /// </summary>
        internal bool IsSetReviewRequestComments() => this.ReviewRequestComments != null && (this.ReviewRequestComments.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
