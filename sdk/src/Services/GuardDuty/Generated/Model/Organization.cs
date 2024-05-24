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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the ISP organization of the remote IP address.
    /// </summary>
    public partial class Organization
    {
        private string _asn;
        private string _asnOrg;
        private string _isp;
        private string _org;

        /// <summary>
        /// Gets and sets the property Asn. 
        /// <para>
        /// The Autonomous System Number (ASN) of the internet provider of the remote IP address.
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
        /// The organization that registered this ASN.
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
        /// The ISP information for the internet provider.
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
        /// The name of the internet provider.
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