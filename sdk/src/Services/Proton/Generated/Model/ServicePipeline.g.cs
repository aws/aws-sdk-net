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
    /// Detailed data of an Proton service instance pipeline resource.
    /// </summary>
    public partial class ServicePipeline
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the service pipeline was created.
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
        /// The deployment status of the service pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DeploymentStatus DeploymentStatus { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentStatus property is set.
        /// </summary>
        internal bool IsSetDeploymentStatus() => this.DeploymentStatus != null;

        /// <summary>
        /// Gets and sets the property DeploymentStatusMessage. 
        /// <para>
        /// A service pipeline deployment status message.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string DeploymentStatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentStatusMessage property is set.
        /// </summary>
        internal bool IsSetDeploymentStatusMessage() => this.DeploymentStatusMessage != null;

        /// <summary>
        /// Gets and sets the property LastAttemptedDeploymentId. 
        /// <para>
        /// The ID of the last attempted deployment of this service pipeline.
        /// </para>
        /// </summary>
        public string LastAttemptedDeploymentId { get; set; }

        /// <summary>
        /// Checks to see if the LastAttemptedDeploymentId property is set.
        /// </summary>
        internal bool IsSetLastAttemptedDeploymentId() => this.LastAttemptedDeploymentId != null;

        /// <summary>
        /// Gets and sets the property LastDeploymentAttemptedAt. 
        /// <para>
        /// The time when a deployment of the service pipeline was last attempted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastDeploymentAttemptedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastDeploymentAttemptedAt property is set.
        /// </summary>
        internal bool IsSetLastDeploymentAttemptedAt() => this.LastDeploymentAttemptedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastDeploymentSucceededAt. 
        /// <para>
        /// The time when the service pipeline was last deployed successfully.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastDeploymentSucceededAt { get; set; }

        /// <summary>
        /// Checks to see if the LastDeploymentSucceededAt property is set.
        /// </summary>
        internal bool IsSetLastDeploymentSucceededAt() => this.LastDeploymentSucceededAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastSucceededDeploymentId. 
        /// <para>
        /// The ID of the last successful deployment of this service pipeline.
        /// </para>
        /// </summary>
        public string LastSucceededDeploymentId { get; set; }

        /// <summary>
        /// Checks to see if the LastSucceededDeploymentId property is set.
        /// </summary>
        internal bool IsSetLastSucceededDeploymentId() => this.LastSucceededDeploymentId != null;

        /// <summary>
        /// Gets and sets the property Spec. 
        /// <para>
        /// The service spec that was used to create the service pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 51200)]
        public string Spec { get; set; }

        /// <summary>
        /// Checks to see if the Spec property is set.
        /// </summary>
        internal bool IsSetSpec() => this.Spec != null;

        /// <summary>
        /// Gets and sets the property TemplateMajorVersion. 
        /// <para>
        /// The major version of the service template that was used to create the service pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public string TemplateMajorVersion { get; set; }

        /// <summary>
        /// Checks to see if the TemplateMajorVersion property is set.
        /// </summary>
        internal bool IsSetTemplateMajorVersion() => this.TemplateMajorVersion != null;

        /// <summary>
        /// Gets and sets the property TemplateMinorVersion. 
        /// <para>
        /// The minor version of the service template that was used to create the service pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public string TemplateMinorVersion { get; set; }

        /// <summary>
        /// Checks to see if the TemplateMinorVersion property is set.
        /// </summary>
        internal bool IsSetTemplateMinorVersion() => this.TemplateMinorVersion != null;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the service template that was used to create the service pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;
    }
}
