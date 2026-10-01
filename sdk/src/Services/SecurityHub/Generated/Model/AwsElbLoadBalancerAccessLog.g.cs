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
    /// Contains information about the access log configuration for the load balancer.
    /// </summary>
    public partial class AwsElbLoadBalancerAccessLog
    {
        /// <summary>
        /// Gets and sets the property EmitInterval. 
        /// <para>
        /// The interval in minutes for publishing the access logs.
        /// </para>
        ///  
        /// <para>
        /// You can publish access logs either every 5 minutes or every 60 minutes.
        /// </para>
        /// </summary>
        public int? EmitInterval { get; set; }

        /// <summary>
        /// Checks to see if the EmitInterval property is set.
        /// </summary>
        internal bool IsSetEmitInterval() => this.EmitInterval.HasValue;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether access logs are enabled for the load balancer.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// The name of the S3 bucket where the access logs are stored.
        /// </para>
        /// </summary>
        public string S3BucketName { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketName property is set.
        /// </summary>
        internal bool IsSetS3BucketName() => this.S3BucketName != null;

        /// <summary>
        /// Gets and sets the property S3BucketPrefix. 
        /// <para>
        /// The logical hierarchy that was created for the S3 bucket.
        /// </para>
        ///  
        /// <para>
        /// If a prefix is not provided, the log is placed at the root level of the bucket.
        /// </para>
        /// </summary>
        public string S3BucketPrefix { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketPrefix property is set.
        /// </summary>
        internal bool IsSetS3BucketPrefix() => this.S3BucketPrefix != null;
    }
}
