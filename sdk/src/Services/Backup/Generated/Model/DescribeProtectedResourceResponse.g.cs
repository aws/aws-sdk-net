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

namespace Amazon.Backup.Model
{
    /// <summary>
    /// This is the response object from the DescribeProtectedResource operation.
    /// </summary>
    public partial class DescribeProtectedResourceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property LastBackupTime. 
        /// <para>
        /// The date and time that a resource was last backed up, in Unix format and Coordinated
        /// Universal Time (UTC). The value of <c>LastBackupTime</c> is accurate to milliseconds.
        /// For example, the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087
        /// AM.
        /// </para>
        /// </summary>
        public DateTime? LastBackupTime { get; set; }

        /// <summary>
        /// Checks to see if the LastBackupTime property is set.
        /// </summary>
        internal bool IsSetLastBackupTime() => this.LastBackupTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastBackupVaultArn. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the backup vault that contains the most recent backup
        /// recovery point.
        /// </para>
        /// </summary>
        public string LastBackupVaultArn { get; set; }

        /// <summary>
        /// Checks to see if the LastBackupVaultArn property is set.
        /// </summary>
        internal bool IsSetLastBackupVaultArn() => this.LastBackupVaultArn != null;

        /// <summary>
        /// Gets and sets the property LastRecoveryPointArn. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the most recent recovery point.
        /// </para>
        /// </summary>
        public string LastRecoveryPointArn { get; set; }

        /// <summary>
        /// Checks to see if the LastRecoveryPointArn property is set.
        /// </summary>
        internal bool IsSetLastRecoveryPointArn() => this.LastRecoveryPointArn != null;

        /// <summary>
        /// Gets and sets the property LatestRestoreExecutionTimeMinutes. 
        /// <para>
        /// The time, in minutes, that the most recent restore job took to complete.
        /// </para>
        /// </summary>
        public long? LatestRestoreExecutionTimeMinutes { get; set; }

        /// <summary>
        /// Checks to see if the LatestRestoreExecutionTimeMinutes property is set.
        /// </summary>
        internal bool IsSetLatestRestoreExecutionTimeMinutes() => this.LatestRestoreExecutionTimeMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property LatestRestoreJobCreationDate. 
        /// <para>
        /// The creation date of the most recent restore job.
        /// </para>
        /// </summary>
        public DateTime? LatestRestoreJobCreationDate { get; set; }

        /// <summary>
        /// Checks to see if the LatestRestoreJobCreationDate property is set.
        /// </summary>
        internal bool IsSetLatestRestoreJobCreationDate() => this.LatestRestoreJobCreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property LatestRestoreRecoveryPointCreationDate. 
        /// <para>
        /// The date the most recent recovery point was created.
        /// </para>
        /// </summary>
        public DateTime? LatestRestoreRecoveryPointCreationDate { get; set; }

        /// <summary>
        /// Checks to see if the LatestRestoreRecoveryPointCreationDate property is set.
        /// </summary>
        internal bool IsSetLatestRestoreRecoveryPointCreationDate() => this.LatestRestoreRecoveryPointCreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// An ARN that uniquely identifies a resource. The format of the ARN depends on the resource
        /// type.
        /// </para>
        /// </summary>
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The name of the resource that belongs to the specified backup.
        /// </para>
        /// </summary>
        public string ResourceName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceName property is set.
        /// </summary>
        internal bool IsSetResourceName() => this.ResourceName != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of Amazon Web Services resource saved as a recovery point; for example, an
        /// Amazon EBS volume or an Amazon RDS database.
        /// </para>
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}
