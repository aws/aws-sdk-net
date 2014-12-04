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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Represents the result of an individual record from a <code>PutRecords</code> request.
    /// A record that is successfully added to your Amazon Kinesis stream includes SequenceNumber
    /// and ShardId in the result. A record that fails to be added to your Amazon Kinesis
    /// stream includes ErrorCode and ErrorMessage in the result.
    /// </summary>
    public partial class PutRecordsResultEntry
    {
        private string _errorCode;
        private string _errorMessage;
        private string _sequenceNumber;
        private string _shardId;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code for an individual record result. <code>ErrorCodes</code> can be either
        /// <code>ProvisionedThroughputExceededException</code> or <code>InternalFailure</code>.
        /// </para>
        /// </summary>
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message for an individual record result. An <code>ErrorCode</code> value
        /// of <code>ProvisionedThroughputExceededException</code> has an error message that includes
        /// the account ID, stream name, and shard ID. An <code>ErrorCode</code> value of <code>InternalFailure</code>
        /// has the error message <code>"Internal Service Failure"</code>.
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
        /// Gets and sets the property SequenceNumber. 
        /// <para>
        /// The sequence number for an individual record result.
        /// </para>
        /// </summary>
        public string SequenceNumber
        {
            get { return this._sequenceNumber; }
            set { this._sequenceNumber = value; }
        }

        // Check to see if SequenceNumber property is set
        internal bool IsSetSequenceNumber()
        {
            return this._sequenceNumber != null;
        }

        /// <summary>
        /// Gets and sets the property ShardId. 
        /// <para>
        /// The shard ID for an individual record result.
        /// </para>
        /// </summary>
        public string ShardId
        {
            get { return this._shardId; }
            set { this._shardId = value; }
        }

        // Check to see if ShardId property is set
        internal bool IsSetShardId()
        {
            return this._shardId != null;
        }

    }
}