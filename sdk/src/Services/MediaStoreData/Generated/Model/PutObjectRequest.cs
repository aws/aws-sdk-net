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
using Amazon.Runtime.Internal.Auth;

namespace Amazon.MediaStoreData.Model
{
    /// <summary>
    /// Container for the parameters to the PutObject operation.
    /// Uploads an object to the specified path. Object sizes are limited to 25 MB.
    /// </summary>
    public partial class PutObjectRequest : AmazonMediaStoreDataRequest
    {
        private Stream _body;
        private string _cacheControl;
        private string _contentType;
        private string _path;
        private StorageClass _storageClass;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The bytes to be stored. 
        /// </para>
        /// </summary>
        public Stream Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

        /// <summary>
        /// Gets and sets the property CacheControl. 
        /// <para>
        /// An optional <code>CacheControl</code> header that allows the caller to control the
        /// object's cache behavior. Headers can be passed in as specified in the HTTP at <a href="https://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.9">https://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.9</a>.
        /// </para>
        ///  
        /// <para>
        /// Headers with a custom user-defined value are also accepted.
        /// </para>
        /// </summary>
        public string CacheControl
        {
            get { return this._cacheControl; }
            set { this._cacheControl = value; }
        }

        // Check to see if CacheControl property is set
        internal bool IsSetCacheControl()
        {
            return this._cacheControl != null;
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The content type of the object.
        /// </para>
        /// </summary>
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path (including the file name) where the object is stored in the container. Format:
        /// &lt;folder name&gt;/&lt;folder name&gt;/&lt;file name&gt;
        /// </para>
        ///  
        /// <para>
        /// For example, to upload the file <code>mlaw.avi</code> to the folder path <code>premium\canada</code>
        /// in the container <code>movies</code>, enter the path <code>premium/canada/mlaw.avi</code>.
        /// </para>
        ///  
        /// <para>
        /// Do not include the container name in this path.
        /// </para>
        ///  
        /// <para>
        /// If the path includes any folders that don't exist yet, the service creates them. For
        /// example, suppose you have an existing <code>premium/usa</code> subfolder. If you specify
        /// <code>premium/canada</code>, the service creates a <code>canada</code> subfolder in
        /// the <code>premium</code> folder. You then have two subfolders, <code>usa</code> and
        /// <code>canada</code>, in the <code>premium</code> folder. 
        /// </para>
        ///  
        /// <para>
        /// There is no correlation between the path to the source and the path (folders) in the
        /// container in AWS Elemental MediaStore.
        /// </para>
        ///  
        /// <para>
        /// For more information about folders and how they exist in a container, see the <a href="http://docs.aws.amazon.com/mediastore/latest/ug/">AWS
        /// Elemental MediaStore User Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// The file name is the name that is assigned to the file that you upload. The file can
        /// have the same name inside and outside of AWS Elemental MediaStore, or it can have
        /// the same name. The file name can include or omit an extension. 
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property StorageClass. 
        /// <para>
        /// Indicates the storage class of a <code>Put</code> request. Defaults to high-performance
        /// temporal storage class, and objects are persisted into durable storage shortly after
        /// being received.
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