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
 * Do not modify this file. This file is generated from the mediastore-data-2017-09-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaStoreData.Model
{
    /// <summary>
    /// This is the response object from the PutObject operation.
    /// </summary>
    public partial class PutObjectResponse : AmazonWebServiceResponse
    {
        private string _contentSHA256;
        private string _eTag;
        private StorageClass _storageClass;

        /// <summary>
        /// Gets and sets the property ContentSHA256. 
        /// <para>
        /// The SHA256 digest of the object that is persisted.
        /// </para>
        /// </summary>
        public string ContentSHA256
        {
            get { return this._contentSHA256; }
            set { this._contentSHA256 = value; }
        }

        // Check to see if ContentSHA256 property is set
        internal bool IsSetContentSHA256()
        {
            return this._contentSHA256 != null;
        }

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// Unique identifier of the object in the container.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property StorageClass. 
        /// <para>
        /// The storage class where the object was persisted. Should be “Temporal”.
        /// </para>
        /// </summary>
        public StorageClass StorageClass
        {
            get { return this._storageClass; }
            set { this._storageClass = value; }
        }

        // Check to see if StorageClass property is set
        internal bool IsSetStorageClass()
        {
            return this._storageClass != null;
        }

    }
}