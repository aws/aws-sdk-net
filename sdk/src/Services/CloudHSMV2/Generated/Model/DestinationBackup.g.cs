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

namespace Amazon.CloudHSMV2.Model
{
    /// <summary>
    /// Contains information about the backup that will be copied and created by the <a>CopyBackupToRegion</a>
    /// operation.
    /// </summary>
    public partial class DestinationBackup
    {
        /// <summary>
        /// Gets and sets the property CreateTimestamp. 
        /// <para>
        /// The date and time when both the source backup was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreateTimestamp property is set.
        /// </summary>
        internal bool IsSetCreateTimestamp() => this.CreateTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property SourceBackup. 
        /// <para>
        /// The identifier (ID) of the source backup from which the new backup was copied.
        /// </para>
        /// </summary>
        public string SourceBackup { get; set; }

        /// <summary>
        /// Checks to see if the SourceBackup property is set.
        /// </summary>
        internal bool IsSetSourceBackup() => this.SourceBackup != null;

        /// <summary>
        /// Gets and sets the property SourceCluster. 
        /// <para>
        /// The identifier (ID) of the cluster containing the source backup from which the new
        /// backup was copied.
        /// </para>
        /// </summary>
        public string SourceCluster { get; set; }

        /// <summary>
        /// Checks to see if the SourceCluster property is set.
        /// </summary>
        internal bool IsSetSourceCluster() => this.SourceCluster != null;

        /// <summary>
        /// Gets and sets the property SourceRegion. 
        /// <para>
        /// The AWS region that contains the source backup from which the new backup was copied.
        /// </para>
        /// </summary>
        public string SourceRegion { get; set; }

        /// <summary>
        /// Checks to see if the SourceRegion property is set.
        /// </summary>
        internal bool IsSetSourceRegion() => this.SourceRegion != null;
    }
}
