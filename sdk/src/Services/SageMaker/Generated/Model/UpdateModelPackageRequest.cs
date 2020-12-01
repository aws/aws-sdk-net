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
    /// Container for the parameters to the UpdateModelPackage operation.
    /// Updates a versioned model.
    /// </summary>
    public partial class UpdateModelPackageRequest : AmazonSageMakerRequest
    {
        private string _approvalDescription;
        private ModelApprovalStatus _modelApprovalStatus;
        private string _modelPackageArn;

        /// <summary>
        /// Gets and sets the property ApprovalDescription. 
        /// <para>
        /// A description for the approval status of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string ApprovalDescription
        {
            get { return this._approvalDescription; }
            set { this._approvalDescription = value; }
        }

        // Check to see if ApprovalDescription property is set
        internal bool IsSetApprovalDescription()
        {
            return this._approvalDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ModelApprovalStatus. 
        /// <para>
        /// The approval status of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ModelApprovalStatus ModelApprovalStatus
        {
            get { return this._modelApprovalStatus; }
            set { this._modelApprovalStatus = value; }
        }

        // Check to see if ModelApprovalStatus property is set
        internal bool IsSetModelApprovalStatus()
        {
            return this._modelApprovalStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ModelPackageArn
        {
            get { return this._modelPackageArn; }
            set { this._modelPackageArn = value; }
        }

        // Check to see if ModelPackageArn property is set
        internal bool IsSetModelPackageArn()
        {
            return this._modelPackageArn != null;
        }

    }
}