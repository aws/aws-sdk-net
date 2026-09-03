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
    /// An object that contains information about an S/MIME certificate that's associated
    /// with an email identity.
    /// </summary>
    public partial class IdentityCertificate
    {
        private string _certificateArn;
        private DateTime? _certificateExpiryTime;
        private string _fromAddress;
        private IdentityCertificateStatus _status;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Certificate Manager (ACM) certificate that's
        /// associated with the email identity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// Gets and sets the property CertificateExpiryTime. 
        /// <para>
        /// The timestamp after which the certificate is no longer valid.
        /// </para>
        /// </summary>
        public DateTime? CertificateExpiryTime
        {
            get { return this._certificateExpiryTime; }
            set { this._certificateExpiryTime = value; }
        }

        // Check to see if CertificateExpiryTime property is set
        internal bool IsSetCertificateExpiryTime()
        {
            return this._certificateExpiryTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FromAddress. 
        /// <para>
        /// The email address that the certificate applies to.
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the certificate association. A status of <c>ACTIVE</c> indicates that
        /// the certificate is ready to use for signing.
        /// </para>
        /// </summary>
        public IdentityCertificateStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}