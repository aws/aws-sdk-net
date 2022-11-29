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
 * Do not modify this file. This file is generated from the simspaceweaver-2022-10-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimSpaceWeaver.Model
{
    /// <summary>
    /// Options that apply when the app starts. These optiAons override default behavior.
    /// </summary>
    public partial class LaunchOverrides
    {
        private List<string> _launchCommands = new List<string>();

        /// <summary>
        /// Gets and sets the property LaunchCommands. 
        /// <para>
        /// App launch commands and command line parameters that override the launch command configured
        /// in the simulation schema.
        /// </para>
        /// </summary>
        public List<string> LaunchCommands
        {
            get { return this._launchCommands; }
            set { this._launchCommands = value; }
        }

        // Check to see if LaunchCommands property is set
        internal bool IsSetLaunchCommands()
        {
            return this._launchCommands != null && this._launchCommands.Count > 0; 
        }

    }
}