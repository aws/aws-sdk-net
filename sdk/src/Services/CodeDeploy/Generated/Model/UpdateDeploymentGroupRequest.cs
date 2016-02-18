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
    /// Container for the parameters to the UpdateDeploymentGroup operation.
    /// Changes information about an existing deployment group.
    /// </summary>
    public partial class UpdateDeploymentGroupRequest : AmazonCodeDeployRequest
    {
        private string _applicationName;
        private List<string> _autoScalingGroups = new List<string>();
        private string _currentDeploymentGroupName;
        private string _deploymentConfigName;
        private List<EC2TagFilter> _ec2TagFilters = new List<EC2TagFilter>();
        private string _newDeploymentGroupName;
        private List<TagFilter> _onPremisesInstanceTagFilters = new List<TagFilter>();
        private string _serviceRoleArn;
        private List<TriggerConfig> _triggerConfigurations = new List<TriggerConfig>();

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The application name corresponding to the deployment group to update.
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
        /// The replacement list of Auto Scaling groups to be included in the deployment group,
        /// if you want to change them. To keep the existing Auto Scaling groups, enter their
        /// names. To remove Auto Scaling groups, do not enter any Auto Scaling group names.
        /// </para>
        /// </summary>
        public List<string> AutoScalingGroups
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
        /// Gets and sets the property CurrentDeploymentGroupName. 
        /// <para>
        /// The current name of the existing deployment group.
        /// </para>
        /// </summary>
        public string CurrentDeploymentGroupName
        {
            get { return this._currentDeploymentGroupName; }
            set { this._currentDeploymentGroupName = value; }
        }

        // Check to see if CurrentDeploymentGroupName property is set
        internal bool IsSetCurrentDeploymentGroupName()
        {
            return this._currentDeploymentGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentConfigName. 
        /// <para>
        /// The replacement deployment configuration name to use, if you want to change it.
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
        /// Gets and sets the property Ec2TagFilters. 
        /// <para>
        /// The replacement set of Amazon EC2 tags to filter on, if you want to change them. To
        /// keep the existing tags, enter their names. To remove tags, do not enter any tag names.
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
        /// Gets and sets the property NewDeploymentGroupName. 
        /// <para>
        /// The new name of the deployment group, if you want to change it.
        /// </para>
        /// </summary>
        public string NewDeploymentGroupName
        {
            get { return this._newDeploymentGroupName; }
            set { this._newDeploymentGroupName = value; }
        }

        // Check to see if NewDeploymentGroupName property is set
        internal bool IsSetNewDeploymentGroupName()
        {
            return this._newDeploymentGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property OnPremisesInstanceTagFilters. 
        /// <para>
        /// The replacement set of on-premises instance tags for filter on, if you want to change
        /// them. To keep the existing tags, enter their names. To remove tags, do not enter any
        /// tag names.
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
        /// A replacement service role's ARN, if you want to change it.
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
        /// Gets and sets the property TriggerConfigurations. 
        /// <para>
        /// Information about triggers to change when the deployment group is updated.
        /// </para>
        /// </summary>
        public List<TriggerConfig> TriggerConfigurations
        {
            get { return this._triggerConfigurations; }
            set { this._triggerConfigurations = value; }
        }

        // Check to see if TriggerConfigurations property is set
        internal bool IsSetTriggerConfigurations()
        {
            return this._triggerConfigurations != null && this._triggerConfigurations.Count > 0; 
        }

    }
}