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
    /// Detailed data of an Proton service instance pipeline resource.
    /// </summary>
    public partial class ServicePipeline
    {
        private string _arn;
        private DateTime? _createdAt;
        private DeploymentStatus _deploymentStatus;
        private string _deploymentStatusMessage;
        private DateTime? _lastDeploymentAttemptedAt;
        private DateTime? _lastDeploymentSucceededAt;
        private string _spec;
        private string _templateMajorVersion;
        private string _templateMinorVersion;
        private string _templateName;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
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
        /// The time when the service pipeline was created.
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
        /// The deployment status of the service pipeline.
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
        /// A service pipeline deployment status message.
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
        /// Gets and sets the property LastDeploymentAttemptedAt. 
        /// <para>
        /// The time when a deployment of the service pipeline was last attempted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The time when the service pipeline was last deployed successfully.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Spec. 
        /// <para>
        /// The service spec that was used to create the service pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=51200)]
        public string Spec
        {
            get { return this._spec; }
            set { this._spec = value; }
        }

        // Check to see if Spec property is set
        internal bool IsSetSpec()
        {
            return this._spec != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateMajorVersion. 
        /// <para>
        /// The major version of the service template that was used to create the service pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string TemplateMajorVersion
        {
            get { return this._templateMajorVersion; }
            set { this._templateMajorVersion = value; }
        }

        // Check to see if TemplateMajorVersion property is set
        internal bool IsSetTemplateMajorVersion()
        {
            return this._templateMajorVersion != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateMinorVersion. 
        /// <para>
        /// The minor version of the service template that was used to create the service pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string TemplateMinorVersion
        {
            get { return this._templateMinorVersion; }
            set { this._templateMinorVersion = value; }
        }

        // Check to see if TemplateMinorVersion property is set
        internal bool IsSetTemplateMinorVersion()
        {
            return this._templateMinorVersion != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the service template that was used to create the service pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string TemplateName
        {
            get { return this._templateName; }
            set { this._templateName = value; }
        }

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this._templateName != null;
        }

    }
}