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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains details about an Elastic Beanstalk environment.
    /// </summary>
    public partial class AwsElasticBeanstalkEnvironmentDetails
    {
        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application that is associated with the environment.
        /// </para>
        /// </summary>
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property Cname. 
        /// <para>
        /// The URL to the CNAME for this environment.
        /// </para>
        /// </summary>
        public string Cname { get; set; }

        /// <summary>
        /// Checks to see if the Cname property is set.
        /// </summary>
        internal bool IsSetCname() => this.Cname != null;

        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The creation date for this environment.
        /// </para>
        /// </summary>
        public string DateCreated { get; set; }

        /// <summary>
        /// Checks to see if the DateCreated property is set.
        /// </summary>
        internal bool IsSetDateCreated() => this.DateCreated != null;

        /// <summary>
        /// Gets and sets the property DateUpdated. 
        /// <para>
        /// The date when this environment was last modified.
        /// </para>
        /// </summary>
        public string DateUpdated { get; set; }

        /// <summary>
        /// Checks to see if the DateUpdated property is set.
        /// </summary>
        internal bool IsSetDateUpdated() => this.DateUpdated != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the environment.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EndpointUrl. 
        /// <para>
        /// For load-balanced, autoscaling environments, the URL to the load balancer. For single-instance
        /// environments, the IP address of the instance.
        /// </para>
        /// </summary>
        public string EndpointUrl { get; set; }

        /// <summary>
        /// Checks to see if the EndpointUrl property is set.
        /// </summary>
        internal bool IsSetEndpointUrl() => this.EndpointUrl != null;

        /// <summary>
        /// Gets and sets the property EnvironmentArn. 
        /// <para>
        /// The ARN of the environment.
        /// </para>
        /// </summary>
        public string EnvironmentArn { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentArn property is set.
        /// </summary>
        internal bool IsSetEnvironmentArn() => this.EnvironmentArn != null;

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The identifier of the environment.
        /// </para>
        /// </summary>
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property EnvironmentLinks. 
        /// <para>
        /// Links to other environments in the same group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsElasticBeanstalkEnvironmentEnvironmentLink> EnvironmentLinks { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsElasticBeanstalkEnvironmentEnvironmentLink>() : null;

        /// <summary>
        /// Checks to see if the EnvironmentLinks property is set.
        /// </summary>
        internal bool IsSetEnvironmentLinks() => this.EnvironmentLinks != null && (this.EnvironmentLinks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of the environment.
        /// </para>
        /// </summary>
        public string EnvironmentName { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentName property is set.
        /// </summary>
        internal bool IsSetEnvironmentName() => this.EnvironmentName != null;

        /// <summary>
        /// Gets and sets the property OptionSettings. 
        /// <para>
        /// The configuration setting for the environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsElasticBeanstalkEnvironmentOptionSetting> OptionSettings { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsElasticBeanstalkEnvironmentOptionSetting>() : null;

        /// <summary>
        /// Checks to see if the OptionSettings property is set.
        /// </summary>
        internal bool IsSetOptionSettings() => this.OptionSettings != null && (this.OptionSettings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PlatformArn. 
        /// <para>
        /// The ARN of the platform version for the environment.
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
        /// The name of the solution stack that is deployed with the environment.
        /// </para>
        /// </summary>
        public string SolutionStackName { get; set; }

        /// <summary>
        /// Checks to see if the SolutionStackName property is set.
        /// </summary>
        internal bool IsSetSolutionStackName() => this.SolutionStackName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current operational status of the environment. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Aborting</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Launching</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LinkingFrom</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LinkingTo</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Ready</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Terminated</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Terminating</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Updating</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The tier of the environment.
        /// </para>
        /// </summary>
        public AwsElasticBeanstalkEnvironmentTier Tier { get; set; }

        /// <summary>
        /// Checks to see if the Tier property is set.
        /// </summary>
        internal bool IsSetTier() => this.Tier != null;

        /// <summary>
        /// Gets and sets the property VersionLabel. 
        /// <para>
        /// The application version of the environment.
        /// </para>
        /// </summary>
        public string VersionLabel { get; set; }

        /// <summary>
        /// Checks to see if the VersionLabel property is set.
        /// </summary>
        internal bool IsSetVersionLabel() => this.VersionLabel != null;
    }
}
