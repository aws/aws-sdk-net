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
 * Do not modify this file. This file is generated from the cloudhsmv2-2017-04-28.normal.json service model.
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
namespace Amazon.CloudHSMV2.Model
{
    /// <summary>
    /// Contains information about the backup that will be copied and created by the <a>CopyBackupToRegion</a>
    /// operation.
    /// </summary>
    public partial class DestinationBackup
    {
        private DateTime? _createTimestamp;
        private string _sourceBackup;
        private string _sourceCluster;
        private string _sourceRegion;

        /// <summary>
        /// Gets and sets the property CreateTimestamp. 
        /// <para>
        /// The date and time when both the source backup was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTimestamp
        {
            get { return this._createTimestamp; }
            set { this._createTimestamp = value; }
        }

        // Check to see if CreateTimestamp property is set
        internal bool IsSetCreateTimestamp()
        {
            return this._createTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceBackup. 
        /// <para>
        /// The identifier (ID) of the source backup from which the new backup was copied.
        /// </para>
        /// </summary>
        public string SourceBackup
        {
            get { return this._sourceBackup; }
            set { this._sourceBackup = value; }
        }

        // Check to see if SourceBackup property is set
        internal bool IsSetSourceBackup()
        {
            return this._sourceBackup != null;
        }

        /// <summary>
        /// Gets and sets the property SourceCluster. 
        /// <para>
        /// The identifier (ID) of the cluster containing the source backup from which the new
        /// backup was copied.
        /// </para>
        /// </summary>
        public string SourceCluster
        {
            get { return this._sourceCluster; }
            set { this._sourceCluster = value; }
        }

        // Check to see if SourceCluster property is set
        internal bool IsSetSourceCluster()
        {
            return this._sourceCluster != null;
        }

        /// <summary>
        /// Gets and sets the property SourceRegion. 
        /// <para>
        /// The AWS region that contains the source backup from which the new backup was copied.
        /// </para>
        /// </summary>
        public string SourceRegion
        {
            get { return this._sourceRegion; }
            set { this._sourceRegion = value; }
        }

        // Check to see if SourceRegion property is set
        internal bool IsSetSourceRegion()
        {
            return this._sourceRegion != null;
        }

    }
}