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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
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
namespace Amazon.CloudWatchEvidently.Model
{
    /// <summary>
    /// Container for the parameters to the StopLaunch operation.
    /// Stops a launch that is currently running. After you stop a launch, you will not be
    /// able to resume it or restart it. Also, it will not be evaluated as a rule for traffic
    /// allocation, and the traffic that was allocated to the launch will instead be available
    /// to the feature's experiment, if there is one. Otherwise, all traffic will be served
    /// the default variation after the launch is stopped.
    /// </summary>
    public partial class StopLaunchRequest : AmazonCloudWatchEvidentlyRequest
    {
        private LaunchStopDesiredState _desiredState;
        private string _launch;
        private string _project;
        private string _reason;

        /// <summary>
        /// Gets and sets the property DesiredState. 
        /// <para>
        /// Specify whether to consider the launch as <c>COMPLETED</c> or <c>CANCELLED</c> after
        /// it stops.
        /// </para>
        /// </summary>
        public LaunchStopDesiredState DesiredState
        {
            get { return this._desiredState; }
            set { this._desiredState = value; }
        }

        // Check to see if DesiredState property is set
        internal bool IsSetDesiredState()
        {
            return this._desiredState != null;
        }

        /// <summary>
        /// Gets and sets the property Launch. 
        /// <para>
        /// The name of the launch to stop.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=127)]
        public string Launch
        {
            get { return this._launch; }
            set { this._launch = value; }
        }

        // Check to see if Launch property is set
        internal bool IsSetLaunch()
        {
            return this._launch != null;
        }

        /// <summary>
        /// Gets and sets the property Project. 
        /// <para>
        /// The name or ARN of the project that contains the launch that you want to stop.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string Project
        {
            get { return this._project; }
            set { this._project = value; }
        }

        // Check to see if Project property is set
        internal bool IsSetProject()
        {
            return this._project != null;
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// A string that describes why you are stopping the launch.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=160)]
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

    }
}