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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Represents the output for <a>DescribeStreamSummary</a>
    /// </summary>
    public partial class StreamDescriptionSummary
    {
        private EncryptionType _encryptionType;
        private List<EnhancedMetrics> _enhancedMonitoring = new List<EnhancedMetrics>();
        private string _keyId;
        private int? _openShardCount;
        private int? _retentionPeriodHours;
        private string _streamARN;
        private DateTime? _streamCreationTimestamp;
        private string _streamName;
        private StreamStatus _streamStatus;

        /// <summary>
        /// Gets and sets the property EncryptionType. 
        /// <para>
        /// The encryption type used. This value is one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>KMS</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NONE</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EncryptionType EncryptionType
        {
            get { return this._encryptionType; }
            set { this._encryptionType = value; }
        }

        // Check to see if EncryptionType property is set
        internal bool IsSetEncryptionType()
        {
            return this._encryptionType != null;
        }

        /// <summary>
        /// Gets and sets the property EnhancedMonitoring. 
        /// <para>
        /// Represents the current enhanced monitoring settings of the stream.
        /// </para>
        /// </summary>
        public List<EnhancedMetrics> EnhancedMonitoring
        {
            get { return this._enhancedMonitoring; }
            set { this._enhancedMonitoring = value; }
        }

        // Check to see if EnhancedMonitoring property is set
        internal bool IsSetEnhancedMonitoring()
        {
            return this._enhancedMonitoring != null && this._enhancedMonitoring.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The GUID for the customer-managed AWS KMS key to use for encryption. This value can
        /// be a globally unique identifier, a fully specified ARN to either an alias or a key,
        /// or an alias name prefixed by "alias/".You can also use a master key owned by Kinesis
        /// Data Streams by specifying the alias <code>aws/kinesis</code>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ARN example: <code>arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias ARN example: <code> arn:aws:kms:us-east-1:123456789012:alias/MyAliasName</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Globally unique key ID example: <code>12345678-1234-1234-1234-123456789012</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias name example: <code>alias/MyAliasName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Master key owned by Kinesis Data Streams: <code>alias/aws/kinesis</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string KeyId
        {
            get { return this._keyId; }
            set { this._keyId = value; }
        }

        // Check to see if KeyId property is set
        internal bool IsSetKeyId()
        {
            return this._keyId != null;
        }

        /// <summary>
        /// Gets and sets the property OpenShardCount. 
        /// <para>
        /// The number of open shards in the stream.
        /// </para>
        /// </summary>
        public int OpenShardCount
        {
            get { return this._openShardCount.GetValueOrDefault(); }
            set { this._openShardCount = value; }
        }

        // Check to see if OpenShardCount property is set
        internal bool IsSetOpenShardCount()
        {
            return this._openShardCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetentionPeriodHours. 
        /// <para>
        /// The current retention period, in hours.
        /// </para>
        /// </summary>
        public int RetentionPeriodHours
        {
            get { return this._retentionPeriodHours.GetValueOrDefault(); }
            set { this._retentionPeriodHours = value; }
        }

        // Check to see if RetentionPeriodHours property is set
        internal bool IsSetRetentionPeriodHours()
        {
            return this._retentionPeriodHours.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the stream being described.
        /// </para>
        /// </summary>
        public string StreamARN
        {
            get { return this._streamARN; }
            set { this._streamARN = value; }
        }

        // Check to see if StreamARN property is set
        internal bool IsSetStreamARN()
        {
            return this._streamARN != null;
        }

        /// <summary>
        /// Gets and sets the property StreamCreationTimestamp. 
        /// <para>
        /// The approximate time that the stream was created.
        /// </para>
        /// </summary>
        public DateTime StreamCreationTimestamp
        {
            get { return this._streamCreationTimestamp.GetValueOrDefault(); }
            set { this._streamCreationTimestamp = value; }
        }

        // Check to see if StreamCreationTimestamp property is set
        internal bool IsSetStreamCreationTimestamp()
        {
            return this._streamCreationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream being described.
        /// </para>
        /// </summary>
        public string StreamName
        {
            get { return this._streamName; }
            set { this._streamName = value; }
        }

        // Check to see if StreamName property is set
        internal bool IsSetStreamName()
        {
            return this._streamName != null;
        }

        /// <summary>
        /// Gets and sets the property StreamStatus. 
        /// <para>
        /// The current status of the stream being described. The stream status is one of the
        /// following states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CREATING</code> - The stream is being created. Kinesis Data Streams immediately
        /// returns and sets <code>StreamStatus</code> to <code>CREATING</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETING</code> - The stream is being deleted. The specified stream is in the
        /// <code>DELETING</code> state until Kinesis Data Streams completes the deletion.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ACTIVE</code> - The stream exists and is ready for read and write operations
        /// or deletion. You should perform read and write operations only on an <code>ACTIVE</code>
        /// stream.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UPDATING</code> - Shards in the stream are being merged or split. Read and
        /// write operations continue to work while the stream is in the <code>UPDATING</code>
        /// state.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StreamStatus StreamStatus
        {
            get { return this._streamStatus; }
            set { this._streamStatus = value; }
        }

        // Check to see if StreamStatus property is set
        internal bool IsSetStreamStatus()
        {
            return this._streamStatus != null;
        }

    }
}