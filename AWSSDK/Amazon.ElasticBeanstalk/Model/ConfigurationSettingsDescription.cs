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
    /// Describes the settings for a configuration set.
    /// </summary>
    public partial class ConfigurationSettingsDescription
    {
        private string _applicationName;
        private DateTime? _dateCreated;
        private DateTime? _dateUpdated;
        private string _deploymentStatus;
        private string _description;
        private string _environmentName;
        private List<ConfigurationOptionSetting> _optionSettings = new List<ConfigurationOptionSetting>();
        private string _solutionStackName;
        private string _templateName;


        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        ///          The name of the application associated with this configuration set.        
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
        public ConfigurationSettingsDescription WithApplicationName(string applicationName)
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
        /// Gets and sets the property DateCreated. 
        /// <para>
        ///          The date (in UTC time) when this configuration set was created.        
        /// </para>
        /// </summary>
        public DateTime DateCreated
        {
            get { return this._dateCreated.GetValueOrDefault(); }
            set { this._dateCreated = value; }
        }


        /// <summary>
        /// Sets the DateCreated property
        /// </summary>
        /// <param name="dateCreated">The value to set for the DateCreated property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ConfigurationSettingsDescription WithDateCreated(DateTime dateCreated)
        {
            this._dateCreated = dateCreated;
            return this;
        }

        // Check to see if DateCreated property is set
        internal bool IsSetDateCreated()
        {
            return this._dateCreated.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property DateUpdated. 
        /// <para>
        ///          The date (in UTC time) when this configuration set was last modified.        
        /// </para>
        /// </summary>
        public DateTime DateUpdated
        {
            get { return this._dateUpdated.GetValueOrDefault(); }
            set { this._dateUpdated = value; }
        }


        /// <summary>
        /// Sets the DateUpdated property
        /// </summary>
        /// <param name="dateUpdated">The value to set for the DateUpdated property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ConfigurationSettingsDescription WithDateUpdated(DateTime dateUpdated)
        {
            this._dateUpdated = dateUpdated;
            return this;
        }

        // Check to see if DateUpdated property is set
        internal bool IsSetDateUpdated()
        {
            return this._dateUpdated.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property DeploymentStatus. 
        /// <para>
        ///          If this configuration set is associated with an environment, the        
        ///  <code>DeploymentStatus</code> parameter indicates         the deployment status of
        /// this configuration set:        
        /// </para>
        ///       <enumValues>         <value name="null">            
        /// <para>
        ///                <code>null</code>: This configuration is not associated with a running
        ///               environment.            
        /// </para>
        ///          </value>         <value name="pending">            
        /// <para>
        ///                <code>pending</code>: This is a draft configuration that is not deployed
        ///               to the               associated environment but is in the process of
        /// deploying.            
        /// </para>
        ///          </value>         <value name="deployed">            
        /// <para>
        ///                <code>deployed</code>: This is the configuration that is currently
        /// deployed               to the associated running environment.            
        /// </para>
        ///          </value>         <value name="failed">            
        /// <para>
        ///                <code>failed</code>: This is a draft configuration, that          
        ///     failed to successfully deploy.            
        /// </para>
        ///          </value>      </enumValues>      <ul>         <li>            <code>null</code>:
        /// This configuration is not associated with a running            environment.      
        ///   </li>         <li>            <code>pending</code>: This is a draft configuration
        /// that is not deployed            to the associated environment but is in the process
        /// of deploying.         </li>         <li>            <code>deployed</code>: This is
        /// the configuration that is currently deployed            to the associated running
        /// environment.         </li>         <li>            <code>failed</code>: This is a
        /// draft configuration that failed to            successfully deploy.         </li> 
        ///     </ul>
        /// </summary>
        public string DeploymentStatus
        {
            get { return this._deploymentStatus; }
            set { this._deploymentStatus = value; }
        }


        /// <summary>
        /// Sets the DeploymentStatus property
        /// </summary>
        /// <param name="deploymentStatus">The value to set for the DeploymentStatus property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ConfigurationSettingsDescription WithDeploymentStatus(string deploymentStatus)
        {
            this._deploymentStatus = deploymentStatus;
            return this;
        }

        // Check to see if DeploymentStatus property is set
        internal bool IsSetDeploymentStatus()
        {
            return this._deploymentStatus != null;
        }


        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///          Describes this configuration set.        
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
        public ConfigurationSettingsDescription WithDescription(string description)
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
        ///          If not         <code>null</code>, the name of the environment for this configuration
        /// set.      
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
        public ConfigurationSettingsDescription WithEnvironmentName(string environmentName)
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
        ///          A list of the configuration options and their values in this configuration
        ///         set.        
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
        public ConfigurationSettingsDescription WithOptionSettings(params ConfigurationOptionSetting[] optionSettings)
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
        public ConfigurationSettingsDescription WithOptionSettings(IEnumerable<ConfigurationOptionSetting> optionSettings)
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
        /// Gets and sets the property SolutionStackName. 
        /// <para>
        ///          The name of the solution stack this configuration set uses.        
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
        public ConfigurationSettingsDescription WithSolutionStackName(string solutionStackName)
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
        /// Gets and sets the property TemplateName. 
        /// <para>
        ///          If not         <code>null</code>, the name of the configuration template
        /// for this configuration set.      
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
        public ConfigurationSettingsDescription WithTemplateName(string templateName)
        {
            this._templateName = templateName;
            return this;
        }

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this._templateName != null;
        }

    }
}