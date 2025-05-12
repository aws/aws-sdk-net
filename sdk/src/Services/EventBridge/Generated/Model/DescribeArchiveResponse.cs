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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
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
namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// This is the response object from the DescribeArchive operation.
    /// </summary>
    public partial class DescribeArchiveResponse : AmazonWebServiceResponse
    {
        private string _archiveArn;
        private string _archiveName;
        private DateTime? _creationTime;
        private string _description;
        private long? _eventCount;
        private string _eventPattern;
        private string _eventSourceArn;
        private string _kmsKeyIdentifier;
        private int? _retentionDays;
        private long? _sizeBytes;
        private ArchiveState _state;
        private string _stateReason;

        /// <summary>
        /// Gets and sets the property ArchiveArn. 
        /// <para>
        /// The ARN of the archive.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string ArchiveArn
        {
            get { return this._archiveArn; }
            set { this._archiveArn = value; }
        }

        // Check to see if ArchiveArn property is set
        internal bool IsSetArchiveArn()
        {
            return this._archiveArn != null;
        }

        /// <summary>
        /// Gets and sets the property ArchiveName. 
        /// <para>
        /// The name of the archive.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=48)]
        public string ArchiveName
        {
            get { return this._archiveName; }
            set { this._archiveName = value; }
        }

        // Check to see if ArchiveName property is set
        internal bool IsSetArchiveName()
        {
            return this._archiveName != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time at which the archive was created.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the archive.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
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
        /// Gets and sets the property EventCount. 
        /// <para>
        /// The number of events in the archive.
        /// </para>
        /// </summary>
        public long? EventCount
        {
            get { return this._eventCount; }
            set { this._eventCount = value; }
        }

        // Check to see if EventCount property is set
        internal bool IsSetEventCount()
        {
            return this._eventCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventPattern. 
        /// <para>
        /// The event pattern used to filter events sent to the archive.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string EventPattern
        {
            get { return this._eventPattern; }
            set { this._eventPattern = value; }
        }

        // Check to see if EventPattern property is set
        internal bool IsSetEventPattern()
        {
            return this._eventPattern != null;
        }

        /// <summary>
        /// Gets and sets the property EventSourceArn. 
        /// <para>
        /// The ARN of the event source associated with the archive.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string EventSourceArn
        {
            get { return this._eventSourceArn; }
            set { this._eventSourceArn = value; }
        }

        // Check to see if EventSourceArn property is set
        internal bool IsSetEventSourceArn()
        {
            return this._eventSourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyIdentifier. 
        /// <para>
        /// The identifier of the KMS customer managed key for EventBridge to use to encrypt this
        /// archive, if one has been specified.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/encryption-archives.html">Encrypting
        /// archives</a> in the <i>Amazon EventBridge User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string KmsKeyIdentifier
        {
            get { return this._kmsKeyIdentifier; }
            set { this._kmsKeyIdentifier = value; }
        }

        // Check to see if KmsKeyIdentifier property is set
        internal bool IsSetKmsKeyIdentifier()
        {
            return this._kmsKeyIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property RetentionDays. 
        /// <para>
        /// The number of days to retain events for in the archive.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? RetentionDays
        {
            get { return this._retentionDays; }
            set { this._retentionDays = value; }
        }

        // Check to see if RetentionDays property is set
        internal bool IsSetRetentionDays()
        {
            return this._retentionDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SizeBytes. 
        /// <para>
        /// The size of the archive in bytes.
        /// </para>
        /// </summary>
        public long? SizeBytes
        {
            get { return this._sizeBytes; }
            set { this._sizeBytes = value; }
        }

        // Check to see if SizeBytes property is set
        internal bool IsSetSizeBytes()
        {
            return this._sizeBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the archive.
        /// </para>
        /// </summary>
        public ArchiveState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// The reason that the archive is in the state.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string StateReason
        {
            get { return this._stateReason; }
            set { this._stateReason = value; }
        }

        // Check to see if StateReason property is set
        internal bool IsSetStateReason()
        {
            return this._stateReason != null;
        }

    }
}