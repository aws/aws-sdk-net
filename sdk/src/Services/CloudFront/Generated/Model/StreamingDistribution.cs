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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A streaming distribution tells CloudFront where you want RTMP content to be delivered
    /// from, and the details about how to track and manage content delivery.
    /// </summary>
    public partial class StreamingDistribution
    {
        private ActiveTrustedSigners _activeTrustedSigners;
        private string _arn;
        private string _domainName;
        private string _id;
        private DateTime? _lastModifiedTime;
        private string _status;
        private StreamingDistributionConfig _streamingDistributionConfig;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public StreamingDistribution() { }

        /// <summary>
        /// Gets and sets the property ActiveTrustedSigners. 
        /// <para>
        /// A complex type that lists the Amazon Web Services accounts, if any, that you included
        /// in the <code>TrustedSigners</code> complex type for this distribution. These are the
        /// accounts that you want to allow to create signed URLs for private content.
        /// </para>
        ///  
        /// <para>
        /// The <code>Signer</code> complex type lists the Amazon Web Services account number
        /// of the trusted signer or <code>self</code> if the signer is the Amazon Web Services
        /// account that created the distribution. The <code>Signer</code> element also includes
        /// the IDs of any active CloudFront key pairs that are associated with the trusted signer's
        /// Amazon Web Services account. If no <code>KeyPairId</code> element appears for a <code>Signer</code>,
        /// that signer can't create signed URLs.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/PrivateContent.html">Serving
        /// Private Content through CloudFront</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActiveTrustedSigners ActiveTrustedSigners
        {
            get { return this._activeTrustedSigners; }
            set { this._activeTrustedSigners = value; }
        }

        // Check to see if ActiveTrustedSigners property is set
        internal bool IsSetActiveTrustedSigners()
        {
            return this._activeTrustedSigners != null;
        }

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The ARN (Amazon Resource Name) for the distribution. For example: <code>arn:aws:cloudfront::123456789012:distribution/EDFDVBD632BHDS5</code>,
        /// where <code>123456789012</code> is your Amazon Web Services account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name that corresponds to the streaming distribution, for example, <code>s5c39gqb8ow64r.cloudfront.net</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier for the RTMP distribution. For example: <code>EGTXBD79EXAMPLE</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time that the distribution was last modified.
        /// </para>
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the RTMP distribution. When the status is <code>Deployed</code>,
        /// the distribution's information is propagated to all CloudFront edge locations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StreamingDistributionConfig. 
        /// <para>
        /// The current configuration information for the RTMP distribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StreamingDistributionConfig StreamingDistributionConfig
        {
            get { return this._streamingDistributionConfig; }
            set { this._streamingDistributionConfig = value; }
        }

        // Check to see if StreamingDistributionConfig property is set
        internal bool IsSetStreamingDistributionConfig()
        {
            return this._streamingDistributionConfig != null;
        }

    }
}