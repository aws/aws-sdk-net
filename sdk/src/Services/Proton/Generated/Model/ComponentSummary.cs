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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Proton.Model
{
    /// <summary>
    /// Summary data of an Proton component resource.
    /// 
    ///  
    /// <para>
    /// For more information about components, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-components.html">Proton
    /// components</a> in the <i>Proton User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ComponentSummary
    {
        private string _arn;
        private DateTime? _createdAt;
        private DeploymentStatus _deploymentStatus;
        private string _deploymentStatusMessage;
        private string _environmentName;
        private DateTime? _lastDeploymentAttemptedAt;
        private DateTime? _lastDeploymentSucceededAt;
        private DateTime? _lastModifiedAt;
        private string _name;
        private string _serviceInstanceName;
        private string _serviceName;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the component was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeploymentStatus. 
        /// <para>
        /// The component deployment status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeploymentStatus DeploymentStatus
        {
            get { return this._deploymentStatus; }
            set { this._deploymentStatus = value; }
        }

        // Check to see if DeploymentStatus property is set
        internal bool IsSetDeploymentStatus()
        {
            return this._deploymentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentStatusMessage. 
        /// <para>
        /// The message associated with the component deployment status.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string DeploymentStatusMessage
        {
            get { return this._deploymentStatusMessage; }
            set { this._deploymentStatusMessage = value; }
        }

        // Check to see if DeploymentStatusMessage property is set
        internal bool IsSetDeploymentStatusMessage()
        {
            return this._deploymentStatusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of the Proton environment that this component is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string EnvironmentName
        {
            get { return this._environmentName; }
            set { this._environmentName = value; }
        }

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this._environmentName != null;
        }

        /// <summary>
        /// Gets and sets the property LastDeploymentAttemptedAt. 
        /// <para>
        /// The time when a deployment of the component was last attempted.
        /// </para>
        /// </summary>
        public DateTime LastDeploymentAttemptedAt
        {
            get { return this._lastDeploymentAttemptedAt.GetValueOrDefault(); }
            set { this._lastDeploymentAttemptedAt = value; }
        }

        // Check to see if LastDeploymentAttemptedAt property is set
        internal bool IsSetLastDeploymentAttemptedAt()
        {
            return this._lastDeploymentAttemptedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastDeploymentSucceededAt. 
        /// <para>
        /// The time when the component was last deployed successfully.
        /// </para>
        /// </summary>
        public DateTime LastDeploymentSucceededAt
        {
            get { return this._lastDeploymentSucceededAt.GetValueOrDefault(); }
            set { this._lastDeploymentSucceededAt = value; }
        }

        // Check to see if LastDeploymentSucceededAt property is set
        internal bool IsSetLastDeploymentSucceededAt()
        {
            return this._lastDeploymentSucceededAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedAt. 
        /// <para>
        /// The time when the component was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastModifiedAt
        {
            get { return this._lastModifiedAt.GetValueOrDefault(); }
            set { this._lastModifiedAt = value; }
        }

        // Check to see if LastModifiedAt property is set
        internal bool IsSetLastModifiedAt()
        {
            return this._lastModifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceInstanceName. 
        /// <para>
        /// The name of the service instance that this component is attached to. Provided when
        /// a component is attached to a service instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ServiceInstanceName
        {
            get { return this._serviceInstanceName; }
            set { this._serviceInstanceName = value; }
        }

        // Check to see if ServiceInstanceName property is set
        internal bool IsSetServiceInstanceName()
        {
            return this._serviceInstanceName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the service that <code>serviceInstanceName</code> is associated with.
        /// Provided when a component is attached to a service instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

    }
}