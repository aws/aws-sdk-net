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
    /// Configures how streaming sessions are backed up when launched from this launch profile.
    /// </summary>
    public partial class StreamConfigurationSessionBackup
    {
        private int? _maxBackupsToRetain;
        private SessionBackupMode _mode;

        /// <summary>
        /// Gets and sets the property MaxBackupsToRetain. 
        /// <para>
        /// The maximum number of backups that each streaming session created from this launch
        /// profile can have.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public int MaxBackupsToRetain
        {
            get { return this._maxBackupsToRetain.GetValueOrDefault(); }
            set { this._maxBackupsToRetain = value; }
        }

        // Check to see if MaxBackupsToRetain property is set
        internal bool IsSetMaxBackupsToRetain()
        {
            return this._maxBackupsToRetain.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// Specifies how artists sessions are backed up.
        /// </para>
        ///  
        /// <para>
        /// Configures backups for streaming sessions launched with this launch profile. The default
        /// value is <code>DEACTIVATED</code>, which means that backups are deactivated. To allow
        /// backups, set this value to <code>AUTOMATIC</code>.
        /// </para>
        /// </summary>
        public SessionBackupMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

    }
}