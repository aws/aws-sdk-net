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
    /// Creates a deployment group to which application revisions will be deployed.
    /// </summary>
    public partial class CreateDeploymentGroupRequest : AmazonCodeDeployRequest
    {
        private AlarmConfiguration _alarmConfiguration;
        private string _applicationName;
        private AutoRollbackConfiguration _autoRollbackConfiguration;
        private List<string> _autoScalingGroups = new List<string>();
        private string _deploymentConfigName;
        private string _deploymentGroupName;
        private List<EC2TagFilter> _ec2TagFilters = new List<EC2TagFilter>();
        private List<TagFilter> _onPremisesInstanceTagFilters = new List<TagFilter>();
        private string _serviceRoleArn;
        private List<TriggerConfig> _triggerConfigurations = new List<TriggerConfig>();

        /// <summary>
        /// Gets and sets the property AlarmConfiguration. 
        /// <para>
        /// Information to add about Amazon CloudWatch alarms when the deployment group is created.
        /// 
        /// </para>
        /// </summary>
        public AlarmConfiguration AlarmConfiguration
        {
            get { return this._alarmConfiguration; }
            set { this._alarmConfiguration = value; }
        }

        // Check to see if AlarmConfiguration property is set
        internal bool IsSetAlarmConfiguration()
        {
            return this._alarmConfiguration != null;
        }

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
        /// group is created.
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
        /// If specified, the deployment configuration name can be either one of the predefined
        /// configurations provided with AWS CodeDeploy or a custom deployment configuration that
        /// you create by calling the create deployment configuration operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// CodeDeployDefault.OneAtATime is the default deployment configuration. It is used if
        /// a configuration isn't specified for the deployment or the deployment group.
        /// </para>
        ///  </note> 
        /// <para>
        /// The predefined deployment configurations include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>CodeDeployDefault.AllAtOnce</b> attempts to deploy an application revision to
        /// as many instances as possible at once. The status of the overall deployment will be
        /// displayed as <b>Succeeded</b> if the application revision is deployed to one or more
        /// of the instances. The status of the overall deployment will be displayed as <b>Failed</b>
        /// if the application revision is not deployed to any of the instances. Using an example
        /// of nine instances, CodeDeployDefault.AllAtOnce will attempt to deploy to all nine
        /// instances at once. The overall deployment will succeed if deployment to even a single
        /// instance is successful; it will fail only if deployments to all nine instances fail.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CodeDeployDefault.HalfAtATime</b> deploys to up to half of the instances at a
        /// time (with fractions rounded down). The overall deployment succeeds if the application
        /// revision is deployed to at least half of the instances (with fractions rounded up);
        /// otherwise, the deployment fails. In the example of nine instances, it will deploy
        /// to up to four instances at a time. The overall deployment succeeds if deployment to
        /// five or more instances succeed; otherwise, the deployment fails. The deployment may
        /// be successfully deployed to some instances even if the overall deployment fails.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>CodeDeployDefault.OneAtATime</b> deploys the application revision to only one
        /// instance at a time.
        /// </para>
        ///  
        /// <para>
        /// For deployment groups that contain more than one instance:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The overall deployment succeeds if the application revision is deployed to all of
        /// the instances. The exception to this rule is if deployment to the last instance fails,
        /// the overall deployment still succeeds. This is because AWS CodeDeploy allows only
        /// one instance at a time to be taken offline with the CodeDeployDefault.OneAtATime configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The overall deployment fails as soon as the application revision fails to be deployed
        /// to any but the last instance. The deployment may be successfully deployed to some
        /// instances even if the overall deployment fails.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In an example using nine instances, it will deploy to one instance at a time. The
        /// overall deployment succeeds if deployment to the first eight instances is successful;
        /// the overall deployment fails if deployment to any of the first eight instances fails.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For deployment groups that contain only one instance, the overall deployment is successful
        /// only if deployment to the single instance is successful
        /// </para>
        ///  </li> </ul>
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
        /// The name of a new deployment group for the specified application.
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
        /// The Amazon EC2 tags on which to filter.
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
        /// The on-premises instance tags on which to filter.
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

        /// <summary>
        /// Gets and sets the property TriggerConfigurations. 
        /// <para>
        /// Information about triggers to create when the deployment group is created. For examples,
        /// see <a href="http://docs.aws.amazon.com/codedeploy/latest/userguide/how-to-notify-sns.html">Create
        /// a Trigger for an AWS CodeDeploy Event</a> in the AWS CodeDeploy User Guide.
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