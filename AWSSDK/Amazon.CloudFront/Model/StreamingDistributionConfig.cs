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
    /// <para> The configuration for the streaming distribution. </para>
    /// </summary>
    public class StreamingDistributionConfig  
    {
        
        private string callerReference;
        private S3Origin s3Origin;
        private Aliases aliases;
        private string comment;
        private StreamingLoggingConfig logging;
        private TrustedSigners trustedSigners;
        private string priceClass = "PriceClass_All";
        private bool? enabled;

        /// <summary>
        /// A unique number that ensures the request can't be replayed. If the CallerReference is new (no matter the content of the
        /// StreamingDistributionConfig object), a new streaming distribution is created. If the CallerReference is a value you already sent in a
        /// previous request to create a streaming distribution, and the content of the StreamingDistributionConfig is identical to the original request
        /// (ignoring white space), the response includes the same information returned to the original request. If the CallerReference is a value you
        /// already sent in a previous request to create a streaming distribution but the content of the StreamingDistributionConfig is different from
        /// the original request, CloudFront returns a DistributionAlreadyExists error.
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
        public StreamingDistributionConfig WithCallerReference(string callerReference)
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
        /// A complex type that contains information about the Amazon S3 bucket from which you want CloudFront to get your media files for distribution.
        ///  
        /// </summary>
        public S3Origin S3Origin
        {
            get { return this.s3Origin; }
            set { this.s3Origin = value; }
        }

        /// <summary>
        /// Sets the S3Origin property
        /// </summary>
        /// <param name="s3Origin">The value to set for the S3Origin property </param>
        /// <returns>this instance</returns>
        public StreamingDistributionConfig WithS3Origin(S3Origin s3Origin)
        {
            this.s3Origin = s3Origin;
            return this;
        }
            

        // Check to see if S3Origin property is set
        internal bool IsSetS3Origin()
        {
            return this.s3Origin != null;       
        }

        /// <summary>
        /// A complex type that contains information about CNAMEs (alternate domain names), if any, for this streaming distribution.
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
        public StreamingDistributionConfig WithAliases(Aliases aliases)
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
        /// Any comments you want to include about the streaming distribution.
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
        public StreamingDistributionConfig WithComment(string comment)
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
        /// A complex type that controls whether access logs are written for the streaming distribution.
        ///  
        /// </summary>
        public StreamingLoggingConfig Logging
        {
            get { return this.logging; }
            set { this.logging = value; }
        }

        /// <summary>
        /// Sets the Logging property
        /// </summary>
        /// <param name="logging">The value to set for the Logging property </param>
        /// <returns>this instance</returns>
        public StreamingDistributionConfig WithLogging(StreamingLoggingConfig logging)
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
        public StreamingDistributionConfig WithTrustedSigners(TrustedSigners trustedSigners)
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
        /// A complex type that contains information about price class for this streaming distribution.
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
        public StreamingDistributionConfig WithPriceClass(string priceClass)
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
        /// Whether the streaming distribution is enabled to accept end user requests for content.
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
        public StreamingDistributionConfig WithEnabled(bool enabled)
        {
            this.enabled = enabled;
            return this;
        }
            

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this.enabled.HasValue;       
        }
    }
}
