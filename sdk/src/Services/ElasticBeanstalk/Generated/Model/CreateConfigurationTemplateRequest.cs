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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
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
    /// Container for the parameters to the CreateConfigurationTemplate operation.
    /// Creates an AWS Elastic Beanstalk configuration template, associated with a specific
    /// Elastic Beanstalk application. You define application configuration settings in a
    /// configuration template. You can then use the configuration template to deploy different
    /// versions of the application with the same configuration settings.
    /// 
    ///  
    /// <para>
    /// Templates aren't associated with any environment. The <c>EnvironmentName</c> response
    /// element is always <c>null</c>.
    /// </para>
    ///  
    /// <para>
    /// Related Topics
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DescribeConfigurationOptions</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeConfigurationSettings</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListAvailableSolutionStacks</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateConfigurationTemplateRequest : AmazonElasticBeanstalkRequest
    {
        private string _applicationName;
        private string _description;
        private string _environmentId;
        private List<ConfigurationOptionSetting> _optionSettings = AWSConfigs.InitializeCollections ? new List<ConfigurationOptionSetting>() : null;
        private string _platformArn;
        private string _solutionStackName;
        private SourceConfiguration _sourceConfiguration;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _templateName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateConfigurationTemplateRequest() { }

        /// <summary>
        /// Instantiates CreateConfigurationTemplateRequest with the parameterized properties
        /// </summary>
        /// <param name="applicationName">The name of the Elastic Beanstalk application to associate with this configuration template.</param>
        /// <param name="templateName">The name of the configuration template. Constraint: This name must be unique per application.</param>
        public CreateConfigurationTemplateRequest(string applicationName, string templateName)
        {
            _applicationName = applicationName;
            _templateName = templateName;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the Elastic Beanstalk application to associate with this configuration
        /// template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for this configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
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
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The ID of an environment whose settings you want to use to create the configuration
        /// template. You must specify <c>EnvironmentId</c> if you don't specify <c>PlatformArn</c>,
        /// <c>SolutionStackName</c>, or <c>SourceConfiguration</c>.
        /// </para>
        /// </summary>
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property OptionSettings. 
        /// <para>
        /// Option values for the Elastic Beanstalk configuration, such as the instance type.
        /// If specified, these values override the values obtained from the solution stack or
        /// the source configuration template. For a complete list of Elastic Beanstalk configuration
        /// options, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/command-options.html">Option
        /// Values</a> in the <i>AWS Elastic Beanstalk Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConfigurationOptionSetting> OptionSettings
        {
            get { return this._optionSettings; }
            set { this._optionSettings = value; }
        }

        // Check to see if OptionSettings property is set
        internal bool IsSetOptionSettings()
        {
            return this._optionSettings != null && (this._optionSettings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PlatformArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the custom platform. For more information, see <a
        /// href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/custom-platforms.html">
        /// Custom Platforms</a> in the <i>AWS Elastic Beanstalk Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify <c>PlatformArn</c>, then don't specify <c>SolutionStackName</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public string PlatformArn
        {
            get { return this._platformArn; }
            set { this._platformArn = value; }
        }

        // Check to see if PlatformArn property is set
        internal bool IsSetPlatformArn()
        {
            return this._platformArn != null;
        }

        /// <summary>
        /// Gets and sets the property SolutionStackName. 
        /// <para>
        /// The name of an Elastic Beanstalk solution stack (platform version) that this configuration
        /// uses. For example, <c>64bit Amazon Linux 2013.09 running Tomcat 7 Java 7</c>. A solution
        /// stack specifies the operating system, runtime, and application server for a configuration
        /// template. It also determines the set of configuration options as well as the possible
        /// and default values. For more information, see <a href="https://docs.aws.amazon.com/elasticbeanstalk/latest/dg/concepts.platforms.html">Supported
        /// Platforms</a> in the <i>AWS Elastic Beanstalk Developer Guide</i>.
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
        public string SolutionStackName
        {
            get { return this._solutionStackName; }
            set { this._solutionStackName = value; }
        }

        // Check to see if SolutionStackName property is set
        internal bool IsSetSolutionStackName()
        {
            return this._solutionStackName != null;
        }

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
        public SourceConfiguration SourceConfiguration
        {
            get { return this._sourceConfiguration; }
            set { this._sourceConfiguration = value; }
        }

        // Check to see if SourceConfiguration property is set
        internal bool IsSetSourceConfiguration()
        {
            return this._sourceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specifies the tags applied to the configuration template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string TemplateName
        {
            get { return this._templateName; }
            set { this._templateName = value; }
        }

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this._templateName != null;
        }

    }
}