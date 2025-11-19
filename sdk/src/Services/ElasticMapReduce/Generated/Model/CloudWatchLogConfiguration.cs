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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Holds CloudWatch log configuration settings and metadata that specify settings like
    /// log files to monitor and where to send them.
    /// </summary>
    public partial class CloudWatchLogConfiguration
    {
        private bool? _enabled;
        private string _encryptionKeyArn;
        private string _logGroupName;
        private string _logStreamNamePrefix;
        private Dictionary<string, List<string>> _logTypes = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies if CloudWatch logging is enabled.
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
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The ARN of the encryption key used to encrypt the logs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
        public string EncryptionKeyArn
        {
            get { return this._encryptionKeyArn; }
            set { this._encryptionKeyArn = value; }
        }

        // Check to see if EncryptionKeyArn property is set
        internal bool IsSetEncryptionKeyArn()
        {
            return this._encryptionKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of the CloudWatch log group where logs are published.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
        public string LogGroupName
        {
            get { return this._logGroupName; }
            set { this._logGroupName = value; }
        }

        // Check to see if LogGroupName property is set
        internal bool IsSetLogGroupName()
        {
            return this._logGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property LogStreamNamePrefix. 
        /// <para>
        /// The prefix of the log stream name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
        public string LogStreamNamePrefix
        {
            get { return this._logStreamNamePrefix; }
            set { this._logStreamNamePrefix = value; }
        }

        // Check to see if LogStreamNamePrefix property is set
        internal bool IsSetLogStreamNamePrefix()
        {
            return this._logStreamNamePrefix != null;
        }

        /// <summary>
        /// Gets and sets the property LogTypes. 
        /// <para>
        /// A map of log types to file names for publishing logs to the standard output or standard
        /// error streams for CloudWatch. Valid log types include STEP_LOGS, SPARK_DRIVER, and
        /// SPARK_EXECUTOR. Valid file names for each type include STDOUT and STDERR.
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> LogTypes
        {
            get { return this._logTypes; }
            set { this._logTypes = value; }
        }

        // Check to see if LogTypes property is set
        internal bool IsSetLogTypes()
        {
            return this._logTypes != null && (this._logTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}