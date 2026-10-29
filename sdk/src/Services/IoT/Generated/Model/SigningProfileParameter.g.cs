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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// Certificate ARN.
        /// </para>
        /// </summary>
        public string CertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateArn property is set.
        /// </summary>
        internal bool IsSetCertificateArn() => this.CertificateArn != null;

        /// <summary>
        /// Gets and sets the property CertificatePathOnDevice. 
        /// <para>
        /// The location of the code-signing certificate on your device.
        /// </para>
        /// </summary>
        public string CertificatePathOnDevice { get; set; }

        /// <summary>
        /// Checks to see if the CertificatePathOnDevice property is set.
        /// </summary>
        internal bool IsSetCertificatePathOnDevice() => this.CertificatePathOnDevice != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The hardware platform of your device.
        /// </para>
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;
    }
}
