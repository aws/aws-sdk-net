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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// Container for the parameters to the GetSparqlStream operation.
    /// Gets a stream for an RDF graph.
    /// 
    ///  
    /// <para>
    /// With the Neptune Streams feature, you can generate a complete sequence of change-log
    /// entries that record every change made to your graph data as it happens. <c>GetSparqlStream</c>
    /// lets you collect these change-log entries for an RDF graph.
    /// </para>
    ///  
    /// <para>
    /// The Neptune streams feature needs to be enabled on your Neptune DBcluster. To enable
    /// streams, set the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/parameters.html#parameters-db-cluster-parameters-neptune_streams">neptune_streams</a>
    /// DB cluster parameter to <c>1</c>.
    /// </para>
    ///  
    /// <para>
    /// See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/streams.html">Capturing
    /// graph changes in real time using Neptune streams</a>.
    /// </para>
    ///  
    /// <para>
    /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
    /// the IAM user or role making the request must have a policy attached that allows the
    /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getstreamrecords">neptune-db:GetStreamRecords</a>
    /// IAM action in that cluster.
    /// </para>
    ///  
    /// <para>
    /// Note that the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html#iam-neptune-condition-keys">neptune-db:QueryLanguage:Sparql</a>
    /// IAM condition key can be used in the policy document to restrict the use of SPARQL
    /// queries (see <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-data-condition-keys.html">Condition
    /// keys available in Neptune IAM data-access policy statements</a>).
    /// </para>
    /// </summary>
    public partial class GetSparqlStreamRequest : AmazonNeptunedataRequest
    {
        private long? _commitNum;
        private Encoding _encoding;
        private IteratorType _iteratorType;
        private long? _limit;
        private long? _opNum;

        /// <summary>
        /// Gets and sets the property CommitNum. 
        /// <para>
        /// The commit number of the starting record to read from the change-log stream. This
        /// parameter is required when <c>iteratorType</c> is<c>AT_SEQUENCE_NUMBER</c> or <c>AFTER_SEQUENCE_NUMBER</c>,
        /// and ignored when <c>iteratorType</c> is <c>TRIM_HORIZON</c> or <c>LATEST</c>.
        /// </para>
        /// </summary>
        public long? CommitNum
        {
            get { return this._commitNum; }
            set { this._commitNum = value; }
        }

        // Check to see if CommitNum property is set
        internal bool IsSetCommitNum()
        {
            return this._commitNum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Encoding. 
        /// <para>
        /// If set to TRUE, Neptune compresses the response using gzip encoding.
        /// </para>
        /// </summary>
        public Encoding Encoding
        {
            get { return this._encoding; }
            set { this._encoding = value; }
        }

        // Check to see if Encoding property is set
        internal bool IsSetEncoding()
        {
            return this._encoding != null;
        }

        /// <summary>
        /// Gets and sets the property IteratorType. 
        /// <para>
        /// Can be one of:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AT_SEQUENCE_NUMBER</c>   –   Indicates that reading should start from the event
        /// sequence number specified jointly by the <c>commitNum</c> and <c>opNum</c> parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AFTER_SEQUENCE_NUMBER</c>   –   Indicates that reading should start right after
        /// the event sequence number specified jointly by the <c>commitNum</c> and <c>opNum</c>
        /// parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TRIM_HORIZON</c>   –   Indicates that reading should start at the last untrimmed
        /// record in the system, which is the oldest unexpired (not yet deleted) record in the
        /// change-log stream.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LATEST</c>   –   Indicates that reading should start at the most recent record
        /// in the system, which is the latest unexpired (not yet deleted) record in the change-log
        /// stream.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public IteratorType IteratorType
        {
            get { return this._iteratorType; }
            set { this._iteratorType = value; }
        }

        // Check to see if IteratorType property is set
        internal bool IsSetIteratorType()
        {
            return this._iteratorType != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// Specifies the maximum number of records to return. There is also a size limit of 10
        /// MB on the response that can't be modified and that takes precedence over the number
        /// of records specified in the <c>limit</c> parameter. The response does include a threshold-breaching
        /// record if the 10 MB limit was reached.
        /// </para>
        ///  
        /// <para>
        /// The range for <c>limit</c> is 1 to 100,000, with a default of 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100000)]
        public long? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OpNum. 
        /// <para>
        /// The operation sequence number within the specified commit to start reading from in
        /// the change-log stream data. The default is <c>1</c>.
        /// </para>
        /// </summary>
        public long? OpNum
        {
            get { return this._opNum; }
            set { this._opNum = value; }
        }

        // Check to see if OpNum property is set
        internal bool IsSetOpNum()
        {
            return this._opNum.HasValue; 
        }

    }
}