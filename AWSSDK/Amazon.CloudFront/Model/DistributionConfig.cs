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
    /// <para> A distribution Configuration. </para>
    /// </summary>
    public class DistributionConfig
    {
        
        private string callerReference;
        private Aliases aliases;
        private string defaultRootObject;
        private Origins origins;
        private DefaultCacheBehavior defaultCacheBehavior;
        private CacheBehaviors cacheBehaviors;
        private CustomErrorResponses customErrorResponses;
        private string comment;
        private LoggingConfig logging;
        private string priceClass;
        private bool? enabled;
        private ViewerCertificate viewerCertificate;

        /// <summary>
        /// A unique number that ensures the request can't be replayed. If the CallerReference is new (no matter the content of the DistributionConfig
        /// object), a new distribution is created. If the CallerReference is a value you already sent in a previous request to create a distribution,
        /// and the content of the DistributionConfig is identical to the original request (ignoring white space), the response includes the same
        /// information returned to the original request. If the CallerReference is a value you already sent in a previous request to create a
        /// distribution but the content of the DistributionConfig is different from the original request, CloudFront returns a
        /// DistributionAlreadyExists error.
        ///  
        /// </summary>
        public string CallerReference
        {
            get { return this.callerReference; }
            set { this.callerReference = value; }
        }

        /// <summary>
        /// Sets the CallerReference property
        /// </summary>
        /// <param name="callerReference">The value to set for the CallerReference property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionConfig WithCallerReference(string callerReference)
        {
            this.callerReference = callerReference;
            return this;
        }
            

        // Check to see if CallerReference property is set
        internal bool IsSetCallerReference()
        {
            return this.callerReference != null;
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
        public DistributionConfig WithAliases(Aliases aliases)
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
        /// The object that you want CloudFront to return (for example, index.html) when an end user requests the root URL for your distribution
        /// (http://www.example.com) instead of an object in your distribution (http://www.example.com/index.html). Specifying a default root object
        /// avoids exposing the contents of your distribution. If you don't want to specify a default root object when you create a distribution,
        /// include an empty DefaultRootObject element. To delete the default root object from an existing distribution, update the distribution
        /// configuration and include an empty DefaultRootObject element. To replace the default root object, update the distribution configuration and
        /// specify the new object.
        ///  
        /// </summary>
        public string DefaultRootObject
        {
            get { return this.defaultRootObject; }
            set { this.defaultRootObject = value; }
        }

        /// <summary>
        /// Sets the DefaultRootObject property
        /// </summary>
        /// <param name="defaultRootObject">The value to set for the DefaultRootObject property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionConfig WithDefaultRootObject(string defaultRootObject)
        {
            this.defaultRootObject = defaultRootObject;
            return this;
        }
            

        // Check to see if DefaultRootObject property is set
        internal bool IsSetDefaultRootObject()
        {
            return this.defaultRootObject != null;
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
        public DistributionConfig WithOrigins(Origins origins)
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
        public DistributionConfig WithDefaultCacheBehavior(DefaultCacheBehavior defaultCacheBehavior)
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
        public DistributionConfig WithCacheBehaviors(CacheBehaviors cacheBehaviors)
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
        /// A complex type that contains zero or more CustomErrorResponse elements.
        ///  
        /// </summary>
        public CustomErrorResponses CustomErrorResponses
        {
            get { return this.customErrorResponses; }
            set { this.customErrorResponses = value; }
        }

        /// <summary>
        /// Sets the CustomErrorResponses property
        /// </summary>
        /// <param name="customErrorResponses">The value to set for the CustomErrorResponses property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionConfig WithCustomErrorResponses(CustomErrorResponses customErrorResponses)
        {
            this.customErrorResponses = customErrorResponses;
            return this;
        }
            

        // Check to see if CustomErrorResponses property is set
        internal bool IsSetCustomErrorResponses()
        {
            return this.customErrorResponses != null;
        }

        /// <summary>
        /// Any comments you want to include about the distribution.
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
        public DistributionConfig WithComment(string comment)
        {
            this.comment = comment;
            return this;
        }
            

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this.comment != null;
        }

        /// <summary>
        /// A complex type that controls whether access logs are written for the distribution.
        ///  
        /// </summary>
        public LoggingConfig Logging
        {
            get { return this.logging; }
            set { this.logging = value; }
        }

        /// <summary>
        /// Sets the Logging property
        /// </summary>
        /// <param name="logging">The value to set for the Logging property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DistributionConfig WithLogging(LoggingConfig logging)
        {
            this.logging = logging;
            return this;
        }
            

        // Check to see if Logging property is set
        internal bool IsSetLogging()
        {
            return this.logging != null;
        }

        /// <summary>
        /// A complex type that contains information about price class for this distribution.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>PriceClass_100, PriceClass_200, PriceClass_All</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
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
        public DistributionConfig WithPriceClass(string priceClass)
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
        public DistributionConfig WithEnabled(bool enabled)
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
        public DistributionConfig WithViewerCertificate(ViewerCertificate viewerCertificate)
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
