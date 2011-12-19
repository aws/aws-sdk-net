/*******************************************************************************
 *  Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Amazon.S3.Model
{
    /// <summary>
    /// DeletedObject is a container for information about a successful
    /// delete operation against a specific S3 object.
    /// </summary>
    public class DeletedObject
    {
        private string key;
        private string versionId;
        private bool isDeleteMarker;
        private string deleteMarkerVersionId;

        /// <summary>
        /// Gets and set the key of the deleted S3 object.
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Gets and sets the version of the deleted S3 object.
        /// </summary>
        public string VersionId
        {
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        /// <summary>
        /// Gets and sets the IsDeleteMarker property.
        /// Specifies whether the object deleted was (true) or 
        /// was not (false) a Delete Marker.
        /// </summary>
        [XmlElement("DeleteMarker")]
        public bool IsDeleteMarker
        {
            get { return this.isDeleteMarker; }
            set { this.isDeleteMarker = value; }
        }

        /// <summary>
        /// Gets and sets the DeleteMarkerVersionId property.
        /// Specifies the VersionId for the DeleteMarker that
        /// was created when doing a non-versioned object
        /// was deleted in a versioned bucket.
        /// </summary>
        public string DeleteMarkerVersionId
        {
            get { return this.deleteMarkerVersionId; }
            set { this.deleteMarkerVersionId = value; }
        }
    }
}
