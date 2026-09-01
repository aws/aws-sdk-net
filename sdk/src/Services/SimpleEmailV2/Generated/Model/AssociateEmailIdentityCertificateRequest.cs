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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateEmailIdentityCertificate operation.
    /// Associates an S/MIME certificate with an email identity. After the certificate is
    /// active, Amazon SES API v2 can add an S/MIME signature to messages that you send from
    /// the associated address when signing is enabled on the configuration set used to send
    /// the message.
    /// 
    ///  
    /// <para>
    /// The certificate is an X.509 certificate that you manage in Certificate Manager (ACM).
    /// You identify it by its Amazon Resource Name (ARN).
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the email identity is a domain, you must specify a <c>FromAddress</c> that belongs
    /// to that domain or one of its subdomains. The certificate applies to messages sent
    /// from that address.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the email identity is an email address, <c>FromAddress</c> is optional. If you
    /// specify it, it must exactly match the email identity.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// When the association is created, the certificate begins provisioning and its status
    /// is <c>PROVISIONING</c>. The status changes to <c>ACTIVE</c> when the certificate is
    /// ready to use for signing. Each email address can have only one certificate association.
    /// If an association already exists for the address, this operation returns an error,
    /// unless the existing association is in the <c>DEPROVISIONING</c> state.
    /// </para>
    /// </summary>
    public partial class AssociateEmailIdentityCertificateRequest : AmazonSimpleEmailServiceV2Request
    {
        private string _certificateArn;
        private string _emailIdentity;
        private string _fromAddress;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Certificate Manager (ACM) certificate to associate
        /// with the email identity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string CertificateArn
        {
            get { return this._certificateArn; }
            set { this._certificateArn = value; }
        }

        // Check to see if CertificateArn property is set
        internal bool IsSetCertificateArn()
        {
            return this._certificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property EmailIdentity. 
        /// <para>
        /// The email identity, either an email address or a domain, to associate the certificate
        /// with.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string EmailIdentity
        {
            get { return this._emailIdentity; }
            set { this._emailIdentity = value; }
        }

        // Check to see if EmailIdentity property is set
        internal bool IsSetEmailIdentity()
        {
            return this._emailIdentity != null;
        }

        /// <summary>
        /// Gets and sets the property FromAddress. 
        /// <para>
        /// The email address that the certificate applies to. This value is required when the
        /// email identity is a domain, and the address must belong to that domain or one of its
        /// subdomains. When the email identity is an email address, this value is optional. If
        /// you specify it, it must exactly match the email identity.
        /// </para>
        /// </summary>
        public string FromAddress
        {
            get { return this._fromAddress; }
            set { this._fromAddress = value; }
        }

        // Check to see if FromAddress property is set
        internal bool IsSetFromAddress()
        {
            return this._fromAddress != null;
        }

    }
}