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
 * Do not modify this file. This file is generated from the managedblockchain-query-2023-05-04.normal.json service model.
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
namespace Amazon.ManagedBlockchainQuery.Model
{
    /// <summary>
    /// This container specifies filtering attributes related to <c>BITCOIN_VOUT</c> event
    /// types
    /// </summary>
    public partial class VoutFilter
    {
        private bool? _voutSpent;

        /// <summary>
        /// Gets and sets the property VoutSpent. 
        /// <para>
        /// Specifies if the transaction output is spent or unspent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? VoutSpent
        {
            get { return this._voutSpent; }
            set { this._voutSpent = value; }
        }

        // Check to see if VoutSpent property is set
        internal bool IsSetVoutSpent()
        {
            return this._voutSpent.HasValue; 
        }

    }
}