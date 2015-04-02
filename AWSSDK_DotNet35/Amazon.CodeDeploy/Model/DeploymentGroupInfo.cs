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
    /// Information about a deployment group.
    /// </summary>
    public partial class DeploymentGroupInfo
    {
        private string _applicationName;
        private List<AutoScalingGroup> _autoScalingGroups = new List<AutoScalingGroup>();
        private string _deploymentConfigName;
        private string _deploymentGroupId;
        private string _deploymentGroupName;
        private List<EC2TagFilter> _ec2TagFilters = new List<EC2TagFilter>();
        private List<TagFilter> _onPremisesInstanceTagFilters = new List<TagFilter>();
        private string _serviceRoleArn;
        private RevisionLocation _targetRevision;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The application name.
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
        /// Gets and sets the property AutoScalingGroups. 
        /// <para>
        /// A list of associated Auto Scaling groups.
        /// </para>
        /// </summary>
        public List<AutoScalingGroup> AutoScalingGroups
        {
            get { return this._autoScalingGroups; }
            set { this._autoScalingGroups = value; }
        }

        // Check to see if AutoScalingGroups property is set
        internal bool IsSetAutoScalingGroups()
        {
            return this._autoScalingGroups != null && this._autoScalingGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DeploymentConfigName. 
        /// <para>
        /// The deployment configuration name.
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
        /// Gets and sets the property DeploymentGroupId. 
        /// <para>
        /// The deployment group ID.
        /// </para>
        /// </summary>
        public string DeploymentGroupId
        {
            get { return this._deploymentGroupId; }
            set { this._deploymentGroupId = value; }
        }

        // Check to see if DeploymentGroupId property is set
        internal bool IsSetDeploymentGroupId()
        {
            return this._deploymentGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentGroupName. 
        /// <para>
        /// The deployment group name.
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
        /// Gets and sets the property Ec2TagFilters. 
        /// <para>
        /// The Amazon EC2 tags to filter on.
        /// </para>
        /// </summary>
        public List<EC2TagFilter> Ec2TagFilters
        {
            get { return this._ec2TagFilters; }
            set { this._ec2TagFilters = value; }
        }

        // Check to see if Ec2TagFilters property is set
        internal bool IsSetEc2TagFilters()
        {
            return this._ec2TagFilters != null && this._ec2TagFilters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OnPremisesInstanceTagFilters. 
        /// <para>
        /// The on-premises instance tags to filter on.
        /// </para>
        /// </summary>
        public List<TagFilter> OnPremisesInstanceTagFilters
        {
            get { return this._onPremisesInstanceTagFilters; }
            set { this._onPremisesInstanceTagFilters = value; }
        }

        // Check to see if OnPremisesInstanceTagFilters property is set
        internal bool IsSetOnPremisesInstanceTagFilters()
        {
            return this._onPremisesInstanceTagFilters != null && this._onPremisesInstanceTagFilters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ServiceRoleArn. 
        /// <para>
        /// A service role ARN.
        /// </para>
        /// </summary>
        public string ServiceRoleArn
        {
            get { return this._serviceRoleArn; }
            set { this._serviceRoleArn = value; }
        }

        // Check to see if ServiceRoleArn property is set
        internal bool IsSetServiceRoleArn()
        {
            return this._serviceRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property TargetRevision. 
        /// <para>
        /// Information about the deployment group's target revision, including the revision's
        /// type and its location.
        /// </para>
        /// </summary>
        public RevisionLocation TargetRevision
        {
            get { return this._targetRevision; }
            set { this._targetRevision = value; }
        }

        // Check to see if TargetRevision property is set
        internal bool IsSetTargetRevision()
        {
            return this._targetRevision != null;
        }

    }
}