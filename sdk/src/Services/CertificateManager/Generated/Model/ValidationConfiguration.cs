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
    /// Contains the validation method, validation status, and validation challenge details
    /// for a domain. This structure appears in <a>DomainValidationSummary</a> as both the
    /// active and requested validation configuration.
    /// </summary>
    public partial class ValidationConfiguration
    {
        private ValidationChallenge _validationChallenge;
        private ValidationMethod _validationMethod;
        private DomainStatus _validationStatus;

        /// <summary>
        /// Gets and sets the property ValidationChallenge. 
        /// <para>
        /// The validation challenge details for this configuration. The structure varies by validation
        /// method: for DNS validation, contains a <c>DnsValidationChallenge</c> with the CNAME
        /// record to add; for email validation, contains an <c>EmailValidationChallenge</c> with
        /// the validation email addresses.
        /// </para>
        /// </summary>
        public ValidationChallenge ValidationChallenge
        {
            get { return this._validationChallenge; }
            set { this._validationChallenge = value; }
        }

        // Check to see if ValidationChallenge property is set
        internal bool IsSetValidationChallenge()
        {
            return this._validationChallenge != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationMethod. 
        /// <para>
        /// The validation method for this configuration. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DNS</c> – Validation using a CNAME record added to your DNS configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EMAIL</c> – Validation using an approval email sent to domain contacts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HTTP</c> – Validation using an HTTP resource placed on your web server.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ValidationMethod ValidationMethod
        {
            get { return this._validationMethod; }
            set { this._validationMethod = value; }
        }

        // Check to see if ValidationMethod property is set
        internal bool IsSetValidationMethod()
        {
            return this._validationMethod != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationStatus. 
        /// <para>
        /// The validation status for this domain. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING_VALIDATION</c> – The domain is waiting for validation to complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCESS</c> – Validation completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> – Validation failed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DomainStatus ValidationStatus
        {
            get { return this._validationStatus; }
            set { this._validationStatus = value; }
        }

        // Check to see if ValidationStatus property is set
        internal bool IsSetValidationStatus()
        {
            return this._validationStatus != null;
        }

    }
}