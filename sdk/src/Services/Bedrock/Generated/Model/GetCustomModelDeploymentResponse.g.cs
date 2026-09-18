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
    /// This is the response object from the GetCustomModelDeployment operation.
    /// </summary>
    public partial class GetCustomModelDeploymentResponse : AmazonWebServiceResponse
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the custom model deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

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
        /// The date and time when the custom model deployment was last updated.
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
        /// Gets and sets the property ModelDeploymentName. 
        /// <para>
        /// The name of the custom model deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string ModelDeploymentName { get; set; }

        /// <summary>
        /// Checks to see if the ModelDeploymentName property is set.
        /// </summary>
        internal bool IsSetModelDeploymentName() => this.ModelDeploymentName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the custom model deployment. Possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c> - The deployment is being set up and prepared for inference.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> - The deployment is ready and available for inference requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - The deployment failed to be created or became unavailable.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public CustomModelDeploymentStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdateDetails. 
        /// <para>
        ///  Details about any pending or completed updates to the custom model deployment, including
        /// the new model ARN and update status. 
        /// </para>
        /// </summary>
        public CustomModelDeploymentUpdateDetails UpdateDetails { get; set; }

        /// <summary>
        /// Checks to see if the UpdateDetails property is set.
        /// </summary>
        internal bool IsSetUpdateDetails() => this.UpdateDetails != null;
    }
}
