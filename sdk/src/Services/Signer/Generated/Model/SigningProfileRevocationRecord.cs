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
 * Do not modify this file. This file is generated from the signer-2017-08-25.normal.json service model.
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
namespace Amazon.Signer.Model
{
    /// <summary>
    /// Revocation information for a signing profile.
    /// </summary>
    public partial class SigningProfileRevocationRecord
    {
        private DateTime? _revocationEffectiveFrom;
        private DateTime? _revokedAt;
        private string _revokedBy;

        /// <summary>
        /// Gets and sets the property RevocationEffectiveFrom. 
        /// <para>
        /// The time when revocation becomes effective.
        /// </para>
        /// </summary>
        public DateTime? RevocationEffectiveFrom
        {
            get { return this._revocationEffectiveFrom; }
            set { this._revocationEffectiveFrom = value; }
        }

        // Check to see if RevocationEffectiveFrom property is set
        internal bool IsSetRevocationEffectiveFrom()
        {
            return this._revocationEffectiveFrom.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RevokedAt. 
        /// <para>
        /// The time when the signing profile was revoked.
        /// </para>
        /// </summary>
        public DateTime? RevokedAt
        {
            get { return this._revokedAt; }
            set { this._revokedAt = value; }
        }

        // Check to see if RevokedAt property is set
        internal bool IsSetRevokedAt()
        {
            return this._revokedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RevokedBy. 
        /// <para>
        /// The identity of the revoker.
        /// </para>
        /// </summary>
        public string RevokedBy
        {
            get { return this._revokedBy; }
            set { this._revokedBy = value; }
        }

        // Check to see if RevokedBy property is set
        internal bool IsSetRevokedBy()
        {
            return this._revokedBy != null;
        }

    }
}