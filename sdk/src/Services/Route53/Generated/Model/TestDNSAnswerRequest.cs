/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the TestDNSAnswer operation.
    /// 
    /// </summary>
    public partial class TestDNSAnswerRequest : AmazonRoute53Request
    {
        private string _hostedZoneId;
        private string _recordName;
        private RRType _recordType;
        private string _resolverIP;
        private string _edns0ClientSubnetIP;
        private string _edns0ClientSubnetMask;

        /// <summary>
        /// Gets and sets the property HostedZoneId.
        /// </summary>
        public string HostedZoneId
        {
            get { return this._hostedZoneId; }
            set { this._hostedZoneId = value; }
        }

        // Check to see if HostedZoneId property is set
        internal bool IsSetHostedZoneId()
        {
            return this._hostedZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property RecordName.
        /// </summary>
        public string RecordName
        {
            get { return this._recordName; }
            set { this._recordName = value; }
        }

        // Check to see if RecordName property is set
        internal bool IsSetRecordName()
        {
            return this._recordName != null;
        }

        /// <summary>
        /// Gets and sets the property RecordType.
        /// </summary>
        public RRType RecordType
        {
            get { return this._recordType; }
            set { this._recordType = value; }
        }

        // Check to see if RecordType property is set
        internal bool IsSetRecordType()
        {
            return this._recordType != null;
        }

        /// <summary>
        /// Gets and sets the property ResolverIP.
        /// </summary>
        public string ResolverIP
        {
            get { return this._resolverIP; }
            set { this._resolverIP = value; }
        }

        // Check to see if ResolverIP property is set
        internal bool IsSetResolverIP()
        {
            return this._resolverIP != null;
        }

        /// <summary>
        /// Gets and sets the property EDNS0ClientSubnetIP.
        /// </summary>
        public string EDNS0ClientSubnetIP
        {
            get { return this._edns0ClientSubnetIP; }
            set { this._edns0ClientSubnetIP = value; }
        }

        // Check to see if EDNS0ClientSubnetIP property is set
        internal bool IsSetEDNS0ClientSubnetIP()
        {
            return this._edns0ClientSubnetIP != null;
        }

        /// <summary>
        /// Gets and sets the property EDNS0ClientSubnetMask.
        /// </summary>
        public string EDNS0ClientSubnetMask
        {
            get { return this._edns0ClientSubnetMask; }
            set { this._edns0ClientSubnetMask = value; }
        }

        // Check to see if EDNS0ClientSubnetMask property is set
        internal bool IsSetEDNS0ClientSubnetMask()
        {
            return this._edns0ClientSubnetMask != null;
        }

    }
}