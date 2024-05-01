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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
    /// Provides information about an Amazon Kinesis data stream.
    /// </summary>
    public partial class AwsKinesisStreamDetails
    {
        private string _arn;
        private string _name;
        private int? _retentionPeriodHours;
        private int? _shardCount;
        private AwsKinesisStreamStreamEncryptionDetails _streamEncryption;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Kinesis data stream. 
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Kinesis stream. If you don't specify a name, CloudFront generates
        /// a unique physical ID and uses that ID for the stream name. 
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RetentionPeriodHours. 
        /// <para>
        /// The number of hours for the data records that are stored in shards to remain accessible.
        /// 
        /// </para>
        /// </summary>
        public int? RetentionPeriodHours
        {
            get { return this._retentionPeriodHours; }
            set { this._retentionPeriodHours = value; }
        }

        // Check to see if RetentionPeriodHours property is set
        internal bool IsSetRetentionPeriodHours()
        {
            return this._retentionPeriodHours.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShardCount. 
        /// <para>
        /// The number of shards that the stream uses. 
        /// </para>
        /// </summary>
        public int? ShardCount
        {
            get { return this._shardCount; }
            set { this._shardCount = value; }
        }

        // Check to see if ShardCount property is set
        internal bool IsSetShardCount()
        {
            return this._shardCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamEncryption. 
        /// <para>
        /// When specified, enables or updates server-side encryption using an KMS key for a specified
        /// stream. Removing this property from your stack template and updating your stack disables
        /// encryption. 
        /// </para>
        /// </summary>
        public AwsKinesisStreamStreamEncryptionDetails StreamEncryption
        {
            get { return this._streamEncryption; }
            set { this._streamEncryption = value; }
        }

        // Check to see if StreamEncryption property is set
        internal bool IsSetStreamEncryption()
        {
            return this._streamEncryption != null;
        }

    }
}