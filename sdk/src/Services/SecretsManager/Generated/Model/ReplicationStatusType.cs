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
 * Do not modify this file. This file is generated from the secretsmanager-2017-10-17.normal.json service model.
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
        private string _kmsKeyId;
        private DateTime? _lastAccessedDate;
        private string _region;
        private StatusType _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// Can be an <c>ARN</c>, <c>Key ID</c>, or <c>Alias</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Gets and sets the property LastAccessedDate. 
        /// <para>
        /// The date that the secret was last accessed in the Region. This field is omitted if
        /// the secret has never been retrieved in the Region.
        /// </para>
        /// </summary>
        public DateTime? LastAccessedDate
        {
            get { return this._lastAccessedDate; }
            set { this._lastAccessedDate = value; }
        }

        // Check to see if LastAccessedDate property is set
        internal bool IsSetLastAccessedDate()
        {
            return this._lastAccessedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Region where replication occurs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status can be <c>InProgress</c>, <c>Failed</c>, or <c>InSync</c>.
        /// </para>
        /// </summary>
        public StatusType Status
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
        /// Status message such as "<i>Secret with this name already exists in this region</i>".
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
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