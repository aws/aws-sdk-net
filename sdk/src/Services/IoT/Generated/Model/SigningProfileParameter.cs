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
    /// Describes the code-signing profile.
    /// </summary>
    public partial class SigningProfileParameter
    {
        private string _certificateArn;
        private string _certificatePathOnDevice;
        private string _platform;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// Certificate ARN.
        /// </para>
        /// </summary>
        public string CertificateArn
        {
            get { return this._certificateArn; }
            set { this._certificateArn = value; }
        }

        // Check to see if CertificateArn property is set
        internal bool IsSetCertificateArn()
        {
            return this._certificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property CertificatePathOnDevice. 
        /// <para>
        /// The location of the code-signing certificate on your device.
        /// </para>
        /// </summary>
        public string CertificatePathOnDevice
        {
            get { return this._certificatePathOnDevice; }
            set { this._certificatePathOnDevice = value; }
        }

        // Check to see if CertificatePathOnDevice property is set
        internal bool IsSetCertificatePathOnDevice()
        {
            return this._certificatePathOnDevice != null;
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The hardware platform of your device.
        /// </para>
        /// </summary>
        public string Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

    }
}