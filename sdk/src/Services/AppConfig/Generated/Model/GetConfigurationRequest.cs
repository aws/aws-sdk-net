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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// Container for the parameters to the GetConfiguration operation.
    /// Retrieve information about a configuration.
    /// </summary>
    public partial class GetConfigurationRequest : AmazonAppConfigRequest
    {
        private string _application;
        private string _clientConfigurationVersion;
        private string _clientId;
        private string _configuration;
        private string _environment;

        /// <summary>
        /// Gets and sets the property Application. 
        /// <para>
        /// The application to get. Specify either the application name or the application ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Application
        {
            get { return this._application; }
            set { this._application = value; }
        }

        // Check to see if Application property is set
        internal bool IsSetApplication()
        {
            return this._application != null;
        }

        /// <summary>
        /// Gets and sets the property ClientConfigurationVersion. 
        /// <para>
        /// The configuration version returned in the most recent GetConfiguration response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientConfigurationVersion
        {
            get { return this._clientConfigurationVersion; }
            set { this._clientConfigurationVersion = value; }
        }

        // Check to see if ClientConfigurationVersion property is set
        internal bool IsSetClientConfigurationVersion()
        {
            return this._clientConfigurationVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// A unique ID to identify the client for the configuration. This ID enables AppConfig
        /// to deploy the configuration in intervals, as defined in the deployment strategy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration to get. Specify either the configuration name or the configuration
        /// ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment to get. Specify either the environment name or the environment ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null;
        }

    }
}