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

using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Defines the website configuration for a S3 bucket.
    /// </summary>
    public class WebsiteConfiguration
    {
        string _indexDocumentSuffix;
        string _errorDocument;
        RoutingRuleRedirect _redirectAllRequestsTo;
        List<RoutingRule> _routingRules = new List<RoutingRule>();

        #region IndexDocumentSuffix

        /// <summary>
        /// <para>
        /// This value is a suffix that is appended to a request that is for a "directory" 
        /// on the website endpoint (e.g. if the suffix is index.html and
        /// you make a request to samplebucket/images/ the data that
        /// is returned will be for the object with the key name
        /// images/index.html)
        /// </para>
        /// <para>
        /// The suffix must not be empty and must not include a slash
        /// character.
        /// </para>
        /// </summary>
        public string IndexDocumentSuffix
        {
            get { return this._indexDocumentSuffix; }
            set { this._indexDocumentSuffix = value; }
        }

        /// <summary>
        /// <para>
        /// This value is a suffix that is appended to a request that is for a "directory" 
        /// on the website endpoint (e.g. if the suffix is index.html and
        /// you make a request to samplebucket/images/ the data that
        /// is returned will be for the object with the key name
        /// images/index.html)
        /// </para>
        /// <para>
        /// The suffix must not be empty and must not include a slash
        /// character.
        /// </para>
        /// </summary>
        /// <param name="indexDocumentSuffix">Index document suffix</param>
        /// <returns>the WebsiteConfiguration with the IndexDocumentSuffix set</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public WebsiteConfiguration WithIndexDocumentSuffix(string indexDocumentSuffix)
        {
            this._indexDocumentSuffix = indexDocumentSuffix;
            return this;
        }

        /// <summary>
        /// Checks if the IndexDocumentSuffix property is set.
        /// </summary>
        /// <returns>true if IndexDocumentSuffix property is set.</returns>
        internal bool IsSetIndexDocumentSuffix()
        {
            return !System.String.IsNullOrEmpty(this._indexDocumentSuffix);
        }

        #endregion


        #region ErrorDocument

        /// <summary>
        /// The ErrorDocument value, an object key name to use when a 4XX class error occurs.
        /// </summary>
        public string ErrorDocument
        {
            get { return this._errorDocument; }
            set { this._errorDocument = value; }
        }

        /// <summary>
        /// The ErrorDocument value, an object key name to use when a 4XX class error occurs.
        /// </summary>
        /// <param name="errorDocument">Error document key</param>
        /// <returns>the WebsiteConfiguration with the ErrorDocument set</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public WebsiteConfiguration WithErrorDocument(string errorDocument)
        {
            this._errorDocument = errorDocument;
            return this;
        }

        /// <summary>
        /// Checks if the ErrorDocument property is set.
        /// </summary>
        /// <returns>true if ErrorDocument property is set.</returns>
        internal bool IsSetErrorDocument()
        {
            return !System.String.IsNullOrEmpty(this._errorDocument);
        }

        #endregion

        #region RedirectAllRequestsTo

        /// <summary>
        /// Container for redirect information where all requests will be redirect
        /// to. You can redirect requests to another host, to another page, or with
        /// another protocol. In the event of an error, you can can specify a
        /// different error code to return. .
        /// </summary>
        public RoutingRuleRedirect RedirectAllRequestsTo
        {
            get { return this._redirectAllRequestsTo; }
            set { this._redirectAllRequestsTo = value; }
        }

        /// <summary>
        /// The RedirectAllRequestsTo value, This is the container for redirect information where all requests will be redirect
        /// to. You can redirect requests to another host, to another page, or with
        /// another protocol. In the event of an error, you can can specify a
        /// different error code to return. .
        /// </summary>
        /// <param name="redirectAllRequestsTo">The container for redirect information</param>
        /// <returns>the WebsiteConfiguration with the RedirectAllRequestsTo set</returns>
        [System.Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public WebsiteConfiguration WithRedirectAllRequestsTo(RoutingRuleRedirect redirectAllRequestsTo)
        {
            this._redirectAllRequestsTo = redirectAllRequestsTo;
            return this;
        }

        /// <summary>
        /// Checks if the RedirectAllRequestsTo property is set.
        /// </summary>
        /// <returns>true if RedirectAllRequestsTo property is set.</returns>
        internal bool IsSetRedirectAllRequestsTo()
        {
            return this.RedirectAllRequestsTo != null;
        }

        #endregion


        /// <summary>
        /// The list of routing rules that can be used for configuring redirects if certain conditions are meet.
        /// </summary>
        public List<RoutingRule> RoutingRules
        {
            get
            {
                if (this._routingRules == null)
                    this._routingRules = new List<RoutingRule>();
                return this._routingRules;
            }
            set { this._routingRules = value; }
        }

        internal string ToXML()
        {
            StringWriter sw = new StringWriter();
            XmlTextWriter xmlWriter = new XmlTextWriter(sw);

            xmlWriter.WriteStartElement("WebsiteConfiguration", "xmlns='http://s3.amazonaws.com/doc/2006-03-01/'");

            if (this.IsSetRedirectAllRequestsTo())
            {
                xmlWriter.WriteStartElement("RedirectAllRequestsTo");
                if (this.RedirectAllRequestsTo.IsSetHostName())
                    xmlWriter.WriteElementString("HostName", this.RedirectAllRequestsTo.HostName);
                if (this.RedirectAllRequestsTo.IsSetHttpRedirectCode())
                    xmlWriter.WriteElementString("HttpRedirectCode", this.RedirectAllRequestsTo.HttpRedirectCode);
                if (this.RedirectAllRequestsTo.IsSetProtocol())
                    xmlWriter.WriteElementString("Protocol", this.RedirectAllRequestsTo.Protocol);
                if (this.RedirectAllRequestsTo.IsSetReplaceKeyPrefixWith())
                    xmlWriter.WriteElementString("ReplaceKeyPrefixWith", this.RedirectAllRequestsTo.ReplaceKeyPrefixWith);
                if (this.RedirectAllRequestsTo.IsSetReplaceKeyWith())
                    xmlWriter.WriteElementString("ReplaceKeyWith", this.RedirectAllRequestsTo.ReplaceKeyWith);
                xmlWriter.WriteEndElement();
            }
            else
            {
                xmlWriter.WriteStartElement("IndexDocument");
                xmlWriter.WriteElementString("Suffix", this.IndexDocumentSuffix);
                xmlWriter.WriteEndElement();

                if (this.IsSetErrorDocument())
                {
                    xmlWriter.WriteStartElement("ErrorDocument");
                    xmlWriter.WriteElementString("Key", this.ErrorDocument);
                    xmlWriter.WriteEndElement();
                }
            }

            if (this.RoutingRules.Count > 0)
            {
                xmlWriter.WriteStartElement("RoutingRules");
                foreach (var rule in this.RoutingRules)
                {
                    xmlWriter.WriteStartElement("RoutingRule");
                    if (rule.Condition != null)
                    {
                        xmlWriter.WriteStartElement("Condition");
                        if (rule.Condition.IsSetHttpErrorCodeReturnedEquals())
                            xmlWriter.WriteElementString("HttpErrorCodeReturnedEquals", rule.Condition.HttpErrorCodeReturnedEquals);
                        if (rule.Condition.IsSetKeyPrefixEquals())
                            xmlWriter.WriteElementString("KeyPrefixEquals", rule.Condition.KeyPrefixEquals);
                        xmlWriter.WriteEndElement();
                    }
                    if (rule.Redirect != null)
                    {
                        xmlWriter.WriteStartElement("Redirect");
                        if (rule.Redirect.IsSetHostName())
                            xmlWriter.WriteElementString("HostName", rule.Redirect.HostName);
                        if (rule.Redirect.IsSetHttpRedirectCode())
                            xmlWriter.WriteElementString("HttpRedirectCode", rule.Redirect.HttpRedirectCode);
                        if (rule.Redirect.IsSetProtocol())
                            xmlWriter.WriteElementString("Protocol", rule.Redirect.Protocol);
                        if (rule.Redirect.IsSetReplaceKeyPrefixWith())
                            xmlWriter.WriteElementString("ReplaceKeyPrefixWith", rule.Redirect.ReplaceKeyPrefixWith);
                        if (rule.Redirect.IsSetReplaceKeyWith())
                            xmlWriter.WriteElementString("ReplaceKeyWith", rule.Redirect.ReplaceKeyWith);
                        xmlWriter.WriteEndElement();
                    }
                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();
            }

            xmlWriter.WriteEndElement();

            xmlWriter.Close();
            return sw.ToString();
        }

    }
}
