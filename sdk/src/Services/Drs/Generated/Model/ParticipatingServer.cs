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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
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
namespace Amazon.Drs.Model
{
    /// <summary>
    /// Represents a server participating in an asynchronous Job.
    /// </summary>
    public partial class ParticipatingServer
    {
        private LaunchActionsStatus _launchActionsStatus;
        private LaunchStatus _launchStatus;
        private string _recoveryInstanceID;
        private string _sourceServerID;

        /// <summary>
        /// Gets and sets the property LaunchActionsStatus. 
        /// <para>
        /// The post-launch action runs of a participating server.
        /// </para>
        /// </summary>
        public LaunchActionsStatus LaunchActionsStatus
        {
            get { return this._launchActionsStatus; }
            set { this._launchActionsStatus = value; }
        }

        // Check to see if LaunchActionsStatus property is set
        internal bool IsSetLaunchActionsStatus()
        {
            return this._launchActionsStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchStatus. 
        /// <para>
        /// The launch status of a participating server.
        /// </para>
        /// </summary>
        public LaunchStatus LaunchStatus
        {
            get { return this._launchStatus; }
            set { this._launchStatus = value; }
        }

        // Check to see if LaunchStatus property is set
        internal bool IsSetLaunchStatus()
        {
            return this._launchStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RecoveryInstanceID. 
        /// <para>
        /// The Recovery Instance ID of a participating server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=19)]
        public string RecoveryInstanceID
        {
            get { return this._recoveryInstanceID; }
            set { this._recoveryInstanceID = value; }
        }

        // Check to see if RecoveryInstanceID property is set
        internal bool IsSetRecoveryInstanceID()
        {
            return this._recoveryInstanceID != null;
        }

        /// <summary>
        /// Gets and sets the property SourceServerID. 
        /// <para>
        /// The Source Server ID of a participating server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=19)]
        public string SourceServerID
        {
            get { return this._sourceServerID; }
            set { this._sourceServerID = value; }
        }

        // Check to see if SourceServerID property is set
        internal bool IsSetSourceServerID()
        {
            return this._sourceServerID != null;
        }

    }
}