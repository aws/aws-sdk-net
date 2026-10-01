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

namespace Amazon.Wickr.Model
{
    /// <summary>
    /// Contains network-level configuration settings that apply to all users and security
    /// groups within a Wickr network.
    /// </summary>
    public partial class NetworkSettings
    {
        /// <summary>
        /// Gets and sets the property ConsentPopup. 
        /// <para>
        /// Consent popup configuration for the network, displayed to users on login.
        /// </para>
        /// </summary>
        public ConsentPopupConfig ConsentPopup { get; set; }

        /// <summary>
        /// Checks to see if the ConsentPopup property is set.
        /// </summary>
        internal bool IsSetConsentPopup() => this.ConsentPopup != null;

        /// <summary>
        /// Gets and sets the property DataRetention. 
        /// <para>
        /// Indicates whether the data retention feature is enabled for the network. When true,
        /// messages are captured by the data retention bot for compliance and archiving purposes.
        /// </para>
        /// </summary>
        public bool? DataRetention { get; set; }

        /// <summary>
        /// Checks to see if the DataRetention property is set.
        /// </summary>
        internal bool IsSetDataRetention() => this.DataRetention.HasValue;

        /// <summary>
        /// Gets and sets the property EnableClientMetrics. 
        /// <para>
        /// Allows Wickr clients to send anonymized performance and usage metrics to the Wickr
        /// backend server for service improvement and troubleshooting.
        /// </para>
        /// </summary>
        public bool? EnableClientMetrics { get; set; }

        /// <summary>
        /// Checks to see if the EnableClientMetrics property is set.
        /// </summary>
        internal bool IsSetEnableClientMetrics() => this.EnableClientMetrics.HasValue;

        /// <summary>
        /// Gets and sets the property EnableTrustedDataFormat. 
        /// <para>
        /// Configuration for OpenTDF integration at the network level, enforcing ABAC decision
        /// making when operating in TDF enabled rooms.
        /// </para>
        /// </summary>
        public bool? EnableTrustedDataFormat { get; set; }

        /// <summary>
        /// Checks to see if the EnableTrustedDataFormat property is set.
        /// </summary>
        internal bool IsSetEnableTrustedDataFormat() => this.EnableTrustedDataFormat.HasValue;

        /// <summary>
        /// Gets and sets the property ReadReceiptConfig. 
        /// <para>
        /// Configuration for read receipts at the network level, controlling the default behavior
        /// for whether senders can see when their messages have been read.
        /// </para>
        /// </summary>
        public ReadReceiptConfig ReadReceiptConfig { get; set; }

        /// <summary>
        /// Checks to see if the ReadReceiptConfig property is set.
        /// </summary>
        internal bool IsSetReadReceiptConfig() => this.ReadReceiptConfig != null;
    }
}
