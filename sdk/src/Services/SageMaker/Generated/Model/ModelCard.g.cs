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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// An Amazon SageMaker Model Card.
    /// </summary>
    public partial class ModelCard
    {
        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the model card. Content uses the <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-cards.html#model-cards-json-schema">model
        /// card JSON schema</a> and provided as a string.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 100000)]
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property CreatedBy.
        /// </summary>
        public UserContext CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the model card was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedBy.
        /// </summary>
        public UserContext LastModifiedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedBy property is set.
        /// </summary>
        internal bool IsSetLastModifiedBy() => this.LastModifiedBy != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time that the model card was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ModelCardArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model card.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ModelCardArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelCardArn property is set.
        /// </summary>
        internal bool IsSetModelCardArn() => this.ModelCardArn != null;

        /// <summary>
        /// Gets and sets the property ModelCardName. 
        /// <para>
        /// The unique name of the model card.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ModelCardName { get; set; }

        /// <summary>
        /// Checks to see if the ModelCardName property is set.
        /// </summary>
        internal bool IsSetModelCardName() => this.ModelCardName != null;

        /// <summary>
        /// Gets and sets the property ModelCardStatus. 
        /// <para>
        /// The approval status of the model card within your organization. Different organizations
        /// might have different criteria for model card review and approval.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Draft</c>: The model card is a work in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PendingReview</c>: The model card is pending review.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Approved</c>: The model card is approved.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Archived</c>: The model card is archived. No more updates should be made to the
        /// model card, but it can still be exported.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ModelCardStatus ModelCardStatus { get; set; }

        /// <summary>
        /// Checks to see if the ModelCardStatus property is set.
        /// </summary>
        internal bool IsSetModelCardStatus() => this.ModelCardStatus != null;

        /// <summary>
        /// Gets and sets the property ModelCardVersion. 
        /// <para>
        /// The version of the model card.
        /// </para>
        /// </summary>
        public int? ModelCardVersion { get; set; }

        /// <summary>
        /// Checks to see if the ModelCardVersion property is set.
        /// </summary>
        internal bool IsSetModelCardVersion() => this.ModelCardVersion.HasValue;

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The unique name (ID) of the model.
        /// </para>
        /// </summary>
        public string ModelId { get; set; }

        /// <summary>
        /// Checks to see if the ModelId property is set.
        /// </summary>
        internal bool IsSetModelId() => this.ModelId != null;

        /// <summary>
        /// Gets and sets the property ModelPackageGroupName. 
        /// <para>
        /// The model package group that contains the model package. Only relevant for model cards
        /// created for model packages in the Amazon SageMaker Model Registry. 
        /// </para>
        /// </summary>
        public string ModelPackageGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageGroupName property is set.
        /// </summary>
        internal bool IsSetModelPackageGroupName() => this.ModelPackageGroupName != null;

        /// <summary>
        /// Gets and sets the property RiskRating. 
        /// <para>
        /// The risk rating of the model. Different organizations might have different criteria
        /// for model card risk ratings. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-cards-risk-rating.html">Risk
        /// ratings</a>.
        /// </para>
        /// </summary>
        public string RiskRating { get; set; }

        /// <summary>
        /// Checks to see if the RiskRating property is set.
        /// </summary>
        internal bool IsSetRiskRating() => this.RiskRating != null;

        /// <summary>
        /// Gets and sets the property SecurityConfig. 
        /// <para>
        /// The security configuration used to protect model card data.
        /// </para>
        /// </summary>
        public ModelCardSecurityConfig SecurityConfig { get; set; }

        /// <summary>
        /// Checks to see if the SecurityConfig property is set.
        /// </summary>
        internal bool IsSetSecurityConfig() => this.SecurityConfig != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs used to manage metadata for the model card.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
