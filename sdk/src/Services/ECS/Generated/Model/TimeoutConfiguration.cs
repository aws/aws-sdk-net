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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// An object that represents the timeout configurations for Service Connect.
    /// 
    ///  <note> 
    /// <para>
    /// If <c>idleTimeout</c> is set to a time that is less than <c>perRequestTimeout</c>,
    /// the connection will close when the <c>idleTimeout</c> is reached and not the <c>perRequestTimeout</c>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class TimeoutConfiguration
    {
        private int? _idleTimeoutSeconds;
        private int? _perRequestTimeoutSeconds;

        /// <summary>
        /// Gets and sets the property IdleTimeoutSeconds. 
        /// <para>
        /// The amount of time in seconds a connection will stay active while idle. A value of
        /// <c>0</c> can be set to disable <c>idleTimeout</c>.
        /// </para>
        ///  
        /// <para>
        /// The <c>idleTimeout</c> default for <c>HTTP</c>/<c>HTTP2</c>/<c>GRPC</c> is 5 minutes.
        /// </para>
        ///  
        /// <para>
        /// The <c>idleTimeout</c> default for <c>TCP</c> is 1 hour.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? IdleTimeoutSeconds
        {
            get { return this._idleTimeoutSeconds; }
            set { this._idleTimeoutSeconds = value; }
        }

        // Check to see if IdleTimeoutSeconds property is set
        internal bool IsSetIdleTimeoutSeconds()
        {
            return this._idleTimeoutSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PerRequestTimeoutSeconds. 
        /// <para>
        /// The amount of time waiting for the upstream to respond with a complete response per
        /// request. A value of <c>0</c> can be set to disable <c>perRequestTimeout</c>. <c>perRequestTimeout</c>
        /// can only be set if Service Connect <c>appProtocol</c> isn't <c>TCP</c>. Only <c>idleTimeout</c>
        /// is allowed for <c>TCP</c> <c>appProtocol</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? PerRequestTimeoutSeconds
        {
            get { return this._perRequestTimeoutSeconds; }
            set { this._perRequestTimeoutSeconds = value; }
        }

        // Check to see if PerRequestTimeoutSeconds property is set
        internal bool IsSetPerRequestTimeoutSeconds()
        {
            return this._perRequestTimeoutSeconds.HasValue; 
        }

    }
}