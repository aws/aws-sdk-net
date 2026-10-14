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
    /// Container for the parameters to the DeleteApplicationCloudWatchLoggingOption operation.
    /// Deletes an Amazon CloudWatch log stream from an SQL-based Kinesis Data Analytics application.
    /// </summary>
    public partial class DeleteApplicationCloudWatchLoggingOptionRequest : AmazonKinesisAnalyticsV2Request
    {
        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The application name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property CloudWatchLoggingOptionId. 
        /// <para>
        /// The <c>CloudWatchLoggingOptionId</c> of the Amazon CloudWatch logging option to delete.
        /// You can get the <c>CloudWatchLoggingOptionId</c> by using the <a>DescribeApplication</a>
        /// operation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string CloudWatchLoggingOptionId { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLoggingOptionId property is set.
        /// </summary>
        internal bool IsSetCloudWatchLoggingOptionId() => this.CloudWatchLoggingOptionId != null;

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
        /// The version ID of the application. You must provide the <c>CurrentApplicationVersionId</c>
        /// or the <c>ConditionalToken</c>. You can retrieve the application version ID using
        /// <a>DescribeApplication</a>. For better concurrency support, use the <c>ConditionalToken</c>
        /// parameter instead of <c>CurrentApplicationVersionId</c>.
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
