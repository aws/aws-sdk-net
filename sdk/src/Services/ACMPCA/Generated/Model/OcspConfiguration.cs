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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Contains information to enable and configure Online Certificate Status Protocol (OCSP)
    /// for validating certificate revocation status.
    /// 
    ///  
    /// <para>
    /// When you revoke a certificate, OCSP responses may take up to 60 minutes to reflect
    /// the new status.
    /// </para>
    /// </summary>
    public partial class OcspConfiguration
    {
        private bool? _enabled;
        private string _ocspCustomCname;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Flag enabling use of the Online Certificate Status Protocol (OCSP) for validating
        /// certificate revocation status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OcspCustomCname. 
        /// <para>
        /// By default, Amazon Web Services Private CA injects an Amazon Web Services domain into
        /// certificates being validated by the Online Certificate Status Protocol (OCSP). A customer
        /// can alternatively use this object to define a CNAME specifying a customized OCSP domain.
        /// </para>
        ///  <note> 
        /// <para>
        /// The content of a Canonical Name (CNAME) record must conform to <a href="https://www.ietf.org/rfc/rfc2396.txt">RFC2396</a>
        /// restrictions on the use of special characters in URIs. Additionally, the value of
        /// the CNAME must not include a protocol prefix such as "http://" or "https://".
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/ocsp-customize.html">Customizing
        /// Online Certificate Status Protocol (OCSP) </a> in the <i>Amazon Web Services Private
        /// Certificate Authority User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=253)]
        public string OcspCustomCname
        {
            get { return this._ocspCustomCname; }
            set { this._ocspCustomCname = value; }
        }

        // Check to see if OcspCustomCname property is set
        internal bool IsSetOcspCustomCname()
        {
            return this._ocspCustomCname != null;
        }

    }
}