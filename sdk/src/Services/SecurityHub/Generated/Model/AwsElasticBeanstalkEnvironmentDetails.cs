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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private string _applicationName;
        private string _cname;
        private string _dateCreated;
        private string _dateUpdated;
        private string _description;
        private string _endpointUrl;
        private string _environmentArn;
        private string _environmentId;
        private List<AwsElasticBeanstalkEnvironmentEnvironmentLink> _environmentLinks = AWSConfigs.InitializeCollections ? new List<AwsElasticBeanstalkEnvironmentEnvironmentLink>() : null;
        private string _environmentName;
        private List<AwsElasticBeanstalkEnvironmentOptionSetting> _optionSettings = AWSConfigs.InitializeCollections ? new List<AwsElasticBeanstalkEnvironmentOptionSetting>() : null;
        private string _platformArn;
        private string _solutionStackName;
        private string _status;
        private AwsElasticBeanstalkEnvironmentTier _tier;
        private string _versionLabel;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application that is associated with the environment.
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
        /// Gets and sets the property Cname. 
        /// <para>
        /// The URL to the CNAME for this environment.
        /// </para>
        /// </summary>
        public string Cname
        {
            get { return this._cname; }
            set { this._cname = value; }
        }

        // Check to see if Cname property is set
        internal bool IsSetCname()
        {
            return this._cname != null;
        }

        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The creation date for this environment.
        /// </para>
        /// </summary>
        public string DateCreated
        {
            get { return this._dateCreated; }
            set { this._dateCreated = value; }
        }

        // Check to see if DateCreated property is set
        internal bool IsSetDateCreated()
        {
            return this._dateCreated != null;
        }

        /// <summary>
        /// Gets and sets the property DateUpdated. 
        /// <para>
        /// The date when this environment was last modified.
        /// </para>
        /// </summary>
        public string DateUpdated
        {
            get { return this._dateUpdated; }
            set { this._dateUpdated = value; }
        }

        // Check to see if DateUpdated property is set
        internal bool IsSetDateUpdated()
        {
            return this._dateUpdated != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the environment.
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
        /// Gets and sets the property EndpointUrl. 
        /// <para>
        /// For load-balanced, autoscaling environments, the URL to the load balancer. For single-instance
        /// environments, the IP address of the instance.
        /// </para>
        /// </summary>
        public string EndpointUrl
        {
            get { return this._endpointUrl; }
            set { this._endpointUrl = value; }
        }

        // Check to see if EndpointUrl property is set
        internal bool IsSetEndpointUrl()
        {
            return this._endpointUrl != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentArn. 
        /// <para>
        /// The ARN of the environment.
        /// </para>
        /// </summary>
        public string EnvironmentArn
        {
            get { return this._environmentArn; }
            set { this._environmentArn = value; }
        }

        // Check to see if EnvironmentArn property is set
        internal bool IsSetEnvironmentArn()
        {
            return this._environmentArn != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The identifier of the environment.
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
        /// Gets and sets the property EnvironmentLinks. 
        /// <para>
        /// Links to other environments in the same group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsElasticBeanstalkEnvironmentEnvironmentLink> EnvironmentLinks
        {
            get { return this._environmentLinks; }
            set { this._environmentLinks = value; }
        }

        // Check to see if EnvironmentLinks property is set
        internal bool IsSetEnvironmentLinks()
        {
            return this._environmentLinks != null && (this._environmentLinks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentName. 
        /// <para>
        /// The name of the environment.
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
        /// The configuration setting for the environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsElasticBeanstalkEnvironmentOptionSetting> OptionSettings
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
        /// The ARN of the platform version for the environment.
        /// </para>
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
        /// The name of the solution stack that is deployed with the environment.
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
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The tier of the environment.
        /// </para>
        /// </summary>
        public AwsElasticBeanstalkEnvironmentTier Tier
        {
            get { return this._tier; }
            set { this._tier = value; }
        }

        // Check to see if Tier property is set
        internal bool IsSetTier()
        {
            return this._tier != null;
        }

        /// <summary>
        /// Gets and sets the property VersionLabel. 
        /// <para>
        /// The application version of the environment.
        /// </para>
        /// </summary>
        public string VersionLabel
        {
            get { return this._versionLabel; }
            set { this._versionLabel = value; }
        }

        // Check to see if VersionLabel property is set
        internal bool IsSetVersionLabel()
        {
            return this._versionLabel != null;
        }

    }
}