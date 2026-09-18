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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Provides information about the logging status of the cluster.
    /// </summary>
    public partial class AwsRedshiftClusterLoggingStatus
    {
        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the S3 bucket where the log files are stored.
        /// </para>
        /// </summary>
        public string BucketName { get; set; }

        /// <summary>
        /// Checks to see if the BucketName property is set.
        /// </summary>
        internal bool IsSetBucketName() => this.BucketName != null;

        /// <summary>
        /// Gets and sets the property LastFailureMessage. 
        /// <para>
        /// The message indicating that the logs failed to be delivered.
        /// </para>
        /// </summary>
        public string LastFailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the LastFailureMessage property is set.
        /// </summary>
        internal bool IsSetLastFailureMessage() => this.LastFailureMessage != null;

        /// <summary>
        /// Gets and sets the property LastFailureTime. 
        /// <para>
        /// The last time when logs failed to be delivered.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string LastFailureTime { get; set; }

        /// <summary>
        /// Checks to see if the LastFailureTime property is set.
        /// </summary>
        internal bool IsSetLastFailureTime() => this.LastFailureTime != null;

        /// <summary>
        /// Gets and sets the property LastSuccessfulDeliveryTime. 
        /// <para>
        /// The last time that logs were delivered successfully.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string LastSuccessfulDeliveryTime { get; set; }

        /// <summary>
        /// Checks to see if the LastSuccessfulDeliveryTime property is set.
        /// </summary>
        internal bool IsSetLastSuccessfulDeliveryTime() => this.LastSuccessfulDeliveryTime != null;

        /// <summary>
        /// Gets and sets the property LoggingEnabled. 
        /// <para>
        /// Indicates whether logging is enabled.
        /// </para>
        /// </summary>
        public bool? LoggingEnabled { get; set; }

        /// <summary>
        /// Checks to see if the LoggingEnabled property is set.
        /// </summary>
        internal bool IsSetLoggingEnabled() => this.LoggingEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property S3KeyPrefix. 
        /// <para>
        /// Provides the prefix applied to the log file names.
        /// </para>
        /// </summary>
        public string S3KeyPrefix { get; set; }

        /// <summary>
        /// Checks to see if the S3KeyPrefix property is set.
        /// </summary>
        internal bool IsSetS3KeyPrefix() => this.S3KeyPrefix != null;
    }
}
