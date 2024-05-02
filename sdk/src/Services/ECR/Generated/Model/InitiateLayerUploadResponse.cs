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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
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
namespace Amazon.ECR.Model
{
    /// <summary>
    /// This is the response object from the InitiateLayerUpload operation.
    /// </summary>
    public partial class InitiateLayerUploadResponse : AmazonWebServiceResponse
    {
        private long? _partSize;
        private string _uploadId;

        /// <summary>
        /// Gets and sets the property PartSize. 
        /// <para>
        /// The size, in bytes, that Amazon ECR expects future layer part uploads to be.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? PartSize
        {
            get { return this._partSize; }
            set { this._partSize = value; }
        }

        // Check to see if PartSize property is set
        internal bool IsSetPartSize()
        {
            return this._partSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UploadId. 
        /// <para>
        /// The upload ID for the layer upload. This parameter is passed to further <a>UploadLayerPart</a>
        /// and <a>CompleteLayerUpload</a> operations.
        /// </para>
        /// </summary>
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