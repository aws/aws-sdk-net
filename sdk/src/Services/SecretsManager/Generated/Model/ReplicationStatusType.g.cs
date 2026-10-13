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

namespace Amazon.SecretsManager.Model
{
    /// <summary>
    /// A replication object consisting of a <c>RegionReplicationStatus</c> object and includes
    /// a Region, KMSKeyId, status, and status message.
    /// </summary>
    public partial class ReplicationStatusType
    {
        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// Can be an <c>ARN</c>, <c>Key ID</c>, or <c>Alias</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LastAccessedDate. 
        /// <para>
        /// The date that the secret was last accessed in the Region. This field is omitted if
        /// the secret has never been retrieved in the Region.
        /// </para>
        /// </summary>
        public DateTime? LastAccessedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastAccessedDate property is set.
        /// </summary>
        internal bool IsSetLastAccessedDate() => this.LastAccessedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Region where replication occurs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status can be <c>InProgress</c>, <c>Failed</c>, or <c>InSync</c>.
        /// </para>
        /// </summary>
        public StatusType Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Status message such as "<i>Secret with this name already exists in this region</i>".
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}
