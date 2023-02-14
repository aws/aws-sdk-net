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
    /// Container for the parameters to the UpdateModelCard operation.
    /// Update an Amazon SageMaker Model Card.
    /// 
    ///  <important> 
    /// <para>
    /// You cannot update both model card content and model card status in a single call.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class UpdateModelCardRequest : AmazonSageMakerRequest
    {
        private string _content;
        private string _modelCardName;
        private ModelCardStatus _modelCardStatus;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The updated model card content. Content must be in <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-cards-api-json-schema.html">model
        /// card JSON schema</a> and provided as a string.
        /// </para>
        ///  
        /// <para>
        /// When updating model card content, be sure to include the full content and not just
        /// updated content.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=100000)]
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
        /// Gets and sets the property ModelCardName. 
        /// <para>
        /// The name of the model card to update.
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

    }
}