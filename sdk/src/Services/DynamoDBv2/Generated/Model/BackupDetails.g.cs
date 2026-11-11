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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Contains the details of the backup created for the table.
    /// </summary>
    public partial class BackupDetails
    {
        /// <summary>
        /// Gets and sets the property BackupArn. 
        /// <para>
        /// ARN associated with the backup.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 37, Max = 1024)]
        public string BackupArn { get; set; }

        /// <summary>
        /// Checks to see if the BackupArn property is set.
        /// </summary>
        internal bool IsSetBackupArn() => this.BackupArn != null;

        /// <summary>
        /// Gets and sets the property BackupCreationDateTime. 
        /// <para>
        /// Time at which the backup was created. This is the request time of the backup. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? BackupCreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the BackupCreationDateTime property is set.
        /// </summary>
        internal bool IsSetBackupCreationDateTime() => this.BackupCreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property BackupExpiryDateTime. 
        /// <para>
        /// Time at which the automatic on-demand backup created by DynamoDB will expire. This
        /// <c>SYSTEM</c> on-demand backup expires automatically 35 days after its creation.
        /// </para>
        /// </summary>
        public DateTime? BackupExpiryDateTime { get; set; }

        /// <summary>
        /// Checks to see if the BackupExpiryDateTime property is set.
        /// </summary>
        internal bool IsSetBackupExpiryDateTime() => this.BackupExpiryDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property BackupName. 
        /// <para>
        /// Name of the requested backup.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 255)]
        public string BackupName { get; set; }

        /// <summary>
        /// Checks to see if the BackupName property is set.
        /// </summary>
        internal bool IsSetBackupName() => this.BackupName != null;

        /// <summary>
        /// Gets and sets the property BackupSizeBytes. 
        /// <para>
        /// Size of the backup in bytes. DynamoDB updates this value approximately every six hours.
        /// Recent changes might not be reflected in this value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? BackupSizeBytes { get; set; }

        /// <summary>
        /// Checks to see if the BackupSizeBytes property is set.
        /// </summary>
        internal bool IsSetBackupSizeBytes() => this.BackupSizeBytes.HasValue;

        /// <summary>
        /// Gets and sets the property BackupStatus. 
        /// <para>
        /// Backup can be in one of the following states: CREATING, ACTIVE, DELETED. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BackupStatus BackupStatus { get; set; }

        /// <summary>
        /// Checks to see if the BackupStatus property is set.
        /// </summary>
        internal bool IsSetBackupStatus() => this.BackupStatus != null;

        /// <summary>
        /// Gets and sets the property BackupType. 
        /// <para>
        /// BackupType:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>USER</c> - You create and manage these using the on-demand backup feature.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SYSTEM</c> - If you delete a table with point-in-time recovery enabled, a <c>SYSTEM</c>
        /// backup is automatically created and is retained for 35 days (at no additional cost).
        /// System backups allow you to restore the deleted table to the state it was in just
        /// before the point of deletion. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_BACKUP</c> - On-demand backup created by you from Backup service.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public BackupType BackupType { get; set; }

        /// <summary>
        /// Checks to see if the BackupType property is set.
        /// </summary>
        internal bool IsSetBackupType() => this.BackupType != null;
    }
}
