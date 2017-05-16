/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDeployment operation.
    /// Deploys an application revision through the specified deployment group.
    /// </summary>
    public partial class CreateDeploymentRequest : AmazonCodeDeployRequest
    {
        private string _applicationName;
        private AutoRollbackConfiguration _autoRollbackConfiguration;
        private string _deploymentConfigName;
        private string _deploymentGroupName;
        private string _description;
        private FileExistsBehavior _fileExistsBehavior;
        private bool? _ignoreApplicationStopFailures;
        private RevisionLocation _revision;
        private TargetInstances _targetInstances;
        private bool? _updateOutdatedInstancesOnly;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of an AWS CodeDeploy application associated with the applicable IAM user
        /// or AWS account.
        /// </para>
        /// </summary>
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }

        /// <summary>
        /// Gets and sets the property AutoRollbackConfiguration. 
        /// <para>
        /// Configuration information for an automatic rollback that is added when a deployment
        /// is created.
        /// </para>
        /// </summary>
        public AutoRollbackConfiguration AutoRollbackConfiguration
        {
            get { return this._autoRollbackConfiguration; }
            set { this._autoRollbackConfiguration = value; }
        }

        // Check to see if AutoRollbackConfiguration property is set
        internal bool IsSetAutoRollbackConfiguration()
        {
            return this._autoRollbackConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentConfigName. 
        /// <para>
        /// The name of a deployment configuration associated with the applicable IAM user or
        /// AWS account.
        /// </para>
        ///  
        /// <para>
        /// If not specified, the value configured in the deployment group will be used as the
        /// default. If the deployment group does not have a deployment configuration associated
        /// with it, then CodeDeployDefault.OneAtATime will be used by default.
        /// </para>
        /// </summary>
        public string DeploymentConfigName
        {
            get { return this._deploymentConfigName; }
            set { this._deploymentConfigName = value; }
        }

        // Check to see if DeploymentConfigName property is set
        internal bool IsSetDeploymentConfigName()
        {
            return this._deploymentConfigName != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentGroupName. 
        /// <para>
        /// The name of the deployment group.
        /// </para>
        /// </summary>
        public string DeploymentGroupName
        {
            get { return this._deploymentGroupName; }
            set { this._deploymentGroupName = value; }
        }

        // Check to see if DeploymentGroupName property is set
        internal bool IsSetDeploymentGroupName()
        {
            return this._deploymentGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A comment about the deployment.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FileExistsBehavior. 
        /// <para>
        /// Information about how AWS CodeDeploy handles files that already exist in a deployment
        /// target location but weren't part of the previous successful deployment.
        /// </para>
        ///  
        /// <para>
        /// The fileExistsBehavior parameter takes any of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// DISALLOW: The deployment fails. This is also the default behavior if no option is
        /// specified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OVERWRITE: The version of the file from the application revision currently being deployed
        /// replaces the version already on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RETAIN: The version of the file already on the instance is kept and used as part of
        /// the new deployment.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FileExistsBehavior FileExistsBehavior
        {
            get { return this._fileExistsBehavior; }
            set { this._fileExistsBehavior = value; }
        }

        // Check to see if FileExistsBehavior property is set
        internal bool IsSetFileExistsBehavior()
        {
            return this._fileExistsBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property IgnoreApplicationStopFailures. 
        /// <para>
        /// If set to true, then if the deployment causes the ApplicationStop deployment lifecycle
        /// event to an instance to fail, the deployment to that instance will not be considered
        /// to have failed at that point and will continue on to the BeforeInstall deployment
        /// lifecycle event.
        /// </para>
        ///  
        /// <para>
        /// If set to false or not specified, then if the deployment causes the ApplicationStop
        /// deployment lifecycle event to fail to an instance, the deployment to that instance
        /// will stop, and the deployment to that instance will be considered to have failed.
        /// </para>
        /// </summary>
        public bool IgnoreApplicationStopFailures
        {
            get { return this._ignoreApplicationStopFailures.GetValueOrDefault(); }
            set { this._ignoreApplicationStopFailures = value; }
        }

        // Check to see if IgnoreApplicationStopFailures property is set
        internal bool IsSetIgnoreApplicationStopFailures()
        {
            return this._ignoreApplicationStopFailures.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The type and location of the revision to deploy.
        /// </para>
        /// </summary>
        public RevisionLocation Revision
        {
            get { return this._revision; }
            set { this._revision = value; }
        }

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this._revision != null;
        }

        /// <summary>
        /// Gets and sets the property TargetInstances. 
        /// <para>
        /// Information about the instances that will belong to the replacement environment in
        /// a blue/green deployment.
        /// </para>
        /// </summary>
        public TargetInstances TargetInstances
        {
            get { return this._targetInstances; }
            set { this._targetInstances = value; }
        }

        // Check to see if TargetInstances property is set
        internal bool IsSetTargetInstances()
        {
            return this._targetInstances != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateOutdatedInstancesOnly. 
        /// <para>
        /// Indicates whether to deploy to all instances or only to instances that are not running
        /// the latest application revision.
        /// </para>
        /// </summary>
        public bool UpdateOutdatedInstancesOnly
        {
            get { return this._updateOutdatedInstancesOnly.GetValueOrDefault(); }
            set { this._updateOutdatedInstancesOnly = value; }
        }

        // Check to see if UpdateOutdatedInstancesOnly property is set
        internal bool IsSetUpdateOutdatedInstancesOnly()
        {
            return this._updateOutdatedInstancesOnly.HasValue; 
        }

    }
}