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
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Amazon.S3.Model
{
    /// <summary>
    /// A set of origins and methods (cross-origin access that you want to allow).
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
        /// An optional unique identifier for the rule.
        /// </summary>
        /// <remarks>
        /// The ID value can be up to 255 characters long. The IDs help you find a rule in the configuration.
        /// </remarks>
        [XmlElement(ElementName = "ID")]
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// Sets an optional unique identifier for the rule.
        /// </summary>
        /// <remarks>
        /// The ID value can be up to 255 characters long. The IDs help you find a rule in the configuration.
        /// </remarks>
        /// <param name="id">Rule identifier</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// The set of methods enabled for this rule.
        /// </summary>
        /// <remarks>
        /// Accepted methods are GET, PUT, HEAD, DELETE and POST.
        /// Each CORSRule must contain at least one AllowedMethod and one AllowedOrigin element.
        /// </remarks>
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
        /// Sets the methods allowed for this rule.
        /// </summary>
        /// <remarks>
        /// Accepted methods are GET, PUT, HEAD, DELETE and POST.
        /// Each CORSRule must contain at least one AllowedMethod and one AllowedOrigin element.
        /// </remarks>
        /// <param name="args">AllowedMethods property</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// One or more response headers that you want customers to be able to access from their applications 
        /// (for example, from a JavaScript XMLHttpRequest object).
        /// </summary>
        /// <remarks>
        /// Each CORSRule must have at least one AllowedOrigin element. The string value can include at 
        /// most one '*' wildcard character, for example, http://*.example.com". You can also specify only 
        /// "*" to allow cross-origin access for all domains/origins.
        /// </remarks>
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
        /// Sets one or more response headers that you want customers to be able to access from their applications 
        /// (for example, from a JavaScript XMLHttpRequest object).
        /// </summary>
        /// <remarks>
        /// Each CORSRule must have at least one AllowedOrigin element. The string value can include at 
        /// most one '*' wildcard character, for example, http://*.example.com". You can also specify only 
        /// "*" to allow cross-origin access for all domains/origins.
        /// </remarks>
        /// <param name="args">AllowedOrigins property</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// The time in seconds that your browser is to cache the preflight response for the specified resource.
        /// </summary>
        /// <remarks>
        /// A CORSRule can have at most one MaxAgeSeconds element.
        /// </remarks>
        public int MaxAgeSeconds
        {
            get { return this.maxAgeSeconds.GetValueOrDefault(); }
            set { this.maxAgeSeconds = value; }
        }

        /// <summary>
        /// Sets the time in seconds that your browser is to cache the preflight response for the specified resource.
        /// </summary>
        /// <remarks>
        /// A CORSRule can have at most one MaxAgeSeconds element.
        /// </remarks>
        /// <param name="maxAgeSeconds">MaxAgeSeconds property</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// One or more headers in the response that you want customers to be able to access from their 
        /// applications (for example, from a JavaScript XMLHttpRequest object).
        /// </summary>
        /// <remarks>
        /// You add one ExposeHeader in the rule for each header.
        /// </remarks>
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
        /// Sets one or more headers in the response that you want customers to be able to access from their 
        /// applications (for example, from a JavaScript XMLHttpRequest object).
        /// </summary>
        /// <remarks>
        /// You add one ExposeHeader in the rule for each header.
        /// </remarks>
        /// <param name="args">ExposeHeaders property</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// Specifies which headers are allowed in a pre-flight OPTIONS request through the 
        /// Access-Control-Request-Headers header. 
        /// </summary>
        /// <remarks>
        /// Each header name specified in the Access-Control-Request-Headers must have a corresponding 
        /// entry in the rule. Only the headers that were requested will be sent back. 
        /// This element can contain at most one * wildcard character.
        /// </remarks>
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
        /// Specifies which headers are allowed in a pre-flight OPTIONS request through the 
        /// Access-Control-Request-Headers header. 
        /// </summary>
        /// <remarks>
        /// Each header name specified in the Access-Control-Request-Headers must have a corresponding 
        /// entry in the rule. Only the headers that were requested will be sent back. 
        /// This element can contain at most one * wildcard character.
        /// </remarks>
        /// <param name="args">AllowedHeaders property</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
