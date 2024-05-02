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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains error information for an asset property aggregate entry that is associated
    /// with the <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_BatchGetAssetPropertyAggregates.html">BatchGetAssetPropertyAggregates</a>
    /// API.
    /// </summary>
    public partial class BatchGetAssetPropertyAggregatesErrorEntry
    {
        private string _entryId;
        private BatchGetAssetPropertyAggregatesErrorCode _errorCode;
        private string _errorMessage;

        /// <summary>
        /// Gets and sets the property EntryId. 
        /// <para>
        /// The ID of the entry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string EntryId
        {
            get { return this._entryId; }
            set { this._entryId = value; }
        }

        // Check to see if EntryId property is set
        internal bool IsSetEntryId()
        {
            return this._entryId != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BatchGetAssetPropertyAggregatesErrorCode ErrorCode
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
        /// The associated error message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}