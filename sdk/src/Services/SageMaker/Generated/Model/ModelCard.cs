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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// An Amazon SageMaker Model Card.
    /// </summary>
    public partial class ModelCard
    {
        private string _content;
        private UserContext _createdBy;
        private DateTime? _creationTime;
        private UserContext _lastModifiedBy;
        private DateTime? _lastModifiedTime;
        private string _modelCardArn;
        private string _modelCardName;
        private ModelCardStatus _modelCardStatus;
        private int? _modelCardVersion;
        private string _modelId;
        private string _riskRating;
        private ModelCardSecurityConfig _securityConfig;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the model card. Content uses the <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-cards-api-json-schema.html">model
        /// card JSON schema</a> and provided as a string.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100000)]
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedBy.
        /// </summary>
        public UserContext CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the model card was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedBy.
        /// </summary>
        public UserContext LastModifiedBy
        {
            get { return this._lastModifiedBy; }
            set { this._lastModifiedBy = value; }
        }

        // Check to see if LastModifiedBy property is set
        internal bool IsSetLastModifiedBy()
        {
            return this._lastModifiedBy != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time that the model card was last modified.
        /// </para>
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelCardArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model card.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ModelCardArn
        {
            get { return this._modelCardArn; }
            set { this._modelCardArn = value; }
        }

        // Check to see if ModelCardArn property is set
        internal bool IsSetModelCardArn()
        {
            return this._modelCardArn != null;
        }

        /// <summary>
        /// Gets and sets the property ModelCardName. 
        /// <para>
        /// The unique name of the model card.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string ModelCardName
        {
            get { return this._modelCardName; }
            set { this._modelCardName = value; }
        }

        // Check to see if ModelCardName property is set
        internal bool IsSetModelCardName()
        {
            return this._modelCardName != null;
        }

        /// <summary>
        /// Gets and sets the property ModelCardStatus. 
        /// <para>
        /// The approval status of the model card within your organization. Different organizations
        /// might have different criteria for model card review and approval.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Draft</code>: The model card is a work in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PendingReview</code>: The model card is pending review.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Approved</code>: The model card is approved.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Archived</code>: The model card is archived. No more updates should be made
        /// to the model card, but it can still be exported.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ModelCardStatus ModelCardStatus
        {
            get { return this._modelCardStatus; }
            set { this._modelCardStatus = value; }
        }

        // Check to see if ModelCardStatus property is set
        internal bool IsSetModelCardStatus()
        {
            return this._modelCardStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ModelCardVersion. 
        /// <para>
        /// The version of the model card.
        /// </para>
        /// </summary>
        public int ModelCardVersion
        {
            get { return this._modelCardVersion.GetValueOrDefault(); }
            set { this._modelCardVersion = value; }
        }

        // Check to see if ModelCardVersion property is set
        internal bool IsSetModelCardVersion()
        {
            return this._modelCardVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The unique name (ID) of the model.
        /// </para>
        /// </summary>
        public string ModelId
        {
            get { return this._modelId; }
            set { this._modelId = value; }
        }

        // Check to see if ModelId property is set
        internal bool IsSetModelId()
        {
            return this._modelId != null;
        }

        /// <summary>
        /// Gets and sets the property RiskRating. 
        /// <para>
        /// The risk rating of the model. Different organizations might have different criteria
        /// for model card risk ratings. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-cards-risk-rating.html">Risk
        /// ratings</a>.
        /// </para>
        /// </summary>
        public string RiskRating
        {
            get { return this._riskRating; }
            set { this._riskRating = value; }
        }

        // Check to see if RiskRating property is set
        internal bool IsSetRiskRating()
        {
            return this._riskRating != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityConfig. 
        /// <para>
        /// The security configuration used to protect model card data.
        /// </para>
        /// </summary>
        public ModelCardSecurityConfig SecurityConfig
        {
            get { return this._securityConfig; }
            set { this._securityConfig = value; }
        }

        // Check to see if SecurityConfig property is set
        internal bool IsSetSecurityConfig()
        {
            return this._securityConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs used to manage metadata for the model card.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}