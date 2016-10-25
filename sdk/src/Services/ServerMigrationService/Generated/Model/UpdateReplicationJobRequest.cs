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
    /// Container for the parameters to the UpdateReplicationJob operation.
    /// The UpdateReplicationJob API is used to change the settings of your existing ReplicationJob
    /// created using CreateReplicationJob. Calling this API will affect the next scheduled
    /// ReplicationRun.
    /// </summary>
    public partial class UpdateReplicationJobRequest : AmazonServerMigrationServiceRequest
    {
        private string _description;
        private int? _frequency;
        private LicenseType _licenseType;
        private DateTime? _nextReplicationRunStartTime;
        private string _replicationJobId;
        private string _roleName;

        /// <summary>
        /// Gets and sets the property Description.
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
        /// Gets and sets the property Frequency.
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
        /// Gets and sets the property LicenseType.
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
        /// Gets and sets the property ReplicationJobId.
        /// </summary>
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