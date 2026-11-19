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

namespace Amazon.MarketplaceDeployment.Model
{
    /// <summary>
    /// This is the response object from the GetDeploymentConfigurationJob operation.
    /// </summary>
    public partial class GetDeploymentConfigurationJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The deployment configuration submitted with the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DeploymentConfigurationDetail Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property ConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the deployment configuration. This field is present
        /// only when the job status is <c>SUCCEEDED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationArn property is set.
        /// </summary>
        internal bool IsSetConfigurationArn() => this.ConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The date and time when the job reached the <c>SUCCEEDED</c> or <c>FAILED</c> status.
        /// </para>
        /// </summary>
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// Checks to see if the EndedAt property is set.
        /// </summary>
        internal bool IsSetEndedAt() => this.EndedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code that describes why the job failed. This field is present only when
        /// the job status is <c>FAILED</c>.
        /// </para>
        /// </summary>
        public DeploymentConfigurationJobErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier of the deployment configuration job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message that describes why the job failed. This field is present only when the job
        /// status is <c>FAILED</c>.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the deployment configuration job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DeploymentConfigurationJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
