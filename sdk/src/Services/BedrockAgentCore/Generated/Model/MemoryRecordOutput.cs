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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Output information returned after processing a memory record operation.
    /// </summary>
    public partial class MemoryRecordOutput
    {
        private int? _errorCode;
        private string _errorMessage;
        private string _memoryRecordId;
        private string _requestIdentifier;
        private MemoryRecordStatus _status;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code returned when the memory record operation fails.
        /// </para>
        /// </summary>
        public int? ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// A human-readable error message describing why the memory record operation failed.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property MemoryRecordId. 
        /// <para>
        /// The unique ID associated to the memory record.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=40, Max=50)]
        public string MemoryRecordId
        {
            get { return this._memoryRecordId; }
            set { this._memoryRecordId = value; }
        }

        // Check to see if MemoryRecordId property is set
        internal bool IsSetMemoryRecordId()
        {
            return this._memoryRecordId != null;
        }

        /// <summary>
        /// Gets and sets the property RequestIdentifier. 
        /// <para>
        /// The client-provided identifier that was used to track this record operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=80)]
        public string RequestIdentifier
        {
            get { return this._requestIdentifier; }
            set { this._requestIdentifier = value; }
        }

        // Check to see if RequestIdentifier property is set
        internal bool IsSetRequestIdentifier()
        {
            return this._requestIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the memory record operation (e.g., SUCCEEDED, FAILED).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MemoryRecordStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}