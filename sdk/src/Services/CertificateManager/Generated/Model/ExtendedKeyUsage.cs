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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
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
namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// The Extended Key Usage X.509 v3 extension defines one or more purposes for which the
    /// public key can be used. This is in addition to or in place of the basic purposes specified
    /// by the Key Usage extension.
    /// </summary>
    public partial class ExtendedKeyUsage
    {
        private ExtendedKeyUsageName _name;
        private string _oid;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of an Extended Key Usage value.
        /// </para>
        /// </summary>
        public ExtendedKeyUsageName Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OID. 
        /// <para>
        /// An object identifier (OID) for the extension value. OIDs are strings of numbers separated
        /// by periods. The following OIDs are defined in RFC 3280 and RFC 5280. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>1.3.6.1.5.5.7.3.1 (TLS_WEB_SERVER_AUTHENTICATION)</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>1.3.6.1.5.5.7.3.2 (TLS_WEB_CLIENT_AUTHENTICATION)</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>1.3.6.1.5.5.7.3.3 (CODE_SIGNING)</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>1.3.6.1.5.5.7.3.4 (EMAIL_PROTECTION)</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>1.3.6.1.5.5.7.3.8 (TIME_STAMPING)</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>1.3.6.1.5.5.7.3.9 (OCSP_SIGNING)</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>1.3.6.1.5.5.7.3.5 (IPSEC_END_SYSTEM)</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>1.3.6.1.5.5.7.3.6 (IPSEC_TUNNEL)</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>1.3.6.1.5.5.7.3.7 (IPSEC_USER)</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string OID
        {
            get { return this._oid; }
            set { this._oid = value; }
        }

        // Check to see if OID property is set
        internal bool IsSetOID()
        {
            return this._oid != null;
        }

    }
}