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
    /// Container for the parameters to the CreateConfigurationTemplate operation. Creates
    /// an Elastic Beanstalk configuration template, associated with a specific Elastic Beanstalk
    /// application. You define application configuration settings in a configuration template.
    /// You can then use the configuration template to deploy different versions of the application
    /// with the same configuration settings. <para> Templates aren't associated with any
    /// environment. The <c>EnvironmentName</c> response element is always <c>null</c>. </para>
    /// <para> Related Topics </para> <ul> <li> <para> <a>DescribeConfigurationOptions</a>
    /// </para> </li> <li> <para> <a>DescribeConfigurationSettings</a> </para> </li> <li>
    /// <para> <a>ListAvailableSolutionStacks</a> </para> </li> </ul>
    /// </summary>
    public partial class CreateConfigurationTemplateRequest : AmazonElasticBeanstalkRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public CreateConfigurationTemplateRequest() { }

        /// <summary>
        /// Instantiates CreateConfigurationTemplateRequest with the parameterized properties
        /// </summary>
        /// <param name="applicationName">The name of the Elastic Beanstalk application to associate with this configuration   template.</param>
        /// <param name="templateName">The name of the configuration template.   Constraint: This name must be unique per application.</param>
        public CreateConfigurationTemplateRequest(string applicationName, string templateName)
        {
            this.ApplicationName = applicationName;
            this.TemplateName = templateName;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the Elastic Beanstalk application to associate with this configuration
        /// template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for this configuration.
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
        /// The ID of an environment whose settings you want to use to create the configuration
        /// template. You must specify <c>EnvironmentId</c> if you don't specify <c>PlatformArn</c>,
        /// <c>SolutionStackName</c>, or <c>SourceConfiguration</c>.
        /// </para>
        /// </summary>
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property OptionSettings. 
        /// <para>
        /// Option values for the Elastic Beanstalk configuration, such as the instance type.
        /// If specified, these values override the values obtained from the solution stack or
        /// the source configuration template. For a complete list of Elastic Beanstalk configuration
        /// options, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/command-options.html">Option
        /// Values</a> in the <i>Elastic Beanstalk Developer Guide</i>.
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
        /// Gets and sets the property PlatformArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the custom platform. For more information, see <a
        /// href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/custom-platforms.html">
        /// Custom Platforms</a> in the <i>Elastic Beanstalk Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify <c>PlatformArn</c>, then don't specify <c>SolutionStackName</c>.
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
        /// The name of an Elastic Beanstalk solution stack (platform version) that this configuration
        /// uses. For example, <c>64bit Amazon Linux 2013.09 running Tomcat 7 Java 7</c>. A solution
        /// stack specifies the operating system, runtime, and application server for a configuration
        /// template. It also determines the set of configuration options as well as the possible
        /// and default values. For more information, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/concepts.platforms.html">Supported
        /// Platforms</a> in the <i>Elastic Beanstalk Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You must specify <c>SolutionStackName</c> if you don't specify <c>PlatformArn</c>,
        /// <c>EnvironmentId</c>, or <c>SourceConfiguration</c>.
        /// </para>
        ///  
        /// <para>
        /// Use the <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/api/API_ListAvailableSolutionStacks.html">
        /// <c>ListAvailableSolutionStacks</c> </a> API to obtain a list of available solution
        /// stacks.
        /// </para>
        /// </summary>
        public string SolutionStackName { get; set; }

        /// <summary>
        /// Checks to see if the SolutionStackName property is set.
        /// </summary>
        internal bool IsSetSolutionStackName() => this.SolutionStackName != null;

        /// <summary>
        /// Gets and sets the property SourceConfiguration. 
        /// <para>
        /// An Elastic Beanstalk configuration template to base this one on. If specified, Elastic
        /// Beanstalk uses the configuration values from the specified configuration template
        /// to create a new configuration.
        /// </para>
        ///  
        /// <para>
        /// Values specified in <c>OptionSettings</c> override any values obtained from the <c>SourceConfiguration</c>.
        /// </para>
        ///  
        /// <para>
        /// You must specify <c>SourceConfiguration</c> if you don't specify <c>PlatformArn</c>,
        /// <c>EnvironmentId</c>, or <c>SolutionStackName</c>.
        /// </para>
        ///  
        /// <para>
        /// Constraint: If both solution stack name and source configuration are specified, the
        /// solution stack of the source configuration template must match the specified solution
        /// stack name.
        /// </para>
        /// </summary>
        public SourceConfiguration SourceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SourceConfiguration property is set.
        /// </summary>
        internal bool IsSetSourceConfiguration() => this.SourceConfiguration != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specifies the tags applied to the configuration template.
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
        /// The name of the configuration template.
        /// </para>
        ///  
        /// <para>
        /// Constraint: This name must be unique per application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;
    }
}
