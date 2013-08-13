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
        private string comment;
        private string priceClass;
        private bool? enabled;
        private ViewerCertificate viewerCertificate;

        /// <summary>
        /// The identifier for the distribution. For example: EDFDVBD632BHDS5.
        ///  
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// Sets the Id property
        /// </summary>
        /// <param name="id">The value to set for the Id property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionSummary WithId(string id)
        {
            this.id = id;
            return this;
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

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionSummary WithStatus(string status)
        {
            this.status = status;
            return this;
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

        /// <summary>
        /// Sets the LastModifiedTime property
        /// </summary>
        /// <param name="lastModifiedTime">The value to set for the LastModifiedTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionSummary WithLastModifiedTime(DateTime lastModifiedTime)
        {
            this.lastModifiedTime = lastModifiedTime;
            return this;
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

        /// <summary>
        /// Sets the DomainName property
        /// </summary>
        /// <param name="domainName">The value to set for the DomainName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionSummary WithDomainName(string domainName)
        {
            this.domainName = domainName;
            return this;
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

        /// <summary>
        /// Sets the Aliases property
        /// </summary>
        /// <param name="aliases">The value to set for the Aliases property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionSummary WithAliases(Aliases aliases)
        {
            this.aliases = aliases;
            return this;
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

        /// <summary>
        /// Sets the Origins property
        /// </summary>
        /// <param name="origins">The value to set for the Origins property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionSummary WithOrigins(Origins origins)
        {
            this.origins = origins;
            return this;
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

        /// <summary>
        /// Sets the DefaultCacheBehavior property
        /// </summary>
        /// <param name="defaultCacheBehavior">The value to set for the DefaultCacheBehavior property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionSummary WithDefaultCacheBehavior(DefaultCacheBehavior defaultCacheBehavior)
        {
            this.defaultCacheBehavior = defaultCacheBehavior;
            return this;
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

        /// <summary>
        /// Sets the CacheBehaviors property
        /// </summary>
        /// <param name="cacheBehaviors">The value to set for the CacheBehaviors property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionSummary WithCacheBehaviors(CacheBehaviors cacheBehaviors)
        {
            this.cacheBehaviors = cacheBehaviors;
            return this;
        }
            

        // Check to see if CacheBehaviors property is set
        internal bool IsSetCacheBehaviors()
        {
            return this.cacheBehaviors != null;
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

        /// <summary>
        /// Sets the Comment property
        /// </summary>
        /// <param name="comment">The value to set for the Comment property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionSummary WithComment(string comment)
        {
            this.comment = comment;
            return this;
        }
            

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this.comment != null;
        }
        public string PriceClass
        {
            get { return this.priceClass; }
            set { this.priceClass = value; }
        }

        /// <summary>
        /// Sets the PriceClass property
        /// </summary>
        /// <param name="priceClass">The value to set for the PriceClass property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionSummary WithPriceClass(string priceClass)
        {
            this.priceClass = priceClass;
            return this;
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

        /// <summary>
        /// Sets the Enabled property
        /// </summary>
        /// <param name="enabled">The value to set for the Enabled property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionSummary WithEnabled(bool enabled)
        {
            this.enabled = enabled;
            return this;
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

        /// <summary>
        /// Sets the ViewerCertificate property
        /// </summary>
        /// <param name="viewerCertificate">The value to set for the ViewerCertificate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionSummary WithViewerCertificate(ViewerCertificate viewerCertificate)
        {
            this.viewerCertificate = viewerCertificate;
            return this;
        }
            

        // Check to see if ViewerCertificate property is set
        internal bool IsSetViewerCertificate()
        {
            return this.viewerCertificate != null;
        }
    }
}
