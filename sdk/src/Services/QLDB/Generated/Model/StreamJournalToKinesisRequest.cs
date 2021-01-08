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
 * Do not modify this file. This file is generated from the qldb-2019-01-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QLDB.Model
{
    /// <summary>
    /// Container for the parameters to the StreamJournalToKinesis operation.
    /// Creates a journal stream for a given Amazon QLDB ledger. The stream captures every
    /// document revision that is committed to the ledger's journal and delivers the data
    /// to a specified Amazon Kinesis Data Streams resource.
    /// </summary>
    public partial class StreamJournalToKinesisRequest : AmazonQLDBRequest
    {
        private DateTime? _exclusiveEndTime;
        private DateTime? _inclusiveStartTime;
        private KinesisConfiguration _kinesisConfiguration;
        private string _ledgerName;
        private string _roleArn;
        private string _streamName;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ExclusiveEndTime. 
        /// <para>
        /// The exclusive date and time that specifies when the stream ends. If you don't define
        /// this parameter, the stream runs indefinitely until you cancel it.
        /// </para>
        ///  
        /// <para>
        /// The <code>ExclusiveEndTime</code> must be in <code>ISO 8601</code> date and time format
        /// and in Universal Coordinated Time (UTC). For example: <code>2019-06-13T21:36:34Z</code>
        /// 
        /// </para>
        /// </summary>
        public DateTime ExclusiveEndTime
        {
            get { return this._exclusiveEndTime.GetValueOrDefault(); }
            set { this._exclusiveEndTime = value; }
        }

        // Check to see if ExclusiveEndTime property is set
        internal bool IsSetExclusiveEndTime()
        {
            return this._exclusiveEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InclusiveStartTime. 
        /// <para>
        /// The inclusive start date and time from which to start streaming journal data. This
        /// parameter must be in <code>ISO 8601</code> date and time format and in Universal Coordinated
        /// Time (UTC). For example: <code>2019-06-13T21:36:34Z</code> 
        /// </para>
        ///  
        /// <para>
        /// The <code>InclusiveStartTime</code> cannot be in the future and must be before <code>ExclusiveEndTime</code>.
        /// </para>
        ///  
        /// <para>
        /// If you provide an <code>InclusiveStartTime</code> that is before the ledger's <code>CreationDateTime</code>,
        /// QLDB effectively defaults it to the ledger's <code>CreationDateTime</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime InclusiveStartTime
        {
            get { return this._inclusiveStartTime.GetValueOrDefault(); }
            set { this._inclusiveStartTime = value; }
        }

        // Check to see if InclusiveStartTime property is set
        internal bool IsSetInclusiveStartTime()
        {
            return this._inclusiveStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KinesisConfiguration. 
        /// <para>
        /// The configuration settings of the Kinesis Data Streams destination for your stream
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KinesisConfiguration KinesisConfiguration
        {
            get { return this._kinesisConfiguration; }
            set { this._kinesisConfiguration = value; }
        }

        // Check to see if KinesisConfiguration property is set
        internal bool IsSetKinesisConfiguration()
        {
            return this._kinesisConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LedgerName. 
        /// <para>
        /// The name of the ledger.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string LedgerName
        {
            get { return this._ledgerName; }
            set { this._ledgerName = value; }
        }

        // Check to see if LedgerName property is set
        internal bool IsSetLedgerName()
        {
            return this._ledgerName != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that grants QLDB permissions for a
        /// journal stream to write data records to a Kinesis Data Streams resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1600)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name that you want to assign to the QLDB journal stream. User-defined names can
        /// help identify and indicate the purpose of a stream.
        /// </para>
        ///  
        /// <para>
        /// Your stream name must be unique among other <i>active</i> streams for a given ledger.
        /// Stream names have the same naming constraints as ledger names, as defined in <a href="https://docs.aws.amazon.com/qldb/latest/developerguide/limits.html#limits.naming">Quotas
        /// in Amazon QLDB</a> in the <i>Amazon QLDB Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key-value pairs to add as tags to the stream that you want to create. Tag keys
        /// are case sensitive. Tag values are case sensitive and can be null.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}