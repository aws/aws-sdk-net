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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// Information about the deleted object.
    /// </summary>
    public partial class DeletedObject
    {
        private bool? _deleteMarker;
        private string _deleteMarkerVersionId;
        private string _key;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property DeleteMarker. 
        /// <para>
        /// Indicates whether the specified object version that was permanently deleted was (true)
        /// or was not (false) a delete marker before deletion. In a simple DELETE, this header
        /// indicates whether (true) or not (false) the current version of the object is a delete
        /// marker. To learn more about delete markers, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/DeleteMarker.html">Working
        /// with delete markers</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? DeleteMarker
        {
            get { return this._deleteMarker; }
            set { this._deleteMarker = value; }
        }

        // Check to see if DeleteMarker property is set
        internal bool IsSetDeleteMarker()
        {
            return this._deleteMarker.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeleteMarkerVersionId. 
        /// <para>
        /// The version ID of the delete marker created as a result of the DELETE operation. If
        /// you delete a specific object version, the value returned by this header is the version
        /// ID of the object version deleted.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public string DeleteMarkerVersionId
        {
            get { return this._deleteMarkerVersionId; }
            set { this._deleteMarkerVersionId = value; }
        }

        // Check to see if DeleteMarkerVersionId property is set
        internal bool IsSetDeleteMarkerVersionId()
        {
            return this._deleteMarkerVersionId != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The name of the deleted object.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The version ID of the deleted object.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}