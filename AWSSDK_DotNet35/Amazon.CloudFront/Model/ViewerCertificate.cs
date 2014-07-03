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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A complex type that contains information about viewer certificates for this distribution.
    /// </summary>
    public partial class ViewerCertificate
    {
        private bool? _cloudFrontDefaultCertificate;
        private string _iAMCertificateId;
        private SSLSupportMethod _sSLSupportMethod;


        /// <summary>
        /// Gets and sets the property CloudFrontDefaultCertificate. If you want viewers to use
        /// HTTPS to request your objects and you're using the CloudFront domain name     of your
        /// distribution in your object URLs (for example, https://d111111abcdef8.cloudfront.net/logo.jpg),
        ///    set to true. Omit this value if you are setting an IAMCertificateId.
        /// </summary>
        public bool CloudFrontDefaultCertificate
        {
            get { return this._cloudFrontDefaultCertificate.GetValueOrDefault(); }
            set { this._cloudFrontDefaultCertificate = value; }
        }

        // Check to see if CloudFrontDefaultCertificate property is set
        internal bool IsSetCloudFrontDefaultCertificate()
        {
            return this._cloudFrontDefaultCertificate.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property IAMCertificateId. If you want viewers to use HTTPS to request
        /// your objects and you're using an    alternate domain name in your object URLs (for
        /// example, https://example.com/logo.jpg),     specify the IAM certificate identifier
        /// of the custom viewer certificate for this distribution.     Specify either this value
        /// or CloudFrontDefaultCertificate.
        /// </summary>
        public string IAMCertificateId
        {
            get { return this._iAMCertificateId; }
            set { this._iAMCertificateId = value; }
        }

        // Check to see if IAMCertificateId property is set
        internal bool IsSetIAMCertificateId()
        {
            return this._iAMCertificateId != null;
        }


        /// <summary>
        /// Gets and sets the property SSLSupportMethod. If you specify a value for IAMCertificateId,
        /// you must also specify how you want CloudFront     to serve HTTPS requests. Valid values
        /// are vip and sni-only. If you specify vip, CloudFront uses     dedicated IP addresses
        /// for your content and can respond to HTTPS requests from any viewer.     However, you
        /// must request permission to use this feature, and you incur additional monthly    
        /// charges. If you specify sni-only, CloudFront can only respond to HTTPS requests from
        ///     viewers that support Server Name Indication (SNI). All modern browsers support
        /// SNI,     but some browsers still in use don't support SNI. Do not specify a value
        /// for SSLSupportMethod if you     specified true for CloudFrontDefaultCertificate.
        /// </summary>
        public SSLSupportMethod SSLSupportMethod
        {
            get { return this._sSLSupportMethod; }
            set { this._sSLSupportMethod = value; }
        }

        // Check to see if SSLSupportMethod property is set
        internal bool IsSetSSLSupportMethod()
        {
            return this._sSLSupportMethod != null;
        }

    }
}