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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
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
        private bool? _dataRetention;
        private bool? _enableClientMetrics;
        private ReadReceiptConfig _readReceiptConfig;

        /// <summary>
        /// Gets and sets the property DataRetention. 
        /// <para>
        /// Indicates whether the data retention feature is enabled for the network. When true,
        /// messages are captured by the data retention bot for compliance and archiving purposes.
        /// </para>
        /// </summary>
        public bool DataRetention
        {
            get { return this._dataRetention.GetValueOrDefault(); }
            set { this._dataRetention = value; }
        }

        // Check to see if DataRetention property is set
        internal bool IsSetDataRetention()
        {
            return this._dataRetention.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableClientMetrics. 
        /// <para>
        /// Allows Wickr clients to send anonymized performance and usage metrics to the Wickr
        /// backend server for service improvement and troubleshooting.
        /// </para>
        /// </summary>
        public bool EnableClientMetrics
        {
            get { return this._enableClientMetrics.GetValueOrDefault(); }
            set { this._enableClientMetrics = value; }
        }

        // Check to see if EnableClientMetrics property is set
        internal bool IsSetEnableClientMetrics()
        {
            return this._enableClientMetrics.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReadReceiptConfig. 
        /// <para>
        /// Configuration for read receipts at the network level, controlling the default behavior
        /// for whether senders can see when their messages have been read.
        /// </para>
        /// </summary>
        public ReadReceiptConfig ReadReceiptConfig
        {
            get { return this._readReceiptConfig; }
            set { this._readReceiptConfig = value; }
        }

        // Check to see if ReadReceiptConfig property is set
        internal bool IsSetReadReceiptConfig()
        {
            return this._readReceiptConfig != null;
        }

    }
}