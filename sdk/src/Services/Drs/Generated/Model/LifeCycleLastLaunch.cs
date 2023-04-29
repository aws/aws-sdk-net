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

namespace Amazon.Drs.Model
{
    /// <summary>
    /// An object containing information regarding the last launch of a Source Server.
    /// </summary>
    public partial class LifeCycleLastLaunch
    {
        private LifeCycleLastLaunchInitiated _initiated;
        private LaunchStatus _status;

        /// <summary>
        /// Gets and sets the property Initiated. 
        /// <para>
        /// An object containing information regarding the initiation of the last launch of a
        /// Source Server.
        /// </para>
        /// </summary>
        public LifeCycleLastLaunchInitiated Initiated
        {
            get { return this._initiated; }
            set { this._initiated = value; }
        }

        // Check to see if Initiated property is set
        internal bool IsSetInitiated()
        {
            return this._initiated != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of Source Server's last launch.
        /// </para>
        /// </summary>
        public LaunchStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}