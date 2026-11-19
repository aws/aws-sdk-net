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
    /// A streaming distribution tells CloudFront where you want RTMP content to be delivered
    /// from, and the details about how to track and manage content delivery.
    /// </summary>
    public partial class StreamingDistribution
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public StreamingDistribution() { }

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The ARN (Amazon Resource Name) for the distribution. For example: <c>arn:aws:cloudfront::123456789012:distribution/EDFDVBD632BHDS5</c>,
        /// where <c>123456789012</c> is your Amazon Web Services account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ARN { get; set; }

        /// <summary>
        /// Checks to see if the ARN property is set.
        /// </summary>
        internal bool IsSetARN() => this.ARN != null;

        /// <summary>
        /// Gets and sets the property ActiveTrustedSigners. 
        /// <para>
        /// A complex type that lists the Amazon Web Services accounts, if any, that you included
        /// in the <c>TrustedSigners</c> complex type for this distribution. These are the accounts
        /// that you want to allow to create signed URLs for private content.
        /// </para>
        ///  
        /// <para>
        /// The <c>Signer</c> complex type lists the Amazon Web Services account number of the
        /// trusted signer or <c>self</c> if the signer is the Amazon Web Services account that
        /// created the distribution. The <c>Signer</c> element also includes the IDs of any active
        /// CloudFront key pairs that are associated with the trusted signer's Amazon Web Services
        /// account. If no <c>KeyPairId</c> element appears for a <c>Signer</c>, that signer can't
        /// create signed URLs.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/PrivateContent.html">Serving
        /// Private Content through CloudFront</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActiveTrustedSigners ActiveTrustedSigners { get; set; }

        /// <summary>
        /// Checks to see if the ActiveTrustedSigners property is set.
        /// </summary>
        internal bool IsSetActiveTrustedSigners() => this.ActiveTrustedSigners != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name that corresponds to the streaming distribution, for example, <c>s5c39gqb8ow64r.cloudfront.net</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier for the RTMP distribution. For example: <c>EGTXBD79EXAMPLE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time that the distribution was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the RTMP distribution. When the status is <c>Deployed</c>, the
        /// distribution's information is propagated to all CloudFront edge locations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StreamingDistributionConfig. 
        /// <para>
        /// The current configuration information for the RTMP distribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StreamingDistributionConfig StreamingDistributionConfig { get; set; }

        /// <summary>
        /// Checks to see if the StreamingDistributionConfig property is set.
        /// </summary>
        internal bool IsSetStreamingDistributionConfig() => this.StreamingDistributionConfig != null;
    }
}
