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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Describes a filter for a specific list of instances.
    /// </summary>
    public partial class InstanceInformation
    {
        private string _agentVersion;
        private string _instanceId;
        private bool? _isLatestVersion;
        private DateTime? _lastPingDateTime;
        private PingStatus _pingStatus;
        private string _platformName;
        private PlatformType _platformType;
        private string _platformVersion;

        /// <summary>
        /// Gets and sets the property AgentVersion. 
        /// <para>
        /// The version of the SSM agent running on your instance. 
        /// </para>
        /// </summary>
        public string AgentVersion
        {
            get { return this._agentVersion; }
            set { this._agentVersion = value; }
        }

        // Check to see if AgentVersion property is set
        internal bool IsSetAgentVersion()
        {
            return this._agentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The instance ID. 
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property IsLatestVersion. 
        /// <para>
        /// Indicates whether latest version of the SSM agent is running on your instance. 
        /// </para>
        /// </summary>
        public bool IsLatestVersion
        {
            get { return this._isLatestVersion.GetValueOrDefault(); }
            set { this._isLatestVersion = value; }
        }

        // Check to see if IsLatestVersion property is set
        internal bool IsSetIsLatestVersion()
        {
            return this._isLatestVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastPingDateTime. 
        /// <para>
        /// The date and time when agent last pinged SSM service. 
        /// </para>
        /// </summary>
        public DateTime LastPingDateTime
        {
            get { return this._lastPingDateTime.GetValueOrDefault(); }
            set { this._lastPingDateTime = value; }
        }

        // Check to see if LastPingDateTime property is set
        internal bool IsSetLastPingDateTime()
        {
            return this._lastPingDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PingStatus. 
        /// <para>
        /// Connection status of the SSM agent. 
        /// </para>
        /// </summary>
        public PingStatus PingStatus
        {
            get { return this._pingStatus; }
            set { this._pingStatus = value; }
        }

        // Check to see if PingStatus property is set
        internal bool IsSetPingStatus()
        {
            return this._pingStatus != null;
        }

        /// <summary>
        /// Gets and sets the property PlatformName. 
        /// <para>
        /// The name of the operating system platform running on your instance. 
        /// </para>
        /// </summary>
        public string PlatformName
        {
            get { return this._platformName; }
            set { this._platformName = value; }
        }

        // Check to see if PlatformName property is set
        internal bool IsSetPlatformName()
        {
            return this._platformName != null;
        }

        /// <summary>
        /// Gets and sets the property PlatformType. 
        /// <para>
        /// The operating system platform type. 
        /// </para>
        /// </summary>
        public PlatformType PlatformType
        {
            get { return this._platformType; }
            set { this._platformType = value; }
        }

        // Check to see if PlatformType property is set
        internal bool IsSetPlatformType()
        {
            return this._platformType != null;
        }

        /// <summary>
        /// Gets and sets the property PlatformVersion. 
        /// <para>
        /// The version of the OS platform running on your instance. 
        /// </para>
        /// </summary>
        public string PlatformVersion
        {
            get { return this._platformVersion; }
            set { this._platformVersion = value; }
        }

        // Check to see if PlatformVersion property is set
        internal bool IsSetPlatformVersion()
        {
            return this._platformVersion != null;
        }

    }
}