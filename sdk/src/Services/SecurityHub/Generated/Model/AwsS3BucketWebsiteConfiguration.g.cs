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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Website parameters for the S3 bucket.
    /// </summary>
    public partial class AwsS3BucketWebsiteConfiguration
    {
        /// <summary>
        /// Gets and sets the property ErrorDocument. 
        /// <para>
        /// The name of the error document for the website.
        /// </para>
        /// </summary>
        public string ErrorDocument { get; set; }

        /// <summary>
        /// Checks to see if the ErrorDocument property is set.
        /// </summary>
        internal bool IsSetErrorDocument() => this.ErrorDocument != null;

        /// <summary>
        /// Gets and sets the property IndexDocumentSuffix. 
        /// <para>
        /// The name of the index document for the website.
        /// </para>
        /// </summary>
        public string IndexDocumentSuffix { get; set; }

        /// <summary>
        /// Checks to see if the IndexDocumentSuffix property is set.
        /// </summary>
        internal bool IsSetIndexDocumentSuffix() => this.IndexDocumentSuffix != null;

        /// <summary>
        /// Gets and sets the property RedirectAllRequestsTo. 
        /// <para>
        /// The redirect behavior for requests to the website.
        /// </para>
        /// </summary>
        public AwsS3BucketWebsiteConfigurationRedirectTo RedirectAllRequestsTo { get; set; }

        /// <summary>
        /// Checks to see if the RedirectAllRequestsTo property is set.
        /// </summary>
        internal bool IsSetRedirectAllRequestsTo() => this.RedirectAllRequestsTo != null;

        /// <summary>
        /// Gets and sets the property RoutingRules. 
        /// <para>
        /// The rules for applying redirects for requests to the website.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsS3BucketWebsiteConfigurationRoutingRule> RoutingRules { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsS3BucketWebsiteConfigurationRoutingRule>() : null;

        /// <summary>
        /// Checks to see if the RoutingRules property is set.
        /// </summary>
        internal bool IsSetRoutingRules() => this.RoutingRules != null && (this.RoutingRules.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
