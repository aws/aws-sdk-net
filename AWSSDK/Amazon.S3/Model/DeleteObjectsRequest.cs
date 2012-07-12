﻿/*******************************************************************************
 *  Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The DeleteObjectsRequest contains the parameters used for the DeleteObjects operation.
    /// <br />Required Parameters: BucketName, Keys
    /// <br />The MfaCodes property is required if the bucket containing this object has been
    /// configured with the EnableMfaDelete property. For more information, please see:
    /// <see cref="P:Amazon.S3.Model.S3BucketVersioningConfig.EnableMfaDelete"/>.
    /// </summary>
    public class DeleteObjectsRequest : S3Request
    {
        #region Private Members

        private string bucketName;
        private bool quiet = false;
        private List<KeyVersion> keys = new List<KeyVersion>();
        private Tuple<string, string> mfaCodes;

        #endregion

        #region BucketName

        /// <summary>
        /// Gets and sets the BucketName property.
        /// </summary>
        [XmlElementAttribute(ElementName = "BucketName")]
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Sets the BucketName property for this request.
        /// This is the S3 Bucket that contains the S3 Objects
        /// you want to delete.
        /// </summary>
        /// <param name="bucketName">The value that BucketName is set to</param>
        /// <returns>the request with the BucketName set</returns>
        public DeleteObjectsRequest WithBucketName(string bucketName)
        {
            this.bucketName = bucketName;
            return this;
        }

        /// <summary>
        /// Checks if BucketName property is set.
        /// </summary>
        /// <returns>true if BucketName property is set.</returns>
        internal bool IsSetBucketName()
        {
            return !System.String.IsNullOrEmpty(this.bucketName);
        }
        #endregion

        #region Quiet

        /// <summary>
        /// Gets and Sets the property that governs whether
        /// the response includes successful deletes as well as errors
        /// following the DeleteObjects call against S3.
        /// 
        /// By default this property is false and successful deletes
        /// are returned in the response.
        /// </summary>
        public bool Quiet
        {
            get { return this.quiet; }
            set { this.quiet = value; }
        }

        /// <summary>
        /// Sets the Quiet property. If this property is set,
        /// the response includes successful deletes as well as errors
        /// following the DeleteObjects call against S3.
        /// </summary>
        /// <param name="quiet">Quiet property</param>
        /// <returns>This instance</returns>
        public DeleteObjectsRequest WithQuiet(bool quiet)
        {
            this.quiet = quiet;
            return this;
        }

        #endregion

        #region Keys

        /// <summary>
        /// List of KeyVersion objects representing
        /// the S3 objects that should be deleted.
        /// </summary>
        public List<KeyVersion> Keys
        {
            get
            {
                if (this.keys == null)
                    this.keys = new List<KeyVersion>();
                return this.keys;
            }
            set { this.keys = value; }
        }

        /// <summary>
        /// Add a key to be deleted.
        /// </summary>
        /// <param name="key">Key of the object to be deleted</param>
        public void AddKey(string key)
        {
            AddKey(new KeyVersion(key));
        }

        /// <summary>
        /// Add a key and a version to be deleted.
        /// </summary>
        /// <param name="key">Key of the object to be deleted.</param>
        /// <param name="version">Version of the object to be deleted.</param>
        public void AddKey(string key, string version)
        {
            AddKey(new KeyVersion(key, version));
        }

        /// <summary>
        /// Add a KeyVersion object representing the S3 object
        /// to be deleted.
        /// </summary>
        /// <param name="keyVersion">
        /// KeyVersion representation of object to be deleted.
        /// </param>
        public void AddKey(KeyVersion keyVersion)
        {
            if (this.keys == null)
            {
                this.keys = new List<KeyVersion>();
            }
            this.keys.Add(keyVersion);
        }

        /// <summary>
        /// Add a number of KeyVersion objects representing the S3 objects
        /// to be deleted.
        /// </summary>
        /// <param name="keys">
        /// KeyVersion representations of objects to be deleted.
        /// </param>
        public void AddKeys(params KeyVersion[] keys)
        {
            foreach (var key in keys)
            {
                AddKey(key);
            }
        }
        
        /// <summary>
        /// Adds the elements from the array to the collection of KeyVersions
        /// for this request.
        /// </summary>
        /// <param name="keys">
        /// KeyVersions that will be added to this request.
        /// </param>
        /// <returns></returns>
        public DeleteObjectsRequest WithKeys(params KeyVersion[] keys)
        {
            AddKeys(keys);
            return this;
        }

        #endregion

        #region MfaCodes

        /// <summary>
        /// Gets and Sets the MfaCodes property.
        /// The MfaCodes Tuple associates the Serial Number
        /// and the current Token/Code displayed on the
        /// Multi-Factor Authentication device associated with
        /// your AWS Account. This is a required property for this
        /// request if:<br />
        /// Permanently deleting a versioned object and
        /// versioning is configured with MFA Delete enabled.<br />
        /// </summary>
        [XmlIgnore]
        public Tuple<string, string> MfaCodes
        {
            get
            {
                if (this.mfaCodes == null)
                {
                    this.mfaCodes = new Tuple<string, string>("", "");
                }
                return this.mfaCodes;
            }
            set { this.mfaCodes = value; }
        }

        /// <summary>
        /// Sets the MfaCodes property.
        /// The MfaCodes Tuple associates the Serial Number
        /// and the current Token/Code displayed on the
        /// Multi-Factor Authentication device associated with
        /// your AWS Account. This is a required property for this
        /// request if:<br />
        /// Permanently deleting a versioned object and
        /// versioning is configured with MFA Delete enabled.<br />
        /// </summary>
        /// <param name="serial">Serial number of the authentication device</param>
        /// <param name="token">Token displayed on the authentication device</param>
        /// <returns>this instance</returns>
        public DeleteObjectsRequest WithMfaCodes(string serial, string token)
        {
            mfaCodes = new Tuple<string, string>(serial, token);
            return this;
        }

        /// <summary>
        /// Checks if the MfaCodes property is set.
        /// </summary>
        /// <returns>true if the MfaCodes property is set.</returns>
        internal bool IsSetMfaCodes()
        {
            return (this.mfaCodes != null) &&
                (!System.String.IsNullOrEmpty(MfaCodes.First)) &&
                (!System.String.IsNullOrEmpty(MfaCodes.Second));
        }

        #endregion

        internal string ContentXML
        {
            get
            {
                using (StringWriter sw = new StringWriter())
                {
                    using (XmlTextWriter writer = new XmlTextWriter(sw))
                    {
                        writer.WriteStartElement("Delete");
                        if (Quiet)
                        {
                            writer.WriteElementString("Quiet", Quiet.ToString());
                        }
                        foreach (KeyVersion keyVersion in keys)
                        {
                            writer.WriteStartElement("Object");
                            writer.WriteElementString("Key", keyVersion.Key);
                            if (!string.IsNullOrEmpty(keyVersion.VersionId))
                            {
                                writer.WriteElementString("VersionId", keyVersion.VersionId);
                            }
                            writer.WriteEndElement();
                        }
                        writer.WriteEndElement();
                    }
                    string xml = sw.ToString();
                    return xml;
                }
            }
        }
    }
}