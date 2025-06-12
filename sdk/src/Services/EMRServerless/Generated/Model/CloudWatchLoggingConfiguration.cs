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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
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
namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// The Amazon CloudWatch configuration for monitoring logs. You can configure your jobs
    /// to send log information to CloudWatch.
    /// </summary>
    public partial class CloudWatchLoggingConfiguration
    {
        private bool? _enabled;
        private string _encryptionKeyArn;
        private string _logGroupName;
        private string _logStreamNamePrefix;
        private Dictionary<string, List<string>> _logTypes = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Enables CloudWatch logging.
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
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The Key Management Service (KMS) key ARN to encrypt the logs that you store in CloudWatch
        /// Logs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// The name of the log group in Amazon CloudWatch Logs where you want to publish your
        /// logs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
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
        /// Prefix for the CloudWatch log stream name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
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
        /// The types of logs that you want to publish to CloudWatch. If you don't specify any
        /// log types, driver STDOUT and STDERR logs will be published to CloudWatch Logs by default.
        /// For more information including the supported worker types for Hive and Spark, see
        /// <a href="https://docs.aws.amazon.com/emr/latest/EMR-Serverless-UserGuide/logging.html#jobs-log-storage-cw">Logging
        /// for EMR Serverless with CloudWatch</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Key Valid Values</b>: <c>SPARK_DRIVER</c>, <c>SPARK_EXECUTOR</c>, <c>HIVE_DRIVER</c>,
        /// <c>TEZ_TASK</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Array Members Valid Values</b>: <c>STDOUT</c>, <c>STDERR</c>, <c>HIVE_LOG</c>,
        /// <c>TEZ_AM</c>, <c>SYSTEM_LOGS</c> 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
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