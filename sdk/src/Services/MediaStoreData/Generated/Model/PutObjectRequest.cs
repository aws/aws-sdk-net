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
 * Do not modify this file. This file is generated from the mediastore-data-2017-09-01.normal.json service model.
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
namespace Amazon.MediaStoreData.Model
{
    /// <summary>
    /// Container for the parameters to the PutObject operation.
    /// Uploads an object to the specified path. Object sizes are limited to 25 MB for standard
    /// upload availability and 10 MB for streaming upload availability.
    /// </summary>
    public partial class PutObjectRequest : AmazonMediaStoreDataRequest
    {
        private Stream _body;
        private string _cacheControl;
        private string _contentType;
        private string _path;
        private StorageClass _storageClass;
        private UploadAvailability _uploadAvailability;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The bytes to be stored. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// An optional <c>CacheControl</c> header that allows the caller to control the object's
        /// cache behavior. Headers can be passed in as specified in the HTTP at <a href="https://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.9">https://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.9</a>.
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
        /// For example, to upload the file <c>mlaw.avi</c> to the folder path <c>premium\canada</c>
        /// in the container <c>movies</c>, enter the path <c>premium/canada/mlaw.avi</c>.
        /// </para>
        ///  
        /// <para>
        /// Do not include the container name in this path.
        /// </para>
        ///  
        /// <para>
        /// If the path includes any folders that don't exist yet, the service creates them. For
        /// example, suppose you have an existing <c>premium/usa</c> subfolder. If you specify
        /// <c>premium/canada</c>, the service creates a <c>canada</c> subfolder in the <c>premium</c>
        /// folder. You then have two subfolders, <c>usa</c> and <c>canada</c>, in the <c>premium</c>
        /// folder. 
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
        [AWSProperty(Required=true, Min=1, Max=900)]
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
        /// Indicates the storage class of a <c>Put</c> request. Defaults to high-performance
        /// temporal storage class, and objects are persisted into durable storage shortly after
        /// being received.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16)]
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
        /// Gets and sets the property UploadAvailability. 
        /// <para>
        /// Indicates the availability of an object while it is still uploading. If the value
        /// is set to <c>streaming</c>, the object is available for downloading after some initial
        /// buffering but before the object is uploaded completely. If the value is set to <c>standard</c>,
        /// the object is available for downloading only when it is uploaded completely. The default
        /// value for this header is <c>standard</c>.
        /// </para>
        ///  
        /// <para>
        /// To use this header, you must also set the HTTP <c>Transfer-Encoding</c> header to
        /// <c>chunked</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16)]
        public UploadAvailability UploadAvailability
        {
            get { return this._uploadAvailability; }
            set { this._uploadAvailability = value; }
        }

        // Check to see if UploadAvailability property is set
        internal bool IsSetUploadAvailability()
        {
            return this._uploadAvailability != null;
        }

    }
}