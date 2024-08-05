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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The model card associated with the model package. Since <c>ModelPackageModelCard</c>
    /// is tied to a model package, it is a specific usage of a model card and its schema
    /// is simplified compared to the schema of <c>ModelCard</c>. The <c>ModelPackageModelCard</c>
    /// schema does not include <c>model_package_details</c>, and <c>model_overview</c> is
    /// composed of the <c>model_creator</c> and <c>model_artifact</c> properties. For more
    /// information about the model package model card schema, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-registry-details.html#model-card-schema">Model
    /// package model card schema</a>. For more information about the model card associated
    /// with the model package, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-registry-details.html">View
    /// the Details of a Model Version</a>.
    /// </summary>
    public partial class ModelPackageModelCard
    {
        private string _modelCardContent;
        private ModelCardStatus _modelCardStatus;

        /// <summary>
        /// Gets and sets the property ModelCardContent. 
        /// <para>
        /// The content of the model card. The content must follow the schema described in <a
        /// href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-registry-details.html#model-card-schema">Model
        /// Package Model Card Schema</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=100000)]
        public string ModelCardContent
        {
            get { return this._modelCardContent; }
            set { this._modelCardContent = value; }
        }

        // Check to see if ModelCardContent property is set
        internal bool IsSetModelCardContent()
        {
            return this._modelCardContent != null;
        }

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
        ///  <c>Archived</c>: The model card is archived. No more updates can be made to the model
        /// card content. If you try to update the model card content, you will receive the message
        /// <c>Model Card is in Archived state</c>.
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