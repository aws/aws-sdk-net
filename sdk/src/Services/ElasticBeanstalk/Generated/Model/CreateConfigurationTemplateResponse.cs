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

/*
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
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
    public partial class CreateConfigurationTemplateResponse : AmazonWebServiceResponse
    {
        private string _applicationName;
        private DateTime? _dateCreated;
        private DateTime? _dateUpdated;
        private ConfigurationDeploymentStatus _deploymentStatus;
        private string _description;
        private string _environmentName;
        private List<ConfigurationOptionSetting> _optionSettings = new List<ConfigurationOptionSetting>();
        private string _solutionStackName;
        private string _templateName;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        ///  The name of the application associated with this configuration set. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DateCreated. 
        /// <para>
        ///  The date (in UTC time) when this configuration set was created. 
        /// </para>
        /// </summary>
        public DateTime DateCreated
        {
            get { return this._dateCreated.GetValueOrDefault(); }
            set { this._dateCreated = value; }
        }

        // Check to see if DateCreated property is set
        internal bool IsSetDateCreated()
        {
            return this._dateCreated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DateUpdated. 
        /// <para>
        ///  The date (in UTC time) when this configuration set was last modified. 
        /// </para>
        /// </summary>
        public DateTime DateUpdated
        {
            get { return this._dateUpdated.GetValueOrDefault(); }
            set { this._dateUpdated = value; }
        }

        // Check to see if DateUpdated property is set
        internal bool IsSetDateUpdated()
        {
            return this._dateUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeploymentStatus. 
        /// <para>
        ///  If this configuration set is associated with an environment, the <code>DeploymentStatus</code>
        /// parameter indicates the deployment status of this configuration set: 
        /// </para>
        ///  <enumValues> <value name="null"> 
        /// <para>
        ///  <code>null</code>: This configuration is not associated with a running environment.
        /// 
        /// </para>
        ///  </value> <value name="pending"> 
        /// <para>
        ///  <code>pending</code>: This is a draft configuration that is not deployed to the associated
        /// environment but is in the process of deploying. 
        /// </para>
        ///  </value> <value name="deployed"> 
        /// <para>
        ///  <code>deployed</code>: This is the configuration that is currently deployed to the
        /// associated running environment. 
        /// </para>
        ///  </value> <value name="failed"> 
        /// <para>
        ///  <code>failed</code>: This is a draft configuration, that failed to successfully deploy.
        /// 
        /// </para>
        ///  </value> </enumValues> <ul> <li> <code>null</code>: This configuration is not associated
        /// with a running environment. </li> <li> <code>pending</code>: This is a draft configuration
        /// that is not deployed to the associated environment but is in the process of deploying.
        /// </li> <li> <code>deployed</code>: This is the configuration that is currently deployed
        /// to the associated running environment. </li> <li> <code>failed</code>: This is a draft
        /// configuration that failed to successfully deploy. </li> </ul>
        /// </summary>
        public ConfigurationDeploymentStatus DeploymentStatus
        {
            get { return this._deploymentStatus; }
            set { this._deploymentStatus = value; }
        }

        // Check to see if DeploymentStatus property is set
        internal bool IsSetDeploymentStatus()
        {
            return this._deploymentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  Describes this configuration set. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        ///  If not <code>null</code>, the name of the environment for this configuration set.
        /// 
        /// </para>
        /// </summary>
        public string EnvironmentName
        {
            get { return this._environmentName; }
            set { this._environmentName = value; }
        }

        // Check to see if EnvironmentName property is set
        internal bool IsSetEnvironmentName()
        {
            return this._environmentName != null;
        }

        /// <summary>
        /// Gets and sets the property OptionSettings. 
        /// <para>
        ///  A list of the configuration options and their values in this configuration set. 
        /// </para>
        /// </summary>
        public List<ConfigurationOptionSetting> OptionSettings
        {
            get { return this._optionSettings; }
            set { this._optionSettings = value; }
        }

        // Check to see if OptionSettings property is set
        internal bool IsSetOptionSettings()
        {
            return this._optionSettings != null && this._optionSettings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SolutionStackName. 
        /// <para>
        ///  The name of the solution stack this configuration set uses. 
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
        /// Gets and sets the property TemplateName. 
        /// <para>
        ///  If not <code>null</code>, the name of the configuration template for this configuration
        /// set. 
        /// </para>
        /// </summary>
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