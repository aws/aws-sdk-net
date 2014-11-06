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
    /// The configuration for the streaming distribution.
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
        /// Gets and sets the property Aliases. A complex type that contains information about
        /// CNAMEs (alternate domain names), if any, for this streaming distribution.
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
        /// Gets and sets the property CallerReference. A unique number that ensures the request
        /// can't be replayed. If the CallerReference is new (no matter the content of the StreamingDistributionConfig
        /// object), a new streaming distribution is created. If the CallerReference is a value
        /// you already sent in a previous request to create a streaming distribution, and the
        /// content of the StreamingDistributionConfig is identical to the original request (ignoring
        /// white space), the response includes the same information returned to the original
        /// request. If the CallerReference is a value you already sent in a previous request
        /// to create a streaming distribution but the content of the StreamingDistributionConfig
        /// is different from the original request, CloudFront returns a DistributionAlreadyExists
        /// error.
        /// </summary>
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
        /// Gets and sets the property Comment. Any comments you want to include about the streaming
        /// distribution.
        /// </summary>
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
        /// Gets and sets the property Enabled. Whether the streaming distribution is enabled
        /// to accept end user requests for content.
        /// </summary>
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
        /// Gets and sets the property Logging. A complex type that controls whether access logs
        /// are written for the streaming distribution.
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
        /// Gets and sets the property PriceClass. A complex type that contains information about
        /// price class for this streaming distribution.
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
        /// Gets and sets the property S3Origin. A complex type that contains information about
        /// the Amazon S3 bucket from which you want CloudFront to get your media files for distribution.
        /// </summary>
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

    }
}