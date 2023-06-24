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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides information about the logging status of the cluster.
    /// </summary>
    public partial class AwsRedshiftClusterLoggingStatus
    {
        private string _bucketName;
        private string _lastFailureMessage;
        private string _lastFailureTime;
        private string _lastSuccessfulDeliveryTime;
        private bool? _loggingEnabled;
        private string _s3KeyPrefix;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the S3 bucket where the log files are stored.
        /// </para>
        /// </summary>
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property LastFailureMessage. 
        /// <para>
        /// The message indicating that the logs failed to be delivered.
        /// </para>
        /// </summary>
        public string LastFailureMessage
        {
            get { return this._lastFailureMessage; }
            set { this._lastFailureMessage = value; }
        }

        // Check to see if LastFailureMessage property is set
        internal bool IsSetLastFailureMessage()
        {
            return this._lastFailureMessage != null;
        }

        /// <summary>
        /// Gets and sets the property LastFailureTime. 
        /// <para>
        /// The last time when logs failed to be delivered.
        /// </para>
        ///  
        /// <para>
        /// Uses the <code>date-time</code> format specified in <a href="https://tools.ietf.org/html/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>. The value cannot contain spaces,
        /// and date and time should be separated by <code>T</code>. For example, <code>2020-03-22T13:22:13.933Z</code>.
        /// </para>
        /// </summary>
        public string LastFailureTime
        {
            get { return this._lastFailureTime; }
            set { this._lastFailureTime = value; }
        }

        // Check to see if LastFailureTime property is set
        internal bool IsSetLastFailureTime()
        {
            return this._lastFailureTime != null;
        }

        /// <summary>
        /// Gets and sets the property LastSuccessfulDeliveryTime. 
        /// <para>
        /// The last time that logs were delivered successfully.
        /// </para>
        ///  
        /// <para>
        /// Uses the <code>date-time</code> format specified in <a href="https://tools.ietf.org/html/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>. The value cannot contain spaces,
        /// and date and time should be separated by <code>T</code>. For example, <code>2020-03-22T13:22:13.933Z</code>.
        /// </para>
        /// </summary>
        public string LastSuccessfulDeliveryTime
        {
            get { return this._lastSuccessfulDeliveryTime; }
            set { this._lastSuccessfulDeliveryTime = value; }
        }

        // Check to see if LastSuccessfulDeliveryTime property is set
        internal bool IsSetLastSuccessfulDeliveryTime()
        {
            return this._lastSuccessfulDeliveryTime != null;
        }

        /// <summary>
        /// Gets and sets the property LoggingEnabled. 
        /// <para>
        /// Indicates whether logging is enabled.
        /// </para>
        /// </summary>
        public bool LoggingEnabled
        {
            get { return this._loggingEnabled.GetValueOrDefault(); }
            set { this._loggingEnabled = value; }
        }

        // Check to see if LoggingEnabled property is set
        internal bool IsSetLoggingEnabled()
        {
            return this._loggingEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property S3KeyPrefix. 
        /// <para>
        /// Provides the prefix applied to the log file names.
        /// </para>
        /// </summary>
        public string S3KeyPrefix
        {
            get { return this._s3KeyPrefix; }
            set { this._s3KeyPrefix = value; }
        }

        // Check to see if S3KeyPrefix property is set
        internal bool IsSetS3KeyPrefix()
        {
            return this._s3KeyPrefix != null;
        }

    }
}