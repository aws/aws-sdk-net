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
 * Do not modify this file. This file is generated from the neptunedata-2023-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// A serialized SPARQL stream record capturing a change-log entry for the RDF graph.
    /// </summary>
    public partial class SparqlRecord
    {
        private long? _commitTimestampInMillis;
        private SparqlData _data;
        private Dictionary<string, string> _eventId = new Dictionary<string, string>();
        private bool? _isLastOp;
        private string _op;

        /// <summary>
        /// Gets and sets the property CommitTimestampInMillis. 
        /// <para>
        /// The time at which the commit for the transaction was requested, in milliseconds from
        /// the Unix epoch.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long CommitTimestampInMillis
        {
            get { return this._commitTimestampInMillis.GetValueOrDefault(); }
            set { this._commitTimestampInMillis = value; }
        }

        // Check to see if CommitTimestampInMillis property is set
        internal bool IsSetCommitTimestampInMillis()
        {
            return this._commitTimestampInMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The serialized SPARQL change record. The serialization formats of each record are
        /// described in more detail in <a href="https://docs.aws.amazon.com/neptune/latest/userguide/streams-change-formats.html">Serialization
        /// Formats in Neptune Streams</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SparqlData Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this._data != null;
        }

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The sequence identifier of the stream change record.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> EventId
        {
            get { return this._eventId; }
            set { this._eventId = value; }
        }

        // Check to see if EventId property is set
        internal bool IsSetEventId()
        {
            return this._eventId != null && this._eventId.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IsLastOp. 
        /// <para>
        /// Only present if this operation is the last one in its transaction. If present, it
        /// is set to true. It is useful for ensuring that an entire transaction is consumed.
        /// </para>
        /// </summary>
        public bool IsLastOp
        {
            get { return this._isLastOp.GetValueOrDefault(); }
            set { this._isLastOp = value; }
        }

        // Check to see if IsLastOp property is set
        internal bool IsSetIsLastOp()
        {
            return this._isLastOp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Op. 
        /// <para>
        /// The operation that created the change.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Op
        {
            get { return this._op; }
            set { this._op = value; }
        }

        // Check to see if Op property is set
        internal bool IsSetOp()
        {
            return this._op != null;
        }

    }
}