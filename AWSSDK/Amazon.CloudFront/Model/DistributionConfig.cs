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
    /// A distribution Configuration.
    /// </summary>
    public partial class DistributionConfig
    {
        private Aliases _aliases;
        private CacheBehaviors _cacheBehaviors;
        private string _callerReference;
        private string _comment;
        private CustomErrorResponses _customErrorResponses;
        private DefaultCacheBehavior _defaultCacheBehavior;
        private string _defaultRootObject;
        private bool? _enabled;
        private LoggingConfig _logging;
        private Origins _origins;
        private string _priceClass;
        private Restrictions _restrictions;
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
        public DistributionConfig WithAliases(Aliases aliases)
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
        public DistributionConfig WithCacheBehaviors(CacheBehaviors cacheBehaviors)
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
        /// Gets and sets the property CallerReference. A unique number that ensures the request
        /// can't be replayed.    If the CallerReference is new (no matter the content of the
        /// DistributionConfig object), a new distribution is created.    If the CallerReference
        /// is a value you already sent in a previous request to create a distribution, and the
        /// content of the DistributionConfig is identical to the original request (ignoring white
        /// space),    the response includes the same information returned to the original request.
        ///    If the CallerReference is a value you already sent in a previous request to create
        /// a distribution but the content of the DistributionConfig is different from the original
        /// request,    CloudFront returns a DistributionAlreadyExists error.
        /// </summary>
        public string CallerReference
        {
            get { return this._callerReference; }
            set { this._callerReference = value; }
        }


        /// <summary>
        /// Sets the CallerReference property
        /// </summary>
        /// <param name="callerReference">The value to set for the CallerReference property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionConfig WithCallerReference(string callerReference)
        {
            this._callerReference = callerReference;
            return this;
        }

        // Check to see if CallerReference property is set
        internal bool IsSetCallerReference()
        {
            return this._callerReference != null;
        }


        /// <summary>
        /// Gets and sets the property Comment. Any comments you want to include about the distribution.
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
        public DistributionConfig WithComment(string comment)
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
        /// or more CustomErrorResponse elements.
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
        public DistributionConfig WithCustomErrorResponses(CustomErrorResponses customErrorResponses)
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
        public DistributionConfig WithDefaultCacheBehavior(DefaultCacheBehavior defaultCacheBehavior)
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
        /// Gets and sets the property DefaultRootObject. The object that you want CloudFront
        /// to return (for example, index.html)    when an end user requests the root URL for
        /// your distribution    (http://www.example.com) instead of an object in your distribution
        ///    (http://www.example.com/index.html). Specifying a default root    object avoids
        /// exposing the contents of your distribution.    If you don't want to specify a default
        /// root object when you create a    distribution, include an empty DefaultRootObject
        /// element.    To delete the default root object from an existing distribution, update
        /// the    distribution configuration and include an empty DefaultRootObject    element.
        /// To replace the default root object, update the distribution configuration    and specify
        /// the new object.
        /// </summary>
        public string DefaultRootObject
        {
            get { return this._defaultRootObject; }
            set { this._defaultRootObject = value; }
        }


        /// <summary>
        /// Sets the DefaultRootObject property
        /// </summary>
        /// <param name="defaultRootObject">The value to set for the DefaultRootObject property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionConfig WithDefaultRootObject(string defaultRootObject)
        {
            this._defaultRootObject = defaultRootObject;
            return this;
        }

        // Check to see if DefaultRootObject property is set
        internal bool IsSetDefaultRootObject()
        {
            return this._defaultRootObject != null;
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
        public DistributionConfig WithEnabled(bool enabled)
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
        /// Gets and sets the property Logging. A complex type that controls whether access logs
        /// are written for the distribution.
        /// </summary>
        public LoggingConfig Logging
        {
            get { return this._logging; }
            set { this._logging = value; }
        }


        /// <summary>
        /// Sets the Logging property
        /// </summary>
        /// <param name="logging">The value to set for the Logging property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionConfig WithLogging(LoggingConfig logging)
        {
            this._logging = logging;
            return this;
        }

        // Check to see if Logging property is set
        internal bool IsSetLogging()
        {
            return this._logging != null;
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
        public DistributionConfig WithOrigins(Origins origins)
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
        /// Gets and sets the property PriceClass. A complex type that contains information about
        /// price class for this distribution.
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
        public DistributionConfig WithPriceClass(string priceClass)
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
        public DistributionConfig WithRestrictions(Restrictions restrictions)
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
        public DistributionConfig WithViewerCertificate(ViewerCertificate viewerCertificate)
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