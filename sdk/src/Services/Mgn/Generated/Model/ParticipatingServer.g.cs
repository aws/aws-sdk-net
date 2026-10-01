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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Server participating in Job.
    /// </summary>
    public partial class ParticipatingServer
    {
        /// <summary>
        /// Gets and sets the property LaunchStatus. 
        /// <para>
        /// Participating server launch status.
        /// </para>
        /// </summary>
        public LaunchStatus LaunchStatus { get; set; }

        /// <summary>
        /// Checks to see if the LaunchStatus property is set.
        /// </summary>
        internal bool IsSetLaunchStatus() => this.LaunchStatus != null;

        /// <summary>
        /// Gets and sets the property LaunchedEc2InstanceID. 
        /// <para>
        /// Participating server's launched ec2 instance ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string LaunchedEc2InstanceID { get; set; }

        /// <summary>
        /// Checks to see if the LaunchedEc2InstanceID property is set.
        /// </summary>
        internal bool IsSetLaunchedEc2InstanceID() => this.LaunchedEc2InstanceID != null;

        /// <summary>
        /// Gets and sets the property PostLaunchActionsStatus. 
        /// <para>
        /// Participating server's Post Launch Actions Status.
        /// </para>
        /// </summary>
        public PostLaunchActionsStatus PostLaunchActionsStatus { get; set; }

        /// <summary>
        /// Checks to see if the PostLaunchActionsStatus property is set.
        /// </summary>
        internal bool IsSetPostLaunchActionsStatus() => this.PostLaunchActionsStatus != null;

        /// <summary>
        /// Gets and sets the property SourceServerID. 
        /// <para>
        /// Participating server Source Server ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 19, Max = 19)]
        public string SourceServerID { get; set; }

        /// <summary>
        /// Checks to see if the SourceServerID property is set.
        /// </summary>
        internal bool IsSetSourceServerID() => this.SourceServerID != null;
    }
}
