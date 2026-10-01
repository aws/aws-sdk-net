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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Contains summary information about a custom model deployment, including its ARN, name,
    /// status, and associated custom model.
    /// </summary>
    public partial class CustomModelDeploymentSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the custom model deployment was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CustomModelDeploymentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the custom model deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1011)]
        public string CustomModelDeploymentArn { get; set; }

        /// <summary>
        /// Checks to see if the CustomModelDeploymentArn property is set.
        /// </summary>
        internal bool IsSetCustomModelDeploymentArn() => this.CustomModelDeploymentArn != null;

        /// <summary>
        /// Gets and sets the property CustomModelDeploymentName. 
        /// <para>
        /// The name of the custom model deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string CustomModelDeploymentName { get; set; }

        /// <summary>
        /// Checks to see if the CustomModelDeploymentName property is set.
        /// </summary>
        internal bool IsSetCustomModelDeploymentName() => this.CustomModelDeploymentName != null;

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// If the deployment status is <c>FAILED</c>, this field contains a message describing
        /// the failure reason.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string FailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the FailureMessage property is set.
        /// </summary>
        internal bool IsSetFailureMessage() => this.FailureMessage != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The date and time when the custom model deployment was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the custom model associated with this deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1011)]
        public string ModelArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelArn property is set.
        /// </summary>
        internal bool IsSetModelArn() => this.ModelArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the custom model deployment. Possible values are <c>CREATING</c>, <c>ACTIVE</c>,
        /// and <c>FAILED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CustomModelDeploymentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
