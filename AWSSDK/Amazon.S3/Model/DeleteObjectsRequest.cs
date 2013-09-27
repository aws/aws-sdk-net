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
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The parameters to request deletion of one or more objects from a bucket.
    /// </summary>
    /// <remarks>
    /// When performing a multi-object delete operation on an MFA Delete enabled bucket, that attempts to delete any versioned objects, 
    /// you must include an MFA token. If you do not provide one, the entire request will fail, even if there are non versioned objects 
    /// you are attempting to delete. If you provide an invalid token, whether there are versioned keys in the request or not, the entire 
    /// multi-object delete request will fail.
    /// </remarks>
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
        /// The name of the bucket containing the objects to be deleted.
        /// </summary>
        [XmlElementAttribute(ElementName = "BucketName")]
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Sets the name of the bucket containing the objects to be deleted.
        /// </summary>
        /// <param name="bucketName">The bucket name</param>
        /// <returns>the request with the BucketName set</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// Toggles between Quiet and Verbose mode for the operation.
        /// If set to true (Quiet mode), the response includes only those keys for objects on which
        /// the delete operation failed.
        /// </summary>
        /// <remarks>
        /// By default this property is false and keys for both successful deletes
        /// and failures are returned in the response.
        /// </remarks>
        public bool Quiet
        {
            get { return this.quiet; }
            set { this.quiet = value; }
        }

        /// <summary>
        /// Toggles between Quiet and Verbose mode for the operation.
        /// If set to true (Quiet mode), the response includes only those keys for objects on which
        /// the delete operation failed.
        /// </summary>
        /// <remarks>
        /// By default this property is false and keys for both successful deletes
        /// and failures are returned in the response.
        /// </remarks>
        /// <param name="quiet">True for Quiet mode, false for Verbose mode</param>
        /// <returns>This instance</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteObjectsRequest WithQuiet(bool quiet)
        {
            this.quiet = quiet;
            return this;
        }

        #endregion

        #region Keys

        /// <summary>
        /// A collection of KeyVersion objects representing the S3 objects that should be deleted.
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
        /// Add a key to the set of keys of objects to be deleted.
        /// </summary>
        /// <param name="key">Object key</param>
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
        /// Add a KeyVersion object representing the S3 object to be deleted.
        /// </summary>
        /// <param name="keyVersion">KeyVersion representation of object to be deleted.</param>
        public void AddKey(KeyVersion keyVersion)
        {
            if (this.keys == null)
            {
                this.keys = new List<KeyVersion>();
            }
            this.keys.Add(keyVersion);
        }

        /// <summary>
        /// Add one or more KeyVersion objects representing the S3 objects to be deleted.
        /// </summary>
        /// <param name="keys">KeyVersion representations of objects to be deleted.</param>
        public void AddKeys(params KeyVersion[] keys)
        {
            foreach (var key in keys)
            {
                AddKey(key);
            }
        }
        
        /// <summary>
        /// Add one or more KeyVersion objects representing the S3 objects to be deleted.
        /// </summary>
        /// <param name="keys">KeyVersions that will be added to this request.</param>
        /// <returns></returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteObjectsRequest WithKeys(params KeyVersion[] keys)
        {
            AddKeys(keys);
            return this;
        }

        #endregion

        #region MfaCodes

        /// <summary>
        /// The MfaCodes Tuple associates the Serial Number and the current Token/Code displayed on the
        /// Multi-Factor Authentication device associated with your AWS Account. 
        /// </summary>
        /// <remarks>
        /// This is a required property for this request if:<br />
        /// 1. EnableMfaDelete was configured on the bucket containing this object's version.<br />
        /// 2. You are deleting an object's version
        /// </remarks>
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
        /// The MfaCodes Tuple associates the Serial Number and the current Token/Code displayed on the
        /// Multi-Factor Authentication device associated with your AWS Account. 
        /// </summary>
        /// <remarks>
        /// This is a required property for this request if:<br />
        /// 1. EnableMfaDelete was configured on the bucket containing this object's version.<br />
        /// 2. You are deleting an object's version
        /// </remarks>
        /// <param name="serial">Serial number of the authentication device</param>
        /// <param name="token">Token displayed on the authentication device</param>
        /// <returns>this instance</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
