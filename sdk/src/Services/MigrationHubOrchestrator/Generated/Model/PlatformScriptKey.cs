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
 * Do not modify this file. This file is generated from the migrationhuborchestrator-2021-08-28.normal.json service model.
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
namespace Amazon.MigrationHubOrchestrator.Model
{
    /// <summary>
    /// The script location for a particular operating system.
    /// </summary>
    public partial class PlatformScriptKey
    {
        private string _linux;
        private string _windows;

        /// <summary>
        /// Gets and sets the property Linux. 
        /// <para>
        /// The script location for Linux.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Linux
        {
            get { return this._linux; }
            set { this._linux = value; }
        }

        // Check to see if Linux property is set
        internal bool IsSetLinux()
        {
            return this._linux != null;
        }

        /// <summary>
        /// Gets and sets the property Windows. 
        /// <para>
        /// The script location for Windows.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Windows
        {
            get { return this._windows; }
            set { this._windows = value; }
        }

        // Check to see if Windows property is set
        internal bool IsSetWindows()
        {
            return this._windows != null;
        }

    }
}