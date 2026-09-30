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

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// This is the response object from the GetBulkDeploymentStatus operation.
    /// </summary>
    public partial class GetBulkDeploymentStatusResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BulkDeploymentMetrics. Relevant metrics on input records
        /// processed during bulk deployment.
        /// </summary>
        public BulkDeploymentMetrics BulkDeploymentMetrics { get; set; }

        /// <summary>
        /// Checks to see if the BulkDeploymentMetrics property is set.
        /// </summary>
        internal bool IsSetBulkDeploymentMetrics() => this.BulkDeploymentMetrics != null;

        /// <summary>
        /// Gets and sets the property BulkDeploymentStatus. The status of the bulk deployment.
        /// </summary>
        public BulkDeploymentStatus BulkDeploymentStatus { get; set; }

        /// <summary>
        /// Checks to see if the BulkDeploymentStatus property is set.
        /// </summary>
        internal bool IsSetBulkDeploymentStatus() => this.BulkDeploymentStatus != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. The time, in ISO format, when the deployment
        /// was created.
        /// </summary>
        public string CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt != null;

        /// <summary>
        /// Gets and sets the property ErrorDetails. Error details
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ErrorDetail> ErrorDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<ErrorDetail>() : null;

        /// <summary>
        /// Checks to see if the ErrorDetails property is set.
        /// </summary>
        internal bool IsSetErrorDetails() => this.ErrorDetails != null && (this.ErrorDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ErrorMessage. Error message
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property Tags. Tag(s) attached to the resource arn.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
