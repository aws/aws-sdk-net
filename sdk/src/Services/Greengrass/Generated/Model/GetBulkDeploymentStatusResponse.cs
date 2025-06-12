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
    /// This is the response object from the GetBulkDeploymentStatus operation.
    /// </summary>
    public partial class GetBulkDeploymentStatusResponse : AmazonWebServiceResponse
    {
        private BulkDeploymentMetrics _bulkDeploymentMetrics;
        private BulkDeploymentStatus _bulkDeploymentStatus;
        private string _createdAt;
        private List<ErrorDetail> _errorDetails = AWSConfigs.InitializeCollections ? new List<ErrorDetail>() : null;
        private string _errorMessage;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property BulkDeploymentMetrics. Relevant metrics on input records
        /// processed during bulk deployment.
        /// </summary>
        public BulkDeploymentMetrics BulkDeploymentMetrics
        {
            get { return this._bulkDeploymentMetrics; }
            set { this._bulkDeploymentMetrics = value; }
        }

        // Check to see if BulkDeploymentMetrics property is set
        internal bool IsSetBulkDeploymentMetrics()
        {
            return this._bulkDeploymentMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property BulkDeploymentStatus. The status of the bulk deployment.
        /// </summary>
        public BulkDeploymentStatus BulkDeploymentStatus
        {
            get { return this._bulkDeploymentStatus; }
            set { this._bulkDeploymentStatus = value; }
        }

        // Check to see if BulkDeploymentStatus property is set
        internal bool IsSetBulkDeploymentStatus()
        {
            return this._bulkDeploymentStatus != null;
        }

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
        /// Gets and sets the property ErrorDetails. Error details
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
        /// Gets and sets the property ErrorMessage. Error message
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
        /// Gets and sets the property Tags. Tag(s) attached to the resource arn.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}