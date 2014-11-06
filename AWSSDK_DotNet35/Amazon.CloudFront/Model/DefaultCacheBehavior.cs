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
    /// A complex type that describes the default cache behavior if you do not specify a CacheBehavior
    /// element or if files don't match any of the values of PathPattern in CacheBehavior
    /// elements.You must create exactly one default cache behavior.
    /// </summary>
    public partial class DefaultCacheBehavior
    {
        private AllowedMethods _allowedMethods;
        private ForwardedValues _forwardedValues;
        private long? _minTTL;
        private bool? _smoothStreaming;
        private string _targetOriginId;
        private TrustedSigners _trustedSigners;
        private ViewerProtocolPolicy _viewerProtocolPolicy;

        /// <summary>
        /// Gets and sets the property AllowedMethods.
        /// </summary>
        public AllowedMethods AllowedMethods
        {
            get { return this._allowedMethods; }
            set { this._allowedMethods = value; }
        }

        // Check to see if AllowedMethods property is set
        internal bool IsSetAllowedMethods()
        {
            return this._allowedMethods != null;
        }

        /// <summary>
        /// Gets and sets the property ForwardedValues. A complex type that specifies how CloudFront
        /// handles query strings, cookies and headers.
        /// </summary>
        public ForwardedValues ForwardedValues
        {
            get { return this._forwardedValues; }
            set { this._forwardedValues = value; }
        }

        // Check to see if ForwardedValues property is set
        internal bool IsSetForwardedValues()
        {
            return this._forwardedValues != null;
        }

        /// <summary>
        /// Gets and sets the property MinTTL. The minimum amount of time that you want objects
        /// to stay in CloudFront caches before CloudFront queries your origin to see whether
        /// the object has been updated.You can specify a value from 0 to 3,153,600,000 seconds
        /// (100 years).
        /// </summary>
        public long MinTTL
        {
            get { return this._minTTL.GetValueOrDefault(); }
            set { this._minTTL = value; }
        }

        // Check to see if MinTTL property is set
        internal bool IsSetMinTTL()
        {
            return this._minTTL.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SmoothStreaming. Indicates whether you want to distribute
        /// media files in Microsoft Smooth Streaming format using the origin that is associated
        /// with this cache behavior. If so, specify true; if not, specify false.
        /// </summary>
        public bool SmoothStreaming
        {
            get { return this._smoothStreaming.GetValueOrDefault(); }
            set { this._smoothStreaming = value; }
        }

        // Check to see if SmoothStreaming property is set
        internal bool IsSetSmoothStreaming()
        {
            return this._smoothStreaming.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetOriginId. The value of ID for the origin that you
        /// want CloudFront to route requests to when a request matches the path pattern either
        /// for a cache behavior or for the default cache behavior.
        /// </summary>
        public string TargetOriginId
        {
            get { return this._targetOriginId; }
            set { this._targetOriginId = value; }
        }

        // Check to see if TargetOriginId property is set
        internal bool IsSetTargetOriginId()
        {
            return this._targetOriginId != null;
        }

        /// <summary>
        /// Gets and sets the property TrustedSigners. A complex type that specifies the AWS accounts,
        /// if any, that you want to allow to create signed URLs for private content. If you want
        /// to require signed URLs in requests for objects in the target origin that match the
        /// PathPattern for this cache behavior, specify true for Enabled, and specify the applicable
        /// values for Quantity and Items. For more information, go to Using a Signed URL to Serve
        /// Private Content in the Amazon CloudFront Developer Guide. If you don't want to require
        /// signed URLs in requests for objects that match PathPattern, specify false for Enabled
        /// and 0 for Quantity. Omit Items. To add, change, or remove one or more trusted signers,
        /// change Enabled to true (if it's currently false), change Quantity as applicable, and
        /// specify all of the trusted signers that you want to include in the updated distribution.
        /// </summary>
        public TrustedSigners TrustedSigners
        {
            get { return this._trustedSigners; }
            set { this._trustedSigners = value; }
        }

        // Check to see if TrustedSigners property is set
        internal bool IsSetTrustedSigners()
        {
            return this._trustedSigners != null;
        }

        /// <summary>
        /// Gets and sets the property ViewerProtocolPolicy. Use this element to specify the protocol
        /// that users can use to access the files in the origin specified by TargetOriginId when
        /// a request matches the path pattern in PathPattern. If you want CloudFront to allow
        /// end users to use any available protocol, specify allow-all. If you want CloudFront
        /// to require HTTPS, specify https. If you want CloudFront to respond to an HTTP request
        /// with an HTTP status code of 301 (Moved Permanently) and the HTTPS URL, specify redirect-to-https.
        /// The viewer then resubmits the request using the HTTPS URL.
        /// </summary>
        public ViewerProtocolPolicy ViewerProtocolPolicy
        {
            get { return this._viewerProtocolPolicy; }
            set { this._viewerProtocolPolicy = value; }
        }

        // Check to see if ViewerProtocolPolicy property is set
        internal bool IsSetViewerProtocolPolicy()
        {
            return this._viewerProtocolPolicy != null;
        }

    }
}