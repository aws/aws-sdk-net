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
    /// Container for the parameters to the CreateDeploymentGroup operation.
    /// Creates a new deployment group for application revisions to be deployed to.
    /// </summary>
    public partial class CreateDeploymentGroupRequest : AmazonCodeDeployRequest
    {
        private string _applicationName;
        private List<string> _autoScalingGroups = new List<string>();
        private string _deploymentConfigName;
        private string _deploymentGroupName;
        private List<EC2TagFilter> _ec2TagFilters = new List<EC2TagFilter>();
        private List<TagFilter> _onPremisesInstanceTagFilters = new List<TagFilter>();
        private string _serviceRoleArn;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of an existing AWS CodeDeploy application associated with the applicable
        /// IAM user or AWS account.
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
        /// Gets and sets the property DeploymentConfigName. 
        /// <para>
        /// If specified, the deployment configuration name must be one of the predefined values,
        /// or it can be a custom deployment configuration:
        /// </para>
        ///  <ul> <li>CodeDeployDefault.AllAtOnce deploys an application revision to up to all
        /// of the instances at once. The overall deployment succeeds if the application revision
        /// deploys to at least one of the instances. The overall deployment fails after the application
        /// revision fails to deploy to all of the instances. For example, for 9 instances, deploy
        /// to up to all 9 instances at once. The overall deployment succeeds if any of the 9
        /// instances is successfully deployed to, and it fails if all 9 instances fail to be
        /// deployed to.</li> <li>CodeDeployDefault.HalfAtATime deploys to up to half of the instances
        /// at a time (with fractions rounded down). The overall deployment succeeds if the application
        /// revision deploys to at least half of the instances (with fractions rounded up); otherwise,
        /// the deployment fails. For example, for 9 instances, deploy to up to 4 instances at
        /// a time. The overall deployment succeeds if 5 or more instances are successfully deployed
        /// to; otherwise, the deployment fails. Note that the deployment may successfully deploy
        /// to some instances, even if the overall deployment fails.</li> <li>CodeDeployDefault.OneAtATime
        /// deploys the application revision to only one of the instances at a time. The overall
        /// deployment succeeds if the application revision deploys to all of the instances. The
        /// overall deployment fails after the application revision first fails to deploy to any
        /// one instances. For example, for 9 instances, deploy to one instance at a time. The
        /// overall deployment succeeds if all 9 instances are successfully deployed to, and it
        /// fails if any of one of the 9 instances fail to be deployed to. Note that the deployment
        /// may successfully deploy to some instances, even if the overall deployment fails. This
        /// is the default deployment configuration if a configuration isn't specified for either
        /// the deployment or the deployment group.</li> </ul> 
        /// <para>
        /// To create a custom deployment configuration, call the create deployment configuration
        /// operation.
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
        /// The name of an existing deployment group for the specified application.
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
        /// A service role ARN that allows AWS CodeDeploy to act on the user's behalf when interacting
        /// with AWS services.
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

    }
}