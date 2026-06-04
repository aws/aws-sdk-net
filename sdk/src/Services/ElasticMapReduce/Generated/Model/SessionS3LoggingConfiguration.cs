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
    /// The Amazon S3 logging configuration for a session.
    /// </summary>
    public partial class SessionS3LoggingConfiguration
    {
        private bool? _enabled;
        private string _encryptionKeyArn;
        private Dictionary<string, List<string>> _logTypes = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private string _logUri;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether Amazon S3 logging is enabled for the session.
        /// </para>
        /// </summary>
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
        /// The Amazon Resource Name (ARN) of the KMS key used to encrypt logs published to Amazon
        /// S3.
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
        /// Gets and sets the property LogTypes. 
        /// <para>
        /// A map of log component names (for example, <c>SPARK_DRIVER</c>, <c>SPARK_EXECUTOR</c>)
        /// to the list of log types to publish for that component (for example, <c>stdout</c>,
        /// <c>stderr</c>).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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

        /// <summary>
        /// Gets and sets the property LogUri. 
        /// <para>
        /// The Amazon S3 destination URI where session logs are published.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10280)]
        public string LogUri
        {
            get { return this._logUri; }
            set { this._logUri = value; }
        }

        // Check to see if LogUri property is set
        internal bool IsSetLogUri()
        {
            return this._logUri != null;
        }

    }
}