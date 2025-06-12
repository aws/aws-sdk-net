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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
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
namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// <c>PutRecords</c> results.
    /// </summary>
    public partial class PutRecordsResponse : AmazonWebServiceResponse
    {
        private EncryptionType _encryptionType;
        private int? _failedRecordCount;
        private List<PutRecordsResultEntry> _records = AWSConfigs.InitializeCollections ? new List<PutRecordsResultEntry>() : null;

        /// <summary>
        /// Gets and sets the property EncryptionType. 
        /// <para>
        /// The encryption type used on the records. This parameter can be one of the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NONE</c>: Do not encrypt the records.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KMS</c>: Use server-side encryption on the records using a customer-managed Amazon
        /// Web Services KMS key.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EncryptionType EncryptionType
        {
            get { return this._encryptionType; }
            set { this._encryptionType = value; }
        }

        // Check to see if EncryptionType property is set
        internal bool IsSetEncryptionType()
        {
            return this._encryptionType != null;
        }

        /// <summary>
        /// Gets and sets the property FailedRecordCount. 
        /// <para>
        /// The number of unsuccessfully processed records in a <c>PutRecords</c> request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? FailedRecordCount
        {
            get { return this._failedRecordCount; }
            set { this._failedRecordCount = value; }
        }

        // Check to see if FailedRecordCount property is set
        internal bool IsSetFailedRecordCount()
        {
            return this._failedRecordCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Records. 
        /// <para>
        /// An array of successfully and unsuccessfully processed record results. A record that
        /// is successfully added to a stream includes <c>SequenceNumber</c> and <c>ShardId</c>
        /// in the result. A record that fails to be added to a stream includes <c>ErrorCode</c>
        /// and <c>ErrorMessage</c> in the result.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public List<PutRecordsResultEntry> Records
        {
            get { return this._records; }
            set { this._records = value; }
        }

        // Check to see if Records property is set
        internal bool IsSetRecords()
        {
            return this._records != null && (this._records.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}