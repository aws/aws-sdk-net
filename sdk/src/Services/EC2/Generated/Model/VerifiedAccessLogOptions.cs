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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Options for Verified Access logs.
    /// </summary>
    public partial class VerifiedAccessLogOptions
    {
        private VerifiedAccessLogCloudWatchLogsDestinationOptions _cloudWatchLogs;
        private bool? _includeTrustContext;
        private VerifiedAccessLogKinesisDataFirehoseDestinationOptions _kinesisDataFirehose;
        private string _logVersion;
        private VerifiedAccessLogS3DestinationOptions _s3;

        /// <summary>
        /// Gets and sets the property CloudWatchLogs. 
        /// <para>
        /// Sends Verified Access logs to CloudWatch Logs.
        /// </para>
        /// </summary>
        public VerifiedAccessLogCloudWatchLogsDestinationOptions CloudWatchLogs
        {
            get { return this._cloudWatchLogs; }
            set { this._cloudWatchLogs = value; }
        }

        // Check to see if CloudWatchLogs property is set
        internal bool IsSetCloudWatchLogs()
        {
            return this._cloudWatchLogs != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeTrustContext. 
        /// <para>
        /// Indicates whether to include trust data sent by trust providers in the logs.
        /// </para>
        /// </summary>
        public bool? IncludeTrustContext
        {
            get { return this._includeTrustContext; }
            set { this._includeTrustContext = value; }
        }

        // Check to see if IncludeTrustContext property is set
        internal bool IsSetIncludeTrustContext()
        {
            return this._includeTrustContext.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KinesisDataFirehose. 
        /// <para>
        /// Sends Verified Access logs to Kinesis.
        /// </para>
        /// </summary>
        public VerifiedAccessLogKinesisDataFirehoseDestinationOptions KinesisDataFirehose
        {
            get { return this._kinesisDataFirehose; }
            set { this._kinesisDataFirehose = value; }
        }

        // Check to see if KinesisDataFirehose property is set
        internal bool IsSetKinesisDataFirehose()
        {
            return this._kinesisDataFirehose != null;
        }

        /// <summary>
        /// Gets and sets the property LogVersion. 
        /// <para>
        /// The logging version.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>ocsf-0.1</c> | <c>ocsf-1.0.0-rc.2</c> 
        /// </para>
        /// </summary>
        public string LogVersion
        {
            get { return this._logVersion; }
            set { this._logVersion = value; }
        }

        // Check to see if LogVersion property is set
        internal bool IsSetLogVersion()
        {
            return this._logVersion != null;
        }

        /// <summary>
        /// Gets and sets the property S3. 
        /// <para>
        /// Sends Verified Access logs to Amazon S3.
        /// </para>
        /// </summary>
        public VerifiedAccessLogS3DestinationOptions S3
        {
            get { return this._s3; }
            set { this._s3 = value; }
        }

        // Check to see if S3 property is set
        internal bool IsSetS3()
        {
            return this._s3 != null;
        }

    }
}