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
    public partial class EnableLoggingResult
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


        /// <summary>
        /// Sets the BucketName property
        /// </summary>
        /// <param name="bucketName">The value to set for the BucketName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnableLoggingResult WithBucketName(string bucketName)
        {
            this._bucketName = bucketName;
            return this;
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }


        /// <summary>
        /// Gets and sets the property LastFailureMessage. 
        /// <para>
        ///             The message indicating that logs failed to be delivered.        
        /// </para>
        /// </summary>
        public string LastFailureMessage
        {
            get { return this._lastFailureMessage; }
            set { this._lastFailureMessage = value; }
        }


        /// <summary>
        /// Sets the LastFailureMessage property
        /// </summary>
        /// <param name="lastFailureMessage">The value to set for the LastFailureMessage property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnableLoggingResult WithLastFailureMessage(string lastFailureMessage)
        {
            this._lastFailureMessage = lastFailureMessage;
            return this;
        }

        // Check to see if LastFailureMessage property is set
        internal bool IsSetLastFailureMessage()
        {
            return this._lastFailureMessage != null;
        }


        /// <summary>
        /// Gets and sets the property LastFailureTime. 
        /// <para>
        ///             The last time when logs failed to be delivered.        
        /// </para>
        /// </summary>
        public DateTime LastFailureTime
        {
            get { return this._lastFailureTime.GetValueOrDefault(); }
            set { this._lastFailureTime = value; }
        }


        /// <summary>
        /// Sets the LastFailureTime property
        /// </summary>
        /// <param name="lastFailureTime">The value to set for the LastFailureTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnableLoggingResult WithLastFailureTime(DateTime lastFailureTime)
        {
            this._lastFailureTime = lastFailureTime;
            return this;
        }

        // Check to see if LastFailureTime property is set
        internal bool IsSetLastFailureTime()
        {
            return this._lastFailureTime.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property LastSuccessfulDeliveryTime. 
        /// <para>
        ///             The last time when logs were delivered.        
        /// </para>
        /// </summary>
        public DateTime LastSuccessfulDeliveryTime
        {
            get { return this._lastSuccessfulDeliveryTime.GetValueOrDefault(); }
            set { this._lastSuccessfulDeliveryTime = value; }
        }


        /// <summary>
        /// Sets the LastSuccessfulDeliveryTime property
        /// </summary>
        /// <param name="lastSuccessfulDeliveryTime">The value to set for the LastSuccessfulDeliveryTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnableLoggingResult WithLastSuccessfulDeliveryTime(DateTime lastSuccessfulDeliveryTime)
        {
            this._lastSuccessfulDeliveryTime = lastSuccessfulDeliveryTime;
            return this;
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


        /// <summary>
        /// Sets the LoggingEnabled property
        /// </summary>
        /// <param name="loggingEnabled">The value to set for the LoggingEnabled property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnableLoggingResult WithLoggingEnabled(bool loggingEnabled)
        {
            this._loggingEnabled = loggingEnabled;
            return this;
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


        /// <summary>
        /// Sets the S3KeyPrefix property
        /// </summary>
        /// <param name="s3KeyPrefix">The value to set for the S3KeyPrefix property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnableLoggingResult WithS3KeyPrefix(string s3KeyPrefix)
        {
            this._s3KeyPrefix = s3KeyPrefix;
            return this;
        }

        // Check to see if S3KeyPrefix property is set
        internal bool IsSetS3KeyPrefix()
        {
            return this._s3KeyPrefix != null;
        }

    }
}