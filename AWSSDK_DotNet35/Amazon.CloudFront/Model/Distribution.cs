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
    /// <para> A distribution. </para>
    /// </summary>
    public class Distribution
    {
        
        private string id;
        private string status;
        private DateTime? lastModifiedTime;
        private int? inProgressInvalidationBatches;
        private string domainName;
        private ActiveTrustedSigners activeTrustedSigners;
        private DistributionConfig distributionConfig;


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
        /// This response element indicates the current status of the distribution. When the status is Deployed, the distribution's information is fully
        /// propagated throughout the Amazon CloudFront system.
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
        /// The number of invalidation batches currently in progress.
        ///  
        /// </summary>
        public int InProgressInvalidationBatches
        {
            get { return this.inProgressInvalidationBatches ?? default(int); }
            set { this.inProgressInvalidationBatches = value; }
        }

        // Check to see if InProgressInvalidationBatches property is set
        internal bool IsSetInProgressInvalidationBatches()
        {
            return this.inProgressInvalidationBatches.HasValue;
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
        /// CloudFront automatically adds this element to the response only if you've set up the distribution to serve private content with signed URLs.
        /// The element lists the key pair IDs that CloudFront is aware of for each trusted signer. The Signer child element lists the AWS account
        /// number of the trusted signer (or an empty Self element if the signer is you). The Signer element also includes the IDs of any active key
        /// pairs associated with the trusted signer's AWS account. If no KeyPairId element appears for a Signer, that signer can't create working
        /// signed URLs.
        ///  
        /// </summary>
        public ActiveTrustedSigners ActiveTrustedSigners
        {
            get { return this.activeTrustedSigners; }
            set { this.activeTrustedSigners = value; }
        }

        // Check to see if ActiveTrustedSigners property is set
        internal bool IsSetActiveTrustedSigners()
        {
            return this.activeTrustedSigners != null;
        }

        /// <summary>
        /// The current configuration information for the distribution.
        ///  
        /// </summary>
        public DistributionConfig DistributionConfig
        {
            get { return this.distributionConfig; }
            set { this.distributionConfig = value; }
        }

        // Check to see if DistributionConfig property is set
        internal bool IsSetDistributionConfig()
        {
            return this.distributionConfig != null;
        }
    }
}
