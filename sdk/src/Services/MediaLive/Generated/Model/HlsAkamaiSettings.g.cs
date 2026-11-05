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
    /// Hls Akamai Settings
    /// </summary>
    public partial class HlsAkamaiSettings
    {
        /// <summary>
        /// Gets and sets the property ConnectionRetryInterval. Number of seconds to wait before
        /// retrying connection to the CDN if the connection is lost.
        /// </summary>
        public int? ConnectionRetryInterval { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionRetryInterval property is set.
        /// </summary>
        internal bool IsSetConnectionRetryInterval() => this.ConnectionRetryInterval.HasValue;

        /// <summary>
        /// Gets and sets the property FilecacheDuration. Size in seconds of file cache for streaming
        /// outputs.
        /// </summary>
        public int? FilecacheDuration { get; set; }

        /// <summary>
        /// Checks to see if the FilecacheDuration property is set.
        /// </summary>
        internal bool IsSetFilecacheDuration() => this.FilecacheDuration.HasValue;

        /// <summary>
        /// Gets and sets the property HttpTransferMode. Specify whether or not to use chunked
        /// transfer encoding to Akamai. User should contact Akamai to enable this feature.
        /// </summary>
        public HlsAkamaiHttpTransferMode HttpTransferMode { get; set; }

        /// <summary>
        /// Checks to see if the HttpTransferMode property is set.
        /// </summary>
        internal bool IsSetHttpTransferMode() => this.HttpTransferMode != null;

        /// <summary>
        /// Gets and sets the property NumRetries. Number of retry attempts that will be made
        /// before the Live Event is put into an error state. Applies only if the CDN destination
        /// URI begins with "s3" or "mediastore". For other URIs, the value is always 3.
        /// </summary>
        public int? NumRetries { get; set; }

        /// <summary>
        /// Checks to see if the NumRetries property is set.
        /// </summary>
        internal bool IsSetNumRetries() => this.NumRetries.HasValue;

        /// <summary>
        /// Gets and sets the property RestartDelay. If a streaming output fails, number of seconds
        /// to wait until a restart is initiated. A value of 0 means never restart.
        /// </summary>
        public int? RestartDelay { get; set; }

        /// <summary>
        /// Checks to see if the RestartDelay property is set.
        /// </summary>
        internal bool IsSetRestartDelay() => this.RestartDelay.HasValue;

        /// <summary>
        /// Gets and sets the property Salt. Salt for authenticated Akamai.
        /// </summary>
        public string Salt { get; set; }

        /// <summary>
        /// Checks to see if the Salt property is set.
        /// </summary>
        internal bool IsSetSalt() => this.Salt != null;

        /// <summary>
        /// Gets and sets the property Token. Token parameter for authenticated akamai. If not
        /// specified, _gda_ is used.
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Checks to see if the Token property is set.
        /// </summary>
        internal bool IsSetToken() => this.Token != null;
    }
}
