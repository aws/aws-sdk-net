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
    /// Container for the parameters to the StartTransaction operation.
    /// Starts a new transaction and returns its transaction ID. Transaction IDs are opaque
    /// objects that you can use to identify a transaction.
    /// </summary>
    public partial class StartTransactionRequest : AmazonLakeFormationRequest
    {
        private TransactionType _transactionType;

        /// <summary>
        /// Gets and sets the property TransactionType. 
        /// <para>
        /// Indicates whether this transaction should be read only or read and write. Writes made
        /// using a read-only transaction ID will be rejected. Read-only transactions do not need
        /// to be committed. 
        /// </para>
        /// </summary>
        public TransactionType TransactionType
        {
            get { return this._transactionType; }
            set { this._transactionType = value; }
        }

        // Check to see if TransactionType property is set
        internal bool IsSetTransactionType()
        {
            return this._transactionType != null;
        }

    }
}