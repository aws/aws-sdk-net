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
    /// Configuration for centralization destination metrics, including backup settings.
    /// </summary>
    public partial class DestinationMetricsConfiguration
    {
        private MetricsBackupConfiguration _backupConfiguration;

        /// <summary>
        /// Gets and sets the property BackupConfiguration. 
        /// <para>
        /// Configuration defining the backup region for the metrics backup destination.
        /// </para>
        /// </summary>
        public MetricsBackupConfiguration BackupConfiguration
        {
            get { return this._backupConfiguration; }
            set { this._backupConfiguration = value; }
        }

        // Check to see if BackupConfiguration property is set
        internal bool IsSetBackupConfiguration()
        {
            return this._backupConfiguration != null;
        }

    }
}