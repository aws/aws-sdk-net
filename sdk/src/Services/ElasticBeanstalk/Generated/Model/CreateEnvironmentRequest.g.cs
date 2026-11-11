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
    /// Container for the parameters to the CreateEnvironment operation. Launches an Elastic
    /// Beanstalk environment for the specified application using the specified configuration.
    /// </summary>
    public partial class CreateEnvironmentRequest : AmazonElasticBeanstalkRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public CreateEnvironmentRequest() { }

        /// <summary>
        /// Instantiates CreateEnvironmentRequest with the parameterized properties
        /// </summary>
        /// <param name="applicationName">The name of the application that is associated with this environment.</param>
        /// <param name="environmentName">A unique name for the environment.   Constraint: Must be from 4 to 40 characters in length. The name can contain only letters, numbers, and hyphens. It can't start or end with a hyphen.   This name must be unique within a region in your account. If the specified name already exists in the region, Elastic Beanstalk returns an  <c>InvalidParameterValue</c> error.    If you don't specify the <c>CNAMEPrefix</c> parameter, the environment name becomes part of the CNAME, and therefore part of the visible URL for   your application.</param>
        public CreateEnvironmentRequest(string applicationName, string environmentName)
        {
            this.ApplicationName = applicationName;
            this.EnvironmentName = environmentName;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application that is associated with this environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property CNAMEPrefix. 
        /// <para>
        /// If specified, the environment attempts to use this value as the prefix for the CNAME
        /// in your Elastic Beanstalk environment URL. If not specified, the CNAME is generated
        /// automatically by appending a random alphanumeric string to the environment name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 63)]
        public string CNAMEPrefix { get; set; }

        /// <summary>
        /// Checks to see if the CNAMEPrefix property is set.
        /// </summary>
        internal bool IsSetCNAMEPrefix() => this.CNAMEPrefix != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Your description for this environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// A unique name for the environment.
        /// </para>
        ///  
        /// <para>
        /// Constraint: Must be from 4 to 40 characters in length. The name can contain only letters,
        /// numbers, and hyphens. It can't start or end with a hyphen. This name must be unique
        /// within a region in your account. If the specified name already exists in the region,
        /// Elastic Beanstalk returns an <c>InvalidParameterValue</c> error. 
        /// </para>
        ///  
        /// <para>
        /// If you don't specify the <c>CNAMEPrefix</c> parameter, the environment name becomes
        /// part of the CNAME, and therefore part of the visible URL for your application.
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
        /// the environment name parameter. See <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/environment-cfg-manifest.html">Environment
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
        /// Gets and sets the property OperationsRole. <important> 
        /// <para>
        /// The operations role feature of Elastic Beanstalk is in beta release and is subject
        /// to change.
        /// </para>
        ///  </important> 
        /// <para>
        /// The Amazon Resource Name (ARN) of an existing IAM role to be used as the environment's
        /// operations role. If specified, Elastic Beanstalk uses the operations role for permissions
        /// to downstream services during this call and during subsequent calls acting on this
        /// environment. To specify an operations role, you must have the <c>iam:PassRole</c>
        /// permission for the role.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string OperationsRole { get; set; }

        /// <summary>
        /// Checks to see if the OperationsRole property is set.
        /// </summary>
        internal bool IsSetOperationsRole() => this.OperationsRole != null;

        /// <summary>
        /// Gets and sets the property OptionSettings. 
        /// <para>
        /// If specified, Elastic Beanstalk sets the specified configuration options to the requested
        /// value in the configuration set for the new environment. These override the values
        /// obtained from the solution stack or the configuration template.
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
        /// set for this new environment.
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
        /// The Amazon Resource Name (ARN) of the custom platform to use with the environment.
        /// For more information, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/custom-platforms.html">Custom
        /// Platforms</a> in the <i>Elastic Beanstalk Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify <c>PlatformArn</c>, don't specify <c>SolutionStackName</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public string PlatformArn { get; set; }

        /// <summary>
        /// Checks to see if the PlatformArn property is set.
        /// </summary>
        internal bool IsSetPlatformArn() => this.PlatformArn != null;

        /// <summary>
        /// Gets and sets the property SolutionStackName. 
        /// <para>
        /// The name of an Elastic Beanstalk solution stack (platform version) to use with the
        /// environment. If specified, Elastic Beanstalk sets the configuration values to the
        /// default values associated with the specified solution stack. For a list of current
        /// solution stacks, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/platforms/platforms-supported.html">Elastic
        /// Beanstalk Supported Platforms</a> in the <i>Elastic Beanstalk Platforms</i> guide.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify <c>SolutionStackName</c>, don't specify <c>PlatformArn</c> or <c>TemplateName</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public string SolutionStackName { get; set; }

        /// <summary>
        /// Checks to see if the SolutionStackName property is set.
        /// </summary>
        internal bool IsSetSolutionStackName() => this.SolutionStackName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specifies the tags applied to resources in the environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the Elastic Beanstalk configuration template to use with the environment.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify <c>TemplateName</c>, then don't specify <c>SolutionStackName</c>.
        /// </para>
        ///  </note>
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
        /// Specifies the tier to use in creating this environment. The environment tier that
        /// you choose determines whether Elastic Beanstalk provisions resources on Amazon EC2
        /// instances or on an Amazon EKS cluster, and, for Amazon EC2, whether the environment
        /// serves HTTP(S) requests or processes background tasks from a queue.
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
        /// The name of the application version to deploy.
        /// </para>
        ///  
        /// <para>
        /// Default: If not specified, Elastic Beanstalk attempts to deploy the sample application.
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
