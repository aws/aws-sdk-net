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
 * Do not modify this file. This file is generated from the payment-cryptography-2021-09-14.normal.json service model.
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
namespace Amazon.PaymentCryptography.Model
{
    /// <summary>
    /// Represents the replication status information for a key in a replication region.
    /// 
    ///  
    /// <para>
    /// This structure contains details about the current state of key replication, including
    /// any status messages and operational information about the replication process.
    /// </para>
    /// </summary>
    public partial class ReplicationStatusType
    {
        private KeyReplicationState _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of key replication in this region.
        /// </para>
        ///  
        /// <para>
        /// This field indicates whether the key replication is in progress, completed successfully,
        /// or has encountered an error. Possible values include states such as SYNCRHONIZED,
        /// IN_PROGRESS, DELETE_IN_PROGRESS, or FAILED. This provides visibility into the replication
        /// process for monitoring and troubleshooting purposes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KeyReplicationState Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message that provides additional information about the current replication status
        /// of the key.
        /// </para>
        ///  
        /// <para>
        /// This field contains details about any issues or progress updates related to key replication
        /// operations. It may include information about replication failures, synchronization
        /// status, or other operational details.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}