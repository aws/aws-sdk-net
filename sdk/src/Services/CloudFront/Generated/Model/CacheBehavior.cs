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
 * Do not modify this file. This file is generated from the cloudfront-2017-10-30.normal.json service model.
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
    /// A complex type that describes how CloudFront processes requests.
    /// 
    ///  
    /// <para>
    /// You must create at least as many cache behaviors (including the default cache behavior)
    /// as you have origins if you want CloudFront to distribute objects from all of the origins.
    /// Each cache behavior specifies the one origin from which you want CloudFront to get
    /// objects. If you have two origins and only the default cache behavior, the default
    /// cache behavior will cause CloudFront to get objects from one of the origins, but the
    /// other origin is never used.
    /// </para>
    ///  
    /// <para>
    /// For the current limit on the number of cache behaviors that you can add to a distribution,
    /// see <a href="http://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html#limits_cloudfront">Amazon
    /// CloudFront Limits</a> in the <i>AWS General Reference</i>.
    /// </para>
    ///  
    /// <para>
    /// If you don't want to specify any cache behaviors, include only an empty <code>CacheBehaviors</code>
    /// element. Don't include an empty <code>CacheBehavior</code> element, or CloudFront
    /// returns a <code>MalformedXML</code> error.
    /// </para>
    ///  
    /// <para>
    /// To delete all cache behaviors in an existing distribution, update the distribution
    /// configuration and include only an empty <code>CacheBehaviors</code> element.
    /// </para>
    ///  
    /// <para>
    /// To add, change, or remove one or more cache behaviors, update the distribution configuration
    /// and specify all of the cache behaviors that you want to include in the updated distribution.
    /// </para>
    ///  
    /// <para>
    /// For more information about cache behaviors, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-web-values-specify.html#DownloadDistValuesCacheBehavior">Cache
    /// Behaviors</a> in the <i>Amazon CloudFront Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CacheBehavior
    {
        private AllowedMethods _allowedMethods;
        private bool? _compress;
        private long? _defaultTTL;
        private string _fieldLevelEncryptionId;
        private ForwardedValues _forwardedValues;
        private LambdaFunctionAssociations _lambdaFunctionAssociations;
        private long? _maxTTL;
        private long? _minTTL;
        private string _pathPattern;
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
        /// Gets and sets the property Compress. 
        /// <para>
        /// Whether you want CloudFront to automatically compress certain files for this cache
        /// behavior. If so, specify true; if not, specify false. For more information, see <a
        /// href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/ServingCompressedFiles.html">Serving
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
        /// The default amount of time that you want objects to stay in CloudFront caches before
        /// CloudFront forwards another request to your origin to determine whether the object
        /// has been updated. The value that you specify applies only when your origin does not
        /// add HTTP headers such as <code>Cache-Control max-age</code>, <code>Cache-Control s-maxage</code>,
        /// and <code>Expires</code> to objects. For more information, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/Expiration.html">Specifying
        /// How Long Objects and Errors Stay in a CloudFront Edge Cache (Expiration)</a> in the
        /// <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
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
        /// A complex type that specifies how CloudFront handles query strings and cookies.
        /// </para>
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
        /// Gets and sets the property LambdaFunctionAssociations. 
        /// <para>
        /// A complex type that contains zero or more Lambda function associations for a cache
        /// behavior.
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
        /// The maximum amount of time that you want objects to stay in CloudFront caches before
        /// CloudFront forwards another request to your origin to determine whether the object
        /// has been updated. The value that you specify applies only when your origin adds HTTP
        /// headers such as <code>Cache-Control max-age</code>, <code>Cache-Control s-maxage</code>,
        /// and <code>Expires</code> to objects. For more information, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/Expiration.html">Specifying
        /// How Long Objects and Errors Stay in a CloudFront Edge Cache (Expiration)</a> in the
        /// <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
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
        /// The minimum amount of time that you want objects to stay in CloudFront caches before
        /// CloudFront forwards another request to your origin to determine whether the object
        /// has been updated. For more information, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/Expiration.html">Specifying
        /// How Long Objects and Errors Stay in a CloudFront Edge Cache (Expiration)</a> in the
        /// <i>Amazon Amazon CloudFront Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You must specify <code>0</code> for <code>MinTTL</code> if you configure CloudFront
        /// to forward all headers to your origin (under <code>Headers</code>, if you specify
        /// <code>1</code> for <code>Quantity</code> and <code>*</code> for <code>Name</code>).
        /// </para>
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
        /// Gets and sets the property PathPattern. 
        /// <para>
        /// The pattern (for example, <code>images/*.jpg</code>) that specifies which requests
        /// to apply the behavior to. When CloudFront receives a viewer request, the requested
        /// path is compared with path patterns in the order in which cache behaviors are listed
        /// in the distribution.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can optionally include a slash (<code>/</code>) at the beginning of the path pattern.
        /// For example, <code>/images/*.jpg</code>. CloudFront behavior is the same with or without
        /// the leading <code>/</code>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The path pattern for the default cache behavior is <code>*</code> and cannot be changed.
        /// If the request for an object does not match the path pattern for any cache behaviors,
        /// CloudFront applies the behavior in the default cache behavior.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-web-values-specify.html#DownloadDistValuesPathPattern">Path
        /// Pattern</a> in the <i> Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        public string PathPattern
        {
            get { return this._pathPattern; }
            set { this._pathPattern = value; }
        }

        // Check to see if PathPattern property is set
        internal bool IsSetPathPattern()
        {
            return this._pathPattern != null;
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
        /// to when a request matches the path pattern either for a cache behavior or for the
        /// default cache behavior.
        /// </para>
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
        /// Gets and sets the property TrustedSigners. 
        /// <para>
        /// A complex type that specifies the AWS accounts, if any, that you want to allow to
        /// create signed URLs for private content.
        /// </para>
        ///  
        /// <para>
        /// If you want to require signed URLs in requests for objects in the target origin that
        /// match the <code>PathPattern</code> for this cache behavior, specify <code>true</code>
        /// for <code>Enabled</code>, and specify the applicable values for <code>Quantity</code>
        /// and <code>Items</code>. For more information, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/PrivateContent.html">Serving
        /// Private Content through CloudFront</a> in the <i>Amazon Amazon CloudFront Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you don't want to require signed URLs in requests for objects that match <code>PathPattern</code>,
        /// specify <code>false</code> for <code>Enabled</code> and <code>0</code> for <code>Quantity</code>.
        /// Omit <code>Items</code>.
        /// </para>
        ///  
        /// <para>
        /// To add, change, or remove one or more trusted signers, change <code>Enabled</code>
        /// to <code>true</code> (if it's currently <code>false</code>), change <code>Quantity</code>
        /// as applicable, and specify all of the trusted signers that you want to include in
        /// the updated distribution.
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
        /// For more information about requiring the HTTPS protocol, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/SecureConnections.html">Using
        /// an HTTPS Connection to Access Your Objects</a> in the <i>Amazon CloudFront Developer
        /// Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The only way to guarantee that viewers retrieve an object that was fetched from the
        /// origin using HTTPS is never to use any other protocol to fetch the object. If you
        /// have recently changed from HTTP to HTTPS, we recommend that you clear your objects'
        /// cache because cached objects are protocol agnostic. That means that an edge location
        /// will return an object from the cache regardless of whether the current request protocol
        /// matches the protocol used previously. For more information, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/Expiration.html">Specifying
        /// How Long Objects and Errors Stay in a CloudFront Edge Cache (Expiration)</a> in the
        /// <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        ///  </note>
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