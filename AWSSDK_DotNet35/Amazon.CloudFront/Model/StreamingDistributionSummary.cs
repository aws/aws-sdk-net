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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// <para> A summary of the information for an Amazon CloudFront streaming distribution. </para>
    /// </summary>
    public class StreamingDistributionSummary
    {
        
        private string id;
        private string status;
        private DateTime? lastModifiedTime;
        private string domainName;
        private S3Origin s3Origin;
        private Aliases aliases;
        private TrustedSigners trustedSigners;
        private string comment;
        private PriceClass priceClass;
        private bool? enabled;

        /// <summary>
        /// The identifier for the distribution. For example: EDFDVBD632BHDS5.
        ///  
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this.id != null;
        }

        /// <summary>
        /// Indicates the current status of the distribution. When the status is Deployed, the distribution's information is fully propagated throughout
        /// the Amazon CloudFront system.
        ///  
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// The date and time the distribution was last modified.
        ///  
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this.lastModifiedTime ?? default(DateTime); }
            set { this.lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this.lastModifiedTime.HasValue;
        }

        /// <summary>
        /// The domain name corresponding to the distribution. For example: d604721fxaaqy9.cloudfront.net.
        ///  
        /// </summary>
        public string DomainName
        {
            get { return this.domainName; }
            set { this.domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this.domainName != null;
        }

        /// <summary>
        /// A complex type that contains information about the Amazon S3 bucket from which you want CloudFront to get your media files for distribution.
        ///  
        /// </summary>
        public S3Origin S3Origin
        {
            get { return this.s3Origin; }
            set { this.s3Origin = value; }
        }

        // Check to see if S3Origin property is set
        internal bool IsSetS3Origin()
        {
            return this.s3Origin != null;
        }

        /// <summary>
        /// A complex type that contains information about CNAMEs (alternate domain names), if any, for this streaming distribution.
        ///  
        /// </summary>
        public Aliases Aliases
        {
            get { return this.aliases; }
            set { this.aliases = value; }
        }

        // Check to see if Aliases property is set
        internal bool IsSetAliases()
        {
            return this.aliases != null;
        }

        /// <summary>
        /// A complex type that specifies the AWS accounts, if any, that you want to allow to create signed URLs for private content. If you want to
        /// require signed URLs in requests for objects in the target origin that match the PathPattern for this cache behavior, specify true for
        /// Enabled, and specify the applicable values for Quantity and Items. For more information, go to Using a Signed URL to Serve Private Content
        /// in the Amazon CloudFront Developer Guide. If you don't want to require signed URLs in requests for objects that match PathPattern, specify
        /// false for Enabled and 0 for Quantity. Omit Items. To add, change, or remove one or more trusted signers, change Enabled to true (if it's
        /// currently false), change Quantity as applicable, and specify all of the trusted signers that you want to include in the updated
        /// distribution.
        ///  
        /// </summary>
        public TrustedSigners TrustedSigners
        {
            get { return this.trustedSigners; }
            set { this.trustedSigners = value; }
        }

        // Check to see if TrustedSigners property is set
        internal bool IsSetTrustedSigners()
        {
            return this.trustedSigners != null;
        }

        /// <summary>
        /// The comment originally specified when this distribution was created.
        ///  
        /// </summary>
        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this.comment != null;
        }
        public PriceClass PriceClass
        {
            get { return this.priceClass; }
            set { this.priceClass = value; }
        }

        // Check to see if PriceClass property is set
        internal bool IsSetPriceClass()
        {
            return this.priceClass != null;
        }

        /// <summary>
        /// Whether the distribution is enabled to accept end user requests for content.
        ///  
        /// </summary>
        public bool Enabled
        {
            get { return this.enabled ?? default(bool); }
            set { this.enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this.enabled.HasValue;
        }
    }
}
