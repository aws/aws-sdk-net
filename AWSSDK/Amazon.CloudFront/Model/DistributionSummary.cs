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
    /// A summary of the information for an Amazon CloudFront distribution.
    /// </summary>
    public partial class DistributionSummary
    {
        private Aliases _aliases;
        private CacheBehaviors _cacheBehaviors;
        private string _comment;
        private CustomErrorResponses _customErrorResponses;
        private DefaultCacheBehavior _defaultCacheBehavior;
        private string _domainName;
        private bool? _enabled;
        private string _id;
        private DateTime? _lastModifiedTime;
        private Origins _origins;
        private string _priceClass;
        private Restrictions _restrictions;
        private string _status;
        private ViewerCertificate _viewerCertificate;


        /// <summary>
        /// Gets and sets the property Aliases. A complex type that contains information about
        /// CNAMEs (alternate domain names), if any, for this distribution.
        /// </summary>
        public Aliases Aliases
        {
            get { return this._aliases; }
            set { this._aliases = value; }
        }


        /// <summary>
        /// Sets the Aliases property
        /// </summary>
        /// <param name="aliases">The value to set for the Aliases property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionSummary WithAliases(Aliases aliases)
        {
            this._aliases = aliases;
            return this;
        }

        // Check to see if Aliases property is set
        internal bool IsSetAliases()
        {
            return this._aliases != null;
        }


        /// <summary>
        /// Gets and sets the property CacheBehaviors. A complex type that contains zero or more
        /// CacheBehavior elements.
        /// </summary>
        public CacheBehaviors CacheBehaviors
        {
            get { return this._cacheBehaviors; }
            set { this._cacheBehaviors = value; }
        }


        /// <summary>
        /// Sets the CacheBehaviors property
        /// </summary>
        /// <param name="cacheBehaviors">The value to set for the CacheBehaviors property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionSummary WithCacheBehaviors(CacheBehaviors cacheBehaviors)
        {
            this._cacheBehaviors = cacheBehaviors;
            return this;
        }

        // Check to see if CacheBehaviors property is set
        internal bool IsSetCacheBehaviors()
        {
            return this._cacheBehaviors != null;
        }


        /// <summary>
        /// Gets and sets the property Comment. The comment originally specified when this distribution
        /// was created.
        /// </summary>
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }


        /// <summary>
        /// Sets the Comment property
        /// </summary>
        /// <param name="comment">The value to set for the Comment property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionSummary WithComment(string comment)
        {
            this._comment = comment;
            return this;
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }


        /// <summary>
        /// Gets and sets the property CustomErrorResponses. A complex type that contains zero
        /// or more CustomErrorResponses elements.
        /// </summary>
        public CustomErrorResponses CustomErrorResponses
        {
            get { return this._customErrorResponses; }
            set { this._customErrorResponses = value; }
        }


        /// <summary>
        /// Sets the CustomErrorResponses property
        /// </summary>
        /// <param name="customErrorResponses">The value to set for the CustomErrorResponses property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionSummary WithCustomErrorResponses(CustomErrorResponses customErrorResponses)
        {
            this._customErrorResponses = customErrorResponses;
            return this;
        }

        // Check to see if CustomErrorResponses property is set
        internal bool IsSetCustomErrorResponses()
        {
            return this._customErrorResponses != null;
        }


        /// <summary>
        /// Gets and sets the property DefaultCacheBehavior. A complex type that describes the
        /// default cache behavior if you do not    specify a CacheBehavior element or if files
        /// don't match any of the values    of PathPattern in CacheBehavior elements.You must
        /// create exactly    one default cache behavior.
        /// </summary>
        public DefaultCacheBehavior DefaultCacheBehavior
        {
            get { return this._defaultCacheBehavior; }
            set { this._defaultCacheBehavior = value; }
        }


        /// <summary>
        /// Sets the DefaultCacheBehavior property
        /// </summary>
        /// <param name="defaultCacheBehavior">The value to set for the DefaultCacheBehavior property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionSummary WithDefaultCacheBehavior(DefaultCacheBehavior defaultCacheBehavior)
        {
            this._defaultCacheBehavior = defaultCacheBehavior;
            return this;
        }

        // Check to see if DefaultCacheBehavior property is set
        internal bool IsSetDefaultCacheBehavior()
        {
            return this._defaultCacheBehavior != null;
        }


        /// <summary>
        /// Gets and sets the property DomainName. The domain name corresponding to the distribution.
        /// For example: d604721fxaaqy9.cloudfront.net.
        /// </summary>
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }


        /// <summary>
        /// Sets the DomainName property
        /// </summary>
        /// <param name="domainName">The value to set for the DomainName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionSummary WithDomainName(string domainName)
        {
            this._domainName = domainName;
            return this;
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }


        /// <summary>
        /// Gets and sets the property Enabled. Whether the distribution is enabled to accept
        /// end user requests for content.
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }


        /// <summary>
        /// Sets the Enabled property
        /// </summary>
        /// <param name="enabled">The value to set for the Enabled property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionSummary WithEnabled(bool enabled)
        {
            this._enabled = enabled;
            return this;
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Id. The identifier for the distribution. For example: EDFDVBD632BHDS5.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }


        /// <summary>
        /// Sets the Id property
        /// </summary>
        /// <param name="id">The value to set for the Id property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionSummary WithId(string id)
        {
            this._id = id;
            return this;
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


        /// <summary>
        /// Sets the LastModifiedTime property
        /// </summary>
        /// <param name="lastModifiedTime">The value to set for the LastModifiedTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionSummary WithLastModifiedTime(DateTime lastModifiedTime)
        {
            this._lastModifiedTime = lastModifiedTime;
            return this;
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Origins. A complex type that contains information about
        /// origins for this distribution.
        /// </summary>
        public Origins Origins
        {
            get { return this._origins; }
            set { this._origins = value; }
        }


        /// <summary>
        /// Sets the Origins property
        /// </summary>
        /// <param name="origins">The value to set for the Origins property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionSummary WithOrigins(Origins origins)
        {
            this._origins = origins;
            return this;
        }

        // Check to see if Origins property is set
        internal bool IsSetOrigins()
        {
            return this._origins != null;
        }


        /// <summary>
        /// Gets and sets the property PriceClass.
        /// </summary>
        public string PriceClass
        {
            get { return this._priceClass; }
            set { this._priceClass = value; }
        }


        /// <summary>
        /// Sets the PriceClass property
        /// </summary>
        /// <param name="priceClass">The value to set for the PriceClass property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionSummary WithPriceClass(string priceClass)
        {
            this._priceClass = priceClass;
            return this;
        }

        // Check to see if PriceClass property is set
        internal bool IsSetPriceClass()
        {
            return this._priceClass != null;
        }


        /// <summary>
        /// Gets and sets the property Restrictions.
        /// </summary>
        public Restrictions Restrictions
        {
            get { return this._restrictions; }
            set { this._restrictions = value; }
        }


        /// <summary>
        /// Sets the Restrictions property
        /// </summary>
        /// <param name="restrictions">The value to set for the Restrictions property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionSummary WithRestrictions(Restrictions restrictions)
        {
            this._restrictions = restrictions;
            return this;
        }

        // Check to see if Restrictions property is set
        internal bool IsSetRestrictions()
        {
            return this._restrictions != null;
        }


        /// <summary>
        /// Gets and sets the property Status. This response element indicates the current status
        /// of the distribution.    When the status is Deployed, the distribution's information
        /// is fully propagated throughout the Amazon CloudFront system.
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }


        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionSummary WithStatus(string status)
        {
            this._status = status;
            return this;
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }


        /// <summary>
        /// Gets and sets the property ViewerCertificate.
        /// </summary>
        public ViewerCertificate ViewerCertificate
        {
            get { return this._viewerCertificate; }
            set { this._viewerCertificate = value; }
        }


        /// <summary>
        /// Sets the ViewerCertificate property
        /// </summary>
        /// <param name="viewerCertificate">The value to set for the ViewerCertificate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionSummary WithViewerCertificate(ViewerCertificate viewerCertificate)
        {
            this._viewerCertificate = viewerCertificate;
            return this;
        }

        // Check to see if ViewerCertificate property is set
        internal bool IsSetViewerCertificate()
        {
            return this._viewerCertificate != null;
        }

    }
}