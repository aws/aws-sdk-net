/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A complex type that describes the default cache behavior if you don't specify a <code>CacheBehavior</code>
    /// element or if request URLs don't match any of the values of <code>PathPattern</code>
    /// in <code>CacheBehavior</code> elements. You must create exactly one default cache
    /// behavior.
    /// </summary>
    public partial class DefaultCacheBehavior
    {
        private AllowedMethods _allowedMethods;
        private string _cachePolicyId;
        private bool? _compress;
        private long? _defaultTTL;
        private string _fieldLevelEncryptionId;
        private ForwardedValues _forwardedValues;
        private FunctionAssociations _functionAssociations;
        private LambdaFunctionAssociations _lambdaFunctionAssociations;
        private long? _maxTTL;
        private long? _minTTL;
        private string _originRequestPolicyId;
        private string _realtimeLogConfigArn;
        private string _responseHeadersPolicyId;
        private bool? _smoothStreaming;
        private string _targetOriginId;
        private TrustedKeyGroups _trustedKeyGroups;
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
        /// Gets and sets the property CachePolicyId. 
        /// <para>
        /// The unique identifier of the cache policy that is attached to the default cache behavior.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/controlling-the-cache-key.html#cache-key-create-cache-policy">Creating
        /// cache policies</a> or <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/using-managed-cache-policies.html">Using
        /// the managed cache policies</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// A <code>DefaultCacheBehavior</code> must include either a <code>CachePolicyId</code>
        /// or <code>ForwardedValues</code>. We recommend that you use a <code>CachePolicyId</code>.
        /// </para>
        /// </summary>
        public string CachePolicyId
        {
            get { return this._cachePolicyId; }
            set { this._cachePolicyId = value; }
        }

        // Check to see if CachePolicyId property is set
        internal bool IsSetCachePolicyId()
        {
            return this._cachePolicyId != null;
        }

        /// <summary>
        /// Gets and sets the property Compress. 
        /// <para>
        /// Whether you want CloudFront to automatically compress certain files for this cache
        /// behavior. If so, specify <code>true</code>; if not, specify <code>false</code>. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/ServingCompressedFiles.html">Serving
        /// Compressed Files</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        public bool Compress
        {
            get { return this._compress.GetValueOrDefault(); }
            set { this._compress = value; }
        }

        // Check to see if Compress property is set
        internal bool IsSetCompress()
        {
            return this._compress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultTTL. 
        /// <para>
        /// This field is deprecated. We recommend that you use the <code>DefaultTTL</code> field
        /// in a cache policy instead of this field. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/controlling-the-cache-key.html#cache-key-create-cache-policy">Creating
        /// cache policies</a> or <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/using-managed-cache-policies.html">Using
        /// the managed cache policies</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The default amount of time that you want objects to stay in CloudFront caches before
        /// CloudFront forwards another request to your origin to determine whether the object
        /// has been updated. The value that you specify applies only when your origin does not
        /// add HTTP headers such as <code>Cache-Control max-age</code>, <code>Cache-Control s-maxage</code>,
        /// and <code>Expires</code> to objects. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/Expiration.html">Managing
        /// How Long Content Stays in an Edge Cache (Expiration)</a> in the <i>Amazon CloudFront
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        [Obsolete("This field is deprecated. Use CachePolicy instead.")]
        public long DefaultTTL
        {
            get { return this._defaultTTL.GetValueOrDefault(); }
            set { this._defaultTTL = value; }
        }

        // Check to see if DefaultTTL property is set
        internal bool IsSetDefaultTTL()
        {
            return this._defaultTTL.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FieldLevelEncryptionId. 
        /// <para>
        /// The value of <code>ID</code> for the field-level encryption configuration that you
        /// want CloudFront to use for encrypting specific fields of data for the default cache
        /// behavior.
        /// </para>
        /// </summary>
        public string FieldLevelEncryptionId
        {
            get { return this._fieldLevelEncryptionId; }
            set { this._fieldLevelEncryptionId = value; }
        }

        // Check to see if FieldLevelEncryptionId property is set
        internal bool IsSetFieldLevelEncryptionId()
        {
            return this._fieldLevelEncryptionId != null;
        }

        /// <summary>
        /// Gets and sets the property ForwardedValues. 
        /// <para>
        /// This field is deprecated. We recommend that you use a cache policy or an origin request
        /// policy instead of this field. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/working-with-policies.html">Working
        /// with policies</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you want to include values in the cache key, use a cache policy. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/controlling-the-cache-key.html#cache-key-create-cache-policy">Creating
        /// cache policies</a> or <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/using-managed-cache-policies.html">Using
        /// the managed cache policies</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you want to send values to the origin but not include them in the cache key, use
        /// an origin request policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/controlling-origin-requests.html#origin-request-create-origin-request-policy">Creating
        /// origin request policies</a> or <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/using-managed-origin-request-policies.html">Using
        /// the managed origin request policies</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// A <code>DefaultCacheBehavior</code> must include either a <code>CachePolicyId</code>
        /// or <code>ForwardedValues</code>. We recommend that you use a <code>CachePolicyId</code>.
        /// </para>
        ///  
        /// <para>
        /// A complex type that specifies how CloudFront handles query strings, cookies, and HTTP
        /// headers.
        /// </para>
        /// </summary>
        [Obsolete("This field is deprecated. Use CachePolicy instead.")]
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
        /// Gets and sets the property FunctionAssociations. 
        /// <para>
        /// A list of CloudFront functions that are associated with this cache behavior. CloudFront
        /// functions must be published to the <code>LIVE</code> stage to associate them with
        /// a cache behavior.
        /// </para>
        /// </summary>
        public FunctionAssociations FunctionAssociations
        {
            get { return this._functionAssociations; }
            set { this._functionAssociations = value; }
        }

        // Check to see if FunctionAssociations property is set
        internal bool IsSetFunctionAssociations()
        {
            return this._functionAssociations != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaFunctionAssociations. 
        /// <para>
        /// A complex type that contains zero or more Lambda@Edge function associations for a
        /// cache behavior.
        /// </para>
        /// </summary>
        public LambdaFunctionAssociations LambdaFunctionAssociations
        {
            get { return this._lambdaFunctionAssociations; }
            set { this._lambdaFunctionAssociations = value; }
        }

        // Check to see if LambdaFunctionAssociations property is set
        internal bool IsSetLambdaFunctionAssociations()
        {
            return this._lambdaFunctionAssociations != null;
        }

        /// <summary>
        /// Gets and sets the property MaxTTL. 
        /// <para>
        /// This field is deprecated. We recommend that you use the <code>MaxTTL</code> field
        /// in a cache policy instead of this field. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/controlling-the-cache-key.html#cache-key-create-cache-policy">Creating
        /// cache policies</a> or <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/using-managed-cache-policies.html">Using
        /// the managed cache policies</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The maximum amount of time that you want objects to stay in CloudFront caches before
        /// CloudFront forwards another request to your origin to determine whether the object
        /// has been updated. The value that you specify applies only when your origin adds HTTP
        /// headers such as <code>Cache-Control max-age</code>, <code>Cache-Control s-maxage</code>,
        /// and <code>Expires</code> to objects. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/Expiration.html">Managing
        /// How Long Content Stays in an Edge Cache (Expiration)</a> in the <i>Amazon CloudFront
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        [Obsolete("This field is deprecated. Use CachePolicy instead.")]
        public long MaxTTL
        {
            get { return this._maxTTL.GetValueOrDefault(); }
            set { this._maxTTL = value; }
        }

        // Check to see if MaxTTL property is set
        internal bool IsSetMaxTTL()
        {
            return this._maxTTL.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinTTL. 
        /// <para>
        /// This field is deprecated. We recommend that you use the <code>MinTTL</code> field
        /// in a cache policy instead of this field. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/controlling-the-cache-key.html#cache-key-create-cache-policy">Creating
        /// cache policies</a> or <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/using-managed-cache-policies.html">Using
        /// the managed cache policies</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The minimum amount of time that you want objects to stay in CloudFront caches before
        /// CloudFront forwards another request to your origin to determine whether the object
        /// has been updated. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/Expiration.html">Managing
        /// How Long Content Stays in an Edge Cache (Expiration)</a> in the <i>Amazon CloudFront
        /// Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You must specify <code>0</code> for <code>MinTTL</code> if you configure CloudFront
        /// to forward all headers to your origin (under <code>Headers</code>, if you specify
        /// <code>1</code> for <code>Quantity</code> and <code>*</code> for <code>Name</code>).
        /// </para>
        /// </summary>
        [Obsolete("This field is deprecated. Use CachePolicy instead.")]
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
        /// Gets and sets the property OriginRequestPolicyId. 
        /// <para>
        /// The unique identifier of the origin request policy that is attached to the default
        /// cache behavior. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/controlling-origin-requests.html#origin-request-create-origin-request-policy">Creating
        /// origin request policies</a> or <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/using-managed-origin-request-policies.html">Using
        /// the managed origin request policies</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        public string OriginRequestPolicyId
        {
            get { return this._originRequestPolicyId; }
            set { this._originRequestPolicyId = value; }
        }

        // Check to see if OriginRequestPolicyId property is set
        internal bool IsSetOriginRequestPolicyId()
        {
            return this._originRequestPolicyId != null;
        }

        /// <summary>
        /// Gets and sets the property RealtimeLogConfigArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the real-time log configuration that is attached
        /// to this cache behavior. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/real-time-logs.html">Real-time
        /// logs</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        public string RealtimeLogConfigArn
        {
            get { return this._realtimeLogConfigArn; }
            set { this._realtimeLogConfigArn = value; }
        }

        // Check to see if RealtimeLogConfigArn property is set
        internal bool IsSetRealtimeLogConfigArn()
        {
            return this._realtimeLogConfigArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResponseHeadersPolicyId. 
        /// <para>
        /// The identifier for a response headers policy.
        /// </para>
        /// </summary>
        public string ResponseHeadersPolicyId
        {
            get { return this._responseHeadersPolicyId; }
            set { this._responseHeadersPolicyId = value; }
        }

        // Check to see if ResponseHeadersPolicyId property is set
        internal bool IsSetResponseHeadersPolicyId()
        {
            return this._responseHeadersPolicyId != null;
        }

        /// <summary>
        /// Gets and sets the property SmoothStreaming. 
        /// <para>
        /// Indicates whether you want to distribute media files in the Microsoft Smooth Streaming
        /// format using the origin that is associated with this cache behavior. If so, specify
        /// <code>true</code>; if not, specify <code>false</code>. If you specify <code>true</code>
        /// for <code>SmoothStreaming</code>, you can still distribute other content using this
        /// cache behavior if the content matches the value of <code>PathPattern</code>.
        /// </para>
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
        /// Gets and sets the property TargetOriginId. 
        /// <para>
        /// The value of <code>ID</code> for the origin that you want CloudFront to route requests
        /// to when they use the default cache behavior.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property TrustedKeyGroups. 
        /// <para>
        /// A list of key groups that CloudFront can use to validate signed URLs or signed cookies.
        /// </para>
        ///  
        /// <para>
        /// When a cache behavior contains trusted key groups, CloudFront requires signed URLs
        /// or signed cookies for all requests that match the cache behavior. The URLs or cookies
        /// must be signed with a private key whose corresponding public key is in the key group.
        /// The signed URL or cookie contains information about which public key CloudFront should
        /// use to verify the signature. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/PrivateContent.html">Serving
        /// private content</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        public TrustedKeyGroups TrustedKeyGroups
        {
            get { return this._trustedKeyGroups; }
            set { this._trustedKeyGroups = value; }
        }

        // Check to see if TrustedKeyGroups property is set
        internal bool IsSetTrustedKeyGroups()
        {
            return this._trustedKeyGroups != null;
        }

        /// <summary>
        /// Gets and sets the property TrustedSigners. <important> 
        /// <para>
        /// We recommend using <code>TrustedKeyGroups</code> instead of <code>TrustedSigners</code>.
        /// </para>
        ///  </important> 
        /// <para>
        /// A list of Amazon Web Services account IDs whose public keys CloudFront can use to
        /// validate signed URLs or signed cookies.
        /// </para>
        ///  
        /// <para>
        /// When a cache behavior contains trusted signers, CloudFront requires signed URLs or
        /// signed cookies for all requests that match the cache behavior. The URLs or cookies
        /// must be signed with the private key of a CloudFront key pair in a trusted signer's
        /// Amazon Web Services account. The signed URL or cookie contains information about which
        /// public key CloudFront should use to verify the signature. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/PrivateContent.html">Serving
        /// private content</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
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
        /// Gets and sets the property ViewerProtocolPolicy. 
        /// <para>
        /// The protocol that viewers can use to access the files in the origin specified by <code>TargetOriginId</code>
        /// when a request matches the path pattern in <code>PathPattern</code>. You can specify
        /// the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>allow-all</code>: Viewers can use HTTP or HTTPS.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>redirect-to-https</code>: If a viewer submits an HTTP request, CloudFront returns
        /// an HTTP status code of 301 (Moved Permanently) to the viewer along with the HTTPS
        /// URL. The viewer then resubmits the request using the new URL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>https-only</code>: If a viewer sends an HTTP request, CloudFront returns an
        /// HTTP status code of 403 (Forbidden).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about requiring the HTTPS protocol, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/using-https-viewers-to-cloudfront.html">Requiring
        /// HTTPS Between Viewers and CloudFront</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The only way to guarantee that viewers retrieve an object that was fetched from the
        /// origin using HTTPS is never to use any other protocol to fetch the object. If you
        /// have recently changed from HTTP to HTTPS, we recommend that you clear your objects'
        /// cache because cached objects are protocol agnostic. That means that an edge location
        /// will return an object from the cache regardless of whether the current request protocol
        /// matches the protocol used previously. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/Expiration.html">Managing
        /// Cache Expiration</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
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