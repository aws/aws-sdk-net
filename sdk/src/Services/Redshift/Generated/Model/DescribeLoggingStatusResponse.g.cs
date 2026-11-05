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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// This is the response object from the DescribeLoggingStatus operation.
    /// </summary>
    public partial class DescribeLoggingStatusResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the S3 bucket where the log files are stored.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string BucketName { get; set; }

        /// <summary>
        /// Checks to see if the BucketName property is set.
        /// </summary>
        internal bool IsSetBucketName() => this.BucketName != null;

        /// <summary>
        /// Gets and sets the property LastFailureMessage. 
        /// <para>
        /// The message indicating that logs failed to be delivered.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
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
        /// </summary>
        public DateTime? LastFailureTime { get; set; }

        /// <summary>
        /// Checks to see if the LastFailureTime property is set.
        /// </summary>
        internal bool IsSetLastFailureTime() => this.LastFailureTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastSuccessfulDeliveryTime. 
        /// <para>
        /// The last time that logs were delivered.
        /// </para>
        /// </summary>
        public DateTime? LastSuccessfulDeliveryTime { get; set; }

        /// <summary>
        /// Checks to see if the LastSuccessfulDeliveryTime property is set.
        /// </summary>
        internal bool IsSetLastSuccessfulDeliveryTime() => this.LastSuccessfulDeliveryTime.HasValue;

        /// <summary>
        /// Gets and sets the property LogDestinationType. 
        /// <para>
        /// The log destination type. An enum with possible values of <c>s3</c>, <c>cloudwatch</c>,
        /// and <c>s3table</c>.
        /// </para>
        /// </summary>
        public LogDestinationType LogDestinationType { get; set; }

        /// <summary>
        /// Checks to see if the LogDestinationType property is set.
        /// </summary>
        internal bool IsSetLogDestinationType() => this.LogDestinationType != null;

        /// <summary>
        /// Gets and sets the property LogExports. 
        /// <para>
        /// The collection of exported log types. When <c>LogDestinationType</c> is <c>s3</c>
        /// or <c>cloudwatch</c>, possible values are <c>connectionlog</c>, <c>useractivitylog</c>,
        /// and <c>userlog</c>. When <c>LogDestinationType</c> is <c>s3table</c>, the values are
        /// the names of the system tables being published.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LogExports { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LogExports property is set.
        /// </summary>
        internal bool IsSetLogExports() => this.LogExports != null && (this.LogExports.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LoggingEnabled. 
        /// <para>
        ///  <c>true</c> if logging is on, <c>false</c> if logging is off.
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
        /// The prefix applied to the log file names.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string S3KeyPrefix { get; set; }

        /// <summary>
        /// Checks to see if the S3KeyPrefix property is set.
        /// </summary>
        internal bool IsSetS3KeyPrefix() => this.S3KeyPrefix != null;

        /// <summary>
        /// Gets and sets the property S3Tables. 
        /// <para>
        /// The status of system table publishing to S3 Tables. This field is populated only when
        /// system table publishing is active.
        /// </para>
        /// </summary>
        public S3TablePublishStatus S3Tables { get; set; }

        /// <summary>
        /// Checks to see if the S3Tables property is set.
        /// </summary>
        internal bool IsSetS3Tables() => this.S3Tables != null;
    }
}
