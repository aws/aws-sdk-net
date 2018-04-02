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
    /// A complex type that contains information about the Amazon S3 origin. If the origin
    /// is a custom origin, use the <code>CustomOriginConfig</code> element instead.
    /// </summary>
    public partial class S3OriginConfig
    {
        private string _originAccessIdentity;

        /// <summary>
        /// Gets and sets the property OriginAccessIdentity. 
        /// <para>
        /// The CloudFront origin access identity to associate with the origin. Use an origin
        /// access identity to configure the origin so that viewers can <i>only</i> access objects
        /// in an Amazon S3 bucket through CloudFront. The format of the value is:
        /// </para>
        ///  
        /// <para>
        /// origin-access-identity/cloudfront/<i>ID-of-origin-access-identity</i> 
        /// </para>
        ///  
        /// <para>
        /// where <code> <i>ID-of-origin-access-identity</i> </code> is the value that CloudFront
        /// returned in the <code>ID</code> element when you created the origin access identity.
        /// </para>
        ///  
        /// <para>
        /// If you want viewers to be able to access objects using either the CloudFront URL or
        /// the Amazon S3 URL, specify an empty <code>OriginAccessIdentity</code> element.
        /// </para>
        ///  
        /// <para>
        /// To delete the origin access identity from an existing distribution, update the distribution
        /// configuration and include an empty <code>OriginAccessIdentity</code> element.
        /// </para>
        ///  
        /// <para>
        /// To replace the origin access identity, update the distribution configuration and specify
        /// the new origin access identity.
        /// </para>
        ///  
        /// <para>
        /// For more information about the origin access identity, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/PrivateContent.html">Serving
        /// Private Content through CloudFront</a> in the <i>Amazon CloudFront Developer Guide</i>.
        /// </para>
        /// </summary>
        public string OriginAccessIdentity
        {
            get { return this._originAccessIdentity; }
            set { this._originAccessIdentity = value; }
        }

        // Check to see if OriginAccessIdentity property is set
        internal bool IsSetOriginAccessIdentity()
        {
            return this._originAccessIdentity != null;
        }

    }
}