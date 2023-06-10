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
    /// Container for the parameters to the GetBlock operation.
    /// Returns a block object at a specified address in a journal. Also returns a proof of
    /// the specified block for verification if <code>DigestTipAddress</code> is provided.
    /// 
    ///  
    /// <para>
    /// For information about the data contents in a block, see <a href="https://docs.aws.amazon.com/qldb/latest/developerguide/journal-contents.html">Journal
    /// contents</a> in the <i>Amazon QLDB Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If the specified ledger doesn't exist or is in <code>DELETING</code> status, then
    /// throws <code>ResourceNotFoundException</code>.
    /// </para>
    ///  
    /// <para>
    /// If the specified ledger is in <code>CREATING</code> status, then throws <code>ResourcePreconditionNotMetException</code>.
    /// </para>
    ///  
    /// <para>
    /// If no block exists with the specified address, then throws <code>InvalidParameterException</code>.
    /// </para>
    /// </summary>
    public partial class GetBlockRequest : AmazonQLDBRequest
    {
        private ValueHolder _blockAddress;
        private ValueHolder _digestTipAddress;
        private string _name;

        /// <summary>
        /// Gets and sets the property BlockAddress. 
        /// <para>
        /// The location of the block that you want to request. An address is an Amazon Ion structure
        /// that has two fields: <code>strandId</code> and <code>sequenceNo</code>.
        /// </para>
        ///  
        /// <para>
        /// For example: <code>{strandId:"BlFTjlSXze9BIh1KOszcE3",sequenceNo:14}</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public ValueHolder BlockAddress
        {
            get { return this._blockAddress; }
            set { this._blockAddress = value; }
        }

        // Check to see if BlockAddress property is set
        internal bool IsSetBlockAddress()
        {
            return this._blockAddress != null;
        }

        /// <summary>
        /// Gets and sets the property DigestTipAddress. 
        /// <para>
        /// The latest block location covered by the digest for which to request a proof. An address
        /// is an Amazon Ion structure that has two fields: <code>strandId</code> and <code>sequenceNo</code>.
        /// </para>
        ///  
        /// <para>
        /// For example: <code>{strandId:"BlFTjlSXze9BIh1KOszcE3",sequenceNo:49}</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public ValueHolder DigestTipAddress
        {
            get { return this._digestTipAddress; }
            set { this._digestTipAddress = value; }
        }

        // Check to see if DigestTipAddress property is set
        internal bool IsSetDigestTipAddress()
        {
            return this._digestTipAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the ledger.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
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

    }
}