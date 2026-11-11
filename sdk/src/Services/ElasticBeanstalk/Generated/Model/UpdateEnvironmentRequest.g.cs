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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateEnvironment operation. Updates the environment
    /// description, deploys a new application version, updates the configuration settings
    /// to an entirely new configuration template, or updates select configuration option
    /// values in the running environment. <para> Attempting to update both the release and
    /// configuration is not allowed and Elastic Beanstalk returns an <c>InvalidParameterCombination</c>
    /// error. </para> <para> When updating the configuration settings to a new template or
    /// individual settings, a draft configuration is created and <a>DescribeConfigurationSettings</a>
    /// for this environment returns two setting descriptions with different <c>DeploymentStatus</c>
    /// values. </para>
    /// </summary>
    public partial class UpdateEnvironmentRequest : AmazonElasticBeanstalkRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public UpdateEnvironmentRequest() { }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application with which the environment is associated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// If this parameter is specified, Elastic Beanstalk updates the description of this
        /// environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The ID of the environment to update.
        /// </para>
        ///  
        /// <para>
        /// If no environment with this ID exists, Elastic Beanstalk returns an <c>InvalidParameterValue</c>
        /// error.
        /// </para>
        ///  
        /// <para>
        /// Condition: You must specify either this or an EnvironmentName, or both. If you do
        /// not specify either, Elastic Beanstalk returns <c>MissingRequiredParameter</c> error.
        /// 
        /// </para>
        /// </summary>
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of the environment to update. If no environment with this name exists, Elastic
        /// Beanstalk returns an <c>InvalidParameterValue</c> error. 
        /// </para>
        ///  
        /// <para>
        /// Condition: You must specify either this or an EnvironmentId, or both. If you do not
        /// specify either, Elastic Beanstalk returns <c>MissingRequiredParameter</c> error. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 40)]
        public string EnvironmentName { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentName property is set.
        /// </summary>
        internal bool IsSetEnvironmentName() => this.EnvironmentName != null;

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the group to which the target environment belongs. Specify a group name
        /// only if the environment's name is specified in an environment manifest and not with
        /// the environment name or environment ID parameters. See <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/environment-cfg-manifest.html">Environment
        /// Manifest (env.yaml)</a> for details.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 19)]
        public string GroupName { get; set; }

        /// <summary>
        /// Checks to see if the GroupName property is set.
        /// </summary>
        internal bool IsSetGroupName() => this.GroupName != null;

        /// <summary>
        /// Gets and sets the property OptionSettings. 
        /// <para>
        /// If specified, Elastic Beanstalk updates the configuration set associated with the
        /// running environment and sets the specified configuration options to the requested
        /// value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConfigurationOptionSetting> OptionSettings { get; set; } = AWSConfigs.InitializeCollections ? new List<ConfigurationOptionSetting>() : null;

        /// <summary>
        /// Checks to see if the OptionSettings property is set.
        /// </summary>
        internal bool IsSetOptionSettings() => this.OptionSettings != null && (this.OptionSettings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OptionsToRemove. 
        /// <para>
        /// A list of custom user-defined configuration options to remove from the configuration
        /// set for this environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OptionSpecification> OptionsToRemove { get; set; } = AWSConfigs.InitializeCollections ? new List<OptionSpecification>() : null;

        /// <summary>
        /// Checks to see if the OptionsToRemove property is set.
        /// </summary>
        internal bool IsSetOptionsToRemove() => this.OptionsToRemove != null && (this.OptionsToRemove.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PlatformArn. 
        /// <para>
        /// The ARN of the platform, if used.
        /// </para>
        /// </summary>
        public string PlatformArn { get; set; }

        /// <summary>
        /// Checks to see if the PlatformArn property is set.
        /// </summary>
        internal bool IsSetPlatformArn() => this.PlatformArn != null;

        /// <summary>
        /// Gets and sets the property SolutionStackName. 
        /// <para>
        /// This specifies the platform version that the environment will run after the environment
        /// is updated.
        /// </para>
        /// </summary>
        public string SolutionStackName { get; set; }

        /// <summary>
        /// Checks to see if the SolutionStackName property is set.
        /// </summary>
        internal bool IsSetSolutionStackName() => this.SolutionStackName != null;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// If this parameter is specified, Elastic Beanstalk deploys this configuration template
        /// to the environment. If no such configuration template is found, Elastic Beanstalk
        /// returns an <c>InvalidParameterValue</c> error. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// This specifies the tier to use to update the environment.
        /// </para>
        ///  
        /// <para>
        /// Condition: At this time, if you change the tier version, name, or type, Elastic Beanstalk
        /// returns <c>InvalidParameterValue</c> error. 
        /// </para>
        /// </summary>
        public EnvironmentTier Tier { get; set; }

        /// <summary>
        /// Checks to see if the Tier property is set.
        /// </summary>
        internal bool IsSetTier() => this.Tier != null;

        /// <summary>
        /// Gets and sets the property VersionLabel. 
        /// <para>
        /// If this parameter is specified, Elastic Beanstalk deploys the named application version
        /// to the environment. If no such application version is found, returns an <c>InvalidParameterValue</c>
        /// error. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string VersionLabel { get; set; }

        /// <summary>
        /// Checks to see if the VersionLabel property is set.
        /// </summary>
        internal bool IsSetVersionLabel() => this.VersionLabel != null;
    }
}
