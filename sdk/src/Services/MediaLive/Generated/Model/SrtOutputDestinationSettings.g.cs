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
    /// Placeholder documentation for SrtOutputDestinationSettings
    /// </summary>
    public partial class SrtOutputDestinationSettings
    {
        /// <summary>
        /// Gets and sets the property ConnectionMode. Specifies the mode the output should use
        /// for connection establishment. CALLER mode requires URL, LISTENER mode requires port.
        /// </summary>
        public ConnectionMode ConnectionMode { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionMode property is set.
        /// </summary>
        internal bool IsSetConnectionMode() => this.ConnectionMode != null;

        /// <summary>
        /// Gets and sets the property EncryptionPassphraseSecretArn. Arn used to extract the
        /// password from Secrets Manager
        /// </summary>
        public string EncryptionPassphraseSecretArn { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionPassphraseSecretArn property is set.
        /// </summary>
        internal bool IsSetEncryptionPassphraseSecretArn() => this.EncryptionPassphraseSecretArn != null;

        /// <summary>
        /// Gets and sets the property ListenerPort. Port number for listener mode connections
        /// (required when connectionMode is LISTENER, must not be provided when connectionMode
        /// is CALLER).
        /// </summary>
        public int? ListenerPort { get; set; }

        /// <summary>
        /// Checks to see if the ListenerPort property is set.
        /// </summary>
        internal bool IsSetListenerPort() => this.ListenerPort.HasValue;

        /// <summary>
        /// Gets and sets the property StreamId. Stream id for SRT destinations (URLs of type
        /// srt://)
        /// </summary>
        public string StreamId { get; set; }

        /// <summary>
        /// Checks to see if the StreamId property is set.
        /// </summary>
        internal bool IsSetStreamId() => this.StreamId != null;

        /// <summary>
        /// Gets and sets the property Url. A URL specifying a destination
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
