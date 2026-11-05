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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Rtmp Output Settings
    /// </summary>
    public partial class RtmpOutputSettings
    {
        /// <summary>
        /// Gets and sets the property CertificateMode. If set to verifyAuthenticity, verify the
        /// tls certificate chain to a trusted Certificate Authority (CA). This will cause rtmps
        /// outputs with self-signed certificates to fail.
        /// </summary>
        public RtmpOutputCertificateMode CertificateMode { get; set; }

        /// <summary>
        /// Checks to see if the CertificateMode property is set.
        /// </summary>
        internal bool IsSetCertificateMode() => this.CertificateMode != null;

        /// <summary>
        /// Gets and sets the property ConnectionRetryInterval. Number of seconds to wait before
        /// retrying a connection to the Flash Media server if the connection is lost.
        /// </summary>
        public int? ConnectionRetryInterval { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionRetryInterval property is set.
        /// </summary>
        internal bool IsSetConnectionRetryInterval() => this.ConnectionRetryInterval.HasValue;

        /// <summary>
        /// Gets and sets the property Destination. The RTMP endpoint excluding the stream name
        /// (eg. rtmp://host/appname). For connection to Akamai, a username and password must
        /// be supplied. URI fields accept format identifiers.
        /// </summary>
        [AWSProperty(Required = true)]
        public OutputLocationRef Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property NumRetries. Number of retry attempts.
        /// </summary>
        public int? NumRetries { get; set; }

        /// <summary>
        /// Checks to see if the NumRetries property is set.
        /// </summary>
        internal bool IsSetNumRetries() => this.NumRetries.HasValue;
    }
}
