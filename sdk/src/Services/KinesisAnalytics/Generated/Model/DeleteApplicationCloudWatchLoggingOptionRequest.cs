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
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteApplicationCloudWatchLoggingOption operation.
    /// Deletes a CloudWatch log stream from an application. For more information about using
    /// CloudWatch log streams with Amazon Kinesis Analytics applications, see <a href="http://docs.aws.amazon.com/kinesisanalytics/latest/dev/cloudwatch-monitor-configuration.html">Monitoring
    /// Configuration Errors</a>.
    /// </summary>
    public partial class DeleteApplicationCloudWatchLoggingOptionRequest : AmazonKinesisAnalyticsRequest
    {
        private string _applicationName;
        private string _cloudWatchLoggingOptionId;
        private long? _currentApplicationVersionId;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The Amazon Kinesis Analytics application name.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CloudWatchLoggingOptionId. 
        /// <para>
        /// The <code>CloudWatchLoggingOptionId</code> of the CloudWatch logging option to delete.
        /// You can use the <a>DescribeApplication</a> operation to get the <code>CloudWatchLoggingOptionId</code>.
        /// 
        /// </para>
        /// </summary>
        public string CloudWatchLoggingOptionId
        {
            get { return this._cloudWatchLoggingOptionId; }
            set { this._cloudWatchLoggingOptionId = value; }
        }

        // Check to see if CloudWatchLoggingOptionId property is set
        internal bool IsSetCloudWatchLoggingOptionId()
        {
            return this._cloudWatchLoggingOptionId != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentApplicationVersionId. 
        /// <para>
        /// The version ID of the Amazon Kinesis Analytics application.
        /// </para>
        /// </summary>
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