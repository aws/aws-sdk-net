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
    /// This is the response object from the DescribeModelCard operation.
    /// </summary>
    public partial class DescribeModelCardResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the model card. Content is provided as a string in the <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-cards.html#model-cards-json-schema">model
        /// card JSON schema</a>.
        /// </para>
        ///  
        /// <para>
        /// When you set <c>IncludedData</c> to <c>MetadataOnly</c> in the request, SageMaker
        /// returns a sanitized version of <c>Content</c> that includes only the following JSON
        /// paths, when present in the model card:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>model_overview.model_id</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>model_overview.model_name</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>intended_uses.risk_rating</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>model_package_details.model_package_group_name</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>model_package_details.model_package_arn</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// All other fields are removed from <c>Content</c> when <c>IncludedData</c> is <c>MetadataOnly</c>,
        /// including model description, training details, evaluation details, business details,
        /// and additional information. To retrieve the complete <c>Content</c>, set <c>IncludedData</c>
        /// to <c>AllData</c> or omit the parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 100000)]
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property CreatedBy.
        /// </summary>
        [AWSProperty(Required = true)]
        public UserContext CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time the model card was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
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
        /// The date and time the model card was last modified.
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
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ModelCardArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelCardArn property is set.
        /// </summary>
        internal bool IsSetModelCardArn() => this.ModelCardArn != null;

        /// <summary>
        /// Gets and sets the property ModelCardName. 
        /// <para>
        /// The name of the model card.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string ModelCardName { get; set; }

        /// <summary>
        /// Checks to see if the ModelCardName property is set.
        /// </summary>
        internal bool IsSetModelCardName() => this.ModelCardName != null;

        /// <summary>
        /// Gets and sets the property ModelCardProcessingStatus. 
        /// <para>
        /// The processing status of model card deletion. The <c>ModelCardProcessingStatus</c>
        /// updates throughout the different deletion steps.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DeletePending</c>: Model card deletion request received.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DeleteInProgress</c>: Model card deletion is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ContentDeleted</c>: Deleted model card content.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ExportJobsDeleted</c>: Deleted all export jobs associated with the model card.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DeleteCompleted</c>: Successfully deleted the model card.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DeleteFailed</c>: The model card failed to delete.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ModelCardProcessingStatus ModelCardProcessingStatus { get; set; }

        /// <summary>
        /// Checks to see if the ModelCardProcessingStatus property is set.
        /// </summary>
        internal bool IsSetModelCardProcessingStatus() => this.ModelCardProcessingStatus != null;

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
        [AWSProperty(Required = true)]
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
        [AWSProperty(Required = true)]
        public int? ModelCardVersion { get; set; }

        /// <summary>
        /// Checks to see if the ModelCardVersion property is set.
        /// </summary>
        internal bool IsSetModelCardVersion() => this.ModelCardVersion.HasValue;

        /// <summary>
        /// Gets and sets the property SecurityConfig. 
        /// <para>
        /// The security configuration used to protect model card content.
        /// </para>
        /// </summary>
        public ModelCardSecurityConfig SecurityConfig { get; set; }

        /// <summary>
        /// Checks to see if the SecurityConfig property is set.
        /// </summary>
        internal bool IsSetSecurityConfig() => this.SecurityConfig != null;
    }
}
