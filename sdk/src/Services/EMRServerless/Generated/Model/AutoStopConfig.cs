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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
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
namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// The configuration for an application to automatically stop after a certain amount
    /// of time being idle.
    /// </summary>
    public partial class AutoStopConfig
    {
        private bool? _enabled;
        private int? _idleTimeoutMinutes;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Enables the application to automatically stop after a certain amount of time being
        /// idle. Defaults to true.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdleTimeoutMinutes. 
        /// <para>
        /// The amount of idle time in minutes after which your application will automatically
        /// stop. Defaults to 15 minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10080)]
        public int? IdleTimeoutMinutes
        {
            get { return this._idleTimeoutMinutes; }
            set { this._idleTimeoutMinutes = value; }
        }

        // Check to see if IdleTimeoutMinutes property is set
        internal bool IsSetIdleTimeoutMinutes()
        {
            return this._idleTimeoutMinutes.HasValue; 
        }

    }
}