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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteCertificateAuthority operation.
    /// Deletes a private certificate authority (CA). You must provide the ARN (Amazon Resource
    /// Name) of the private CA that you want to delete. You can find the ARN by calling the
    /// <a>ListCertificateAuthorities</a> operation. Before you can delete a CA, you must
    /// disable it. Call the <a>UpdateCertificateAuthority</a> operation and set the <b>CertificateAuthorityStatus</b>
    /// parameter to <code>DISABLED</code>. 
    /// 
    ///  
    /// <para>
    /// Additionally, you can delete a CA if you are waiting for it to be created (the <b>Status</b>
    /// field of the <a>CertificateAuthority</a> is <code>CREATING</code>). You can also delete
    /// it if the CA has been created but you haven't yet imported the signed certificate
    /// (the <b>Status</b> is <code>PENDING_CERTIFICATE</code>) into ACM PCA. 
    /// </para>
    ///  
    /// <para>
    /// If the CA is in one of the aforementioned states and you call <a>DeleteCertificateAuthority</a>,
    /// the CA's status changes to <code>DELETED</code>. However, the CA won't be permentantly
    /// deleted until the restoration period has passed. By default, if you do not set the
    /// <code>PermanentDeletionTimeInDays</code> parameter, the CA remains restorable for
    /// 30 days. You can set the parameter from 7 to 30 days. The <a>DescribeCertificateAuthority</a>
    /// operation returns the time remaining in the restoration window of a Private CA in
    /// the <code>DELETED</code> state. To restore an eligable CA, call the <a>RestoreCertificateAuthority</a>
    /// operation.
    /// </para>
    /// </summary>
    public partial class DeleteCertificateAuthorityRequest : AmazonACMPCARequest
    {
        private string _certificateAuthorityArn;
        private int? _permanentDeletionTimeInDays;

        /// <summary>
        /// Gets and sets the property CertificateAuthorityArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that was returned when you called <a>CreateCertificateAuthority</a>.
        /// This must have the following form: 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:acm-pca:<i>region</i>:<i>account</i>:certificate-authority/<i>12345678-1234-1234-1234-123456789012</i>
        /// </code>. 
        /// </para>
        /// </summary>
        public string CertificateAuthorityArn
        {
            get { return this._certificateAuthorityArn; }
            set { this._certificateAuthorityArn = value; }
        }

        // Check to see if CertificateAuthorityArn property is set
        internal bool IsSetCertificateAuthorityArn()
        {
            return this._certificateAuthorityArn != null;
        }

        /// <summary>
        /// Gets and sets the property PermanentDeletionTimeInDays. 
        /// <para>
        /// The number of days to make a CA restorable after it has been deleted. This can be
        /// anywhere from 7 to 30 days, with 30 being the default.
        /// </para>
        /// </summary>
        public int PermanentDeletionTimeInDays
        {
            get { return this._permanentDeletionTimeInDays.GetValueOrDefault(); }
            set { this._permanentDeletionTimeInDays = value; }
        }

        // Check to see if PermanentDeletionTimeInDays property is set
        internal bool IsSetPermanentDeletionTimeInDays()
        {
            return this._permanentDeletionTimeInDays.HasValue; 
        }

    }
}