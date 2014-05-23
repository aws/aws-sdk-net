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
    /// Container for the parameters to the UpdateEnvironment operation.
    /// Updates the environment description, deploys a new application         version,
    /// updates the configuration settings to an entirely new configuration         template,
    /// or updates select configuration option values in the running         environment.        
    /// 
    ///       
    /// <para>
    ///          Attempting to update both the release and configuration is         not allowed
    /// and AWS Elastic Beanstalk         returns an         <code>InvalidParameterCombination</code>
    ///         error.      
    /// </para>
    ///       
    /// <para>
    ///          When updating the configuration settings to a new template or         individual
    /// settings,         a draft configuration is created and         <a>DescribeConfigurationSettings</a>
    ///         for this         environment returns two setting descriptions with different
    ///         <code>DeploymentStatus</code>         values.      
    /// </para>
    /// </summary>
    public partial class UpdateEnvironmentRequest : AmazonWebServiceRequest
    {
        private string _description;
        private string _environmentId;
        private string _environmentName;
        private List<ConfigurationOptionSetting> _optionSettings = new List<ConfigurationOptionSetting>();
        private List<OptionSpecification> _optionsToRemove = new List<OptionSpecification>();
        private string _templateName;
        private EnvironmentTier _tier;
        private string _versionLabel;


        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///          If this parameter is specified, AWS Elastic Beanstalk         updates the
        /// description         of this environment.      
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
        public UpdateEnvironmentRequest WithDescription(string description)
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
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The ID of the environment to update.
        /// </para>
        ///       
        /// <para>
        ///          If no environment with this ID exists, AWS Elastic Beanstalk         returns
        /// an         <code>InvalidParameterValue</code>         error.      
        /// </para>
        ///       
        /// <para>
        ///          Condition: You must specify either this or an EnvironmentName, or both. 
        ///          If you do not specify either, AWS Elastic Beanstalk returns <code>MissingRequiredParameter</code>
        /// error.        
        /// </para>
        /// </summary>
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }


        /// <summary>
        /// Sets the EnvironmentId property
        /// </summary>
        /// <param name="environmentId">The value to set for the EnvironmentId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateEnvironmentRequest WithEnvironmentId(string environmentId)
        {
            this._environmentId = environmentId;
            return this;
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }


        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The         name of the environment to update. If no environment with this name  
        ///       exists,       AWS Elastic Beanstalk         returns an         <code>InvalidParameterValue</code>
        ///         error.      
        /// </para>
        ///       
        /// <para>
        ///          Condition: You must specify either this or an EnvironmentId, or both.   
        ///        If you do not specify either, AWS Elastic Beanstalk returns <code>MissingRequiredParameter</code>
        /// error.        
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
        public UpdateEnvironmentRequest WithEnvironmentName(string environmentName)
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
        ///          If specified, AWS Elastic Beanstalk         updates the configuration set
        /// associated with         the running environment and sets the specified configuration
        /// options to         the requested value.      
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
        public UpdateEnvironmentRequest WithOptionSettings(params ConfigurationOptionSetting[] optionSettings)
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
        public UpdateEnvironmentRequest WithOptionSettings(IEnumerable<ConfigurationOptionSetting> optionSettings)
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
        ///       configuration set for this environment.        
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
        public UpdateEnvironmentRequest WithOptionsToRemove(params OptionSpecification[] optionsToRemove)
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
        public UpdateEnvironmentRequest WithOptionsToRemove(IEnumerable<OptionSpecification> optionsToRemove)
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
        /// Gets and sets the property TemplateName. 
        /// <para>
        ///          If this parameter is specified, AWS Elastic Beanstalk         deploys this
        ///         configuration template to the environment. If no such         configuration
        ///         template is found, AWS Elastic Beanstalk         returns an         <code>InvalidParameterValue</code>
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
        public UpdateEnvironmentRequest WithTemplateName(string templateName)
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
        ///          This specifies the tier to use to update the environment.      
        /// </para>
        ///       
        /// <para>
        ///          Condition: You can only update the tier version for an environment. If you
        /// change the name of the type,          AWS Elastic Beanstalk returns <code>InvalidParameterValue</code>
        /// error.      
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
        public UpdateEnvironmentRequest WithTier(EnvironmentTier tier)
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
        ///          If this parameter is specified, AWS Elastic Beanstalk         deploys the
        /// named         application version to the environment. If no such         application
        /// version is         found, returns an         <code>InvalidParameterValue</code>  
        ///       error.      
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
        public UpdateEnvironmentRequest WithVersionLabel(string versionLabel)
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