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
    /// Summary data of an Proton environment resource. An Proton environment is a set of
    /// resources shared across Proton services.
    /// </summary>
    public partial class EnvironmentSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ComponentRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM service role that Proton uses when provisioning
        /// directly defined components in this environment. It determines the scope of infrastructure
        /// that a component can provision.
        /// </para>
        ///  
        /// <para>
        /// The environment must have a <c>componentRoleArn</c> to allow directly defined components
        /// to be associated with the environment.
        /// </para>
        ///  
        /// <para>
        /// For more information about components, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-components.html">Proton
        /// components</a> in the <i>Proton User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string ComponentRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ComponentRoleArn property is set.
        /// </summary>
        internal bool IsSetComponentRoleArn() => this.ComponentRoleArn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the environment was created.
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
        /// The environment deployment status.
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
        /// An environment deployment status message.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string DeploymentStatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentStatusMessage property is set.
        /// </summary>
        internal bool IsSetDeploymentStatusMessage() => this.DeploymentStatusMessage != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EnvironmentAccountConnectionId. 
        /// <para>
        /// The ID of the environment account connection that the environment is associated with.
        /// </para>
        /// </summary>
        public string EnvironmentAccountConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentAccountConnectionId property is set.
        /// </summary>
        internal bool IsSetEnvironmentAccountConnectionId() => this.EnvironmentAccountConnectionId != null;

        /// <summary>
        /// Gets and sets the property EnvironmentAccountId. 
        /// <para>
        /// The ID of the environment account that the environment infrastructure resources are
        /// provisioned in.
        /// </para>
        /// </summary>
        public string EnvironmentAccountId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentAccountId property is set.
        /// </summary>
        internal bool IsSetEnvironmentAccountId() => this.EnvironmentAccountId != null;

        /// <summary>
        /// Gets and sets the property LastAttemptedDeploymentId. 
        /// <para>
        /// The ID of the last attempted deployment of this environment.
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
        /// The time when a deployment of the environment was last attempted.
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
        /// The time when the environment was last deployed successfully.
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
        /// The ID of the last successful deployment of this environment.
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
        /// The name of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProtonServiceRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Proton service role that allows Proton to make
        /// calls to other services on your behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string ProtonServiceRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ProtonServiceRoleArn property is set.
        /// </summary>
        internal bool IsSetProtonServiceRoleArn() => this.ProtonServiceRoleArn != null;

        /// <summary>
        /// Gets and sets the property Provisioning. 
        /// <para>
        /// When included, indicates that the environment template is for customer provisioned
        /// and managed infrastructure.
        /// </para>
        /// </summary>
        public Provisioning Provisioning { get; set; }

        /// <summary>
        /// Checks to see if the Provisioning property is set.
        /// </summary>
        internal bool IsSetProvisioning() => this.Provisioning != null;

        /// <summary>
        /// Gets and sets the property TemplateMajorVersion. 
        /// <para>
        /// The major version of the environment template.
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
        /// The minor version of the environment template.
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
        /// The name of the environment template.
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
