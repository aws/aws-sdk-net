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

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Container for the parameters to the AddApplicationCloudWatchLoggingOption operation.
    /// Adds an Amazon CloudWatch log stream to monitor application configuration errors.
    /// </summary>
    public partial class AddApplicationCloudWatchLoggingOptionRequest : AmazonKinesisAnalyticsV2Request
    {
        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The Kinesis Data Analytics application name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property CloudWatchLoggingOption. 
        /// <para>
        /// Provides the Amazon CloudWatch log stream Amazon Resource Name (ARN). 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CloudWatchLoggingOption CloudWatchLoggingOption { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLoggingOption property is set.
        /// </summary>
        internal bool IsSetCloudWatchLoggingOption() => this.CloudWatchLoggingOption != null;

        /// <summary>
        /// Gets and sets the property ConditionalToken. 
        /// <para>
        /// A value you use to implement strong concurrency for application updates. You must
        /// provide the <c>CurrentApplicationVersionId</c> or the <c>ConditionalToken</c>. You
        /// get the application's current <c>ConditionalToken</c> using <a>DescribeApplication</a>.
        /// For better concurrency support, use the <c>ConditionalToken</c> parameter instead
        /// of <c>CurrentApplicationVersionId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string ConditionalToken { get; set; }

        /// <summary>
        /// Checks to see if the ConditionalToken property is set.
        /// </summary>
        internal bool IsSetConditionalToken() => this.ConditionalToken != null;

        /// <summary>
        /// Gets and sets the property CurrentApplicationVersionId. 
        /// <para>
        /// The version ID of the SQL-based Kinesis Data Analytics application. You must provide
        /// the <c>CurrentApplicationVersionId</c> or the <c>ConditionalToken</c>.You can retrieve
        /// the application version ID using <a>DescribeApplication</a>. For better concurrency
        /// support, use the <c>ConditionalToken</c> parameter instead of <c>CurrentApplicationVersionId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 999999999)]
        public long? CurrentApplicationVersionId { get; set; }

        /// <summary>
        /// Checks to see if the CurrentApplicationVersionId property is set.
        /// </summary>
        internal bool IsSetCurrentApplicationVersionId() => this.CurrentApplicationVersionId.HasValue;
    }
}
