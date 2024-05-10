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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
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
namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// A receipt IP address filter enables you to specify whether to accept or reject mail
    /// originating from an IP address or range of IP addresses.
    /// 
    ///  
    /// <para>
    /// For information about setting up IP address filters, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-ip-filtering-console-walkthrough.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class ReceiptIpFilter
    {
        private string _cidr;
        private ReceiptFilterPolicy _policy;

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// A single IP address or a range of IP addresses to block or allow, specified in Classless
        /// Inter-Domain Routing (CIDR) notation. An example of a single email address is 10.0.0.1.
        /// An example of a range of IP addresses is 10.0.0.1/24. For more information about CIDR
        /// notation, see <a href="https://tools.ietf.org/html/rfc2317">RFC 2317</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Cidr
        {
            get { return this._cidr; }
            set { this._cidr = value; }
        }

        // Check to see if Cidr property is set
        internal bool IsSetCidr()
        {
            return this._cidr != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// Indicates whether to block or allow incoming mail from the specified IP addresses.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReceiptFilterPolicy Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

    }
}