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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
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
namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Information about the <c>AccessLog</c> attribute.
    /// </summary>
    public partial class AccessLog
    {
        private int? _emitInterval;
        private bool? _enabled;
        private string _s3BucketName;
        private string _s3BucketPrefix;

        /// <summary>
        /// Gets and sets the property EmitInterval. 
        /// <para>
        /// The interval for publishing the access logs. You can specify an interval of either
        /// 5 minutes or 60 minutes.
        /// </para>
        ///  
        /// <para>
        /// Default: 60 minutes
        /// </para>
        /// </summary>
        public int? EmitInterval
        {
            get { return this._emitInterval; }
            set { this._emitInterval = value; }
        }

        // Check to see if EmitInterval property is set
        internal bool IsSetEmitInterval()
        {
            return this._emitInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether access logs are enabled for the load balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// The name of the Amazon S3 bucket where the access logs are stored.
        /// </para>
        /// </summary>
        public string S3BucketName
        {
            get { return this._s3BucketName; }
            set { this._s3BucketName = value; }
        }

        // Check to see if S3BucketName property is set
        internal bool IsSetS3BucketName()
        {
            return this._s3BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketPrefix. 
        /// <para>
        /// The logical hierarchy you created for your Amazon S3 bucket, for example <c>my-bucket-prefix/prod</c>.
        /// If the prefix is not provided, the log is placed at the root level of the bucket.
        /// </para>
        /// </summary>
        public string S3BucketPrefix
        {
            get { return this._s3BucketPrefix; }
            set { this._s3BucketPrefix = value; }
        }

        // Check to see if S3BucketPrefix property is set
        internal bool IsSetS3BucketPrefix()
        {
            return this._s3BucketPrefix != null;
        }

    }
}