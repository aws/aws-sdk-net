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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Contains information about the status of Lightsail's managed renewal for the certificate.
    /// 
    ///  
    /// <para>
    /// The renewal status of the certificate.
    /// </para>
    ///  
    /// <para>
    /// The following renewal status are possible:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b> <code>PendingAutoRenewal</code> </b> - Lightsail is attempting to automatically
    /// validate the domain names in the certificate. No further action is required. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b> <code>PendingValidation</code> </b> - Lightsail couldn't automatically validate
    /// one or more domain names in the certificate. You must take action to validate these
    /// domain names or the certificate won't be renewed. If you used DNS validation, check
    /// to make sure your certificate's domain validation records exist in your domain's DNS,
    /// and that your certificate remains in use.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b> <code>Success</code> </b> - All domain names in the certificate are validated,
    /// and Lightsail renewed the certificate. No further action is required. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b> <code>Failed</code> </b> - One or more domain names were not validated before
    /// the certificate expired, and Lightsail did not renew the certificate. You can request
    /// a new certificate using the <code>CreateCertificate</code> action.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class LoadBalancerTlsCertificateRenewalSummary
    {
        private List<LoadBalancerTlsCertificateDomainValidationOption> _domainValidationOptions = new List<LoadBalancerTlsCertificateDomainValidationOption>();
        private LoadBalancerTlsCertificateRenewalStatus _renewalStatus;

        /// <summary>
        /// Gets and sets the property DomainValidationOptions. 
        /// <para>
        /// Contains information about the validation of each domain name in the certificate,
        /// as it pertains to Lightsail's managed renewal. This is different from the initial
        /// validation that occurs as a result of the RequestCertificate request.
        /// </para>
        /// </summary>
        public List<LoadBalancerTlsCertificateDomainValidationOption> DomainValidationOptions
        {
            get { return this._domainValidationOptions; }
            set { this._domainValidationOptions = value; }
        }

        // Check to see if DomainValidationOptions property is set
        internal bool IsSetDomainValidationOptions()
        {
            return this._domainValidationOptions != null && this._domainValidationOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RenewalStatus. 
        /// <para>
        /// The renewal status of the certificate.
        /// </para>
        ///  
        /// <para>
        /// The following renewal status are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>PendingAutoRenewal</code> </b> - Lightsail is attempting to automatically
        /// validate the domain names of the certificate. No further action is required. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>PendingValidation</code> </b> - Lightsail couldn't automatically validate
        /// one or more domain names of the certificate. You must take action to validate these
        /// domain names or the certificate won't be renewed. Check to make sure your certificate's
        /// domain validation records exist in your domain's DNS, and that your certificate remains
        /// in use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Success</code> </b> - All domain names in the certificate are validated,
        /// and Lightsail renewed the certificate. No further action is required. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Failed</code> </b> - One or more domain names were not validated before
        /// the certificate expired, and Lightsail did not renew the certificate. You can request
        /// a new certificate using the <code>CreateCertificate</code> action.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public LoadBalancerTlsCertificateRenewalStatus RenewalStatus
        {
            get { return this._renewalStatus; }
            set { this._renewalStatus = value; }
        }

        // Check to see if RenewalStatus property is set
        internal bool IsSetRenewalStatus()
        {
            return this._renewalStatus != null;
        }

    }
}