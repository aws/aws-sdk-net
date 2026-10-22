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

namespace Amazon.Drs.Model
{
    /// <summary>
    /// Represents a server participating in an asynchronous Job.
    /// </summary>
    public partial class ParticipatingServer
    {
        /// <summary>
        /// Gets and sets the property LaunchActionsStatus. 
        /// <para>
        /// The post-launch action runs of a participating server.
        /// </para>
        /// </summary>
        public LaunchActionsStatus LaunchActionsStatus { get; set; }

        /// <summary>
        /// Checks to see if the LaunchActionsStatus property is set.
        /// </summary>
        internal bool IsSetLaunchActionsStatus() => this.LaunchActionsStatus != null;

        /// <summary>
        /// Gets and sets the property LaunchStatus. 
        /// <para>
        /// The launch status of a participating server.
        /// </para>
        /// </summary>
        public LaunchStatus LaunchStatus { get; set; }

        /// <summary>
        /// Checks to see if the LaunchStatus property is set.
        /// </summary>
        internal bool IsSetLaunchStatus() => this.LaunchStatus != null;

        /// <summary>
        /// Gets and sets the property RecoveryInstanceID. 
        /// <para>
        /// The Recovery Instance ID of a participating server.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 19)]
        public string RecoveryInstanceID { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryInstanceID property is set.
        /// </summary>
        internal bool IsSetRecoveryInstanceID() => this.RecoveryInstanceID != null;

        /// <summary>
        /// Gets and sets the property SourceServerID. 
        /// <para>
        /// The Source Server ID of a participating server.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 19)]
        public string SourceServerID { get; set; }

        /// <summary>
        /// Checks to see if the SourceServerID property is set.
        /// </summary>
        internal bool IsSetSourceServerID() => this.SourceServerID != null;
    }
}
