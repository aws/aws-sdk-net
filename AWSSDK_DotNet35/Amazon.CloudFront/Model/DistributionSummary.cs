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
    /// <para> A summary of the information for an Amazon CloudFront distribution. </para>
    /// </summary>
    public class DistributionSummary
    {
        
        private string id;
        private string status;
        private DateTime? lastModifiedTime;
        private string domainName;
        private Aliases aliases;
        private Origins origins;
        private DefaultCacheBehavior defaultCacheBehavior;
        private CacheBehaviors cacheBehaviors;
        private CustomErrorResponses customErrorResponses;
        private string comment;
        private PriceClass priceClass;
        private bool? enabled;
        private ViewerCertificate viewerCertificate;
        private Restrictions restrictions;


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
        /// A complex type that contains information about CNAMEs (alternate domain names), if any, for this distribution.
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
        /// A complex type that contains information about origins for this distribution.
        ///  
        /// </summary>
        public Origins Origins
        {
            get { return this.origins; }
            set { this.origins = value; }
        }

        // Check to see if Origins property is set
        internal bool IsSetOrigins()
        {
            return this.origins != null;
        }

        /// <summary>
        /// A complex type that describes the default cache behavior if you do not specify a CacheBehavior element or if files don't match any of the
        /// values of PathPattern in CacheBehavior elements.You must create exactly one default cache behavior.
        ///  
        /// </summary>
        public DefaultCacheBehavior DefaultCacheBehavior
        {
            get { return this.defaultCacheBehavior; }
            set { this.defaultCacheBehavior = value; }
        }

        // Check to see if DefaultCacheBehavior property is set
        internal bool IsSetDefaultCacheBehavior()
        {
            return this.defaultCacheBehavior != null;
        }

        /// <summary>
        /// A complex type that contains zero or more CacheBehavior elements.
        ///  
        /// </summary>
        public CacheBehaviors CacheBehaviors
        {
            get { return this.cacheBehaviors; }
            set { this.cacheBehaviors = value; }
        }

        // Check to see if CacheBehaviors property is set
        internal bool IsSetCacheBehaviors()
        {
            return this.cacheBehaviors != null;
        }

        /// <summary>
        /// A complex type that contains zero or more CustomErrorResponses elements.
        ///  
        /// </summary>
        public CustomErrorResponses CustomErrorResponses
        {
            get { return this.customErrorResponses; }
            set { this.customErrorResponses = value; }
        }

        // Check to see if CustomErrorResponses property is set
        internal bool IsSetCustomErrorResponses()
        {
            return this.customErrorResponses != null;
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

        /// <summary>
        /// A complex type that contains information about viewer certificates for this distribution.
        ///  
        /// </summary>
        public ViewerCertificate ViewerCertificate
        {
            get { return this.viewerCertificate; }
            set { this.viewerCertificate = value; }
        }

        // Check to see if ViewerCertificate property is set
        internal bool IsSetViewerCertificate()
        {
            return this.viewerCertificate != null;
        }

        /// <summary>
        /// A complex type that identifies ways in which you want to restrict distribution of your content.
        ///  
        /// </summary>
        public Restrictions Restrictions
        {
            get { return this.restrictions; }
            set { this.restrictions = value; }
        }

        // Check to see if Restrictions property is set
        internal bool IsSetRestrictions()
        {
            return this.restrictions != null;
        }
    }
}
