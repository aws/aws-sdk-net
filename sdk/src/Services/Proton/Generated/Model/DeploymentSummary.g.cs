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

namespace Amazon.Proton.Model
{
    /// <summary>
    /// Summary data of the deployment.
    /// </summary>
    public partial class DeploymentSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        /// The date and time the deployment was completed.
        /// </para>
        /// </summary>
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Checks to see if the CompletedAt property is set.
        /// </summary>
        internal bool IsSetCompletedAt() => this.CompletedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ComponentName. 
        /// <para>
        /// The name of the component associated with the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ComponentName { get; set; }

        /// <summary>
        /// Checks to see if the ComponentName property is set.
        /// </summary>
        internal bool IsSetComponentName() => this.ComponentName != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the deployment was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DeploymentStatus. 
        /// <para>
        /// The current status of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DeploymentStatus DeploymentStatus { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentStatus property is set.
        /// </summary>
        internal bool IsSetDeploymentStatus() => this.DeploymentStatus != null;

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of the environment associated with the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string EnvironmentName { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentName property is set.
        /// </summary>
        internal bool IsSetEnvironmentName() => this.EnvironmentName != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastAttemptedDeploymentId. 
        /// <para>
        /// The ID of the last attempted deployment.
        /// </para>
        /// </summary>
        public string LastAttemptedDeploymentId { get; set; }

        /// <summary>
        /// Checks to see if the LastAttemptedDeploymentId property is set.
        /// </summary>
        internal bool IsSetLastAttemptedDeploymentId() => this.LastAttemptedDeploymentId != null;

        /// <summary>
        /// Gets and sets the property LastModifiedAt. 
        /// <para>
        /// The date and time the deployment was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedAt property is set.
        /// </summary>
        internal bool IsSetLastModifiedAt() => this.LastModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastSucceededDeploymentId. 
        /// <para>
        /// The ID of the last successful deployment.
        /// </para>
        /// </summary>
        public string LastSucceededDeploymentId { get; set; }

        /// <summary>
        /// Checks to see if the LastSucceededDeploymentId property is set.
        /// </summary>
        internal bool IsSetLastSucceededDeploymentId() => this.LastSucceededDeploymentId != null;

        /// <summary>
        /// Gets and sets the property ServiceInstanceName. 
        /// <para>
        /// The name of the service instance associated with the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ServiceInstanceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceInstanceName property is set.
        /// </summary>
        internal bool IsSetServiceInstanceName() => this.ServiceInstanceName != null;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the service associated with the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the target of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string TargetArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetArn property is set.
        /// </summary>
        internal bool IsSetTargetArn() => this.TargetArn != null;

        /// <summary>
        /// Gets and sets the property TargetResourceCreatedAt. 
        /// <para>
        /// The date and time the target resource was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? TargetResourceCreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the TargetResourceCreatedAt property is set.
        /// </summary>
        internal bool IsSetTargetResourceCreatedAt() => this.TargetResourceCreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property TargetResourceType. 
        /// <para>
        /// The resource type of the deployment target. It can be an environment, service, service
        /// instance, or component.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DeploymentTargetResourceType TargetResourceType { get; set; }

        /// <summary>
        /// Checks to see if the TargetResourceType property is set.
        /// </summary>
        internal bool IsSetTargetResourceType() => this.TargetResourceType != null;
    }
}
