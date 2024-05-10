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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Omics.Model
{
    /// <summary>
    /// Container for the parameters to the CompleteMultipartReadSetUpload operation.
    /// Concludes a multipart upload once you have uploaded all the components.
    /// </summary>
    public partial class CompleteMultipartReadSetUploadRequest : AmazonOmicsRequest
    {
        private List<CompleteReadSetUploadPartListItem> _parts = AWSConfigs.InitializeCollections ? new List<CompleteReadSetUploadPartListItem>() : null;
        private string _sequenceStoreId;
        private string _uploadId;

        /// <summary>
        /// Gets and sets the property Parts. 
        /// <para>
        /// The individual uploads or parts of a multipart upload.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<CompleteReadSetUploadPartListItem> Parts
        {
            get { return this._parts; }
            set { this._parts = value; }
        }

        // Check to see if Parts property is set
        internal bool IsSetParts()
        {
            return this._parts != null && (this._parts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SequenceStoreId. 
        /// <para>
        /// The sequence store ID for the store involved in the multipart upload.
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
        /// The ID for the multipart upload.
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

    }
}