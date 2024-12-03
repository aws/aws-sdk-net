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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
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
namespace Amazon.B2bi.Model
{
    /// <summary>
    /// A structure that contains the X12 transaction set and version. The X12 structure is
    /// used when the system transforms an EDI (electronic data interchange) file.
    /// 
    ///  <note> 
    /// <para>
    /// If an EDI input file contains more than one transaction, each transaction must have
    /// the same transaction set and version, for example 214/4010. If not, the transformer
    /// cannot parse the file.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class X12Details
    {
        private X12TransactionSet _transactionSet;
        private X12Version _version;

        /// <summary>
        /// Gets and sets the property TransactionSet. 
        /// <para>
        /// Returns an enumerated type where each value identifies an X12 transaction set. Transaction
        /// sets are maintained by the X12 Accredited Standards Committee.
        /// </para>
        /// </summary>
        public X12TransactionSet TransactionSet
        {
            get { return this._transactionSet; }
            set { this._transactionSet = value; }
        }

        // Check to see if TransactionSet property is set
        internal bool IsSetTransactionSet()
        {
            return this._transactionSet != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// Returns the version to use for the specified X12 transaction set.
        /// </para>
        /// </summary>
        public X12Version Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}