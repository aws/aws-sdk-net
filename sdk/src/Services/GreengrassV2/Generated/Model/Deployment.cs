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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
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
namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains information about a deployment.
    /// </summary>
    public partial class Deployment
    {
        private DateTime? _creationTimestamp;
        private string _deploymentId;
        private string _deploymentName;
        private DeploymentStatus _deploymentStatus;
        private bool? _isLatestForTarget;
        private string _parentTargetArn;
        private string _revisionId;
        private string _targetArn;

        /// <summary>
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        /// The time at which the deployment was created, expressed in ISO 8601 format.
        /// </para>
        /// </summary>
        public DateTime? CreationTimestamp
        {
            get { return this._creationTimestamp; }
            set { this._creationTimestamp = value; }
        }

        // Check to see if CreationTimestamp property is set
        internal bool IsSetCreationTimestamp()
        {
            return this._creationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        /// The ID of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string DeploymentId
        {
            get { return this._deploymentId; }
            set { this._deploymentId = value; }
        }

        // Check to see if DeploymentId property is set
        internal bool IsSetDeploymentId()
        {
            return this._deploymentId != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentName. 
        /// <para>
        /// The name of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string DeploymentName
        {
            get { return this._deploymentName; }
            set { this._deploymentName = value; }
        }

        // Check to see if DeploymentName property is set
        internal bool IsSetDeploymentName()
        {
            return this._deploymentName != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentStatus. 
        /// <para>
        /// The status of the deployment.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property IsLatestForTarget. 
        /// <para>
        /// Whether or not the deployment is the latest revision for its target.
        /// </para>
        /// </summary>
        public bool? IsLatestForTarget
        {
            get { return this._isLatestForTarget; }
            set { this._isLatestForTarget = value; }
        }

        // Check to see if IsLatestForTarget property is set
        internal bool IsSetIsLatestForTarget()
        {
            return this._isLatestForTarget.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParentTargetArn. 
        /// <para>
        /// The parent deployment's target <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// within a subdeployment.
        /// </para>
        /// </summary>
        public string ParentTargetArn
        {
            get { return this._parentTargetArn; }
            set { this._parentTargetArn = value; }
        }

        // Check to see if ParentTargetArn property is set
        internal bool IsSetParentTargetArn()
        {
            return this._parentTargetArn != null;
        }

        /// <summary>
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// The revision number of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string RevisionId
        {
            get { return this._revisionId; }
            set { this._revisionId = value; }
        }

        // Check to see if RevisionId property is set
        internal bool IsSetRevisionId()
        {
            return this._revisionId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the target IoT thing or thing group. When creating a subdeployment, the targetARN
        /// can only be a thing group.
        /// </para>
        /// </summary>
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

    }
}