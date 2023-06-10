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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NimbleStudio.Model
{
    /// <summary>
    /// The upload storage root location (folder) on streaming workstations where files are
    /// uploaded.
    /// </summary>
    public partial class StreamingSessionStorageRoot
    {
        private string _linux;
        private string _windows;

        /// <summary>
        /// Gets and sets the property Linux. 
        /// <para>
        /// The folder path in Linux workstations where files are uploaded.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
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
        /// The folder path in Windows workstations where files are uploaded.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
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