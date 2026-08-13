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
    /// Contains the challenge details that you use to prove domain ownership. Only one member
    /// is set, depending on the validation method.
    /// </summary>
    public partial class ValidationChallenge
    {
        private DnsValidationChallenge _dnsValidationChallenge;
        private EmailValidationChallenge _emailValidationChallenge;

        /// <summary>
        /// Gets and sets the property DnsValidationChallenge.
        /// </summary>
        public DnsValidationChallenge DnsValidationChallenge
        {
            get { return this._dnsValidationChallenge; }
            set { this._dnsValidationChallenge = value; }
        }

        // Check to see if DnsValidationChallenge property is set
        internal bool IsSetDnsValidationChallenge()
        {
            return this._dnsValidationChallenge != null;
        }

        /// <summary>
        /// Gets and sets the property EmailValidationChallenge.
        /// </summary>
        public EmailValidationChallenge EmailValidationChallenge
        {
            get { return this._emailValidationChallenge; }
            set { this._emailValidationChallenge = value; }
        }

        // Check to see if EmailValidationChallenge property is set
        internal bool IsSetEmailValidationChallenge()
        {
            return this._emailValidationChallenge != null;
        }

    }
}