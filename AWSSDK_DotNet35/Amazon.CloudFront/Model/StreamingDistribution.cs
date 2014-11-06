/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cloudfront-2014-10-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A streaming distribution.
    /// </summary>
    public partial class StreamingDistribution
    {
        private ActiveTrustedSigners _activeTrustedSigners;
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
        /// Gets and sets the property ActiveTrustedSigners. CloudFront automatically adds this
        /// element to the response only if you've set up the distribution to serve private content
        /// with signed URLs. The element lists the key pair IDs that CloudFront is aware of for
        /// each trusted signer. The Signer child element lists the AWS account number of the
        /// trusted signer (or an empty Self element if the signer is you). The Signer element
        /// also includes the IDs of any active key pairs associated with the trusted signer's
        /// AWS account. If no KeyPairId element appears for a Signer, that signer can't create
        /// working signed URLs.
        /// </summary>
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
        /// Gets and sets the property DomainName. The domain name corresponding to the streaming
        /// distribution. For example: s5c39gqb8ow64r.cloudfront.net.
        /// </summary>
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
        /// Gets and sets the property Id. The identifier for the streaming distribution. For
        /// example: EGTXBD79H29TRA8.
        /// </summary>
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
        /// Gets and sets the property LastModifiedTime. The date and time the distribution was
        /// last modified.
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
        /// Gets and sets the property Status. The current status of the streaming distribution.
        /// When the status is Deployed, the distribution's information is fully propagated throughout
        /// the Amazon CloudFront system.
        /// </summary>
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
        /// Gets and sets the property StreamingDistributionConfig. The current configuration
        /// information for the streaming distribution.
        /// </summary>
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