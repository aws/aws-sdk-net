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
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// Container for the parameters to the AddApplicationCloudWatchLoggingOption operation.
    /// <note> 
    /// <para>
    /// This documentation is for version 1 of the Amazon Kinesis Data Analytics API, which
    /// only supports SQL applications. Version 2 of the API supports SQL and Java applications.
    /// For more information about version 2, see <a href="/kinesisanalytics/latest/apiv2/Welcome.html">Amazon
    /// Kinesis Data Analytics API V2 Documentation</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// Adds a CloudWatch log stream to monitor application configuration errors. For more
    /// information about using CloudWatch log streams with Amazon Kinesis Analytics applications,
    /// see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/cloudwatch-logs.html">Working
    /// with Amazon CloudWatch Logs</a>.
    /// </para>
    /// </summary>
    public partial class AddApplicationCloudWatchLoggingOptionRequest : AmazonKinesisAnalyticsRequest
    {
        private string _applicationName;
        private CloudWatchLoggingOption _cloudWatchLoggingOption;
        private long? _currentApplicationVersionId;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The Kinesis Analytics application name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }

        /// <summary>
        /// Gets and sets the property CloudWatchLoggingOption. 
        /// <para>
        /// Provides the CloudWatch log stream Amazon Resource Name (ARN) and the IAM role ARN.
        /// Note: To write application messages to CloudWatch, the IAM role that is used must
        /// have the <code>PutLogEvents</code> policy action enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CloudWatchLoggingOption CloudWatchLoggingOption
        {
            get { return this._cloudWatchLoggingOption; }
            set { this._cloudWatchLoggingOption = value; }
        }

        // Check to see if CloudWatchLoggingOption property is set
        internal bool IsSetCloudWatchLoggingOption()
        {
            return this._cloudWatchLoggingOption != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentApplicationVersionId. 
        /// <para>
        /// The version ID of the Kinesis Analytics application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=999999999)]
        public long CurrentApplicationVersionId
        {
            get { return this._currentApplicationVersionId.GetValueOrDefault(); }
            set { this._currentApplicationVersionId = value; }
        }

        // Check to see if CurrentApplicationVersionId property is set
        internal bool IsSetCurrentApplicationVersionId()
        {
            return this._currentApplicationVersionId.HasValue; 
        }

    }
}