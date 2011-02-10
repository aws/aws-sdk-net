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

using System.Xml.Serialization;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The CopyObjectResponse contains all the information about the
    /// CopyObject operation.
    /// </summary>
    [XmlTypeAttribute(Namespace = "http://s3.amazonaws.com/doc/2006-03-01/")]
    [XmlRootAttribute(Namespace = "http://s3.amazonaws.com/doc/2006-03-01/", IsNullable = false)]
    public class CopyObjectResponse : S3Response
    {
        #region Private Members

        private string lastModified;
        private string eTag;
        private string versionId;
        private string srcVersionId;

        #endregion

        #region LastModified

        /// <summary>
        /// Gets and sets the LastModified property.
        /// </summary>
        [XmlElementAttribute(ElementName = "LastModified")]
        public string LastModified
        {
            get { return this.lastModified; }
            set { this.lastModified = value; }
        }

        #endregion

        #region ETag

        /// <summary>
        /// Gets and sets the ETag property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ETag")]
        public string ETag
        {
            get { return this.eTag; }
            set { this.eTag = value; }
        }

        #endregion

        #region SourceVersionId

        /// <summary>
        /// Gets and sets the SourceVersionId property.
        /// This is the Version Id of the Source Object
        /// </summary>
        [XmlElementAttribute(ElementName = "SourceVersionId")]
        public string SourceVersionId
        {
            get { return this.srcVersionId; }
            set { this.srcVersionId = value; }
        }

        #endregion

        #region VersionId

        /// <summary>
        /// Gets and sets the VersionId property.
        /// This is the version-id of the  object in the destination bucket
        /// </summary>
        [XmlElementAttribute(ElementName = "VersionId")]
        public string VersionId
        {
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        #endregion

        #region Headers

        /// <summary>
        /// Gets and sets the Headers property.
        /// </summary>
        public override System.Net.WebHeaderCollection Headers
        {
            set
            {
                base.Headers = value;

                string hdr = null;
                if (!System.String.IsNullOrEmpty(hdr = value.Get("x-amz-copy-source-version-id")))
                {
                    this.SourceVersionId = hdr;
                }

                if (!System.String.IsNullOrEmpty(hdr = value.Get(Util.S3Constants.AmzVersionIdHeader)))
                {
                    this.VersionId = hdr;
                }
            }
        }

        #endregion
    }
}