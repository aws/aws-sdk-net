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
 * Do not modify this file. This file is generated from the rds-data-2018-08-01.normal.json service model.
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
namespace Amazon.RDSDataService.Model
{
    /// <summary>
    /// The response elements represent the output of a request to perform a rollback of a
    /// transaction.
    /// </summary>
    public partial class RollbackTransactionResponse : AmazonWebServiceResponse
    {
        private string _transactionStatus;

        /// <summary>
        /// Gets and sets the property TransactionStatus. 
        /// <para>
        /// The status of the rollback operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string TransactionStatus
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