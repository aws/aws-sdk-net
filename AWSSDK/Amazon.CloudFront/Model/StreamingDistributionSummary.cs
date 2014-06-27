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
    /// A summary of the information for an Amazon CloudFront streaming distribution.
    /// </summary>
    public partial class StreamingDistributionSummary
    {
        private Aliases _aliases;
        private string _comment;
        private string _domainName;
        private bool? _enabled;
        private string _id;
        private DateTime? _lastModifiedTime;
        private string _priceClass;
        private S3Origin _s3Origin;
        private string _status;
        private TrustedSigners _trustedSigners;


        /// <summary>
        /// Gets and sets the property Aliases. A complex type that contains information about
        /// CNAMEs (alternate domain names), if any, for this streaming distribution.
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
        public StreamingDistributionSummary WithAliases(Aliases aliases)
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
        public StreamingDistributionSummary WithComment(string comment)
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
        public StreamingDistributionSummary WithDomainName(string domainName)
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
        public StreamingDistributionSummary WithEnabled(bool enabled)
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
        public StreamingDistributionSummary WithId(string id)
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
        public StreamingDistributionSummary WithLastModifiedTime(DateTime lastModifiedTime)
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
        public StreamingDistributionSummary WithPriceClass(string priceClass)
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
        /// Gets and sets the property S3Origin. A complex type that contains information about
        /// the Amazon S3    bucket from which you want CloudFront to get your media files for
        ///    distribution.
        /// </summary>
        public S3Origin S3Origin
        {
            get { return this._s3Origin; }
            set { this._s3Origin = value; }
        }


        /// <summary>
        /// Sets the S3Origin property
        /// </summary>
        /// <param name="s3Origin">The value to set for the S3Origin property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StreamingDistributionSummary WithS3Origin(S3Origin s3Origin)
        {
            this._s3Origin = s3Origin;
            return this;
        }

        // Check to see if S3Origin property is set
        internal bool IsSetS3Origin()
        {
            return this._s3Origin != null;
        }


        /// <summary>
        /// Gets and sets the property Status. Indicates the current status of the distribution.
        ///    When the status is Deployed, the distribution's information is fully propagated
        /// throughout the Amazon CloudFront system.
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
        public StreamingDistributionSummary WithStatus(string status)
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
        /// Gets and sets the property TrustedSigners. A complex type that specifies the AWS accounts,
        /// if any, that you want    to allow to create signed URLs for private content.    If
        /// you want to require signed URLs in requests for objects in the target    origin that
        /// match the PathPattern for this cache behavior, specify true    for Enabled, and specify
        /// the applicable values for Quantity and Items.    For more information, go to Using
        /// a Signed URL to Serve Private Content    in the Amazon CloudFront Developer Guide.
        ///    If you don't want to require signed URLs in requests for objects that match   
        /// PathPattern, specify false for Enabled and 0 for Quantity. Omit    Items.    To add,
        /// change, or remove one or more trusted signers, change Enabled    to true (if it's
        /// currently false), change Quantity as applicable, and    specify all of the trusted
        /// signers that you want to include in the updated    distribution.
        /// </summary>
        public TrustedSigners TrustedSigners
        {
            get { return this._trustedSigners; }
            set { this._trustedSigners = value; }
        }


        /// <summary>
        /// Sets the TrustedSigners property
        /// </summary>
        /// <param name="trustedSigners">The value to set for the TrustedSigners property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StreamingDistributionSummary WithTrustedSigners(TrustedSigners trustedSigners)
        {
            this._trustedSigners = trustedSigners;
            return this;
        }

        // Check to see if TrustedSigners property is set
        internal bool IsSetTrustedSigners()
        {
            return this._trustedSigners != null;
        }

    }
}