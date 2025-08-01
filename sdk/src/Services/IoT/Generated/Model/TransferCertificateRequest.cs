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
    /// Container for the parameters to the TransferCertificate operation.
    /// Transfers the specified certificate to the specified Amazon Web Services account.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">TransferCertificate</a>
    /// action.
    /// </para>
    ///  
    /// <para>
    /// You can cancel the transfer until it is acknowledged by the recipient.
    /// </para>
    ///  
    /// <para>
    /// No notification is sent to the transfer destination's account. It's up to the caller
    /// to notify the transfer target.
    /// </para>
    ///  
    /// <para>
    /// The certificate being transferred must not be in the <c>ACTIVE</c> state. You can
    /// use the <a>UpdateCertificate</a> action to deactivate it.
    /// </para>
    ///  
    /// <para>
    /// The certificate must not have any policies attached to it. You can use the <a>DetachPolicy</a>
    /// action to detach them.
    /// </para>
    ///  
    /// <para>
    ///  <b>Customer managed key behavior:</b> When you use a customer managed key to secure
    /// your data and then transfer the key to a customer in a different account using the
    /// <a>TransferCertificate</a> operation, the certificates will no longer be protected
    /// by their customer managed key configuration. During the transfer process, certificates
    /// are encrypted using IoT owned keys.
    /// </para>
    ///  
    /// <para>
    /// While a certificate is in the <b>PENDING_TRANSFER</b> state, it's always protected
    /// by IoT owned keys, regardless of the customer managed key configuration of either
    /// the source or destination account. 
    /// </para>
    ///  
    /// <para>
    /// Once the transfer is completed through <a>AcceptCertificateTransfer</a>, <a>RejectCertificateTransfer</a>,
    /// or <a>CancelCertificateTransfer</a>, the certificate will be protected by the customer
    /// managed key configuration of the account that owns the certificate after the transfer
    /// operation:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the transfer is accepted: The certificate is protected by the destination account's
    /// customer managed key configuration.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the transfer is rejected or cancelled: The certificate is protected by the source
    /// account's customer managed key configuration.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class TransferCertificateRequest : AmazonIoTRequest
    {
        private string _certificateId;
        private string _targetAwsAccount;
        private string _transferMessage;

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
        /// Gets and sets the property TargetAwsAccount. 
        /// <para>
        /// The Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string TargetAwsAccount
        {
            get { return this._targetAwsAccount; }
            set { this._targetAwsAccount = value; }
        }

        // Check to see if TargetAwsAccount property is set
        internal bool IsSetTargetAwsAccount()
        {
            return this._targetAwsAccount != null;
        }

        /// <summary>
        /// Gets and sets the property TransferMessage. 
        /// <para>
        /// The transfer message.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string TransferMessage
        {
            get { return this._transferMessage; }
            set { this._transferMessage = value; }
        }

        // Check to see if TransferMessage property is set
        internal bool IsSetTransferMessage()
        {
            return this._transferMessage != null;
        }

    }
}