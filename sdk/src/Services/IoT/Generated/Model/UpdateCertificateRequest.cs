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
    /// Container for the parameters to the UpdateCertificate operation.
    /// Updates the status of the specified certificate. This operation is idempotent.
    /// 
    ///  
    /// <para>
    /// Moving a cert from the ACTIVE state (including REVOKED) will NOT disconnect currently-connected
    /// devices, although these devices will be unable to reconnect.
    /// </para>
    ///  
    /// <para>
    /// The ACTIVE state is required to authenticate devices connecting to AWS IoT using a
    /// certificate.
    /// </para>
    /// </summary>
    public partial class UpdateCertificateRequest : AmazonIoTRequest
    {
        private string _certificateId;
        private CertificateStatus _newStatus;

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
        /// Gets and sets the property NewStatus. 
        /// <para>
        /// The new status.
        /// </para>
        /// </summary>
        public CertificateStatus NewStatus
        {
            get { return this._newStatus; }
            set { this._newStatus = value; }
        }

        // Check to see if NewStatus property is set
        internal bool IsSetNewStatus()
        {
            return this._newStatus != null;
        }

    }
}