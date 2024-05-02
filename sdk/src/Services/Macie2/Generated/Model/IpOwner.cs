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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about the registered owner of an IP address.
    /// </summary>
    public partial class IpOwner
    {
        private string _asn;
        private string _asnOrg;
        private string _isp;
        private string _org;

        /// <summary>
        /// Gets and sets the property Asn. 
        /// <para>
        /// The autonomous system number (ASN) for the autonomous system that included the IP
        /// address.
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
        /// Gets and sets the property AsnOrg. 
        /// <para>
        /// The organization identifier that's associated with the autonomous system number (ASN)
        /// for the autonomous system that included the IP address.
        /// </para>
        /// </summary>
        public string AsnOrg
        {
            get { return this._asnOrg; }
            set { this._asnOrg = value; }
        }

        // Check to see if AsnOrg property is set
        internal bool IsSetAsnOrg()
        {
            return this._asnOrg != null;
        }

        /// <summary>
        /// Gets and sets the property Isp. 
        /// <para>
        /// The name of the internet service provider (ISP) that owned the IP address.
        /// </para>
        /// </summary>
        public string Isp
        {
            get { return this._isp; }
            set { this._isp = value; }
        }

        // Check to see if Isp property is set
        internal bool IsSetIsp()
        {
            return this._isp != null;
        }

        /// <summary>
        /// Gets and sets the property Org. 
        /// <para>
        /// The name of the organization that owned the IP address.
        /// </para>
        /// </summary>
        public string Org
        {
            get { return this._org; }
            set { this._org = value; }
        }

        // Check to see if Org property is set
        internal bool IsSetOrg()
        {
            return this._org != null;
        }

    }
}