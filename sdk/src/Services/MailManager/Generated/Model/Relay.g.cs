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

namespace Amazon.MailManager.Model
{
    /// <summary>
    /// The relay resource that can be used as a rule to relay receiving emails to the destination
    /// relay server.
    /// </summary>
    public partial class Relay
    {
        /// <summary>
        /// Gets and sets the property LastModifiedTimestamp. 
        /// <para>
        /// The timestamp of when the relay was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTimestamp property is set.
        /// </summary>
        internal bool IsSetLastModifiedTimestamp() => this.LastModifiedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property RelayId. 
        /// <para>
        /// The unique relay identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string RelayId { get; set; }

        /// <summary>
        /// Checks to see if the RelayId property is set.
        /// </summary>
        internal bool IsSetRelayId() => this.RelayId != null;

        /// <summary>
        /// Gets and sets the property RelayName. 
        /// <para>
        /// The unique relay name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string RelayName { get; set; }

        /// <summary>
        /// Checks to see if the RelayName property is set.
        /// </summary>
        internal bool IsSetRelayName() => this.RelayName != null;
    }
}
