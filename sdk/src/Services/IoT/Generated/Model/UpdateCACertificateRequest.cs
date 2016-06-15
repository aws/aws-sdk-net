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
    /// Container for the parameters to the UpdateCACertificate operation.
    /// Updates a registered CA certificate.
    /// </summary>
    public partial class UpdateCACertificateRequest : AmazonIoTRequest
    {
        private string _certificateId;
        private CACertificateStatus _newStatus;

        /// <summary>
        /// Gets and sets the property CertificateId. 
        /// <para>
        /// The CA certificate identifier.
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
        /// The updated status of the CA certificate.
        /// </para>
        ///  
        /// <para>
        /// <b>Note:</b> The status value REGISTER_INACTIVE is deprecated and should not be used.
        /// </para>
        /// </summary>
        public CACertificateStatus NewStatus
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