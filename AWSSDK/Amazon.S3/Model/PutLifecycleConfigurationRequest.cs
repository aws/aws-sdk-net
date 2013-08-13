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

using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The parameters to set a lifecycle configuration on a bucket.
    /// </summary>
    public class PutLifecycleConfigurationRequest : S3Request
    {
        #region Private Members

        private string bucketName;
        private LifecycleConfiguration configuration;

        #endregion

        #region BucketName

        /// <summary>
        /// The name of the bucket to have the lifecycle configuration applied.
        /// </summary>
        [XmlElementAttribute(ElementName = "BucketName")]
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Sets the name of the bucket to have the lifecycle configuration applied.
        /// </summary>
        /// <param name="bucketName">The bucket name</param>
        /// <returns>the request with the BucketName set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// The lifecycle configuration to be applied.
        /// </summary>
        public LifecycleConfiguration Configuration
        {
            get { return this.configuration; }
            set { this.configuration = value; }
        }

        /// <summary>
        /// The lifecycle configuration to be applied.
        /// </summary>
        /// <param name="configuration">Lifecycle configuration</param>
        /// <returns>This instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
                            writer.WriteStartElement("Rule");

                            if (!string.IsNullOrEmpty(rule.Id))
                            {
                                writer.WriteElementString("ID", rule.Id);
                            }
                            writer.WriteElementString("Prefix", rule.Prefix);
                            writer.WriteElementString("Status", rule.Status.ToString());

                            if (rule.Transition != null)
                            {
                                writer.WriteStartElement("Transition");

                                if (rule.Transition.Date != DateTime.MinValue)
                                    writer.WriteElementString("Date", rule.Transition.Date.ToUniversalTime().Date.ToString(Amazon.Util.AWSSDKUtils.ISO8601DateFormat));
                                else
                                    writer.WriteElementString("Days", rule.Transition.Days.ToString());

                                writer.WriteElementString("StorageClass", rule.Transition.StorageClass.ToString().ToUpper());
                                writer.WriteEndElement();
                            }

                            if (rule.Expiration != null)
                            {
                            writer.WriteStartElement("Expiration");
                                if (rule.Expiration.Date != DateTime.MinValue)
                                    writer.WriteElementString("Date", rule.Expiration.Date.ToUniversalTime().Date.ToString(Amazon.Util.AWSSDKUtils.ISO8601DateFormat));
                                else
                            writer.WriteElementString("Days", rule.Expiration.Days.ToString());
                            writer.WriteEndElement();
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
