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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Contains information about a returned public key.
    /// </summary>
    public partial class PublicKey
    {
        /// <summary>
        /// Gets and sets the property Fingerprint. 
        /// <para>
        /// The fingerprint of the public key.
        /// </para>
        /// </summary>
        public string Fingerprint { get; set; }

        /// <summary>
        /// Checks to see if the Fingerprint property is set.
        /// </summary>
        internal bool IsSetFingerprint() => this.Fingerprint != null;

        /// <summary>
        /// Gets and sets the property ValidityEndTime. 
        /// <para>
        /// The ending time of validity of the public key.
        /// </para>
        /// </summary>
        public DateTime? ValidityEndTime { get; set; }

        /// <summary>
        /// Checks to see if the ValidityEndTime property is set.
        /// </summary>
        internal bool IsSetValidityEndTime() => this.ValidityEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ValidityStartTime. 
        /// <para>
        /// The starting time of validity of the public key.
        /// </para>
        /// </summary>
        public DateTime? ValidityStartTime { get; set; }

        /// <summary>
        /// Checks to see if the ValidityStartTime property is set.
        /// </summary>
        internal bool IsSetValidityStartTime() => this.ValidityStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The DER encoded public key value in PKCS#1 format.
        /// </para>
        /// </summary>
        public MemoryStream Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
