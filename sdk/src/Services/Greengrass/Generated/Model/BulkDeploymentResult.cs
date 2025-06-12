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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
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
namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Information about an individual group deployment in a bulk deployment operation.
    /// </summary>
    public partial class BulkDeploymentResult
    {
        private string _createdAt;
        private string _deploymentArn;
        private string _deploymentId;
        private string _deploymentStatus;
        private DeploymentType _deploymentType;
        private List<ErrorDetail> _errorDetails = AWSConfigs.InitializeCollections ? new List<ErrorDetail>() : null;
        private string _errorMessage;
        private string _groupArn;

        /// <summary>
        /// Gets and sets the property CreatedAt. The time, in ISO format, when the deployment
        /// was created.
        /// </summary>
        public string CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentArn. The ARN of the group deployment.
        /// </summary>
        public string DeploymentArn
        {
            get { return this._deploymentArn; }
            set { this._deploymentArn = value; }
        }

        // Check to see if DeploymentArn property is set
        internal bool IsSetDeploymentArn()
        {
            return this._deploymentArn != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentId. The ID of the group deployment.
        /// </summary>
        public string DeploymentId
        {
            get { return this._deploymentId; }
            set { this._deploymentId = value; }
        }

        // Check to see if DeploymentId property is set
        internal bool IsSetDeploymentId()
        {
            return this._deploymentId != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentStatus. The current status of the group deployment:
        /// ''InProgress'', ''Building'', ''Success'', or ''Failure''.
        /// </summary>
        public string DeploymentStatus
        {
            get { return this._deploymentStatus; }
            set { this._deploymentStatus = value; }
        }

        // Check to see if DeploymentStatus property is set
        internal bool IsSetDeploymentStatus()
        {
            return this._deploymentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentType. The type of the deployment.
        /// </summary>
        public DeploymentType DeploymentType
        {
            get { return this._deploymentType; }
            set { this._deploymentType = value; }
        }

        // Check to see if DeploymentType property is set
        internal bool IsSetDeploymentType()
        {
            return this._deploymentType != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorDetails. Details about the error.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ErrorDetail> ErrorDetails
        {
            get { return this._errorDetails; }
            set { this._errorDetails = value; }
        }

        // Check to see if ErrorDetails property is set
        internal bool IsSetErrorDetails()
        {
            return this._errorDetails != null && (this._errorDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. The error message for a failed deployment
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property GroupArn. The ARN of the Greengrass group.
        /// </summary>
        public string GroupArn
        {
            get { return this._groupArn; }
            set { this._groupArn = value; }
        }

        // Check to see if GroupArn property is set
        internal bool IsSetGroupArn()
        {
            return this._groupArn != null;
        }

    }
}