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
    /// The configuration for a streaming session’s upload storage.
    /// </summary>
    public partial class StreamConfigurationSessionStorage
    {
        private List<string> _mode = new List<string>();
        private StreamingSessionStorageRoot _root;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// Allows artists to upload files to their workstations. The only valid option is <code>UPLOAD</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null && this._mode.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Root. 
        /// <para>
        /// The configuration for the upload storage root of the streaming session.
        /// </para>
        /// </summary>
        public StreamingSessionStorageRoot Root
        {
            get { return this._root; }
            set { this._root = value; }
        }

        // Check to see if Root property is set
        internal bool IsSetRoot()
        {
            return this._root != null;
        }

    }
}