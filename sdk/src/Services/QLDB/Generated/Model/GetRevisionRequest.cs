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
    /// Container for the parameters to the GetRevision operation.
    /// Returns a revision data object for a specified document ID and block address. Also
    /// returns a proof of the specified revision for verification if <code>DigestTipAddress</code>
    /// is provided.
    /// </summary>
    public partial class GetRevisionRequest : AmazonQLDBRequest
    {
        private ValueHolder _blockAddress;
        private ValueHolder _digestTipAddress;
        private string _documentId;
        private string _name;

        /// <summary>
        /// Gets and sets the property BlockAddress. 
        /// <para>
        /// The block location of the document revision to be verified. An address is an Amazon
        /// Ion structure that has two fields: <code>strandId</code> and <code>sequenceNo</code>.
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
        /// Gets and sets the property DocumentId. 
        /// <para>
        /// The UUID (represented in Base62-encoded text) of the document to be verified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=22, Max=22)]
        public string DocumentId
        {
            get { return this._documentId; }
            set { this._documentId = value; }
        }

        // Check to see if DocumentId property is set
        internal bool IsSetDocumentId()
        {
            return this._documentId != null;
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