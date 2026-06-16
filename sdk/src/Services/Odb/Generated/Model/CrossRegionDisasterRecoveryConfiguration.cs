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
    /// The configuration for creating an Autonomous Database as a cross-Region disaster recovery
    /// peer.
    /// </summary>
    public partial class CrossRegionDisasterRecoveryConfiguration
    {
        private bool? _isReplicateAutomaticBackups;
        private DisasterRecoveryType _remoteDisasterRecoveryType;
        private string _sourceAutonomousDatabaseArn;

        /// <summary>
        /// Gets and sets the property IsReplicateAutomaticBackups. 
        /// <para>
        /// Indicates whether automatic backups are replicated to the disaster recovery database.
        /// </para>
        /// </summary>
        public bool? IsReplicateAutomaticBackups
        {
            get { return this._isReplicateAutomaticBackups; }
            set { this._isReplicateAutomaticBackups = value; }
        }

        // Check to see if IsReplicateAutomaticBackups property is set
        internal bool IsSetIsReplicateAutomaticBackups()
        {
            return this._isReplicateAutomaticBackups.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RemoteDisasterRecoveryType. 
        /// <para>
        /// The type of remote disaster recovery to configure, either Autonomous Data Guard or
        /// backup-based.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DisasterRecoveryType RemoteDisasterRecoveryType
        {
            get { return this._remoteDisasterRecoveryType; }
            set { this._remoteDisasterRecoveryType = value; }
        }

        // Check to see if RemoteDisasterRecoveryType property is set
        internal bool IsSetRemoteDisasterRecoveryType()
        {
            return this._remoteDisasterRecoveryType != null;
        }

        /// <summary>
        /// Gets and sets the property SourceAutonomousDatabaseArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source Autonomous Database for the cross-Region
        /// disaster recovery configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string SourceAutonomousDatabaseArn
        {
            get { return this._sourceAutonomousDatabaseArn; }
            set { this._sourceAutonomousDatabaseArn = value; }
        }

        // Check to see if SourceAutonomousDatabaseArn property is set
        internal bool IsSetSourceAutonomousDatabaseArn()
        {
            return this._sourceAutonomousDatabaseArn != null;
        }

    }
}