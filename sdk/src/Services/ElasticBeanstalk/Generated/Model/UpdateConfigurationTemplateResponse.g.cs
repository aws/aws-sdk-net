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
    /// This is the response object from the UpdateConfigurationTemplate operation.
    /// </summary>
    public partial class UpdateConfigurationTemplateResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application associated with this configuration set.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The date (in UTC time) when this configuration set was created.
        /// </para>
        /// </summary>
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// Checks to see if the DateCreated property is set.
        /// </summary>
        internal bool IsSetDateCreated() => this.DateCreated.HasValue;

        /// <summary>
        /// Gets and sets the property DateUpdated. 
        /// <para>
        /// The date (in UTC time) when this configuration set was last modified.
        /// </para>
        /// </summary>
        public DateTime? DateUpdated { get; set; }

        /// <summary>
        /// Checks to see if the DateUpdated property is set.
        /// </summary>
        internal bool IsSetDateUpdated() => this.DateUpdated.HasValue;

        /// <summary>
        /// Gets and sets the property DeploymentStatus. 
        /// <para>
        ///  If this configuration set is associated with an environment, the <c>DeploymentStatus</c>
        /// parameter indicates the deployment status of this configuration set: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>null</c>: This configuration is not associated with a running environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pending</c>: This is a draft configuration that is not deployed to the associated
        /// environment but is in the process of deploying.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deployed</c>: This is the configuration that is currently deployed to the associated
        /// running environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>failed</c>: This is a draft configuration that failed to successfully deploy.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ConfigurationDeploymentStatus DeploymentStatus { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentStatus property is set.
        /// </summary>
        internal bool IsSetDeploymentStatus() => this.DeploymentStatus != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Describes this configuration set.
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
        ///  If not <c>null</c>, the name of the environment for this configuration set. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 40)]
        public string EnvironmentName { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentName property is set.
        /// </summary>
        internal bool IsSetEnvironmentName() => this.EnvironmentName != null;

        /// <summary>
        /// Gets and sets the property OptionSettings. 
        /// <para>
        /// A list of the configuration options and their values in this configuration set.
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
        /// The ARN of the platform version.
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
        /// The name of the solution stack this configuration set uses.
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
        ///  If not <c>null</c>, the name of the configuration template for this configuration
        /// set. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;
    }
}
