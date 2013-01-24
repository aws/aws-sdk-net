/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.S3.Util;
using System;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The CopyPartResponse contains all the information about the
    /// CopyPart operation.
    /// </summary>
    [XmlTypeAttribute(Namespace = "http://s3.amazonaws.com/doc/2006-03-01/")]
    [XmlRootAttribute(Namespace = "http://s3.amazonaws.com/doc/2006-03-01/", IsNullable = false)]
    public class CopyPartResponse : S3Response
    {
        #region Private Members

        private string lastModified;
        private string eTag;
        private string srcVersionId;
        private int partNumber;
        private ServerSideEncryptionMethod serverSideEncryptionMethod;

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

        #region PartNumber

        /// <summary>
        /// Gets and sets the PartNumber property.
        /// This is the part number in it's multi-part upload that will uniquely identify the part 
        /// and determine the relative ordering within the destination object.
        /// </summary>
        [XmlElementAttribute(ElementName = "PartNumber")]
        public int PartNumber
        {
            get { return this.partNumber; }
            set { this.partNumber = value; }
        }

        #endregion

        #region ServerSideEncryption

        /// <summary>
        /// Gets and sets the ServerSideEncryptionMethod property.
        /// Specifies the encryption used on the server to
        /// store the content.
        /// Default is None.
        /// </summary>
        [XmlElementAttribute(ElementName = "ServerSideEncryptionMethod")]
        public ServerSideEncryptionMethod ServerSideEncryptionMethod
        {
            get { return this.serverSideEncryptionMethod; }
            set { this.serverSideEncryptionMethod = value; }
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

                ServerSideEncryptionMethod = ServerSideEncryptionMethod.None;
                if (!System.String.IsNullOrEmpty(hdr = value.Get(S3Constants.AmzServerSideEncryptionHeader)))
                {
                    this.ServerSideEncryptionMethod = (ServerSideEncryptionMethod)Enum.Parse(typeof(ServerSideEncryptionMethod), hdr);
                }
            }
        }

        #endregion
    }
}