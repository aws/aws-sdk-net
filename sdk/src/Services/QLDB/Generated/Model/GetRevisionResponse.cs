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
    /// This is the response object from the GetRevision operation.
    /// </summary>
    public partial class GetRevisionResponse : AmazonWebServiceResponse
    {
        private ValueHolder _proof;
        private ValueHolder _revision;

        /// <summary>
        /// Gets and sets the property Proof. 
        /// <para>
        /// The proof object in Amazon Ion format returned by a <code>GetRevision</code> request.
        /// A proof contains the list of hash values that are required to recalculate the specified
        /// digest using a Merkle tree, starting with the specified document revision.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public ValueHolder Proof
        {
            get { return this._proof; }
            set { this._proof = value; }
        }

        // Check to see if Proof property is set
        internal bool IsSetProof()
        {
            return this._proof != null;
        }

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The document revision data object in Amazon Ion format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public ValueHolder Revision
        {
            get { return this._revision; }
            set { this._revision = value; }
        }

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this._revision != null;
        }

    }
}