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
    /// A structure that contains information about a backed-up resource.
    /// </summary>
    public partial class ProtectedResource
    {
        /// <summary>
        /// Gets and sets the property LastBackupTime. 
        /// <para>
        /// The date and time a resource was last backed up, in Unix format and Coordinated Universal
        /// Time (UTC). The value of <c>LastBackupTime</c> is accurate to milliseconds. For example,
        /// the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087 AM.
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
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a resource. The format of the
        /// ARN depends on the resource type.
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
        /// The non-unique name of the resource that belongs to the specified backup.
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
        /// The type of Amazon Web Services resource; for example, an Amazon Elastic Block Store
        /// (Amazon EBS) volume or an Amazon Relational Database Service (Amazon RDS) database.
        /// For Windows Volume Shadow Copy Service (VSS) backups, the only supported resource
        /// type is Amazon EC2.
        /// </para>
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}
