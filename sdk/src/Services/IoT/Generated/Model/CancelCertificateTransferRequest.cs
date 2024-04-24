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
    /// Container for the parameters to the CancelCertificateTransfer operation.
    /// Cancels a pending transfer for the specified certificate.
    /// 
    ///  
    /// <para>
    ///  <b>Note</b> Only the transfer source account can use this operation to cancel a transfer.
    /// (Transfer destinations can use <a>RejectCertificateTransfer</a> instead.) After transfer,
    /// IoT returns the certificate to the source account in the INACTIVE state. After the
    /// destination account has accepted the transfer, the transfer cannot be cancelled.
    /// </para>
    ///  
    /// <para>
    /// After a certificate transfer is cancelled, the status of the certificate changes from
    /// PENDING_TRANSFER to INACTIVE.
    /// </para>
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CancelCertificateTransfer</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class CancelCertificateTransferRequest : AmazonIoTRequest
    {
        private string _certificateId;

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

    }
}