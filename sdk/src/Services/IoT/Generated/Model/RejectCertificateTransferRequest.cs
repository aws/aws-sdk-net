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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the RejectCertificateTransfer operation.
    /// Rejects a pending certificate transfer. After IoT rejects a certificate transfer,
    /// the certificate status changes from <b>PENDING_TRANSFER</b> to <b>INACTIVE</b>.
    /// 
    ///  
    /// <para>
    /// To check for pending certificate transfers, call <a>ListCertificates</a> to enumerate
    /// your certificates.
    /// </para>
    ///  
    /// <para>
    /// This operation can only be called by the transfer destination. After it is called,
    /// the certificate will be returned to the source's account in the INACTIVE state.
    /// </para>
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">RejectCertificateTransfer</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class RejectCertificateTransferRequest : AmazonIoTRequest
    {
        private string _certificateId;
        private string _rejectReason;

        /// <summary>
        /// Gets and sets the property CertificateId. 
        /// <para>
        /// The ID of the certificate. (The last part of the certificate ARN contains the certificate
        /// ID.)
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=64, Max=64)]
        public string CertificateId
        {
            get { return this._certificateId; }
            set { this._certificateId = value; }
        }

        // Check to see if CertificateId property is set
        internal bool IsSetCertificateId()
        {
            return this._certificateId != null;
        }

        /// <summary>
        /// Gets and sets the property RejectReason. 
        /// <para>
        /// The reason the certificate transfer was rejected.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string RejectReason
        {
            get { return this._rejectReason; }
            set { this._rejectReason = value; }
        }

        // Check to see if RejectReason property is set
        internal bool IsSetRejectReason()
        {
            return this._rejectReason != null;
        }

    }
}