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
 * Do not modify this file. This file is generated from the ssm-quicksetup-2018-05-10.normal.json service model.
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
namespace Amazon.SSMQuickSetup.Model
{
    /// <summary>
    /// Defines the preferences and options for a configuration definition.
    /// </summary>
    public partial class ConfigurationDefinitionInput
    {
        private string _localDeploymentAdministrationRoleArn;
        private string _localDeploymentExecutionRoleName;
        private Dictionary<string, string> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _type;
        private string _typeVersion;

        /// <summary>
        /// Gets and sets the property LocalDeploymentAdministrationRoleArn. 
        /// <para>
        /// The ARN of the IAM role used to administrate local configuration deployments.
        /// </para>
        /// </summary>
        public string LocalDeploymentAdministrationRoleArn
        {
            get { return this._localDeploymentAdministrationRoleArn; }
            set { this._localDeploymentAdministrationRoleArn = value; }
        }

        // Check to see if LocalDeploymentAdministrationRoleArn property is set
        internal bool IsSetLocalDeploymentAdministrationRoleArn()
        {
            return this._localDeploymentAdministrationRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property LocalDeploymentExecutionRoleName. 
        /// <para>
        /// The name of the IAM role used to deploy local configurations.
        /// </para>
        /// </summary>
        public string LocalDeploymentExecutionRoleName
        {
            get { return this._localDeploymentExecutionRoleName; }
            set { this._localDeploymentExecutionRoleName = value; }
        }

        // Check to see if LocalDeploymentExecutionRoleName property is set
        internal bool IsSetLocalDeploymentExecutionRoleName()
        {
            return this._localDeploymentExecutionRoleName != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameters for the configuration definition type. Parameters for configuration
        /// definitions vary based the configuration type. The following tables outline the parameters
        /// for each configuration type.
        /// </para>
        ///  <dl> <dt>OpsCenter (Type: Amazon Web ServicesQuickSetupType-SSMOpsCenter)</dt> <dd>
        /// <ul> <li> 
        /// <para>
        ///  <c>DelegatedAccountId</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) The ID of the delegated administrator account.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetOrganizationalUnits</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) A comma separated list of organizational units (OUs) you want
        /// to deploy the configuration to.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetRegions</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) A comma separated list of Amazon Web Services Regions you
        /// want to deploy the configuration to.
        /// </para>
        ///  </li> </ul> </li> </ul> </dd> <dt>Resource Scheduler (Type: Amazon Web ServicesQuickSetupType-Scheduler)</dt>
        /// <dd> <ul> <li> 
        /// <para>
        ///  <c>TargetTagKey</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) The tag key assigned to the instances you want to target.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetTagValue</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) The value of the tag key assigned to the instances you want
        /// to target.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>ICalendarString</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) An iCalendar formatted string containing the schedule you
        /// want Change Manager to use.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetAccounts</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) The ID of the Amazon Web Services account initiating the configuration
        /// deployment. You only need to provide a value for this parameter if you want to deploy
        /// the configuration locally. A value must be provided for either <c>TargetAccounts</c>
        /// or <c>TargetOrganizationalUnits</c>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetOrganizationalUnits</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A comma separated list of organizational units (OUs) you want
        /// to deploy the configuration to.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetRegions</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) A comma separated list of Amazon Web Services Regions you
        /// want to deploy the configuration to.
        /// </para>
        ///  </li> </ul> </li> </ul> </dd> <dt>Default Host Management Configuration (Type: Amazon
        /// Web ServicesQuickSetupType-DHMC)</dt> <dd> <ul> <li> 
        /// <para>
        ///  <c>UpdateSSMAgent</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A boolean value that determines whether the SSM Agent is updated
        /// on the target instances every 2 weeks. The default value is "<c>true</c>".
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetOrganizationalUnits</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) A comma separated list of organizational units (OUs) you want
        /// to deploy the configuration to.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetRegions</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) A comma separated list of Amazon Web Services Regions you
        /// want to deploy the configuration to.
        /// </para>
        ///  </li> </ul> </li> </ul> </dd> <dt>Resource Explorer (Type: Amazon Web ServicesQuickSetupType-ResourceExplorer)</dt>
        /// <dd> <ul> <li> 
        /// <para>
        ///  <c>SelectedAggregatorRegion</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) The Amazon Web Services Region where you want to create the
        /// aggregator index.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>ReplaceExistingAggregator</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) A boolean value that determines whether to demote an existing
        /// aggregator if it is in a Region that differs from the value you specify for the <c>SelectedAggregatorRegion</c>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetOrganizationalUnits</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) A comma separated list of organizational units (OUs) you want
        /// to deploy the configuration to.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetRegions</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) A comma separated list of Amazon Web Services Regions you
        /// want to deploy the configuration to.
        /// </para>
        ///  </li> </ul> </li> </ul> </dd> <dt>Change Manager (Type: Amazon Web ServicesQuickSetupType-SSMChangeMgr)</dt>
        /// <dd> <ul> <li> 
        /// <para>
        ///  <c>DelegatedAccountId</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) The ID of the delegated administrator account.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>JobFunction</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) The name for the Change Manager job function.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>PermissionType</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) Specifies whether you want to use default administrator permissions
        /// for the job function role, or provide a custom IAM policy. The valid values are <c>CustomPermissions</c>
        /// and <c>AdminPermissions</c>. The default value for the parameter is <c>CustomerPermissions</c>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>CustomPermissions</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A JSON string containing the IAM policy you want your job
        /// function to use. You must provide a value for this parameter if you specify <c>CustomPermissions</c>
        /// for the <c>PermissionType</c> parameter.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetOrganizationalUnits</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) A comma separated list of organizational units (OUs) you want
        /// to deploy the configuration to.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetRegions</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) A comma separated list of Amazon Web Services Regions you
        /// want to deploy the configuration to.
        /// </para>
        ///  </li> </ul> </li> </ul> </dd> <dt>DevOps Guru (Type: Amazon Web ServicesQuickSetupType-DevOpsGuru)</dt>
        /// <dd> <ul> <li> 
        /// <para>
        ///  <c>AnalyseAllResources</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A boolean value that determines whether DevOps Guru analyzes
        /// all CloudFormation stacks in the account. The default value is "<c>false</c>".
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>EnableSnsNotifications</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A boolean value that determines whether DevOps Guru sends
        /// notifications when an insight is created. The default value is "<c>true</c>".
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>EnableSsmOpsItems</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A boolean value that determines whether DevOps Guru creates
        /// an OpsCenter OpsItem when an insight is created. The default value is "<c>true</c>".
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>EnableDriftRemediation</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A boolean value that determines whether a drift remediation
        /// schedule is used. The default value is "<c>false</c>".
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>RemediationSchedule</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A rate expression that defines the schedule for drift remediation.
        /// The valid values are <c>rate(30 days)</c>, <c>rate(14 days)</c>, <c>rate(1 days)</c>,
        /// and <c>none</c>. The default value is "<c>none</c>".
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetAccounts</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) The ID of the Amazon Web Services account initiating the configuration
        /// deployment. You only need to provide a value for this parameter if you want to deploy
        /// the configuration locally. A value must be provided for either <c>TargetAccounts</c>
        /// or <c>TargetOrganizationalUnits</c>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetOrganizationalUnits</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A comma separated list of organizational units (OUs) you want
        /// to deploy the configuration to.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetRegions</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) A comma separated list of Amazon Web Services Regions you
        /// want to deploy the configuration to.
        /// </para>
        ///  </li> </ul> </li> </ul> </dd> <dt>Conformance Packs (Type: Amazon Web ServicesQuickSetupType-CFGCPacks)</dt>
        /// <dd> <ul> <li> 
        /// <para>
        ///  <c>DelegatedAccountId</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) The ID of the delegated administrator account. This parameter
        /// is required for Organization deployments.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>RemediationSchedule</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A rate expression that defines the schedule for drift remediation.
        /// The valid values are <c>rate(30 days)</c>, <c>rate(14 days)</c>, <c>rate(2 days)</c>,
        /// and <c>none</c>. The default value is "<c>none</c>".
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>CPackNames</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) A comma separated list of Config conformance packs.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetAccounts</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) The ID of the Amazon Web Services account initiating the configuration
        /// deployment. You only need to provide a value for this parameter if you want to deploy
        /// the configuration locally. A value must be provided for either <c>TargetAccounts</c>
        /// or <c>TargetOrganizationalUnits</c>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetOrganizationalUnits</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) The ID of the root of your Organization. This configuration
        /// type doesn't currently support choosing specific OUs. The configuration will be deployed
        /// to all the OUs in the Organization.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetRegions</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) A comma separated list of Amazon Web Services Regions you
        /// want to deploy the configuration to.
        /// </para>
        ///  </li> </ul> </li> </ul> </dd> <dt>Config Recording (Type: Amazon Web ServicesQuickSetupType-CFGRecording)</dt>
        /// <dd> <ul> <li> 
        /// <para>
        ///  <c>RecordAllResources</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A boolean value that determines whether all supported resources
        /// are recorded. The default value is "<c>true</c>".
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>ResourceTypesToRecord</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A comma separated list of resource types you want to record.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>RecordGlobalResourceTypes</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A boolean value that determines whether global resources are
        /// recorded with all resource configurations. The default value is "<c>false</c>".
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>GlobalResourceTypesRegion</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) Determines the Amazon Web Services Region where global resources
        /// are recorded.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>UseCustomBucket</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A boolean value that determines whether a custom Amazon S3
        /// bucket is used for delivery. The default value is "<c>false</c>".
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>DeliveryBucketName</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) The name of the Amazon S3 bucket you want Config to deliver
        /// configuration snapshots and configuration history files to.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>DeliveryBucketPrefix</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) The key prefix you want to use in the custom Amazon S3 bucket.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>NotificationOptions</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) Determines the notification configuration for the recorder.
        /// The valid values are <c>NoStreaming</c>, <c>UseExistingTopic</c>, and <c>CreateTopic</c>.
        /// The default value is <c>NoStreaming</c>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>CustomDeliveryTopicAccountId</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) The ID of the Amazon Web Services account where the Amazon
        /// SNS topic you want to use for notifications resides. You must specify a value for
        /// this parameter if you use the <c>UseExistingTopic</c> notification option.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>CustomDeliveryTopicName</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) The name of the Amazon SNS topic you want to use for notifications.
        /// You must specify a value for this parameter if you use the <c>UseExistingTopic</c>
        /// notification option.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>RemediationSchedule</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A rate expression that defines the schedule for drift remediation.
        /// The valid values are <c>rate(30 days)</c>, <c>rate(7 days)</c>, <c>rate(1 days)</c>,
        /// and <c>none</c>. The default value is "<c>none</c>".
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetAccounts</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) The ID of the Amazon Web Services account initiating the configuration
        /// deployment. You only need to provide a value for this parameter if you want to deploy
        /// the configuration locally. A value must be provided for either <c>TargetAccounts</c>
        /// or <c>TargetOrganizationalUnits</c>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetOrganizationalUnits</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) The ID of the root of your Organization. This configuration
        /// type doesn't currently support choosing specific OUs. The configuration will be deployed
        /// to all the OUs in the Organization.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetRegions</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) A comma separated list of Amazon Web Services Regions you
        /// want to deploy the configuration to.
        /// </para>
        ///  </li> </ul> </li> </ul> </dd> <dt>Host Management (Type: Amazon Web ServicesQuickSetupType-SSMHostMgmt)</dt>
        /// <dd> <ul> <li> 
        /// <para>
        ///  <c>UpdateSSMAgent</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A boolean value that determines whether the SSM Agent is updated
        /// on the target instances every 2 weeks. The default value is "<c>true</c>".
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>UpdateEc2LaunchAgent</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A boolean value that determines whether the EC2 Launch agent
        /// is updated on the target instances every month. The default value is "<c>false</c>".
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>CollectInventory</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A boolean value that determines whether the EC2 Launch agent
        /// is updated on the target instances every month. The default value is "<c>true</c>".
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>ScanInstances</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A boolean value that determines whether the target instances
        /// are scanned daily for available patches. The default value is "<c>true</c>".
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>InstallCloudWatchAgent</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A boolean value that determines whether the Amazon CloudWatch
        /// agent is installed on the target instances. The default value is "<c>false</c>".
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>UpdateCloudWatchAgent</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A boolean value that determines whether the Amazon CloudWatch
        /// agent is updated on the target instances every month. The default value is "<c>false</c>".
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>IsPolicyAttachAllowed</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A boolean value that determines whether Quick Setup attaches
        /// policies to instances profiles already associated with the target instances. The default
        /// value is "<c>false</c>".
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetType</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) Determines how instances are targeted for local account deployments.
        /// Don't specify a value for this parameter if you're deploying to OUs. The valid values
        /// are <c>*</c>, <c>InstanceIds</c>, <c>ResourceGroups</c>, and <c>Tags</c>. Use <c>*</c>
        /// to target all instances in the account.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetInstances</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A comma separated list of instance IDs. You must provide a
        /// value for this parameter if you specify <c>InstanceIds</c> for the <c>TargetType</c>
        /// parameter.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetTagKey</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) The tag key assigned to the instances you want to target.
        /// You must provide a value for this parameter if you specify <c>Tags</c> for the <c>TargetType</c>
        /// parameter.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetTagValue</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) The value of the tag key assigned to the instances you want
        /// to target. You must provide a value for this parameter if you specify <c>Tags</c>
        /// for the <c>TargetType</c> parameter.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>ResourceGroupName</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) The name of the resource group associated with the instances
        /// you want to target. You must provide a value for this parameter if you specify <c>ResourceGroups</c>
        /// for the <c>TargetType</c> parameter.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetAccounts</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) The ID of the Amazon Web Services account initiating the configuration
        /// deployment. You only need to provide a value for this parameter if you want to deploy
        /// the configuration locally. A value must be provided for either <c>TargetAccounts</c>
        /// or <c>TargetOrganizationalUnits</c>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetOrganizationalUnits</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A comma separated list of organizational units (OUs) you want
        /// to deploy the configuration to.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetRegions</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) A comma separated list of Amazon Web Services Regions you
        /// want to deploy the configuration to.
        /// </para>
        ///  </li> </ul> </li> </ul> </dd> <dt>Distributor (Type: Amazon Web ServicesQuickSetupType-Distributor)</dt>
        /// <dd> <ul> <li> 
        /// <para>
        ///  <c>PackagesToInstall</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) A comma separated list of packages you want to install on
        /// the target instances. The valid values are <c>AWSEFSTools</c>, <c>AWSCWAgent</c>,
        /// and <c>AWSEC2LaunchAgent</c>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>RemediationSchedule</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A rate expression that defines the schedule for drift remediation.
        /// The valid values are <c>rate(30 days)</c>, <c>rate(14 days)</c>, <c>rate(2 days)</c>,
        /// and <c>none</c>. The default value is "<c>rate(30 days)</c>".
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>IsPolicyAttachAllowed</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A boolean value that determines whether Quick Setup attaches
        /// policies to instances profiles already associated with the target instances. The default
        /// value is "<c>false</c>".
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetType</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) Determines how instances are targeted for local account deployments.
        /// Don't specify a value for this parameter if you're deploying to OUs. The valid values
        /// are <c>*</c>, <c>InstanceIds</c>, <c>ResourceGroups</c>, and <c>Tags</c>. Use <c>*</c>
        /// to target all instances in the account.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetInstances</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A comma separated list of instance IDs. You must provide a
        /// value for this parameter if you specify <c>InstanceIds</c> for the <c>TargetType</c>
        /// parameter.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetTagKey</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) The tag key assigned to the instances you want to target.
        /// You must provide a value for this parameter if you specify <c>Tags</c> for the <c>TargetType</c>
        /// parameter.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetTagValue</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) The value of the tag key assigned to the instances you want
        /// to target. You must provide a value for this parameter if you specify <c>Tags</c>
        /// for the <c>TargetType</c> parameter.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>ResourceGroupName</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) The name of the resource group associated with the instances
        /// you want to target. You must provide a value for this parameter if you specify <c>ResourceGroups</c>
        /// for the <c>TargetType</c> parameter.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetAccounts</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) The ID of the Amazon Web Services account initiating the configuration
        /// deployment. You only need to provide a value for this parameter if you want to deploy
        /// the configuration locally. A value must be provided for either <c>TargetAccounts</c>
        /// or <c>TargetOrganizationalUnits</c>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetOrganizationalUnits</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A comma separated list of organizational units (OUs) you want
        /// to deploy the configuration to.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetRegions</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) A comma separated list of Amazon Web Services Regions you
        /// want to deploy the configuration to.
        /// </para>
        ///  </li> </ul> </li> </ul> </dd> <dt>Patch Policy (Type: Amazon Web ServicesQuickSetupType-PatchPolicy)</dt>
        /// <dd> <ul> <li> 
        /// <para>
        ///  <c>PatchPolicyName</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) A name for the patch policy. The value you provide is applied
        /// to target Amazon EC2 instances as a tag.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>SelectedPatchBaselines</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) An array of JSON objects containing the information for the
        /// patch baselines to include in your patch policy.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>PatchBaselineUseDefault</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A boolean value that determines whether the selected patch
        /// baselines are all Amazon Web Services provided.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>ConfigurationOptionsPatchOperation</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) Determines whether target instances scan for available patches,
        /// or scan and install available patches. The valid values are <c>Scan</c> and <c>ScanAndInstall</c>.
        /// The default value for the parameter is <c>Scan</c>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>ConfigurationOptionsScanValue</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A cron expression that is used as the schedule for when instances
        /// scan for available patches.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>ConfigurationOptionsInstallValue</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A cron expression that is used as the schedule for when instances
        /// install available patches.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>ConfigurationOptionsScanNextInterval</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A boolean value that determines whether instances should scan
        /// for available patches at the next cron interval. The default value is "<c>false</c>".
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>ConfigurationOptionsInstallNextInterval</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A boolean value that determines whether instances should scan
        /// for available patches at the next cron interval. The default value is "<c>false</c>".
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>RebootOption</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) Determines whether instances are rebooted after patches are
        /// installed. Valid values are <c>RebootIfNeeded</c> and <c>NoReboot</c>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>IsPolicyAttachAllowed</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A boolean value that determines whether Quick Setup attaches
        /// policies to instances profiles already associated with the target instances. The default
        /// value is "<c>false</c>".
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>OutputLogEnableS3</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A boolean value that determines whether command output logs
        /// are sent to Amazon S3.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>OutputS3Location</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A JSON string containing information about the Amazon S3 bucket
        /// where you want to store the output details of the request.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>OutputS3BucketRegion</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) The Amazon Web Services Region where the Amazon S3 bucket
        /// you want Config to deliver command output to is located.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>OutputS3BucketName</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) The name of the Amazon S3 bucket you want Config to deliver
        /// command output to.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>OutputS3KeyPrefix</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) The key prefix you want to use in the custom Amazon S3 bucket.
        /// </para>
        ///  </li> </ul> </li> </ul> </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetType</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) Determines how instances are targeted for local account deployments.
        /// Don't specify a value for this parameter if you're deploying to OUs. The valid values
        /// are <c>*</c>, <c>InstanceIds</c>, <c>ResourceGroups</c>, and <c>Tags</c>. Use <c>*</c>
        /// to target all instances in the account.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetInstances</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A comma separated list of instance IDs. You must provide a
        /// value for this parameter if you specify <c>InstanceIds</c> for the <c>TargetType</c>
        /// parameter.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetTagKey</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) The tag key assigned to the instances you want to target.
        /// You must provide a value for this parameter if you specify <c>Tags</c> for the <c>TargetType</c>
        /// parameter.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetTagValue</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) The value of the tag key assigned to the instances you want
        /// to target. You must provide a value for this parameter if you specify <c>Tags</c>
        /// for the <c>TargetType</c> parameter.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>ResourceGroupName</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) The name of the resource group associated with the instances
        /// you want to target. You must provide a value for this parameter if you specify <c>ResourceGroups</c>
        /// for the <c>TargetType</c> parameter.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetAccounts</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) The ID of the Amazon Web Services account initiating the configuration
        /// deployment. You only need to provide a value for this parameter if you want to deploy
        /// the configuration locally. A value must be provided for either <c>TargetAccounts</c>
        /// or <c>TargetOrganizationalUnits</c>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetOrganizationalUnits</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Optional) A comma separated list of organizational units (OUs) you want
        /// to deploy the configuration to.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TargetRegions</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: (Required) A comma separated list of Amazon Web Services Regions you
        /// want to deploy the configuration to.
        /// </para>
        ///  </li> </ul> </li> </ul> </dd> </dl>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the Quick Setup configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property TypeVersion. 
        /// <para>
        /// The version of the Quick Setup type to use.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string TypeVersion
        {
            get { return this._typeVersion; }
            set { this._typeVersion = value; }
        }

        // Check to see if TypeVersion property is set
        internal bool IsSetTypeVersion()
        {
            return this._typeVersion != null;
        }

    }
}