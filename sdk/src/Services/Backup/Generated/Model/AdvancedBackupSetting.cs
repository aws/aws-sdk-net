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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Backup.Model
{
    /// <summary>
    /// The backup options for each resource type.
    /// </summary>
    public partial class AdvancedBackupSetting
    {
        private Dictionary<string, string> _backupOptions = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _resourceType;

        /// <summary>
        /// Gets and sets the property BackupOptions. 
        /// <para>
        /// Specifies the backup option for a selected resource. This option is available for
        /// Windows VSS backup jobs and S3 backups.
        /// </para>
        ///  
        /// <para>
        /// Valid values: 
        /// </para>
        ///  
        /// <para>
        /// Set to <c>"WindowsVSS":"enabled"</c> to enable the <c>WindowsVSS</c> backup option
        /// and create a Windows VSS backup. 
        /// </para>
        ///  
        /// <para>
        /// Set to <c>"WindowsVSS":"disabled"</c> to create a regular backup. The <c>WindowsVSS</c>
        /// option is not enabled by default.
        /// </para>
        ///  
        /// <para>
        /// For S3 backups, set to <c>"S3BackupACLs":"disabled"</c> to exclude ACLs from the backup,
        /// or <c>"S3BackupObjectTags":"disabled"</c> to exclude object tags from the backup.
        /// By default, both ACLs and object tags are included in S3 backups.
        /// </para>
        ///  
        /// <para>
        /// If you specify an invalid option, you get an <c>InvalidParameterValueException</c>
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
            return this._backupOptions != null && (this._backupOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Specifies an object containing resource type and backup options. The only supported
        /// resource type is Amazon EC2 instances with Windows Volume Shadow Copy Service (VSS).
        /// For a CloudFormation example, see the <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/integrate-cloudformation-with-aws-backup.html">sample
        /// CloudFormation template to enable Windows VSS</a> in the <i>Backup User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>EC2</c>.
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