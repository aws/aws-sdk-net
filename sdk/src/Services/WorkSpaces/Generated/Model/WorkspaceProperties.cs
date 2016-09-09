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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes the properties of a WorkSpace.
    /// </summary>
    public partial class WorkspaceProperties
    {
        private RunningMode _runningMode;
        private int? _runningModeAutoStopTimeoutInMinutes;

        /// <summary>
        /// Gets and sets the property RunningMode. 
        /// <para>
        /// The running mode of the WorkSpace. AlwaysOn WorkSpaces are billed monthly. AutoStop
        /// WorkSpaces are billed by the hour and stopped when no longer being used in order to
        /// save on costs.
        /// </para>
        /// </summary>
        public RunningMode RunningMode
        {
            get { return this._runningMode; }
            set { this._runningMode = value; }
        }

        // Check to see if RunningMode property is set
        internal bool IsSetRunningMode()
        {
            return this._runningMode != null;
        }

        /// <summary>
        /// Gets and sets the property RunningModeAutoStopTimeoutInMinutes. 
        /// <para>
        /// The time after a user logs off when WorkSpaces are automatically stopped. Configured
        /// in 60 minute intervals.
        /// </para>
        /// </summary>
        public int RunningModeAutoStopTimeoutInMinutes
        {
            get { return this._runningModeAutoStopTimeoutInMinutes.GetValueOrDefault(); }
            set { this._runningModeAutoStopTimeoutInMinutes = value; }
        }

        // Check to see if RunningModeAutoStopTimeoutInMinutes property is set
        internal bool IsSetRunningModeAutoStopTimeoutInMinutes()
        {
            return this._runningModeAutoStopTimeoutInMinutes.HasValue; 
        }

    }
}