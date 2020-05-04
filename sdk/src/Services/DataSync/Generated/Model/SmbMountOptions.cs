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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Represents the mount options that are available for DataSync to access an SMB location.
    /// </summary>
    public partial class SmbMountOptions
    {
        private SmbVersion _version;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The specific SMB version that you want DataSync to use to mount your SMB share. If
        /// you don't specify a version, DataSync defaults to <code>AUTOMATIC</code>. That is,
        /// DataSync automatically selects a version based on negotiation with the SMB server.
        /// </para>
        /// </summary>
        public SmbVersion Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}