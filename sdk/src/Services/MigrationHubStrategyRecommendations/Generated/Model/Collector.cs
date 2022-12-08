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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// Process data collector that runs in the environment that you specify.
    /// </summary>
    public partial class Collector
    {
        private CollectorHealth _collectorHealth;
        private string _collectorId;
        private string _collectorVersion;
        private ConfigurationSummary _configurationSummary;
        private string _hostName;
        private string _ipAddress;
        private string _lastActivityTimeStamp;
        private string _registeredTimeStamp;

        /// <summary>
        /// Gets and sets the property CollectorHealth. 
        /// <para>
        ///  Indicates the health of a collector. 
        /// </para>
        /// </summary>
        public CollectorHealth CollectorHealth
        {
            get { return this._collectorHealth; }
            set { this._collectorHealth = value; }
        }

        // Check to see if CollectorHealth property is set
        internal bool IsSetCollectorHealth()
        {
            return this._collectorHealth != null;
        }

        /// <summary>
        /// Gets and sets the property CollectorId. 
        /// <para>
        ///  The ID of the collector. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string CollectorId
        {
            get { return this._collectorId; }
            set { this._collectorId = value; }
        }

        // Check to see if CollectorId property is set
        internal bool IsSetCollectorId()
        {
            return this._collectorId != null;
        }

        /// <summary>
        /// Gets and sets the property CollectorVersion. 
        /// <para>
        ///  Current version of the collector that is running in the environment that you specify.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string CollectorVersion
        {
            get { return this._collectorVersion; }
            set { this._collectorVersion = value; }
        }

        // Check to see if CollectorVersion property is set
        internal bool IsSetCollectorVersion()
        {
            return this._collectorVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationSummary. 
        /// <para>
        /// Summary of the collector configuration.
        /// </para>
        /// </summary>
        public ConfigurationSummary ConfigurationSummary
        {
            get { return this._configurationSummary; }
            set { this._configurationSummary = value; }
        }

        // Check to see if ConfigurationSummary property is set
        internal bool IsSetConfigurationSummary()
        {
            return this._configurationSummary != null;
        }

        /// <summary>
        /// Gets and sets the property HostName. 
        /// <para>
        ///  Hostname of the server that is hosting the collector. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string HostName
        {
            get { return this._hostName; }
            set { this._hostName = value; }
        }

        // Check to see if HostName property is set
        internal bool IsSetHostName()
        {
            return this._hostName != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        ///  IP address of the server that is hosting the collector. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        // Check to see if IpAddress property is set
        internal bool IsSetIpAddress()
        {
            return this._ipAddress != null;
        }

        /// <summary>
        /// Gets and sets the property LastActivityTimeStamp. 
        /// <para>
        ///  Time when the collector last pinged the service. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string LastActivityTimeStamp
        {
            get { return this._lastActivityTimeStamp; }
            set { this._lastActivityTimeStamp = value; }
        }

        // Check to see if LastActivityTimeStamp property is set
        internal bool IsSetLastActivityTimeStamp()
        {
            return this._lastActivityTimeStamp != null;
        }

        /// <summary>
        /// Gets and sets the property RegisteredTimeStamp. 
        /// <para>
        ///  Time when the collector registered with the service. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string RegisteredTimeStamp
        {
            get { return this._registeredTimeStamp; }
            set { this._registeredTimeStamp = value; }
        }

        // Check to see if RegisteredTimeStamp property is set
        internal bool IsSetRegisteredTimeStamp()
        {
            return this._registeredTimeStamp != null;
        }

    }
}