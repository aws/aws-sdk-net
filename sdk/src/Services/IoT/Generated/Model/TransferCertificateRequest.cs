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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the TransferCertificate operation.
    /// Transfers the specified certificate to the specified AWS account.
    /// 
    ///  
    /// <para>
    /// You can cancel the transfer until it is acknowledged by the recipient.
    /// </para>
    ///  
    /// <para>
    /// No notification is sent to the transfer destination's account, it is up to the caller
    /// to notify the transfer target.
    /// </para>
    ///  
    /// <para>
    /// The certificate being transferred must not be in the ACTIVE state. It can be deactivated
    /// using the UpdateCertificate API.
    /// </para>
    ///  
    /// <para>
    /// The certificate must not have any policies attached to it. These can be detached using
    /// the DetachPrincipalPolicy API.
    /// </para>
    /// </summary>
    public partial class TransferCertificateRequest : AmazonIoTRequest
    {
        private string _certificateId;
        private string _targetAwsAccount;

        /// <summary>
        /// Gets and sets the property CertificateId. 
        /// <para>
        /// The ID of the certificate.
        /// </para>
        /// </summary>
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
        /// The AWS account.
        /// </para>
        /// </summary>
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

    }
}