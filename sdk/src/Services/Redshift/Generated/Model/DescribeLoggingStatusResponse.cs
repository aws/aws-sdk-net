/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes the status of logging for a cluster.
    /// </summary>
    public partial class DescribeLoggingStatusResponse : AmazonWebServiceResponse
    {
        private string _bucketName;
        private string _lastFailureMessage;
        private DateTime? _lastFailureTime;
        private DateTime? _lastSuccessfulDeliveryTime;
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
        ///  The message indicating that logs failed to be delivered. 
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
        ///  The last time when logs failed to be delivered. 
        /// </para>
        /// </summary>
        public DateTime LastFailureTime
        {
            get { return this._lastFailureTime.GetValueOrDefault(); }
            set { this._lastFailureTime = value; }
        }

        // Check to see if LastFailureTime property is set
        internal bool IsSetLastFailureTime()
        {
            return this._lastFailureTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastSuccessfulDeliveryTime. 
        /// <para>
        ///  The last time that logs were delivered. 
        /// </para>
        /// </summary>
        public DateTime LastSuccessfulDeliveryTime
        {
            get { return this._lastSuccessfulDeliveryTime.GetValueOrDefault(); }
            set { this._lastSuccessfulDeliveryTime = value; }
        }

        // Check to see if LastSuccessfulDeliveryTime property is set
        internal bool IsSetLastSuccessfulDeliveryTime()
        {
            return this._lastSuccessfulDeliveryTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LoggingEnabled. 
        /// <para>
        /// <code>true</code> if logging is on, <code>false</code> if logging is off.
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
        /// The prefix applied to the log file names.
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