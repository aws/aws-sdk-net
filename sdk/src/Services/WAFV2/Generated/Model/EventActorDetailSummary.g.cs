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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// The latest observed attributes of an event actor.
    /// </summary>
    public partial class EventActorDetailSummary
    {
        /// <summary>
        /// Gets and sets the property Asn. 
        /// <para>
        /// The autonomous system number (ASN) that is associated with the client IP address of
        /// the event actor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string Asn { get; set; }

        /// <summary>
        /// Checks to see if the Asn property is set.
        /// </summary>
        internal bool IsSetAsn() => this.Asn != null;

        /// <summary>
        /// Gets and sets the property AsnOrganization. 
        /// <para>
        /// The name of the organization that owns the ASN. For example, <c>AMAZON-02</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string AsnOrganization { get; set; }

        /// <summary>
        /// Checks to see if the AsnOrganization property is set.
        /// </summary>
        internal bool IsSetAsnOrganization() => this.AsnOrganization != null;

        /// <summary>
        /// Gets and sets the property AuthFingerprint. 
        /// <para>
        /// A hash of the authentication credentials that the client of the event actor provides
        /// in the request. These can include a JSON Web Token (JWT), a JSON Web Encryption (JWE)
        /// token, an Amazon Web Services Signature Version 4 (SigV4) signature, or basic authentication
        /// credentials. You can use the fingerprint to match the same client across events and
        /// in your WAF logs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string AuthFingerprint { get; set; }

        /// <summary>
        /// Checks to see if the AuthFingerprint property is set.
        /// </summary>
        internal bool IsSetAuthFingerprint() => this.AuthFingerprint != null;

        /// <summary>
        /// Gets and sets the property ClientIp. 
        /// <para>
        /// The client IP address of the event actor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientIp { get; set; }

        /// <summary>
        /// Checks to see if the ClientIp property is set.
        /// </summary>
        internal bool IsSetClientIp() => this.ClientIp != null;

        /// <summary>
        /// Gets and sets the property Country. 
        /// <para>
        /// The country of the client IP address of the event actor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when WAF first observed the event actor.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EventActorId. 
        /// <para>
        /// The unique identifier of the event actor.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 36)]
        public string EventActorId { get; set; }

        /// <summary>
        /// Checks to see if the EventActorId property is set.
        /// </summary>
        internal bool IsSetEventActorId() => this.EventActorId != null;

        /// <summary>
        /// Gets and sets the property TlsFingerprint. 
        /// <para>
        /// The TLS fingerprint of the event actor, such as a JA3 or JA4 fingerprint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string TlsFingerprint { get; set; }

        /// <summary>
        /// Checks to see if the TlsFingerprint property is set.
        /// </summary>
        internal bool IsSetTlsFingerprint() => this.TlsFingerprint != null;
    }
}
