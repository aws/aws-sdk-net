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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Provides a script that runs as a worker is starting up that you can use to provide
    /// additional configuration for workers in your fleet. 
    /// 
    ///  
    /// <para>
    /// To remove a script from a fleet, use the <a href="https://docs.aws.amazon.com/deadline-cloud/latest/APIReference/API_UpdateFleet.html">UpdateFleet</a>
    /// operation with the <c>hostConfiguration</c> <c>scriptBody</c> parameter set to an
    /// empty string ("").
    /// </para>
    /// </summary>
    public partial class HostConfiguration
    {
        private string _scriptBody;
        private int? _scriptTimeoutSeconds;

        /// <summary>
        /// Gets and sets the property ScriptBody. 
        /// <para>
        /// The text of the script that runs as a worker is starting up that you can use to provide
        /// additional configuration for workers in your fleet. The script runs after a worker
        /// enters the <c>STARTING</c> state and before the worker processes tasks.
        /// </para>
        ///  
        /// <para>
        /// For more information about using the script, see <a href="https://docs.aws.amazon.com/deadline-cloud/latest/developerguide/smf-admin.html">Run
        /// scripts as an administrator to configure workers</a> in the <i>Deadline Cloud Developer
        /// Guide</i>. 
        /// </para>
        ///  <important> 
        /// <para>
        /// The script runs as an administrative user (<c>sudo root</c> on Linux, as an Administrator
        /// on Windows). 
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=15000)]
        public string ScriptBody
        {
            get { return this._scriptBody; }
            set { this._scriptBody = value; }
        }

        // Check to see if ScriptBody property is set
        internal bool IsSetScriptBody()
        {
            return this._scriptBody != null;
        }

        /// <summary>
        /// Gets and sets the property ScriptTimeoutSeconds. 
        /// <para>
        /// The maximum time that the host configuration can run. If the timeout expires, the
        /// worker enters the <c>NOT RESPONDING</c> state and shuts down. You are charged for
        /// the time that the worker is running the host configuration script.
        /// </para>
        ///  <note> 
        /// <para>
        /// You should configure your fleet for a maximum of one worker while testing your host
        /// configuration script to avoid starting additional workers.
        /// </para>
        ///  </note> 
        /// <para>
        /// The default is 300 seconds (5 minutes).
        /// </para>
        /// </summary>
        [AWSProperty(Min=300, Max=3600)]
        public int? ScriptTimeoutSeconds
        {
            get { return this._scriptTimeoutSeconds; }
            set { this._scriptTimeoutSeconds = value; }
        }

        // Check to see if ScriptTimeoutSeconds property is set
        internal bool IsSetScriptTimeoutSeconds()
        {
            return this._scriptTimeoutSeconds.HasValue; 
        }

    }
}