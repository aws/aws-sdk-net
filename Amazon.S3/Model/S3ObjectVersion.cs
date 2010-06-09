/*******************************************************************************
 *  Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Globalization;
using System.Text;
using System.Xml.Serialization;

using Amazon.Util;
using Amazon.S3.Util;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Represents an S3 Bucket Object Version. An S3 Object version is an S3 object
    /// that also has a VersionId, whether this is the Latest version of the object 
    /// and if its a DeleteMarker or not.
    /// </summary>
    public class S3ObjectVersion : S3Object
    {
        #region Private Members

        private string versionId;
        private bool fIsLatest;
        private bool fIsDeleteMarker;

        #endregion

        #region Public Methods

        /// <summary>
        /// Returns a System.String that represents the S3Object.
        /// </summary>
        /// <returns>A System.String representation of the S3Object.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("Properties: {");
            if (IsSetKey())
            {
                sb.Append(String.Concat("Key:", Key));
            }
            sb.Append(String.Concat(", VersionId:", versionId));
            sb.Append(String.Concat(", IsLatest:", fIsLatest));
            sb.Append(String.Concat(", IsDeleteMarker:", fIsDeleteMarker));
            sb.Append(String.Concat(", LastModified:", LastModified));
            sb.Append(String.Concat(", ETag:", ETag));
            sb.Append(String.Concat(", Size:", Size));
            sb.Append(String.Concat(", StorageClass:", StorageClass));
            sb.Append(", Owner Properties: {");
            sb.Append(String.Concat("Id:", Owner.Id));
            sb.Append(String.Concat(", DisplayName:", Owner.DisplayName));
            sb.Append("}}");

            return sb.ToString();
        }

        #endregion

        #region VersionId

        /// <summary>
        /// Gets and sets the VersionId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "VersionId")]
        public string VersionId
        {
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        #endregion

        #region IsLatest

        /// <summary>
        /// Gets and Sets the IsLatest property. 
        /// Specifies whether the object is (true) or 
        /// is not (false) the latest version of an object. 
        /// </summary>
        [XmlElementAttribute(ElementName = "IsLatest")]
        public bool IsLatest
        {
            get { return this.fIsLatest; }
            set { this.fIsLatest = value; }
        }

        #endregion

        #region IsDeleteMarker

        /// <summary>
        /// Gets and Sets the IsDeleteMarker property. 
        /// Specifies whether the object is (true) or 
        /// is not (false) the latest version of an object. 
        /// </summary>
        [XmlElementAttribute(ElementName = "IsDeleteMarker")]
        public bool IsDeleteMarker
        {
            get { return this.fIsDeleteMarker; }
            set { this.fIsDeleteMarker = value; }
        }

        #endregion
    }
}