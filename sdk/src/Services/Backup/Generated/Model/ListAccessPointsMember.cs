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
    /// Contains metadata about a backup access point.
    /// </summary>
    public partial class ListAccessPointsMember
    {
        private string _accessPointArn;
        private Dictionary<string, string> _accessPointMetadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _backupVaultArn;
        private string _backupVaultName;
        private DateTime? _creationTime;
        private string _name;
        private string _recoveryPointArn;
        private string _resourceArn;
        private string _resourceType;
        private AccessPointStatus _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property AccessPointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the backup access point.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AccessPointArn
        {
            get { return this._accessPointArn; }
            set { this._accessPointArn = value; }
        }

        // Check to see if AccessPointArn property is set
        internal bool IsSetAccessPointArn()
        {
            return this._accessPointArn != null;
        }

        /// <summary>
        /// Gets and sets the property AccessPointMetadata. 
        /// <para>
        /// Metadata for the backup access point. After the backup access point reaches the <c>AVAILABLE</c>
        /// status, this map contains <c>S3AccessPointArn</c> and <c>S3AccessPointAlias</c>, which
        /// you use with standard Amazon S3 read APIs to access the backup data. For continuous
        /// recovery points, this map also contains <c>AccessPointInTime</c> (in format <c>2021-11-27T03:30:27Z</c>).
        /// The access point provides access to the content present in the backup at that specific
        /// time.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public Dictionary<string, string> AccessPointMetadata
        {
            get { return this._accessPointMetadata; }
            set { this._accessPointMetadata = value; }
        }

        // Check to see if AccessPointMetadata property is set
        internal bool IsSetAccessPointMetadata()
        {
            return this._accessPointMetadata != null && (this._accessPointMetadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BackupVaultArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the backup vault that contains the recovery point.
        /// </para>
        /// </summary>
        public string BackupVaultArn
        {
            get { return this._backupVaultArn; }
            set { this._backupVaultArn = value; }
        }

        // Check to see if BackupVaultArn property is set
        internal bool IsSetBackupVaultArn()
        {
            return this._backupVaultArn != null;
        }

        /// <summary>
        /// Gets and sets the property BackupVaultName. 
        /// <para>
        /// The name of the backup vault that contains the recovery point.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BackupVaultName
        {
            get { return this._backupVaultName; }
            set { this._backupVaultName = value; }
        }

        // Check to see if BackupVaultName property is set
        internal bool IsSetBackupVaultName()
        {
            return this._backupVaultName != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the backup access point was created, in Unix format and Coordinated
        /// Universal Time (UTC). The value of <c>CreationTime</c> is accurate to milliseconds.
        /// For example, the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087
        /// AM.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the backup access point.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=50)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RecoveryPointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the recovery point that the backup access point
        /// provides access to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RecoveryPointArn
        {
            get { return this._recoveryPointArn; }
            set { this._recoveryPointArn = value; }
        }

        // Check to see if RecoveryPointArn property is set
        internal bool IsSetRecoveryPointArn()
        {
            return this._recoveryPointArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource that was backed up, such as an Amazon
        /// S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of Amazon Web Services resource associated with the recovery point. For example,
        /// <c>S3</c> for Amazon Simple Storage Service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the backup access point.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccessPointStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message that provides additional detail about the status of the backup access point,
        /// such as the reason a creation or deletion attempt failed.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}