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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// The RTMP distribution's configuration information.
    /// </summary>
    public partial class StreamingDistributionConfig
    {
        /// <summary>
        /// Gets and sets the property Aliases. 
        /// <para>
        /// A complex type that contains information about CNAMEs (alternate domain names), if
        /// any, for this streaming distribution.
        /// </para>
        /// </summary>
        public Aliases Aliases { get; set; }

        /// <summary>
        /// Checks to see if the Aliases property is set.
        /// </summary>
        internal bool IsSetAliases() => this.Aliases != null;

        /// <summary>
        /// Gets and sets the property CallerReference. 
        /// <para>
        /// A unique value (for example, a date-time stamp) that ensures that the request can't
        /// be replayed.
        /// </para>
        ///  
        /// <para>
        /// If the value of <c>CallerReference</c> is new (regardless of the content of the <c>StreamingDistributionConfig</c>
        /// object), CloudFront creates a new distribution.
        /// </para>
        ///  
        /// <para>
        /// If <c>CallerReference</c> is a value that you already sent in a previous request to
        /// create a distribution, CloudFront returns a <c>DistributionAlreadyExists</c> error.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CallerReference { get; set; }

        /// <summary>
        /// Checks to see if the CallerReference property is set.
        /// </summary>
        internal bool IsSetCallerReference() => this.CallerReference != null;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// Any comments you want to include about the streaming distribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether the streaming distribution is enabled to accept user requests for content.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property Logging. 
        /// <para>
        /// A complex type that controls whether access logs are written for the streaming distribution.
        /// </para>
        /// </summary>
        public StreamingLoggingConfig Logging { get; set; }

        /// <summary>
        /// Checks to see if the Logging property is set.
        /// </summary>
        internal bool IsSetLogging() => this.Logging != null;

        /// <summary>
        /// Gets and sets the property PriceClass. 
        /// <para>
        /// A complex type that contains information about price class for this streaming distribution.
        /// </para>
        /// </summary>
        public PriceClass PriceClass { get; set; }

        /// <summary>
        /// Checks to see if the PriceClass property is set.
        /// </summary>
        internal bool IsSetPriceClass() => this.PriceClass != null;

        /// <summary>
        /// Gets and sets the property S3Origin. 
        /// <para>
        /// A complex type that contains information about the Amazon S3 bucket from which you
        /// want CloudFront to get your media files for distribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public S3Origin S3Origin { get; set; }

        /// <summary>
        /// Checks to see if the S3Origin property is set.
        /// </summary>
        internal bool IsSetS3Origin() => this.S3Origin != null;

        /// <summary>
        /// Gets and sets the property TrustedSigners. 
        /// <para>
        /// A complex type that specifies any Amazon Web Services accounts that you want to permit
        /// to create signed URLs for private content. If you want the distribution to use signed
        /// URLs, include this element; if you want the distribution to use public URLs, remove
        /// this element. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/PrivateContent.html">Serving
        /// Private Content through CloudFront</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TrustedSigners TrustedSigners { get; set; }

        /// <summary>
        /// Checks to see if the TrustedSigners property is set.
        /// </summary>
        internal bool IsSetTrustedSigners() => this.TrustedSigners != null;
    }
}
