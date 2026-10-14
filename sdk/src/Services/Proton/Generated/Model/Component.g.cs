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
    /// Detailed data of an Proton component resource.
    /// 
    ///  
    /// <para>
    /// For more information about components, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-components.html">Proton
    /// components</a> in the <i>Proton User Guide</i>.
    /// </para>
    /// </summary>
    public partial class Component
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the component.
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
        /// The time when the component was created.
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
        /// The component deployment status.
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
        /// The message associated with the component deployment status.
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
        /// A description of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of the Proton environment that this component is associated with.
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
        /// The ID of the last attempted deployment of this component.
        /// </para>
        /// </summary>
        public string LastAttemptedDeploymentId { get; set; }

        /// <summary>
        /// Checks to see if the LastAttemptedDeploymentId property is set.
        /// </summary>
        internal bool IsSetLastAttemptedDeploymentId() => this.LastAttemptedDeploymentId != null;

        /// <summary>
        /// Gets and sets the property LastClientRequestToken. 
        /// <para>
        /// The last token the client requested.
        /// </para>
        /// </summary>
        public string LastClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the LastClientRequestToken property is set.
        /// </summary>
        internal bool IsSetLastClientRequestToken() => this.LastClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property LastDeploymentAttemptedAt. 
        /// <para>
        /// The time when a deployment of the component was last attempted.
        /// </para>
        /// </summary>
        public DateTime? LastDeploymentAttemptedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastDeploymentAttemptedAt property is set.
        /// </summary>
        internal bool IsSetLastDeploymentAttemptedAt() => this.LastDeploymentAttemptedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastDeploymentSucceededAt. 
        /// <para>
        /// The time when the component was last deployed successfully.
        /// </para>
        /// </summary>
        public DateTime? LastDeploymentSucceededAt { get; set; }

        /// <summary>
        /// Checks to see if the LastDeploymentSucceededAt property is set.
        /// </summary>
        internal bool IsSetLastDeploymentSucceededAt() => this.LastDeploymentSucceededAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedAt. 
        /// <para>
        /// The time when the component was last modified.
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
        /// The ID of the last successful deployment of this component.
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
        /// The name of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ServiceInstanceName. 
        /// <para>
        /// The name of the service instance that this component is attached to. Provided when
        /// a component is attached to a service instance.
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
        /// The name of the service that <c>serviceInstanceName</c> is associated with. Provided
        /// when a component is attached to a service instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;

        /// <summary>
        /// Gets and sets the property ServiceSpec. 
        /// <para>
        /// The service spec that the component uses to access service inputs. Provided when a
        /// component is attached to a service instance.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 51200)]
        public string ServiceSpec { get; set; }

        /// <summary>
        /// Checks to see if the ServiceSpec property is set.
        /// </summary>
        internal bool IsSetServiceSpec() => this.ServiceSpec != null;
    }
}
