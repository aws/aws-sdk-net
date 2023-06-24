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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Server participating in Job.
    /// </summary>
    public partial class ParticipatingServer
    {
        private string _launchedEc2InstanceID;
        private LaunchStatus _launchStatus;
        private PostLaunchActionsStatus _postLaunchActionsStatus;
        private string _sourceServerID;

        /// <summary>
        /// Gets and sets the property LaunchedEc2InstanceID. 
        /// <para>
        /// Participating server's launched ec2 instance ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string LaunchedEc2InstanceID
        {
            get { return this._launchedEc2InstanceID; }
            set { this._launchedEc2InstanceID = value; }
        }

        // Check to see if LaunchedEc2InstanceID property is set
        internal bool IsSetLaunchedEc2InstanceID()
        {
            return this._launchedEc2InstanceID != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchStatus. 
        /// <para>
        /// Participating server launch status.
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
        /// Gets and sets the property PostLaunchActionsStatus. 
        /// <para>
        /// Participating server's Post Launch Actions Status.
        /// </para>
        /// </summary>
        public PostLaunchActionsStatus PostLaunchActionsStatus
        {
            get { return this._postLaunchActionsStatus; }
            set { this._postLaunchActionsStatus = value; }
        }

        // Check to see if PostLaunchActionsStatus property is set
        internal bool IsSetPostLaunchActionsStatus()
        {
            return this._postLaunchActionsStatus != null;
        }

        /// <summary>
        /// Gets and sets the property SourceServerID. 
        /// <para>
        /// Participating server Source Server ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=19)]
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