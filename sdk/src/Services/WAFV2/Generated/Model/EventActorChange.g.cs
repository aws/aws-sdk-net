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
    /// A change to the network attributes of an event actor.
    /// </summary>
    public partial class EventActorChange
    {
        /// <summary>
        /// Gets and sets the property Asn. 
        /// <para>
        /// The autonomous system number (ASN) that is associated with the client IP address after
        /// the change.
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
        /// The name of the organization that owns the ASN after the change.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string AsnOrganization { get; set; }

        /// <summary>
        /// Checks to see if the AsnOrganization property is set.
        /// </summary>
        internal bool IsSetAsnOrganization() => this.AsnOrganization != null;

        /// <summary>
        /// Gets and sets the property ChangeTime. 
        /// <para>
        /// The time of the change.
        /// </para>
        /// </summary>
        public DateTime? ChangeTime { get; set; }

        /// <summary>
        /// Checks to see if the ChangeTime property is set.
        /// </summary>
        internal bool IsSetChangeTime() => this.ChangeTime.HasValue;

        /// <summary>
        /// Gets and sets the property ClientIp. 
        /// <para>
        /// The client IP address of the event actor after the change.
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
        /// The country of the client IP address after the change.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Country { get; set; }

        /// <summary>
        /// Checks to see if the Country property is set.
        /// </summary>
        internal bool IsSetCountry() => this.Country != null;

        /// <summary>
        /// Gets and sets the property TlsFingerprint. 
        /// <para>
        /// The TLS fingerprint of the event actor after the change, such as a JA3 or JA4 fingerprint.
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
