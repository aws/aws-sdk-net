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
    /// The metadata of the contract.
    /// </summary>
    public partial class ContractMetadata
    {
        private int? _decimals;
        private string _name;
        private string _symbol;

        /// <summary>
        /// Gets and sets the property Decimals. 
        /// <para>
        /// The decimals used by the token contract.
        /// </para>
        /// </summary>
        public int? Decimals
        {
            get { return this._decimals; }
            set { this._decimals = value; }
        }

        // Check to see if Decimals property is set
        internal bool IsSetDecimals()
        {
            return this._decimals.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the token contract.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Symbol. 
        /// <para>
        /// The symbol of the token contract.
        /// </para>
        /// </summary>
        public string Symbol
        {
            get { return this._symbol; }
            set { this._symbol = value; }
        }

        // Check to see if Symbol property is set
        internal bool IsSetSymbol()
        {
            return this._symbol != null;
        }

    }
}