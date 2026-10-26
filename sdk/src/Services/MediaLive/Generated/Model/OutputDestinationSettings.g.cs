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
    /// Placeholder documentation for OutputDestinationSettings
    /// </summary>
    public partial class OutputDestinationSettings
    {
        /// <summary>
        /// Gets and sets the property PasswordParam. key used to extract the password from EC2
        /// Parameter store
        /// </summary>
        public string PasswordParam { get; set; }

        /// <summary>
        /// Checks to see if the PasswordParam property is set.
        /// </summary>
        internal bool IsSetPasswordParam() => this.PasswordParam != null;

        /// <summary>
        /// Gets and sets the property StreamName. Stream name for RTMP destinations (URLs of
        /// type rtmp://)
        /// </summary>
        public string StreamName { get; set; }

        /// <summary>
        /// Checks to see if the StreamName property is set.
        /// </summary>
        internal bool IsSetStreamName() => this.StreamName != null;

        /// <summary>
        /// Gets and sets the property Url. A URL specifying a destination
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;

        /// <summary>
        /// Gets and sets the property Username. username for destination
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;

        /// <summary>
        /// Gets and sets the property VirtualSourceAddress. Specifies the source IP address for
        /// outbound multicast packets.
        /// </summary>
        public string VirtualSourceAddress { get; set; }

        /// <summary>
        /// Checks to see if the VirtualSourceAddress property is set.
        /// </summary>
        internal bool IsSetVirtualSourceAddress() => this.VirtualSourceAddress != null;
    }
}
