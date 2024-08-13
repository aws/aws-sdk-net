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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Contains information about a successful delete operation against a specific S3 object.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public class DeletedObject
    {
        
        private bool? deleteMarker;
        private string deleteMarkerVersionId;
        private string key;
        private string versionId;

        /// <summary>
        /// Gets and sets the property DeleteMarker. 
        /// <para>
        /// Indicates whether the specified object version that was permanently deleted was (true)
        /// or was not (false) a delete marker before deletion. In a simple DELETE, this header
        /// indicates whether (true) or not (false) the current version of the object is a delete
        /// marker.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? DeleteMarker
        {
            get { return this.deleteMarker; }
            set { this.deleteMarker = value; }
        }

        // Check to see if DeleteMarker property is set
        internal bool IsSetDeleteMarker()
        {
            return this.deleteMarker.HasValue;
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
            get { return this.deleteMarkerVersionId; }
            set { this.deleteMarkerVersionId = value; }
        }

        // Check to see if DeleteMarkerVersionId property is set
        internal bool IsSetDeleteMarkerVersionId()
        {
            return this.deleteMarkerVersionId != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The name of the deleted object.
        /// </para>
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this.key != null;
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
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this.versionId != null;
        }
    }
}
