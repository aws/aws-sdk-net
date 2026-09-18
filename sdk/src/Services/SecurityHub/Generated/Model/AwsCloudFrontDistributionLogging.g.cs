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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A complex type that controls whether access logs are written for the CloudFront distribution.
    /// </summary>
    public partial class AwsCloudFrontDistributionLogging
    {
        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The S3 bucket to store the access logs in.
        /// </para>
        /// </summary>
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// With this field, you can enable or disable the selected distribution.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeCookies. 
        /// <para>
        /// Specifies whether you want CloudFront to include cookies in access logs.
        /// </para>
        /// </summary>
        public bool? IncludeCookies { get; set; }

        /// <summary>
        /// Checks to see if the IncludeCookies property is set.
        /// </summary>
        internal bool IsSetIncludeCookies() => this.IncludeCookies.HasValue;

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// An optional string that you want CloudFront to use as a prefix to the access log filenames
        /// for this distribution.
        /// </para>
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;
    }
}
