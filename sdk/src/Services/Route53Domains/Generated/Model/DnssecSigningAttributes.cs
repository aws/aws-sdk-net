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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Information about a delegation signer (DS) record that was created in the registry
    /// by <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_AssociateDelegationSignerToDomain.html">AssociateDelegationSignerToDomain</a>.
    /// </summary>
    public partial class DnssecSigningAttributes
    {
        private int? _algorithm;
        private int? _flags;
        private string _publicKey;

        /// <summary>
        /// Gets and sets the property Algorithm. 
        /// <para>
        ///  Algorithm which was used to generate the digest from the public key. 
        /// </para>
        /// </summary>
        public int Algorithm
        {
            get { return this._algorithm.GetValueOrDefault(); }
            set { this._algorithm = value; }
        }

        // Check to see if Algorithm property is set
        internal bool IsSetAlgorithm()
        {
            return this._algorithm.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Flags. 
        /// <para>
        /// Defines the type of key. It can be either a KSK (key-signing-key, value 257) or ZSK
        /// (zone-signing-key, value 256). Using KSK is always encouraged. Only use ZSK if your
        /// DNS provider isn't Route 53 and you don’t have KSK available.
        /// </para>
        ///  
        /// <para>
        /// If you have KSK and ZSK keys, always use KSK to create a delegations signer (DS) record.
        /// If you have ZSK keys only – use ZSK to create a DS record.
        /// </para>
        /// </summary>
        public int Flags
        {
            get { return this._flags.GetValueOrDefault(); }
            set { this._flags = value; }
        }

        // Check to see if Flags property is set
        internal bool IsSetFlags()
        {
            return this._flags.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PublicKey. 
        /// <para>
        ///  The base64-encoded public key part of the key pair that is passed to the registry.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=32768)]
        public string PublicKey
        {
            get { return this._publicKey; }
            set { this._publicKey = value; }
        }

        // Check to see if PublicKey property is set
        internal bool IsSetPublicKey()
        {
            return this._publicKey != null;
        }

    }
}