/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.S3.Model
{
    /// <summary>Website Configuration
    /// </summary>
    public class WebsiteConfiguration
    {
        
        private string errorDocument;
        private string indexDocumentSuffix;
        private RoutingRuleRedirect redirectAllRequestsTo;
        private List<RoutingRule> routingRules = new List<RoutingRule>();

        /// <summary>
        /// The ErrorDocument value, an object key name to use when a 4XX class error occurs.
        /// </summary>
        public string ErrorDocument
        {
            get { return this.errorDocument; }
            set { this.errorDocument = value; }
        }

        // Check to see if ErrorDocument property is set
        internal bool IsSetErrorDocument()
        {
            return this.errorDocument != null;
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
        public string IndexDocumentSuffix
        {
            get { return this.indexDocumentSuffix; }
            set { this.indexDocumentSuffix = value; }
        }

        // Check to see if IndexDocument property is set
        internal bool IsSetIndexDocumentSuffix()
        {
            return this.indexDocumentSuffix != null;
        }

        /// <summary>
        /// Container for redirect information where all requests will be redirect
        /// to. You can redirect requests to another host, to another page, or with
        /// another protocol. In the event of an error, you can can specify a
        /// different error code to return. .
        /// </summary>
        public RoutingRuleRedirect RedirectAllRequestsTo
        {
            get { return this.redirectAllRequestsTo; }
            set { this.redirectAllRequestsTo = value; }
        }

        // Check to see if RedirectAllRequestsTo property is set
        internal bool IsSetRedirectAllRequestsTo()
        {
            return this.redirectAllRequestsTo != null;
        }

        /// <summary>
        /// The list of routing rules that can be used for configuring redirects if certain conditions are meet.
        /// </summary>
        public List<RoutingRule> RoutingRules
        {
            get { return this.routingRules; }
            set { this.routingRules = value; }
        }

        // Check to see if RoutingRules property is set
        internal bool IsSetRoutingRules()
        {
            return this.routingRules.Count > 0;
        }
    }
}
