/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Website parameters for the S3 bucket.
    /// </summary>
    public partial class AwsS3BucketWebsiteConfiguration
    {
        private string _errorDocument;
        private string _indexDocumentSuffix;
        private AwsS3BucketWebsiteConfigurationRedirectTo _redirectAllRequestsTo;
        private List<AwsS3BucketWebsiteConfigurationRoutingRule> _routingRules = new List<AwsS3BucketWebsiteConfigurationRoutingRule>();

        /// <summary>
        /// Gets and sets the property ErrorDocument. 
        /// <para>
        /// The name of the error document for the website.
        /// </para>
        /// </summary>
        public string ErrorDocument
        {
            get { return this._errorDocument; }
            set { this._errorDocument = value; }
        }

        // Check to see if ErrorDocument property is set
        internal bool IsSetErrorDocument()
        {
            return this._errorDocument != null;
        }

        /// <summary>
        /// Gets and sets the property IndexDocumentSuffix. 
        /// <para>
        /// The name of the index document for the website.
        /// </para>
        /// </summary>
        public string IndexDocumentSuffix
        {
            get { return this._indexDocumentSuffix; }
            set { this._indexDocumentSuffix = value; }
        }

        // Check to see if IndexDocumentSuffix property is set
        internal bool IsSetIndexDocumentSuffix()
        {
            return this._indexDocumentSuffix != null;
        }

        /// <summary>
        /// Gets and sets the property RedirectAllRequestsTo. 
        /// <para>
        /// The redirect behavior for requests to the website.
        /// </para>
        /// </summary>
        public AwsS3BucketWebsiteConfigurationRedirectTo RedirectAllRequestsTo
        {
            get { return this._redirectAllRequestsTo; }
            set { this._redirectAllRequestsTo = value; }
        }

        // Check to see if RedirectAllRequestsTo property is set
        internal bool IsSetRedirectAllRequestsTo()
        {
            return this._redirectAllRequestsTo != null;
        }

        /// <summary>
        /// Gets and sets the property RoutingRules. 
        /// <para>
        /// The rules for applying redirects for requests to the website.
        /// </para>
        /// </summary>
        public List<AwsS3BucketWebsiteConfigurationRoutingRule> RoutingRules
        {
            get { return this._routingRules; }
            set { this._routingRules = value; }
        }

        // Check to see if RoutingRules property is set
        internal bool IsSetRoutingRules()
        {
            return this._routingRules != null && this._routingRules.Count > 0; 
        }

    }
}