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
    /// Container for the parameters to the DeleteCertificate operation.
    /// Deletes the specified certificate.
    /// 
    ///  
    /// <para>
    /// A certificate cannot be deleted if it has a policy attached to it or if its status
    /// is set to ACTIVE. To delete a certificate, first use the <a>DetachPrincipalPolicy</a>
    /// API to detach all policies. Next, use the <a>UpdateCertificate</a> API to set the
    /// certificate to the INACTIVE status.
    /// </para>
    /// </summary>
    public partial class DeleteCertificateRequest : AmazonIoTRequest
    {
        private string _certificateId;
        private bool? _forceDelete;

        /// <summary>
        /// Gets and sets the property CertificateId. 
        /// <para>
        /// The ID of the certificate. (The last part of the certificate ARN contains the certificate
        /// ID.)
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
        /// Gets and sets the property ForceDelete. 
        /// <para>
        /// Forces a certificate request to be deleted.
        /// </para>
        /// </summary>
        public bool ForceDelete
        {
            get { return this._forceDelete.GetValueOrDefault(); }
            set { this._forceDelete = value; }
        }

        // Check to see if ForceDelete property is set
        internal bool IsSetForceDelete()
        {
            return this._forceDelete.HasValue; 
        }

    }
}