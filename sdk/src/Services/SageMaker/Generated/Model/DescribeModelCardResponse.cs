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
    /// This is the response object from the DescribeModelCard operation.
    /// </summary>
    public partial class DescribeModelCardResponse : AmazonWebServiceResponse
    {
        private string _content;
        private UserContext _createdBy;
        private DateTime? _creationTime;
        private UserContext _lastModifiedBy;
        private DateTime? _lastModifiedTime;
        private string _modelCardArn;
        private string _modelCardName;
        private ModelCardProcessingStatus _modelCardProcessingStatus;
        private ModelCardStatus _modelCardStatus;
        private int? _modelCardVersion;
        private ModelCardSecurityConfig _securityConfig;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the model card.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=100000)]
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
        [AWSProperty(Required=true)]
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
        /// The date and time the model card was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The date and time the model card was last modified.
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
        [AWSProperty(Required=true, Max=256)]
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
        /// The name of the model card.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        /// Gets and sets the property ModelCardProcessingStatus. 
        /// <para>
        /// The processing status of model card deletion. The <code>ModelCardProcessingStatus</code>
        /// updates throughout the different deletion steps.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DeletePending</code>: Model card deletion request received.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DeleteInProgress</code>: Model card deletion is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ContentDeleted</code>: Deleted model card content.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ExportJobsDeleted</code>: Deleted all export jobs associated with the model
        /// card.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DeleteCompleted</code>: Successfully deleted the model card.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DeleteFailed</code>: The model card failed to delete.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ModelCardProcessingStatus ModelCardProcessingStatus
        {
            get { return this._modelCardProcessingStatus; }
            set { this._modelCardProcessingStatus = value; }
        }

        // Check to see if ModelCardProcessingStatus property is set
        internal bool IsSetModelCardProcessingStatus()
        {
            return this._modelCardProcessingStatus != null;
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
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property SecurityConfig. 
        /// <para>
        /// The security configuration used to protect model card content.
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

    }
}