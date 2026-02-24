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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
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
namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Configuration for centralization destination log groups, including encryption and
    /// backup settings.
    /// </summary>
    public partial class DestinationLogsConfiguration
    {
        private LogsBackupConfiguration _backupConfiguration;
        private LogGroupNameConfiguration _logGroupNameConfiguration;
        private LogsEncryptionConfiguration _logsEncryptionConfiguration;

        /// <summary>
        /// Gets and sets the property BackupConfiguration. 
        /// <para>
        /// Configuration defining the backup region and an optional KMS key for the backup destination.
        /// </para>
        /// </summary>
        public LogsBackupConfiguration BackupConfiguration
        {
            get { return this._backupConfiguration; }
            set { this._backupConfiguration = value; }
        }

        // Check to see if BackupConfiguration property is set
        internal bool IsSetBackupConfiguration()
        {
            return this._backupConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LogGroupNameConfiguration. 
        /// <para>
        /// Configuration that specifies a naming pattern for destination log groups created during
        /// centralization. The pattern supports static text and dynamic variables that are replaced
        /// with source attributes when log groups are created.
        /// </para>
        /// </summary>
        public LogGroupNameConfiguration LogGroupNameConfiguration
        {
            get { return this._logGroupNameConfiguration; }
            set { this._logGroupNameConfiguration = value; }
        }

        // Check to see if LogGroupNameConfiguration property is set
        internal bool IsSetLogGroupNameConfiguration()
        {
            return this._logGroupNameConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LogsEncryptionConfiguration. 
        /// <para>
        /// The encryption configuration for centralization destination log groups.
        /// </para>
        /// </summary>
        public LogsEncryptionConfiguration LogsEncryptionConfiguration
        {
            get { return this._logsEncryptionConfiguration; }
            set { this._logsEncryptionConfiguration = value; }
        }

        // Check to see if LogsEncryptionConfiguration property is set
        internal bool IsSetLogsEncryptionConfiguration()
        {
            return this._logsEncryptionConfiguration != null;
        }

    }
}