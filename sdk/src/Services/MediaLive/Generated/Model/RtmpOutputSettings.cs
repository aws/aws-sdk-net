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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Placeholder documentation for RtmpOutputSettings
    /// </summary>
    public partial class RtmpOutputSettings
    {
        private RtmpOutputCertificateMode _certificateMode;
        private int? _connectionRetryInterval;
        private OutputLocationRef _destination;
        private int? _numRetries;

        /// <summary>
        /// Gets and sets the property CertificateMode. If set to verifyAuthenticity, verify the
        /// tls certificate chain to a trusted Certificate Authority (CA).  This will cause rtmps
        /// outputs with self-signed certificates to fail.
        /// </summary>
        public RtmpOutputCertificateMode CertificateMode
        {
            get { return this._certificateMode; }
            set { this._certificateMode = value; }
        }

        // Check to see if CertificateMode property is set
        internal bool IsSetCertificateMode()
        {
            return this._certificateMode != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionRetryInterval. Number of seconds to wait before
        /// retrying a connection to the Flash Media server if the connection is lost.
        /// </summary>
        public int ConnectionRetryInterval
        {
            get { return this._connectionRetryInterval.GetValueOrDefault(); }
            set { this._connectionRetryInterval = value; }
        }

        // Check to see if ConnectionRetryInterval property is set
        internal bool IsSetConnectionRetryInterval()
        {
            return this._connectionRetryInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Destination. The RTMP endpoint excluding the stream name
        /// (eg. rtmp://host/appname). For connection to Akamai, a username and password must
        /// be supplied. URI fields accept format identifiers.
        /// </summary>
        public OutputLocationRef Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property NumRetries. Number of retry attempts.
        /// </summary>
        public int NumRetries
        {
            get { return this._numRetries.GetValueOrDefault(); }
            set { this._numRetries = value; }
        }

        // Check to see if NumRetries property is set
        internal bool IsSetNumRetries()
        {
            return this._numRetries.HasValue; 
        }

    }
}