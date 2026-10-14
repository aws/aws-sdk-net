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
    /// Summary data of an Proton service instance resource.
    /// </summary>
    public partial class ServiceInstanceSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the service instance was created.
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
        /// The service instance deployment status.
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
        /// A service instance deployment status message.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string DeploymentStatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentStatusMessage property is set.
        /// </summary>
        internal bool IsSetDeploymentStatusMessage() => this.DeploymentStatusMessage != null;

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of the environment that the service instance was deployed into.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string EnvironmentName { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentName property is set.
        /// </summary>
        internal bool IsSetEnvironmentName() => this.EnvironmentName != null;

        /// <summary>
        /// Gets and sets the property LastAttemptedDeploymentId. 
        /// <para>
        /// The ID of the last attempted deployment of this service instance.
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
        /// The time when a deployment of the service was last attempted.
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
        /// The time when the service was last deployed successfully.
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
        /// The ID of the last successful deployment of this service instance.
        /// </para>
        /// </summary>
        public string LastSucceededDeploymentId { get; set; }

        /// <summary>
        /// Checks to see if the LastSucceededDeploymentId property is set.
        /// </summary>
        internal bool IsSetLastSucceededDeploymentId() => this.LastSucceededDeploymentId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the service instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the service that the service instance belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;

        /// <summary>
        /// Gets and sets the property TemplateMajorVersion. 
        /// <para>
        /// The service instance template major version.
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
        /// The service instance template minor version.
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
        /// The name of the service template.
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
