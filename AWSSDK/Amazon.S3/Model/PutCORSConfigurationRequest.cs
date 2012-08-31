/*******************************************************************************
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

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The PutCORSConfigurationRequest contains the parameters used for the PutCORSConfigurationRequest operation.
    /// </summary>
    public class PutCORSConfigurationRequest : S3Request
    {
        private CORSConfiguration configuration;
        private string bucketName;

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
        /// </summary>
        /// <param name="bucketName">The value that BucketName is set to</param>
        /// <returns>the request with the BucketName set</returns>
        public PutCORSConfigurationRequest WithBucketName(string bucketName)
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


        /// <summary>
        /// Gets and sets the Configuration property.
        /// </summary>
        [XmlElementAttribute(ElementName = "CORSConfiguration")]
        public CORSConfiguration Configuration
        {
            get { return this.configuration; }
            set { this.configuration = value; }
        }

        /// <summary>
        /// Sets the Configuration property.
        /// </summary>
        /// <param name="configuration">Configuration property</param>
        /// <returns>this instance</returns>
        public PutCORSConfigurationRequest WithConfiguration(CORSConfiguration configuration)
        {
            this.configuration = configuration;
            return this;
        }

        /// <summary>
        /// Checks if Configuration property is set.
        /// </summary>
        /// <returns>true if Configuration property is set.</returns>
        internal bool IsSetConfiguration()
        {
            return (this.Configuration != null);
        }

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
                        writer.WriteStartElement("CORSConfiguration");
                        foreach (var rule in Configuration.Rules)
                        {
                            writer.WriteRaw(rule.ToXML());
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
