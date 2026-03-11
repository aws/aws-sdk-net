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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteCertificateAuthority operation.
    /// Deletes a private certificate authority (CA). You must provide the Amazon Resource
    /// Name (ARN) of the private CA that you want to delete. You can find the ARN by calling
    /// the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_ListCertificateAuthorities.html">ListCertificateAuthorities</a>
    /// action. 
    /// 
    ///  <note> 
    /// <para>
    /// Deleting a CA will invalidate other CAs and certificates below it in your CA hierarchy.
    /// </para>
    ///  </note> 
    /// <para>
    /// Before you can delete a CA that you have created and activated, you must disable it.
    /// To do this, call the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_UpdateCertificateAuthority.html">UpdateCertificateAuthority</a>
    /// action and set the <b>CertificateAuthorityStatus</b> parameter to <c>DISABLED</c>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// Additionally, you can delete a CA if you are waiting for it to be created (that is,
    /// the status of the CA is <c>CREATING</c>). You can also delete it if the CA has been
    /// created but you haven't yet imported the signed certificate into Amazon Web Services
    /// Private CA (that is, the status of the CA is <c>PENDING_CERTIFICATE</c>). 
    /// </para>
    ///  
    /// <para>
    /// When you successfully call <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_DeleteCertificateAuthority.html">DeleteCertificateAuthority</a>,
    /// the CA's status changes to <c>DELETED</c>. However, the CA won't be permanently deleted
    /// until the restoration period has passed. By default, if you do not set the <c>PermanentDeletionTimeInDays</c>
    /// parameter, the CA remains restorable for 30 days. You can set the parameter from 7
    /// to 30 days. The <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_DescribeCertificateAuthority.html">DescribeCertificateAuthority</a>
    /// action returns the time remaining in the restoration window of a private CA in the
    /// <c>DELETED</c> state. To restore an eligible CA, call the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_RestoreCertificateAuthority.html">RestoreCertificateAuthority</a>
    /// action.
    /// </para>
    ///  <important> 
    /// <para>
    /// A private CA can be deleted if it is in the <c>PENDING_CERTIFICATE</c>, <c>CREATING</c>,
    /// <c>EXPIRED</c>, <c>DISABLED</c>, or <c>FAILED</c> state. To delete a CA in the <c>ACTIVE</c>
    /// state, you must first disable it, or else the delete request results in an exception.
    /// If you are deleting a private CA in the <c>PENDING_CERTIFICATE</c> or <c>DISABLED</c>
    /// state, you can set the length of its restoration period to 7-30 days. The default
    /// is 30. During this time, the status is set to <c>DELETED</c> and the CA can be restored.
    /// A private CA deleted in the <c>CREATING</c> or <c>FAILED</c> state has no assigned
    /// restoration period and cannot be restored.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DeleteCertificateAuthorityRequest : AmazonACMPCARequest
    {
        private string _certificateAuthorityArn;
        private int? _permanentDeletionTimeInDays;

        /// <summary>
        /// Gets and sets the property CertificateAuthorityArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that was returned when you called <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_CreateCertificateAuthority.html">CreateCertificateAuthority</a>.
        /// This must have the following form: 
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:acm-pca:<i>region</i>:<i>account</i>:certificate-authority/<i>12345678-1234-1234-1234-123456789012</i>
        /// </c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=200)]
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
        [AWSProperty(Min=7, Max=30)]
        public int? PermanentDeletionTimeInDays
        {
            get { return this._permanentDeletionTimeInDays; }
            set { this._permanentDeletionTimeInDays = value; }
        }

        // Check to see if PermanentDeletionTimeInDays property is set
        internal bool IsSetPermanentDeletionTimeInDays()
        {
            return this._permanentDeletionTimeInDays.HasValue; 
        }

    }
}