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
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The DeleteObjectsRequest contains the parameters used for the DeleteObjects operation.
    /// <br />Required Parameters: BucketName, Keys
    /// <br />The MfaCodes property is required if the bucket containing this object has been
    /// configured with the EnableMfaDelete property. For more information, please see:
    /// <see cref="P:Amazon.S3.Model.S3BucketVersioningConfig.EnableMfaDelete"/>.
    /// </summary>
    public class PutLifecycleConfigurationRequest : S3Request
    {
        #region Private Members

        private string bucketName;
        private LifecycleConfiguration configuration;

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
        public PutLifecycleConfigurationRequest WithBucketName(string bucketName)
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

        #region Configuration

        /// <summary>
        /// Gets and Sets the property that governs whether
        /// the response includes successful deletes as well as errors
        /// following the DeleteObjects call against S3.
        /// 
        /// By default this property is false and successful deletes
        /// are returned in the response.
        /// </summary>
        public LifecycleConfiguration Configuration
        {
            get { return this.configuration; }
            set { this.configuration = value; }
        }

        /// <summary>
        /// Sets the Quiet property. If this property is set,
        /// the response includes successful deletes as well as errors
        /// following the DeleteObjects call against S3.
        /// </summary>
        /// <param name="configuration">Configuration property</param>
        /// <returns>This instance</returns>
        public PutLifecycleConfigurationRequest WithConfiguration(LifecycleConfiguration configuration)
        {
            this.configuration = configuration;
            return this;
        }

        #endregion

        internal string ContentXML
        {
            get
            {
                if (configuration == null)
                    throw new InvalidOperationException("Configuration cannot be null");

                using (StringWriter sw = new StringWriter())
                {
                    using (XmlTextWriter writer = new XmlTextWriter(sw))
                    {
                        writer.WriteStartElement("LifecycleConfiguration");
                        foreach (var rule in configuration.Rules)
                        {
                            if (rule.Expiration == null)
                                throw new InvalidOperationException("Expiration cannot be null");

                            writer.WriteStartElement("Rule");

                            if (!string.IsNullOrEmpty(rule.Id))
                            {
                                writer.WriteElementString("ID", rule.Id);
                            }
                            writer.WriteElementString("Prefix", rule.Prefix);
                            writer.WriteElementString("Status", rule.Status.ToString());

                            writer.WriteStartElement("Expiration");
                            writer.WriteElementString("Days", rule.Expiration.Days.ToString());
                            writer.WriteEndElement();

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