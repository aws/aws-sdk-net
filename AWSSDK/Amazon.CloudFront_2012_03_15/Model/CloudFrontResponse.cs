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
 *  API Version: 2010-11-01
 *
 */

using System;
using System.Collections.Specialized;
using System.Net;
using System.Xml.Serialization;

namespace Amazon.CloudFront_2012_03_15.Model
{
    /// <summary>
    /// Base class for all CloudFront operation responses.
    /// Provides a header collection which is used to store the response headers.
    /// Also exposes the RequestId and AmazonId2 from CloudFront responses.
    /// </summary>
    public class CloudFrontResponse
    {
        #region Private Members

        private string requestId;
        private string xml;

        /// <summary>
        /// The ETag Header returned by CloudFront that uniquely 
        /// identifies the configuration or information returned
        /// </summary>
        protected string etagHeader;

        /// <summary>
        /// web headers for all requests.
        /// </summary>
        protected WebHeaderCollection webHeaders;

        #endregion

        #region RequestId

        /// <summary>
        /// Gets and sets the RequestId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "RequestId")]
        public string RequestId
        {
            get { return this.requestId; }
            set { this.requestId = value; }
        }

        #endregion

        #region Headers

        /// <summary>
        /// Gets and sets the Headers property.
        /// </summary>
        [XmlIgnore]
        public virtual WebHeaderCollection Headers
        {
            get
            {
                if (this.webHeaders == null)
                {
                    this.webHeaders = new WebHeaderCollection();
                }
                return this.webHeaders;
            }
            set { this.webHeaders = value; }
        }

        #endregion

        #region XML

        /// <summary>
        /// Gets and sets the XML property. This is the 
        /// original XML response received from CloudFront
        /// </summary>
        [XmlIgnore]
        public string XML
        {
            get { return this.xml; }
            set { this.xml = value; }
        }

        #endregion

        #region ETag

        /// <summary>
        /// Gets and sets the ETag property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ETag")]
        public virtual string ETag
        {
            get { return this.etagHeader; }
            set { this.etagHeader = value; }
        }

        #endregion

        /// <summary>
        /// Returns the string representation of the response.
        /// </summary>
        /// <returns>
        /// A string representing the response.
        /// </returns>
        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(1024);
            XmlSerializer ser = new XmlSerializer(this.GetType());
            using (System.IO.StringWriter sr = new System.IO.StringWriter(sb))
            {
                ser.Serialize(sr, this);
            }
            return sb.ToString();
        }
    }
}