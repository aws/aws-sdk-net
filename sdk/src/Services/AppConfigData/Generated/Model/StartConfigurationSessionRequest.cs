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
 * Do not modify this file. This file is generated from the appconfigdata-2021-11-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppConfigData.Model
{
    /// <summary>
    /// Container for the parameters to the StartConfigurationSession operation.
    /// Starts a configuration session used to retrieve a deployed configuration. For more
    /// information about this API action and to view example CLI commands that show how to
    /// use it with the <a>GetLatestConfiguration</a> API action, see <a href="http://docs.aws.amazon.com/appconfig/latest/userguide/appconfig-retrieving-the-configuration">Retrieving
    /// the configuration</a> in the <i>AppConfig User Guide</i>.
    /// </summary>
    public partial class StartConfigurationSessionRequest : AmazonAppConfigDataRequest
    {
        private string _applicationIdentifier;
        private string _configurationProfileIdentifier;
        private string _environmentIdentifier;
        private int? _requiredMinimumPollIntervalInSeconds;

        /// <summary>
        /// Gets and sets the property ApplicationIdentifier. 
        /// <para>
        /// The application ID or the application name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ApplicationIdentifier
        {
            get { return this._applicationIdentifier; }
            set { this._applicationIdentifier = value; }
        }

        // Check to see if ApplicationIdentifier property is set
        internal bool IsSetApplicationIdentifier()
        {
            return this._applicationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationProfileIdentifier. 
        /// <para>
        /// The configuration profile ID or the configuration profile name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ConfigurationProfileIdentifier
        {
            get { return this._configurationProfileIdentifier; }
            set { this._configurationProfileIdentifier = value; }
        }

        // Check to see if ConfigurationProfileIdentifier property is set
        internal bool IsSetConfigurationProfileIdentifier()
        {
            return this._configurationProfileIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentIdentifier. 
        /// <para>
        /// The environment ID or the environment name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string EnvironmentIdentifier
        {
            get { return this._environmentIdentifier; }
            set { this._environmentIdentifier = value; }
        }

        // Check to see if EnvironmentIdentifier property is set
        internal bool IsSetEnvironmentIdentifier()
        {
            return this._environmentIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property RequiredMinimumPollIntervalInSeconds. 
        /// <para>
        /// Sets a constraint on a session. If you specify a value of, for example, 60 seconds,
        /// then the client that established the session can't call <a>GetLatestConfiguration</a>
        /// more frequently than every 60 seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=15, Max=86400)]
        public int RequiredMinimumPollIntervalInSeconds
        {
            get { return this._requiredMinimumPollIntervalInSeconds.GetValueOrDefault(); }
            set { this._requiredMinimumPollIntervalInSeconds = value; }
        }

        // Check to see if RequiredMinimumPollIntervalInSeconds property is set
        internal bool IsSetRequiredMinimumPollIntervalInSeconds()
        {
            return this._requiredMinimumPollIntervalInSeconds.HasValue; 
        }

    }
}