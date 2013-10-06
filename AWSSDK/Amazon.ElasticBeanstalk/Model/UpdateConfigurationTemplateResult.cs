/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// <para> Describes the settings for a configuration set. </para>
    /// </summary>
    public class UpdateConfigurationTemplateResult  
    {
        
        private string solutionStackName;
        private string applicationName;
        private string templateName;
        private string description;
        private string environmentName;
        private string deploymentStatus;
        private DateTime? dateCreated;
        private DateTime? dateUpdated;
        private List<ConfigurationOptionSetting> optionSettings = new List<ConfigurationOptionSetting>();

        /// <summary>
        /// The name of the solution stack this configuration set uses.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string SolutionStackName
        {
            get { return this.solutionStackName; }
            set { this.solutionStackName = value; }
        }

        /// <summary>
        /// Sets the SolutionStackName property
        /// </summary>
        /// <param name="solutionStackName">The value to set for the SolutionStackName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateConfigurationTemplateResult WithSolutionStackName(string solutionStackName)
        {
            this.solutionStackName = solutionStackName;
            return this;
        }
            

        // Check to see if SolutionStackName property is set
        internal bool IsSetSolutionStackName()
        {
            return this.solutionStackName != null;       
        }

        /// <summary>
        /// The name of the application associated with this configuration set.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ApplicationName
        {
            get { return this.applicationName; }
            set { this.applicationName = value; }
        }

        /// <summary>
        /// Sets the ApplicationName property
        /// </summary>
        /// <param name="applicationName">The value to set for the ApplicationName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateConfigurationTemplateResult WithApplicationName(string applicationName)
        {
            this.applicationName = applicationName;
            return this;
        }
            

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this.applicationName != null;       
        }

        /// <summary>
        /// If not <c>null</c>, the name of the configuration template for this configuration set.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TemplateName
        {
            get { return this.templateName; }
            set { this.templateName = value; }
        }

        /// <summary>
        /// Sets the TemplateName property
        /// </summary>
        /// <param name="templateName">The value to set for the TemplateName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateConfigurationTemplateResult WithTemplateName(string templateName)
        {
            this.templateName = templateName;
            return this;
        }
            

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this.templateName != null;       
        }

        /// <summary>
        /// Describes this configuration set.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 200</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateConfigurationTemplateResult WithDescription(string description)
        {
            this.description = description;
            return this;
        }
            

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;       
        }

        /// <summary>
        /// If not <c>null</c>, the name of the environment for this configuration set.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>4 - 23</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string EnvironmentName
        {
            get { return this.environmentName; }
            set { this.environmentName = value; }
        }

        /// <summary>
        /// Sets the EnvironmentName property
        /// </summary>
        /// <param name="environmentName">The value to set for the EnvironmentName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateConfigurationTemplateResult WithEnvironmentName(string environmentName)
        {
            this.environmentName = environmentName;
            return this;
        }
            

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this.environmentName != null;       
        }

        /// <summary>
        /// If this configuration set is associated with an environment, the <c>DeploymentStatus</c> parameter indicates the deployment status of this
        /// configuration set: <enumValues> <value name="null"> <c>null</c>: This configuration is not associated with a running environment. </value>
        /// <value name="pending"> <c>pending</c>: This is a draft configuration that is not deployed to the associated environment but is in the
        /// process of deploying. </value> <value name="deployed"> <c>deployed</c>: This is the configuration that is currently deployed to the
        /// associated running environment. </value> <value name="failed"> <c>failed</c>: This is a draft configuration, that failed to successfully
        /// deploy. </value> </enumValues> <ul> <li> <c>null</c>: This configuration is not associated with a running environment. </li> <li>
        /// <c>pending</c>: This is a draft configuration that is not deployed to the associated environment but is in the process of deploying. </li>
        /// <li> <c>deployed</c>: This is the configuration that is currently deployed to the associated running environment. </li> <li> <c>failed</c>:
        /// This is a draft configuration that failed to successfully deploy. </li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>deployed, pending, failed</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string DeploymentStatus
        {
            get { return this.deploymentStatus; }
            set { this.deploymentStatus = value; }
        }

        /// <summary>
        /// Sets the DeploymentStatus property
        /// </summary>
        /// <param name="deploymentStatus">The value to set for the DeploymentStatus property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateConfigurationTemplateResult WithDeploymentStatus(string deploymentStatus)
        {
            this.deploymentStatus = deploymentStatus;
            return this;
        }
            

        // Check to see if DeploymentStatus property is set
        internal bool IsSetDeploymentStatus()
        {
            return this.deploymentStatus != null;       
        }

        /// <summary>
        /// The date (in UTC time) when this configuration set was created.
        ///  
        /// </summary>
        public DateTime DateCreated
        {
            get { return this.dateCreated ?? default(DateTime); }
            set { this.dateCreated = value; }
        }

        /// <summary>
        /// Sets the DateCreated property
        /// </summary>
        /// <param name="dateCreated">The value to set for the DateCreated property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateConfigurationTemplateResult WithDateCreated(DateTime dateCreated)
        {
            this.dateCreated = dateCreated;
            return this;
        }
            

        // Check to see if DateCreated property is set
        internal bool IsSetDateCreated()
        {
            return this.dateCreated.HasValue;       
        }

        /// <summary>
        /// The date (in UTC time) when this configuration set was last modified.
        ///  
        /// </summary>
        public DateTime DateUpdated
        {
            get { return this.dateUpdated ?? default(DateTime); }
            set { this.dateUpdated = value; }
        }

        /// <summary>
        /// Sets the DateUpdated property
        /// </summary>
        /// <param name="dateUpdated">The value to set for the DateUpdated property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateConfigurationTemplateResult WithDateUpdated(DateTime dateUpdated)
        {
            this.dateUpdated = dateUpdated;
            return this;
        }
            

        // Check to see if DateUpdated property is set
        internal bool IsSetDateUpdated()
        {
            return this.dateUpdated.HasValue;       
        }

        /// <summary>
        /// A list of the configuration options and their values in this configuration set.
        ///  
        /// </summary>
        public List<ConfigurationOptionSetting> OptionSettings
        {
            get { return this.optionSettings; }
            set { this.optionSettings = value; }
        }
        /// <summary>
        /// Adds elements to the OptionSettings collection
        /// </summary>
        /// <param name="optionSettings">The values to add to the OptionSettings collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateConfigurationTemplateResult WithOptionSettings(params ConfigurationOptionSetting[] optionSettings)
        {
            foreach (ConfigurationOptionSetting element in optionSettings)
            {
                this.optionSettings.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the OptionSettings collection
        /// </summary>
        /// <param name="optionSettings">The values to add to the OptionSettings collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateConfigurationTemplateResult WithOptionSettings(IEnumerable<ConfigurationOptionSetting> optionSettings)
        {
            foreach (ConfigurationOptionSetting element in optionSettings)
            {
                this.optionSettings.Add(element);
            }

            return this;
        }

        // Check to see if OptionSettings property is set
        internal bool IsSetOptionSettings()
        {
            return this.optionSettings.Count > 0;       
        }
    }
}
