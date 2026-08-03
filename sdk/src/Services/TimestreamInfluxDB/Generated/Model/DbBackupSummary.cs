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
 * Do not modify this file. This file is generated from the timestream-influxdb-2023-01-27.normal.json service model.
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
namespace Amazon.TimestreamInfluxDB.Model
{
    /// <summary>
    /// Contains a summary of a Timestream for InfluxDB backup.
    /// </summary>
    public partial class DbBackupSummary
    {
        private string _arn;
        private DateTime? _createdAt;
        private string _dbResourceId;
        private ResourceDeploymentType _deploymentType;
        private EngineType _engineType;
        private string _expiresAfter;
        private string _id;
        private string _kmsKeyId;
        private string _name;
        private DbBackupStatus _status;
        private DbBackupType _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the backup.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the backup was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DbResourceId. 
        /// <para>
        /// The identifier of the DB resource that the backup was created from.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=64)]
        public string DbResourceId
        {
            get { return this._dbResourceId; }
            set { this._dbResourceId = value; }
        }

        // Check to see if DbResourceId property is set
        internal bool IsSetDbResourceId()
        {
            return this._dbResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentType. 
        /// <para>
        /// The deployment type of the resource that the backup was created from.
        /// </para>
        /// </summary>
        public ResourceDeploymentType DeploymentType
        {
            get { return this._deploymentType; }
            set { this._deploymentType = value; }
        }

        // Check to see if DeploymentType property is set
        internal bool IsSetDeploymentType()
        {
            return this._deploymentType != null;
        }

        /// <summary>
        /// Gets and sets the property EngineType. 
        /// <para>
        /// The engine type of the resource that the backup was created from.
        /// </para>
        /// </summary>
        public EngineType EngineType
        {
            get { return this._engineType; }
            set { this._engineType = value; }
        }

        // Check to see if EngineType property is set
        internal bool IsSetEngineType()
        {
            return this._engineType != null;
        }

        /// <summary>
        /// Gets and sets the property ExpiresAfter. 
        /// <para>
        /// The date after which the backup will be automatically deleted.
        /// </para>
        /// </summary>
        public string ExpiresAfter
        {
            get { return this._expiresAfter; }
            set { this._expiresAfter = value; }
        }

        // Check to see if ExpiresAfter property is set
        internal bool IsSetExpiresAfter()
        {
            return this._expiresAfter != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Service-generated unique identifier of the backup.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=64)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key ARN used for encryption of the resource at the time
        /// of backup.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The customer-provided name of the backup.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=40)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the backup. Valid values are IN_PROGRESS, COMPLETED, FAILED, DELETING,
        /// and DELETED.
        /// </para>
        /// </summary>
        public DbBackupStatus Status
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of backup. Valid values are HOURLY, DAILY, WEEKLY, MONTHLY, CUSTOM_SCHEDULE,
        /// ON_DEMAND, and CONTINUOUS.
        /// </para>
        /// </summary>
        public DbBackupType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}