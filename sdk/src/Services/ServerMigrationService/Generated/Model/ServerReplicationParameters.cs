/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// Replication parameters for replicating a server.
    /// </summary>
    public partial class ServerReplicationParameters
    {
        private bool? _encrypted;
        private int? _frequency;
        private string _kmsKeyId;
        private LicenseType _licenseType;
        private int? _numberOfRecentAmisToKeep;
        private bool? _runOnce;
        private DateTime? _seedTime;

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// When true, the replication job produces encrypted AMIs. See also <code>KmsKeyId</code>
        /// below.
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
        /// Frequency of creating replication jobs for the server.
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
        /// KMS key ID for replication jobs that produce encrypted AMIs. Can be any of the following:
        /// 
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
        /// ARN referring to KMS key ID
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARN referring to KMS key alias
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  If encrypted is <i>true</i> but a KMS key id is not specified, the customer's default
        /// KMS key for EBS is used. 
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
        /// License type for creating a replication job for the server.
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
        /// Gets and sets the property NumberOfRecentAmisToKeep. 
        /// <para>
        /// Number of recent AMIs to keep when creating a replication job for this server.
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
        /// Gets and sets the property RunOnce.
        /// </summary>
        public bool RunOnce
        {
            get { return this._runOnce.GetValueOrDefault(); }
            set { this._runOnce = value; }
        }

        // Check to see if RunOnce property is set
        internal bool IsSetRunOnce()
        {
            return this._runOnce.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SeedTime. 
        /// <para>
        /// Seed time for creating a replication job for the server.
        /// </para>
        /// </summary>
        public DateTime SeedTime
        {
            get { return this._seedTime.GetValueOrDefault(); }
            set { this._seedTime = value; }
        }

        // Check to see if SeedTime property is set
        internal bool IsSetSeedTime()
        {
            return this._seedTime.HasValue; 
        }

    }
}