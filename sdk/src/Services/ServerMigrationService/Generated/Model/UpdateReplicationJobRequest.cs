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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateReplicationJob operation.
    /// Updates the specified settings for the specified replication job.
    /// </summary>
    public partial class UpdateReplicationJobRequest : AmazonServerMigrationServiceRequest
    {
        private string _description;
        private bool? _encrypted;
        private int? _frequency;
        private string _kmsKeyId;
        private LicenseType _licenseType;
        private DateTime? _nextReplicationRunStartTime;
        private int? _numberOfRecentAmisToKeep;
        private string _replicationJobId;
        private string _roleName;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the replication job.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// When true, the replication job produces encrypted AMIs. For more information, <code>KmsKeyId</code>.
        /// </para>
        /// </summary>
        public bool Encrypted
        {
            get { return this._encrypted.GetValueOrDefault(); }
            set { this._encrypted = value; }
        }

        // Check to see if Encrypted property is set
        internal bool IsSetEncrypted()
        {
            return this._encrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Frequency. 
        /// <para>
        /// The time between consecutive replication runs, in hours.
        /// </para>
        /// </summary>
        public int Frequency
        {
            get { return this._frequency.GetValueOrDefault(); }
            set { this._frequency = value; }
        }

        // Check to see if Frequency property is set
        internal bool IsSetFrequency()
        {
            return this._frequency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the KMS key for replication jobs that produce encrypted AMIs. This value
        /// can be any of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// KMS key ID
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// KMS key alias
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARN referring to the KMS key ID
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARN referring to the KMS key alias
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If encrypted is enabled but a KMS key ID is not specified, the customer's default
        /// KMS key for Amazon EBS is used.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LicenseType. 
        /// <para>
        /// The license type to be used for the AMI created by a successful replication run.
        /// </para>
        /// </summary>
        public LicenseType LicenseType
        {
            get { return this._licenseType; }
            set { this._licenseType = value; }
        }

        // Check to see if LicenseType property is set
        internal bool IsSetLicenseType()
        {
            return this._licenseType != null;
        }

        /// <summary>
        /// Gets and sets the property NextReplicationRunStartTime. 
        /// <para>
        /// The start time of the next replication run.
        /// </para>
        /// </summary>
        public DateTime NextReplicationRunStartTime
        {
            get { return this._nextReplicationRunStartTime.GetValueOrDefault(); }
            set { this._nextReplicationRunStartTime = value; }
        }

        // Check to see if NextReplicationRunStartTime property is set
        internal bool IsSetNextReplicationRunStartTime()
        {
            return this._nextReplicationRunStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfRecentAmisToKeep. 
        /// <para>
        /// The maximum number of SMS-created AMIs to retain. The oldest is deleted after the
        /// maximum number is reached and a new AMI is created.
        /// </para>
        /// </summary>
        public int NumberOfRecentAmisToKeep
        {
            get { return this._numberOfRecentAmisToKeep.GetValueOrDefault(); }
            set { this._numberOfRecentAmisToKeep = value; }
        }

        // Check to see if NumberOfRecentAmisToKeep property is set
        internal bool IsSetNumberOfRecentAmisToKeep()
        {
            return this._numberOfRecentAmisToKeep.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationJobId. 
        /// <para>
        /// The ID of the replication job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReplicationJobId
        {
            get { return this._replicationJobId; }
            set { this._replicationJobId = value; }
        }

        // Check to see if ReplicationJobId property is set
        internal bool IsSetReplicationJobId()
        {
            return this._replicationJobId != null;
        }

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The name of the IAM role to be used by AWS SMS.
        /// </para>
        /// </summary>
        public string RoleName
        {
            get { return this._roleName; }
            set { this._roleName = value; }
        }

        // Check to see if RoleName property is set
        internal bool IsSetRoleName()
        {
            return this._roleName != null;
        }

    }
}