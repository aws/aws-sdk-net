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
using Amazon.Runtime;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// <para> Describes the settings for a configuration set. </para>
    /// </summary>
    public partial class UpdateConfigurationTemplateResult : AmazonWebServiceResponse
    {
        
        private string solutionStackName;
        private string applicationName;
        private string templateName;
        private string description;
        private string environmentName;
        private ConfigurationDeploymentStatus deploymentStatus;
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
        public ConfigurationDeploymentStatus DeploymentStatus
        {
            get { return this.deploymentStatus; }
            set { this.deploymentStatus = value; }
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

        // Check to see if OptionSettings property is set
        internal bool IsSetOptionSettings()
        {
            return this.optionSettings.Count > 0;
        }
    }
}
