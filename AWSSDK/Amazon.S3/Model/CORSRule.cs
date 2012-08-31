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
    /// A single CORS rule instance
    /// </summary>
    public class CORSRule
    {
        private string id;
        private List<string> allowedMethods;
        private List<string> allowedOrigins;
        private int? maxAgeSeconds;
        private List<string> exposeHeaders;
        private List<string> allowedHeaders;

        /// <summary>
        /// An identifier for the current rule
        /// </summary>
        [XmlElement(ElementName = "ID")]
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// Sets the Id property.
        /// </summary>
        /// <param name="id">Id property</param>
        /// <returns>this instance</returns>
        public CORSRule WithId(string id)
        {
            this.id = id;
            return this;
        }

        /// <summary>
        /// Checks if Id property is set.
        /// </summary>
        /// <returns>true if Id property is set.</returns>
        internal bool IsSetId()
        {
            return this.id != null;
        }


        /// <summary>
        /// Methods enabled for this rule.
        /// Accepted methods are GET, PUT, HEAD, DELETE and POST.
        /// </summary>
        [XmlElementAttribute(ElementName = "AllowedMethod")]
        public List<string> AllowedMethods
        {
            get
            {
                if (this.allowedMethods == null)
                {
                    this.allowedMethods = new List<string>();
                }
                return this.allowedMethods;
            }
            set { this.allowedMethods = value; }
        }

        /// <summary>
        /// Sets the AllowedMethods property.
        /// </summary>
        /// <param name="args">AllowedMethods property</param>
        /// <returns>this instance</returns>
        public CORSRule WithAllowedMethods(params string[] args)
        {
            foreach (string arg in args)
            {
                AllowedMethods.Add(arg);
            }
            return this;
        }

        /// <summary>
        /// Checks if AllowedMethods property is set.
        /// </summary>
        /// <returns>true if AllowedMethods property is set.</returns>
        internal bool IsSetAllowedMethods()
        {
            return (this.AllowedMethods.Count > 0);
        }


        /// <summary>
        /// Allowed origins for this rule.
        /// A single origin of "*" can be used to indicate all domains.
        /// </summary>
        [XmlElementAttribute(ElementName = "AllowedOrigin")]
        public List<string> AllowedOrigins
        {
            get
            {
                if (allowedOrigins == null)
                {
                    allowedOrigins = new List<string>();
                }
                return allowedOrigins;
            }
            set { this.allowedOrigins = value; }
        }

        /// <summary>
        /// Sets the AllowedOrigins property.
        /// </summary>
        /// <param name="args">AllowedOrigins property</param>
        /// <returns>this instance</returns>
        public CORSRule WithAllowedOrigins(params string[] args)
        {
            foreach (string arg in args)
            {
                AllowedOrigins.Add(arg);
            }
            return this;
        }

        /// <summary>
        /// Checks if AllowedOrigins property is set.
        /// </summary>
        /// <returns>true if AllowedOrigins property is set.</returns>
        internal bool IsSetAllowedOrigins()
        {
            return (this.AllowedOrigins.Count > 0);
        }


        /// <summary>
        /// Maximum age to set the client's caching behavior.
        /// </summary>
        public int MaxAgeSeconds
        {
            get { return this.maxAgeSeconds.GetValueOrDefault(); }
            set { this.maxAgeSeconds = value; }
        }

        /// <summary>
        /// Sets the MaxAgeSeconds property.
        /// </summary>
        /// <param name="maxAgeSeconds">MaxAgeSeconds property</param>
        /// <returns>this instance</returns>
        public CORSRule WithMaxAgeSeconds(int maxAgeSeconds)
        {
            this.maxAgeSeconds = maxAgeSeconds;
            return this;
        }

        /// <summary>
        /// Checks if MaxAgeSeconds property is set.
        /// </summary>
        /// <returns>true if MaxAgeSeconds property is set.</returns>
        internal bool IsSetMaxAgeSeconds()
        {
            return this.maxAgeSeconds.HasValue;
        }


        /// <summary>
        /// Enable the browser to read these headers.
        /// </summary>
        [XmlElementAttribute(ElementName = "ExposeHeader")]
        public List<string> ExposeHeaders
        {
            get
            {
                if (this.exposeHeaders == null)
                {
                    this.exposeHeaders = new List<string>();
                }
                return this.exposeHeaders;
            }
            set { this.exposeHeaders = value; }
        }

        /// <summary>
        /// Sets the ExposeHeaders property.
        /// </summary>
        /// <param name="args">ExposeHeaders property</param>
        /// <returns>this instance</returns>
        public CORSRule WithExposeHeaders(params string[] args)
        {
            foreach (string arg in args)
            {
                ExposeHeaders.Add(arg);
            }
            return this;
        }

        /// <summary>
        /// Checks if ExposeHeaders property is set.
        /// </summary>
        /// <returns>true if ExposeHeaders property is set.</returns>
        internal bool IsSetExposeHeaders()
        {
            return (this.ExposeHeaders.Count > 0);
        }


        /// <summary>
        /// Used in response to a preflight request to indicate which HTTP headers can
        /// be used when making the actual request
        /// </summary>
        [XmlElementAttribute(ElementName = "AllowedHeader")]
        public List<string> AllowedHeaders
        {
            get
            {
                if (this.allowedHeaders == null)
                {
                    this.allowedHeaders = new List<string>();
                }
                return this.allowedHeaders;
            }
            set { this.allowedHeaders = value; }
        }

        /// <summary>
        /// Sets the AllowedHeaders property.
        /// </summary>
        /// <param name="args">AllowedHeaders property</param>
        /// <returns>this instance</returns>
        public CORSRule WithAllowedHeaders(params string[] args)
        {
            foreach (string arg in args)
            {
                AllowedHeaders.Add(arg);
            }
            return this;
        }

        /// <summary>
        /// Checks if AllowedHeaders property is set.
        /// </summary>
        /// <returns>true if AllowedHeaders property is set.</returns>
        internal bool IsSetAllowedHeaders()
        {
            return (this.AllowedHeaders.Count > 0);
        }


        internal string ToXML()
        {
            using (StringWriter sw = new StringWriter())
            {
                using (XmlTextWriter writer = new XmlTextWriter(sw))
                {
                    writer.WriteStartElement("CORSRule");
                    {
                        if (!string.IsNullOrEmpty(this.Id))
                        {
                            writer.WriteElementString("ID", id);
                        }
                        foreach (var allowedOrigin in this.AllowedOrigins)
                        {
                            writer.WriteElementString("AllowedOrigin", allowedOrigin);
                        }
                        foreach (var allowedMethod in this.AllowedMethods)
                        {
                            writer.WriteElementString("AllowedMethod", allowedMethod);
                        }
                        if (this.maxAgeSeconds.HasValue)
                        {
                            writer.WriteElementString("MaxAgeSeconds", this.MaxAgeSeconds.ToString());
                        }
                        foreach (var exposeHeader in this.ExposeHeaders)
                        {
                            writer.WriteElementString("ExposeHeader", exposeHeader);
                        }
                        foreach (var allowedHeader in this.AllowedHeaders)
                        {
                            writer.WriteElementString("AllowedHeader", allowedHeader);
                        }
                    }
                    writer.WriteEndElement();
                }
                string xml = sw.ToString();
                return xml;
            }

        }
    }
}
