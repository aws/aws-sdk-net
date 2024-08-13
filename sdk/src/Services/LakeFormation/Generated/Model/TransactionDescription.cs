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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
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
namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// A structure that contains information about a transaction.
    /// </summary>
    public partial class TransactionDescription
    {
        private DateTime? _transactionEndTime;
        private string _transactionId;
        private DateTime? _transactionStartTime;
        private TransactionStatus _transactionStatus;

        /// <summary>
        /// Gets and sets the property TransactionEndTime. 
        /// <para>
        /// The time when the transaction committed or aborted, if it is not currently active.
        /// </para>
        /// </summary>
        public DateTime? TransactionEndTime
        {
            get { return this._transactionEndTime; }
            set { this._transactionEndTime = value; }
        }

        // Check to see if TransactionEndTime property is set
        internal bool IsSetTransactionEndTime()
        {
            return this._transactionEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransactionId. 
        /// <para>
        /// The ID of the transaction.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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

        /// <summary>
        /// Gets and sets the property TransactionStartTime. 
        /// <para>
        /// The time when the transaction started.
        /// </para>
        /// </summary>
        public DateTime? TransactionStartTime
        {
            get { return this._transactionStartTime; }
            set { this._transactionStartTime = value; }
        }

        // Check to see if TransactionStartTime property is set
        internal bool IsSetTransactionStartTime()
        {
            return this._transactionStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransactionStatus. 
        /// <para>
        /// A status of ACTIVE, COMMITTED, or ABORTED.
        /// </para>
        /// </summary>
        public TransactionStatus TransactionStatus
        {
            get { return this._transactionStatus; }
            set { this._transactionStatus = value; }
        }

        // Check to see if TransactionStatus property is set
        internal bool IsSetTransactionStatus()
        {
            return this._transactionStatus != null;
        }

    }
}