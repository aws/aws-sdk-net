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
    /// Container for the parameters to the CreateKeysAndCertificate operation.
    /// Creates a 2048-bit RSA key pair and issues an X.509 certificate using the issued public
    /// key.
    /// 
    ///  
    /// <para>
    /// <b>Note</b> This is the only time AWS IoT issues the private key for this certificate,
    /// so it is important to keep it in a secure location.
    /// </para>
    /// </summary>
    public partial class CreateKeysAndCertificateRequest : AmazonIoTRequest
    {
        private bool? _setAsActive;

        /// <summary>
        /// Gets and sets the property SetAsActive. 
        /// <para>
        /// Specifies whether the certificate is active.
        /// </para>
        /// </summary>
        public bool SetAsActive
        {
            get { return this._setAsActive.GetValueOrDefault(); }
            set { this._setAsActive = value; }
        }

        // Check to see if SetAsActive property is set
        internal bool IsSetSetAsActive()
        {
            return this._setAsActive.HasValue; 
        }

    }
}