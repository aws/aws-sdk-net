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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
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
namespace Amazon.Athena.Model
{
    /// <summary>
    /// Configuration settings for delivering logs to Amazon S3 buckets.
    /// </summary>
    public partial class S3LoggingConfiguration
    {
        private bool? _enabled;
        private string _kmsKey;
        private string _logLocation;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Enables S3 log delivery.
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
        /// Gets and sets the property KmsKey. 
        /// <para>
        /// The KMS key ARN to encrypt the logs published to the given Amazon S3 destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKey
        {
            get { return this._kmsKey; }
            set { this._kmsKey = value; }
        }

        // Check to see if KmsKey property is set
        internal bool IsSetKmsKey()
        {
            return this._kmsKey != null;
        }

        /// <summary>
        /// Gets and sets the property LogLocation. 
        /// <para>
        /// The Amazon S3 destination URI for log publishing.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string LogLocation
        {
            get { return this._logLocation; }
            set { this._logLocation = value; }
        }

        // Check to see if LogLocation property is set
        internal bool IsSetLogLocation()
        {
            return this._logLocation != null;
        }

    }
}