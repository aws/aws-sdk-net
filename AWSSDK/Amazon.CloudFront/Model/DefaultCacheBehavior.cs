/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> A complex type that describes the default cache behavior if you do not specify a CacheBehavior element or if files don't match any of
    /// the values of PathPattern in CacheBehavior elements.You must create exactly one default cache behavior. </para>
    /// </summary>
    public class DefaultCacheBehavior  
    {
        
        private string targetOriginId;
        private ForwardedValues forwardedValues;
        private TrustedSigners trustedSigners;
        private string viewerProtocolPolicy;
        private long? minTTL;

        /// <summary>
        /// The value of ID for the origin that you want CloudFront to route requests to when a request matches the path pattern either for a cache
        /// behavior or for the default cache behavior.
        ///  
        /// </summary>
        public string TargetOriginId
        {
            get { return this.targetOriginId; }
            set { this.targetOriginId = value; }
        }

        /// <summary>
        /// Sets the TargetOriginId property
        /// </summary>
        /// <param name="targetOriginId">The value to set for the TargetOriginId property </param>
        /// <returns>this instance</returns>
        public DefaultCacheBehavior WithTargetOriginId(string targetOriginId)
        {
            this.targetOriginId = targetOriginId;
            return this;
        }
            

        // Check to see if TargetOriginId property is set
        internal bool IsSetTargetOriginId()
        {
            return this.targetOriginId != null;       
        }

        /// <summary>
        /// A complex type that specifies how CloudFront handles query strings.
        ///  
        /// </summary>
        public ForwardedValues ForwardedValues
        {
            get { return this.forwardedValues; }
            set { this.forwardedValues = value; }
        }

        /// <summary>
        /// Sets the ForwardedValues property
        /// </summary>
        /// <param name="forwardedValues">The value to set for the ForwardedValues property </param>
        /// <returns>this instance</returns>
        public DefaultCacheBehavior WithForwardedValues(ForwardedValues forwardedValues)
        {
            this.forwardedValues = forwardedValues;
            return this;
        }
            

        // Check to see if ForwardedValues property is set
        internal bool IsSetForwardedValues()
        {
            return this.forwardedValues != null;       
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

        /// <summary>
        /// Sets the TrustedSigners property
        /// </summary>
        /// <param name="trustedSigners">The value to set for the TrustedSigners property </param>
        /// <returns>this instance</returns>
        public DefaultCacheBehavior WithTrustedSigners(TrustedSigners trustedSigners)
        {
            this.trustedSigners = trustedSigners;
            return this;
        }
            

        // Check to see if TrustedSigners property is set
        internal bool IsSetTrustedSigners()
        {
            return this.trustedSigners != null;       
        }

        /// <summary>
        /// Use this element to specify the protocol that users can use to access the files in the origin specified by TargetOriginId when a request
        /// matches the path pattern in PathPattern. If you want CloudFront to allow end users to use any available protocol, specify allow-all. If you
        /// want CloudFront to require HTTPS, specify https.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>allow-all, https-only</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ViewerProtocolPolicy
        {
            get { return this.viewerProtocolPolicy; }
            set { this.viewerProtocolPolicy = value; }
        }

        /// <summary>
        /// Sets the ViewerProtocolPolicy property
        /// </summary>
        /// <param name="viewerProtocolPolicy">The value to set for the ViewerProtocolPolicy property </param>
        /// <returns>this instance</returns>
        public DefaultCacheBehavior WithViewerProtocolPolicy(string viewerProtocolPolicy)
        {
            this.viewerProtocolPolicy = viewerProtocolPolicy;
            return this;
        }
            

        // Check to see if ViewerProtocolPolicy property is set
        internal bool IsSetViewerProtocolPolicy()
        {
            return this.viewerProtocolPolicy != null;       
        }

        /// <summary>
        /// The minimum amount of time that you want objects to stay in CloudFront caches before CloudFront queries your origin to see whether the
        /// object has been updated.You can specify a value from 0 to 3,153,600,000 seconds (100 years).
        ///  
        /// </summary>
        public long MinTTL
        {
            get { return this.minTTL ?? default(long); }
            set { this.minTTL = value; }
        }

        /// <summary>
        /// Sets the MinTTL property
        /// </summary>
        /// <param name="minTTL">The value to set for the MinTTL property </param>
        /// <returns>this instance</returns>
        public DefaultCacheBehavior WithMinTTL(long minTTL)
        {
            this.minTTL = minTTL;
            return this;
        }
            

        // Check to see if MinTTL property is set
        internal bool IsSetMinTTL()
        {
            return this.minTTL.HasValue;       
        }
    }
}
