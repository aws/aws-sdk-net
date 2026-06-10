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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAutonomousDatabaseBackup operation.
    /// Updates the properties of an Autonomous Database backup.
    /// </summary>
    public partial class UpdateAutonomousDatabaseBackupRequest : AmazonOdbRequest
    {
        private string _autonomousDatabaseBackupId;
        private int? _retentionPeriodInDays;

        /// <summary>
        /// Gets and sets the property AutonomousDatabaseBackupId. 
        /// <para>
        /// The unique identifier of the Autonomous Database backup to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=64)]
        public string AutonomousDatabaseBackupId
        {
            get { return this._autonomousDatabaseBackupId; }
            set { this._autonomousDatabaseBackupId = value; }
        }

        // Check to see if AutonomousDatabaseBackupId property is set
        internal bool IsSetAutonomousDatabaseBackupId()
        {
            return this._autonomousDatabaseBackupId != null;
        }

        /// <summary>
        /// Gets and sets the property RetentionPeriodInDays. 
        /// <para>
        /// The retention period, in days, for the Autonomous Database backup.
        /// </para>
        /// </summary>
        [AWSProperty(Min=90, Max=3650)]
        public int? RetentionPeriodInDays
        {
            get { return this._retentionPeriodInDays; }
            set { this._retentionPeriodInDays = value; }
        }

        // Check to see if RetentionPeriodInDays property is set
        internal bool IsSetRetentionPeriodInDays()
        {
            return this._retentionPeriodInDays.HasValue; 
        }

    }
}