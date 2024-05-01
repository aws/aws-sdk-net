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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Proton.Model
{
    /// <summary>
    /// Summary data of the deployment.
    /// </summary>
    public partial class DeploymentSummary
    {
        private string _arn;
        private DateTime? _completedAt;
        private string _componentName;
        private DateTime? _createdAt;
        private DeploymentStatus _deploymentStatus;
        private string _environmentName;
        private string _id;
        private string _lastAttemptedDeploymentId;
        private DateTime? _lastModifiedAt;
        private string _lastSucceededDeploymentId;
        private string _serviceInstanceName;
        private string _serviceName;
        private string _targetArn;
        private DateTime? _targetResourceCreatedAt;
        private DeploymentTargetResourceType _targetResourceType;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the deployment.
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
        /// Gets and sets the property CompletedAt. 
        /// <para>
        /// The date and time the deployment was completed.
        /// </para>
        /// </summary>
        public DateTime? CompletedAt
        {
            get { return this._completedAt; }
            set { this._completedAt = value; }
        }

        // Check to see if CompletedAt property is set
        internal bool IsSetCompletedAt()
        {
            return this._completedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ComponentName. 
        /// <para>
        /// The name of the component associated with the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ComponentName
        {
            get { return this._componentName; }
            set { this._componentName = value; }
        }

        // Check to see if ComponentName property is set
        internal bool IsSetComponentName()
        {
            return this._componentName != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the deployment was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
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
        /// The current status of the deployment.
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
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of the environment associated with the deployment.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastAttemptedDeploymentId. 
        /// <para>
        /// The ID of the last attempted deployment.
        /// </para>
        /// </summary>
        public string LastAttemptedDeploymentId
        {
            get { return this._lastAttemptedDeploymentId; }
            set { this._lastAttemptedDeploymentId = value; }
        }

        // Check to see if LastAttemptedDeploymentId property is set
        internal bool IsSetLastAttemptedDeploymentId()
        {
            return this._lastAttemptedDeploymentId != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedAt. 
        /// <para>
        /// The date and time the deployment was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastModifiedAt
        {
            get { return this._lastModifiedAt; }
            set { this._lastModifiedAt = value; }
        }

        // Check to see if LastModifiedAt property is set
        internal bool IsSetLastModifiedAt()
        {
            return this._lastModifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastSucceededDeploymentId. 
        /// <para>
        /// The ID of the last successful deployment.
        /// </para>
        /// </summary>
        public string LastSucceededDeploymentId
        {
            get { return this._lastSucceededDeploymentId; }
            set { this._lastSucceededDeploymentId = value; }
        }

        // Check to see if LastSucceededDeploymentId property is set
        internal bool IsSetLastSucceededDeploymentId()
        {
            return this._lastSucceededDeploymentId != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceInstanceName. 
        /// <para>
        /// The name of the service instance associated with the deployment.
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
        /// The name of the service associated with the deployment.
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

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the target of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string TargetArn
        {
            get { return this._targetArn; }
            set { this._targetArn = value; }
        }

        // Check to see if TargetArn property is set
        internal bool IsSetTargetArn()
        {
            return this._targetArn != null;
        }

        /// <summary>
        /// Gets and sets the property TargetResourceCreatedAt. 
        /// <para>
        /// The date and time the target resource was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? TargetResourceCreatedAt
        {
            get { return this._targetResourceCreatedAt; }
            set { this._targetResourceCreatedAt = value; }
        }

        // Check to see if TargetResourceCreatedAt property is set
        internal bool IsSetTargetResourceCreatedAt()
        {
            return this._targetResourceCreatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetResourceType. 
        /// <para>
        /// The resource type of the deployment target. It can be an environment, service, service
        /// instance, or component.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeploymentTargetResourceType TargetResourceType
        {
            get { return this._targetResourceType; }
            set { this._targetResourceType = value; }
        }

        // Check to see if TargetResourceType property is set
        internal bool IsSetTargetResourceType()
        {
            return this._targetResourceType != null;
        }

    }
}