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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Backup.Model
{
    /// <summary>
    /// A list of backup options for each resource type.
    /// </summary>
    public partial class AdvancedBackupSetting
    {
        private Dictionary<string, string> _backupOptions = new Dictionary<string, string>();
        private string _resourceType;

        /// <summary>
        /// Gets and sets the property BackupOptions. 
        /// <para>
        /// Specifies the backup option for a selected resource. This option is only available
        /// for Windows VSS backup jobs.
        /// </para>
        ///  
        /// <para>
        /// Valid values: 
        /// </para>
        ///  
        /// <para>
        /// Set to <code>"WindowsVSS":"enabled"</code> to enable the WindowsVSS backup option
        /// and create a VSS Windows backup. 
        /// </para>
        ///  
        /// <para>
        /// Set to <code>"WindowsVSS":"disabled"</code> to create a regular backup. The WindowsVSS
        /// option is not enabled by default.
        /// </para>
        ///  
        /// <para>
        /// If you specify an invalid option, you get an <code>InvalidParameterValueException</code>
        /// exception.
        /// </para>
        ///  
        /// <para>
        /// For more information about Windows VSS backups, see <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/windows-backups.html">Creating
        /// a VSS-Enabled Windows Backup</a>.
        /// </para>
        /// </summary>
        public Dictionary<string, string> BackupOptions
        {
            get { return this._backupOptions; }
            set { this._backupOptions = value; }
        }

        // Check to see if BackupOptions property is set
        internal bool IsSetBackupOptions()
        {
            return this._backupOptions != null && this._backupOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of AWS resource to be backed up. For VSS Windows backups, the only supported
        /// resource type is Amazon EC2.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>EC2</code>.
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}