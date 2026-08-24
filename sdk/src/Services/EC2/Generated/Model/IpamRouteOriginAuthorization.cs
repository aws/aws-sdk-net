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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Contains information about a Route Origin Authorization (ROA) published in the RPKI.
    /// A ROA cryptographically attests that a specific ASN is authorized to originate a specific
    /// IP address prefix.
    /// </summary>
    public partial class IpamRouteOriginAuthorization
    {
        private string _asn;
        private DateTime? _expiration;
        private bool? _match;
        private int? _maxLength;
        private string _prefix;

        /// <summary>
        /// Gets and sets the property Asn. 
        /// <para>
        /// The Autonomous System Number (ASN) authorized by the ROA.
        /// </para>
        /// </summary>
        public string Asn
        {
            get { return this._asn; }
            set { this._asn = value; }
        }

        // Check to see if Asn property is set
        internal bool IsSetAsn()
        {
            return this._asn != null;
        }

        /// <summary>
        /// Gets and sets the property Expiration. 
        /// <para>
        /// The expiration date of the ROA.
        /// </para>
        /// </summary>
        public DateTime? Expiration
        {
            get { return this._expiration; }
            set { this._expiration = value; }
        }

        // Check to see if Expiration property is set
        internal bool IsSetExpiration()
        {
            return this._expiration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Match. 
        /// <para>
        /// Specifies whether the ROA matches the route announcement.
        /// </para>
        /// </summary>
        public bool? Match
        {
            get { return this._match; }
            set { this._match = value; }
        }

        // Check to see if Match property is set
        internal bool IsSetMatch()
        {
            return this._match.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxLength. 
        /// <para>
        /// The maximum prefix length that the ASN is authorized to announce.
        /// </para>
        /// </summary>
        public int? MaxLength
        {
            get { return this._maxLength; }
            set { this._maxLength = value; }
        }

        // Check to see if MaxLength property is set
        internal bool IsSetMaxLength()
        {
            return this._maxLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The IP address prefix authorized by the ROA in CIDR notation.
        /// </para>
        /// </summary>
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

    }
}