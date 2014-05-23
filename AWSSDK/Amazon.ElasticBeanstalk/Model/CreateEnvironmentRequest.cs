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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEnvironment operation.
    /// Launches an environment for the specified application using         the specified
    /// configuration.
    /// </summary>
    public partial class CreateEnvironmentRequest : AmazonWebServiceRequest
    {
        private string _applicationName;
        private string _cNAMEPrefix;
        private string _description;
        private string _environmentName;
        private List<ConfigurationOptionSetting> _optionSettings = new List<ConfigurationOptionSetting>();
        private List<OptionSpecification> _optionsToRemove = new List<OptionSpecification>();
        private string _solutionStackName;
        private List<Tag> _tags = new List<Tag>();
        private string _templateName;
        private EnvironmentTier _tier;
        private string _versionLabel;


        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        ///          The name of the application that contains the version to be deployed.   
        ///   
        /// </para>
        ///       
        /// <para>
        ///          If no application is found with this name, <code>CreateEnvironment</code>
        ///         returns an         <code>InvalidParameterValue</code>         error.     
        /// 
        /// </para>
        /// </summary>
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }


        /// <summary>
        /// Sets the ApplicationName property
        /// </summary>
        /// <param name="applicationName">The value to set for the ApplicationName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateEnvironmentRequest WithApplicationName(string applicationName)
        {
            this._applicationName = applicationName;
            return this;
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }


        /// <summary>
        /// Gets and sets the property CNAMEPrefix. 
        /// <para>
        ///          If specified, the environment attempts to use this value as the prefix for
        /// the         CNAME.         If not specified, the CNAME is generated automatically
        /// by appending a random alphanumeric string to the environment name.        
        /// </para>
        /// </summary>
        public string CNAMEPrefix
        {
            get { return this._cNAMEPrefix; }
            set { this._cNAMEPrefix = value; }
        }


        /// <summary>
        /// Sets the CNAMEPrefix property
        /// </summary>
        /// <param name="cNAMEPrefix">The value to set for the CNAMEPrefix property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateEnvironmentRequest WithCNAMEPrefix(string cNAMEPrefix)
        {
            this._cNAMEPrefix = cNAMEPrefix;
            return this;
        }

        // Check to see if CNAMEPrefix property is set
        internal bool IsSetCNAMEPrefix()
        {
            return this._cNAMEPrefix != null;
        }


        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Describes this environment.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }


        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateEnvironmentRequest WithDescription(string description)
        {
            this._description = description;
            return this;
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }


        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        ///          A unique name for the deployment environment. Used in         the application
        ///         URL.         
        /// </para>
        ///       
        /// <para>
        /// Constraint: Must be from 4 to 23 characters         in length. The name can      
        ///   contain only letters, numbers, and hyphens. It cannot start         or end with
        ///         a hyphen. This name must be unique in your account.         If the specified
        ///         name already exists, AWS Elastic Beanstalk         returns an         <code>InvalidParameterValue</code>
        ///         error.      
        /// </para>
        ///       
        /// <para>
        /// Default: If the CNAME parameter is not specified, the environment name         becomes
        /// part of the CNAME, and therefore         part of the visible URL for your application.
        /// </para>
        /// </summary>
        public string EnvironmentName
        {
            get { return this._environmentName; }
            set { this._environmentName = value; }
        }


        /// <summary>
        /// Sets the EnvironmentName property
        /// </summary>
        /// <param name="environmentName">The value to set for the EnvironmentName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateEnvironmentRequest WithEnvironmentName(string environmentName)
        {
            this._environmentName = environmentName;
            return this;
        }

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this._environmentName != null;
        }


        /// <summary>
        /// Gets and sets the property OptionSettings. 
        /// <para>
        ///          If specified, AWS Elastic Beanstalk         sets the specified configuration
        /// options to the requested value in         the configuration set for the new environment.
        /// These override the values         obtained from         the solution stack or the
        /// configuration template.      
        /// </para>
        /// </summary>
        public List<ConfigurationOptionSetting> OptionSettings
        {
            get { return this._optionSettings; }
            set { this._optionSettings = value; }
        }

        /// <summary>
        /// Sets the OptionSettings property
        /// </summary>
        /// <param name="optionSettings">The values to add to the OptionSettings collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateEnvironmentRequest WithOptionSettings(params ConfigurationOptionSetting[] optionSettings)
        {
            foreach (var element in optionSettings)
            {
                this._optionSettings.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the OptionSettings property
        /// </summary>
        /// <param name="optionSettings">The values to add to the OptionSettings collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateEnvironmentRequest WithOptionSettings(IEnumerable<ConfigurationOptionSetting> optionSettings)
        {
            foreach (var element in optionSettings)
            {
                this._optionSettings.Add(element);
            }
            return this;
        }
        // Check to see if OptionSettings property is set
        internal bool IsSetOptionSettings()
        {
            return this._optionSettings != null && this._optionSettings.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property OptionsToRemove. 
        /// <para>
        ///          A list of custom user-defined configuration options to remove from the  
        ///       configuration set for this new environment.        
        /// </para>
        /// </summary>
        public List<OptionSpecification> OptionsToRemove
        {
            get { return this._optionsToRemove; }
            set { this._optionsToRemove = value; }
        }

        /// <summary>
        /// Sets the OptionsToRemove property
        /// </summary>
        /// <param name="optionsToRemove">The values to add to the OptionsToRemove collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateEnvironmentRequest WithOptionsToRemove(params OptionSpecification[] optionsToRemove)
        {
            foreach (var element in optionsToRemove)
            {
                this._optionsToRemove.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the OptionsToRemove property
        /// </summary>
        /// <param name="optionsToRemove">The values to add to the OptionsToRemove collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateEnvironmentRequest WithOptionsToRemove(IEnumerable<OptionSpecification> optionsToRemove)
        {
            foreach (var element in optionsToRemove)
            {
                this._optionsToRemove.Add(element);
            }
            return this;
        }
        // Check to see if OptionsToRemove property is set
        internal bool IsSetOptionsToRemove()
        {
            return this._optionsToRemove != null && this._optionsToRemove.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property SolutionStackName. 
        /// <para>
        ///          This is an alternative to specifying a configuration name.         If specified,
        /// AWS Elastic Beanstalk         sets the configuration values to the default values
        ///         associated with the specified solution stack.      
        /// </para>
        ///       
        /// <para>
        ///          Condition: You must specify either this or a         <code>TemplateName</code>,
        ///         but not both.         If you specify both, AWS Elastic Beanstalk         returns
        /// an         <code>InvalidParameterCombination</code>         error. If you do not specify
        /// either, AWS Elastic Beanstalk         returns a         <code>MissingRequiredParameter</code>
        ///         error.      
        /// </para>
        /// </summary>
        public string SolutionStackName
        {
            get { return this._solutionStackName; }
            set { this._solutionStackName = value; }
        }


        /// <summary>
        /// Sets the SolutionStackName property
        /// </summary>
        /// <param name="solutionStackName">The value to set for the SolutionStackName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateEnvironmentRequest WithSolutionStackName(string solutionStackName)
        {
            this._solutionStackName = solutionStackName;
            return this;
        }

        // Check to see if SolutionStackName property is set
        internal bool IsSetSolutionStackName()
        {
            return this._solutionStackName != null;
        }


        /// <summary>
        /// Gets and sets the property Tags.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        /// <summary>
        /// Sets the Tags property
        /// </summary>
        /// <param name="tags">The values to add to the Tags collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateEnvironmentRequest WithTags(params Tag[] tags)
        {
            foreach (var element in tags)
            {
                this._tags.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Tags property
        /// </summary>
        /// <param name="tags">The values to add to the Tags collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateEnvironmentRequest WithTags(IEnumerable<Tag> tags)
        {
            foreach (var element in tags)
            {
                this._tags.Add(element);
            }
            return this;
        }
        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        ///          The name of the configuration template to use in         deployment. If no
        ///         configuration template is found with this         name, AWS Elastic Beanstalk
        ///         returns an         <code>InvalidParameterValue</code>         error.     
        /// 
        /// </para>
        ///       
        /// <para>
        ///          Condition: You must specify either this parameter or a         <code>SolutionStackName</code>,
        ///         but not both.         If you specify both, AWS Elastic Beanstalk         returns
        /// an         <code>InvalidParameterCombination</code>         error. If you do not specify
        /// either, AWS Elastic Beanstalk         returns a         <code>MissingRequiredParameter</code>
        ///         error.      
        /// </para>
        /// </summary>
        public string TemplateName
        {
            get { return this._templateName; }
            set { this._templateName = value; }
        }


        /// <summary>
        /// Sets the TemplateName property
        /// </summary>
        /// <param name="templateName">The value to set for the TemplateName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateEnvironmentRequest WithTemplateName(string templateName)
        {
            this._templateName = templateName;
            return this;
        }

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this._templateName != null;
        }


        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        ///          This specifies the tier to use for creating this environment.      
        /// </para>
        /// </summary>
        public EnvironmentTier Tier
        {
            get { return this._tier; }
            set { this._tier = value; }
        }


        /// <summary>
        /// Sets the Tier property
        /// </summary>
        /// <param name="tier">The value to set for the Tier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateEnvironmentRequest WithTier(EnvironmentTier tier)
        {
            this._tier = tier;
            return this;
        }

        // Check to see if Tier property is set
        internal bool IsSetTier()
        {
            return this._tier != null;
        }


        /// <summary>
        /// Gets and sets the property VersionLabel. 
        /// <para>
        /// The name of the application version to deploy.
        /// </para>
        ///       
        /// <para>
        ///          If the specified application has no associated application versions, AWS
        /// Elastic Beanstalk         <code>UpdateEnvironment</code> returns an         <code>InvalidParameterValue</code>
        ///         error.      
        /// </para>
        ///       
        /// <para>
        ///          Default: If not specified, AWS Elastic Beanstalk         attempts to launch
        /// the most recently created         application version sample application in the container.
        ///      
        /// </para>
        /// </summary>
        public string VersionLabel
        {
            get { return this._versionLabel; }
            set { this._versionLabel = value; }
        }


        /// <summary>
        /// Sets the VersionLabel property
        /// </summary>
        /// <param name="versionLabel">The value to set for the VersionLabel property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateEnvironmentRequest WithVersionLabel(string versionLabel)
        {
            this._versionLabel = versionLabel;
            return this;
        }

        // Check to see if VersionLabel property is set
        internal bool IsSetVersionLabel()
        {
            return this._versionLabel != null;
        }

    }
}