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
 * Do not modify this file. This file is generated from the qldb-session-2019-07-11.normal.json service model.
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
namespace Amazon.QLDBSession.Model
{
    /// <summary>
    /// Contains the details of the transaction to commit.
    /// </summary>
    public partial class CommitTransactionRequest
    {
        private MemoryStream _commitDigest;
        private string _transactionId;

        /// <summary>
        /// Gets and sets the property CommitDigest. 
        /// <para>
        /// Specifies the commit digest for the transaction to commit. For every active transaction,
        /// the commit digest must be passed. QLDB validates <c>CommitDigest</c> and rejects the
        /// commit with an error if the digest computed on the client does not match the digest
        /// computed by QLDB.
        /// </para>
        ///  
        /// <para>
        /// The purpose of the <c>CommitDigest</c> parameter is to ensure that QLDB commits a
        /// transaction if and only if the server has processed the exact set of statements sent
        /// by the client, in the same order that client sent them, and with no duplicates.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MemoryStream CommitDigest
        {
            get { return this._commitDigest; }
            set { this._commitDigest = value; }
        }

        // Check to see if CommitDigest property is set
        internal bool IsSetCommitDigest()
        {
            return this._commitDigest != null;
        }

        /// <summary>
        /// Gets and sets the property TransactionId. 
        /// <para>
        /// Specifies the transaction ID of the transaction to commit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=22, Max=22)]
        public string TransactionId
        {
            get { return this._transactionId; }
            set { this._transactionId = value; }
        }

        // Check to see if TransactionId property is set
        internal bool IsSetTransactionId()
        {
            return this._transactionId != null;
        }

    }
}