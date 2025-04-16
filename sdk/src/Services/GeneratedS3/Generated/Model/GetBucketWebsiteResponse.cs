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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.S3.Model
{
    /// <summary>
    /// This is the response object from the GetBucketWebsite operation.
    /// </summary>
    public partial class GetBucketWebsiteResponse : AmazonWebServiceResponse
    {
        private ErrorDocument _errorDocument;
        private IndexDocument _indexDocument;
        private RedirectAllRequestsTo _redirectAllRequestsTo;
        private List<RoutingRule> _routingRules = AWSConfigs.InitializeCollections ? new List<RoutingRule>() : null;

        /// <summary>
        /// Gets and sets the property ErrorDocument. 
        /// <para>
        /// The object key name of the website error document to use for 4XX class errors.
        /// </para>
        /// </summary>
        public ErrorDocument ErrorDocument
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
        /// Gets and sets the property IndexDocument. 
        /// <para>
        /// The name of the index document for the website (for example <c>index.html</c>).
        /// </para>
        /// </summary>
        public IndexDocument IndexDocument
        {
            get { return this._indexDocument; }
            set { this._indexDocument = value; }
        }

        // Check to see if IndexDocument property is set
        internal bool IsSetIndexDocument()
        {
            return this._indexDocument != null;
        }

        /// <summary>
        /// Gets and sets the property RedirectAllRequestsTo. 
        /// <para>
        /// Specifies the redirect behavior of all requests to a website endpoint of an Amazon
        /// S3 bucket.
        /// </para>
        /// </summary>
        public RedirectAllRequestsTo RedirectAllRequestsTo
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
        /// Rules that define when a redirect is applied and the redirect behavior.
        /// </para>
        /// </summary>
        public List<RoutingRule> RoutingRules
        {
            get { return this._routingRules; }
            set { this._routingRules = value; }
        }

        // Check to see if RoutingRules property is set
        internal bool IsSetRoutingRules()
        {
            return this._routingRules != null && (this._routingRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}