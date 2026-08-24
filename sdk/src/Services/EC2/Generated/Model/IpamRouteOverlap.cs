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
    /// Contains information about an overlapping route detected for a BYOIP prefix.
    /// </summary>
    public partial class IpamRouteOverlap
    {
        private string _asn;
        private DateTime? _detectedAt;
        private string _prefix;

        /// <summary>
        /// Gets and sets the property Asn. 
        /// <para>
        /// The ASN originating the overlapping route.
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
        /// Gets and sets the property DetectedAt. 
        /// <para>
        /// The time when the overlap was detected.
        /// </para>
        /// </summary>
        public DateTime? DetectedAt
        {
            get { return this._detectedAt; }
            set { this._detectedAt = value; }
        }

        // Check to see if DetectedAt property is set
        internal bool IsSetDetectedAt()
        {
            return this._detectedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The overlapping IP address prefix in CIDR notation.
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