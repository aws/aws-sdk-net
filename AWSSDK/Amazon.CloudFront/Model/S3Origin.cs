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
    /// A complex type that contains information about the Amazon S3    bucket from which
    /// you want CloudFront to get your media files for    distribution.
    /// </summary>
    public partial class S3Origin
    {
        private string _domainName;
        private string _originAccessIdentity;


        /// <summary>
        /// Gets and sets the property DomainName. The DNS name of the S3 origin.
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
        public S3Origin WithDomainName(string domainName)
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
        /// Gets and sets the property OriginAccessIdentity. Your S3 origin's origin access identity.
        /// </summary>
        public string OriginAccessIdentity
        {
            get { return this._originAccessIdentity; }
            set { this._originAccessIdentity = value; }
        }


        /// <summary>
        /// Sets the OriginAccessIdentity property
        /// </summary>
        /// <param name="originAccessIdentity">The value to set for the OriginAccessIdentity property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public S3Origin WithOriginAccessIdentity(string originAccessIdentity)
        {
            this._originAccessIdentity = originAccessIdentity;
            return this;
        }

        // Check to see if OriginAccessIdentity property is set
        internal bool IsSetOriginAccessIdentity()
        {
            return this._originAccessIdentity != null;
        }

    }
}