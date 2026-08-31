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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
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
namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// Identifies a single uploaded part of a multipart attachment upload. Pass a list of
    /// <c>CompletedUpload</c> objects to <a>CompleteAttachmentUpload</a> to finalize the
    /// upload.
    /// </summary>
    public partial class CompletedUpload
    {
        private string _eTag;
        private int? _partIndex;

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The ETag returned in the response headers when the part was uploaded to Amazon S3.
        /// The <c>ETag</c> value identifies the part contents.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ETag
        {
            get { return this._eTag; }
            set { this._eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this._eTag != null;
        }

        /// <summary>
        /// Gets and sets the property PartIndex. 
        /// <para>
        /// The index of the uploaded part. This is the same <c>partIndex</c> value returned for
        /// the corresponding entry in the <c>uploadUrls</c> field of the <c>GetAttachmentUploadLinks</c>
        /// response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? PartIndex
        {
            get { return this._partIndex; }
            set { this._partIndex = value; }
        }

        // Check to see if PartIndex property is set
        internal bool IsSetPartIndex()
        {
            return this._partIndex.HasValue; 
        }

    }
}