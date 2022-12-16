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
    /// The RTMP distribution's configuration information.
    /// </summary>
    public partial class StreamingDistributionConfig
    {
        private Aliases _aliases;
        private string _callerReference;
        private string _comment;
        private bool? _enabled;
        private StreamingLoggingConfig _logging;
        private PriceClass _priceClass;
        private S3Origin _s3Origin;
        private TrustedSigners _trustedSigners;

        /// <summary>
        /// Gets and sets the property Aliases. 
        /// <para>
        /// A complex type that contains information about CNAMEs (alternate domain names), if
        /// any, for this streaming distribution.
        /// </para>
        /// </summary>
        public Aliases Aliases
        {
            get { return this._aliases; }
            set { this._aliases = value; }
        }

        // Check to see if Aliases property is set
        internal bool IsSetAliases()
        {
            return this._aliases != null;
        }

        /// <summary>
        /// Gets and sets the property CallerReference. 
        /// <para>
        /// A unique value (for example, a date-time stamp) that ensures that the request can't
        /// be replayed.
        /// </para>
        ///  
        /// <para>
        /// If the value of <code>CallerReference</code> is new (regardless of the content of
        /// the <code>StreamingDistributionConfig</code> object), CloudFront creates a new distribution.
        /// </para>
        ///  
        /// <para>
        /// If <code>CallerReference</code> is a value that you already sent in a previous request
        /// to create a distribution, CloudFront returns a <code>DistributionAlreadyExists</code>
        /// error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CallerReference
        {
            get { return this._callerReference; }
            set { this._callerReference = value; }
        }

        // Check to see if CallerReference property is set
        internal bool IsSetCallerReference()
        {
            return this._callerReference != null;
        }

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// Any comments you want to include about the streaming distribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether the streaming distribution is enabled to accept user requests for content.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Logging. 
        /// <para>
        /// A complex type that controls whether access logs are written for the streaming distribution.
        /// </para>
        /// </summary>
        public StreamingLoggingConfig Logging
        {
            get { return this._logging; }
            set { this._logging = value; }
        }

        // Check to see if Logging property is set
        internal bool IsSetLogging()
        {
            return this._logging != null;
        }

        /// <summary>
        /// Gets and sets the property PriceClass. 
        /// <para>
        /// A complex type that contains information about price class for this streaming distribution.
        /// </para>
        /// </summary>
        public PriceClass PriceClass
        {
            get { return this._priceClass; }
            set { this._priceClass = value; }
        }

        // Check to see if PriceClass property is set
        internal bool IsSetPriceClass()
        {
            return this._priceClass != null;
        }

        /// <summary>
        /// Gets and sets the property S3Origin. 
        /// <para>
        /// A complex type that contains information about the Amazon S3 bucket from which you
        /// want CloudFront to get your media files for distribution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3Origin S3Origin
        {
            get { return this._s3Origin; }
            set { this._s3Origin = value; }
        }

        // Check to see if S3Origin property is set
        internal bool IsSetS3Origin()
        {
            return this._s3Origin != null;
        }

        /// <summary>
        /// Gets and sets the property TrustedSigners. 
        /// <para>
        /// A complex type that specifies any Amazon Web Services accounts that you want to permit
        /// to create signed URLs for private content. If you want the distribution to use signed
        /// URLs, include this element; if you want the distribution to use public URLs, remove
        /// this element. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/PrivateContent.html">Serving
        /// Private Content through CloudFront</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}