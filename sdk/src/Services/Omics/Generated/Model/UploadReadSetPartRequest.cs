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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.Omics.Model
{
    /// <summary>
    /// Container for the parameters to the UploadReadSetPart operation.
    /// This operation uploads a specific part of a read set. If you upload a new part using
    /// a previously used part number, the previously uploaded part will be overwritten.
    /// </summary>
    public partial class UploadReadSetPartRequest : AmazonOmicsRequest
    {
        private int? _partNumber;
        private ReadSetPartSource _partSource;
        private Stream _payload;
        private string _sequenceStoreId;
        private string _uploadId;

        /// <summary>
        /// Gets and sets the property PartNumber. 
        /// <para>
        /// The number of the part being uploaded.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10000)]
        public int PartNumber
        {
            get { return this._partNumber.GetValueOrDefault(); }
            set { this._partNumber = value; }
        }

        // Check to see if PartNumber property is set
        internal bool IsSetPartNumber()
        {
            return this._partNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PartSource. 
        /// <para>
        /// The source file for an upload part.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReadSetPartSource PartSource
        {
            get { return this._partSource; }
            set { this._partSource = value; }
        }

        // Check to see if PartSource property is set
        internal bool IsSetPartSource()
        {
            return this._partSource != null;
        }

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// The read set data to upload for a part.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Stream Payload
        {
            get { return this._payload; }
            set { this._payload = value; }
        }

        // Check to see if Payload property is set
        internal bool IsSetPayload()
        {
            return this._payload != null;
        }

        /// <summary>
        /// Gets and sets the property SequenceStoreId. 
        /// <para>
        /// The Sequence Store ID used for the multipart upload.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=36)]
        public string SequenceStoreId
        {
            get { return this._sequenceStoreId; }
            set { this._sequenceStoreId = value; }
        }

        // Check to see if SequenceStoreId property is set
        internal bool IsSetSequenceStoreId()
        {
            return this._sequenceStoreId != null;
        }

        /// <summary>
        /// Gets and sets the property UploadId. 
        /// <para>
        /// The ID for the initiated multipart upload.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=36)]
        public string UploadId
        {
            get { return this._uploadId; }
            set { this._uploadId = value; }
        }

        // Check to see if UploadId property is set
        internal bool IsSetUploadId()
        {
            return this._uploadId != null;
        }

        /// <summary>
        /// Get the signer to use for this request.
        /// </summary>
        /// <returns>A signer for this request.</returns>
        override protected AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer(false);
        }
    }
}