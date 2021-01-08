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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Container for the parameters to the AddApplicationCloudWatchLoggingOption operation.
    /// Adds an Amazon CloudWatch log stream to monitor application configuration errors.
    /// </summary>
    public partial class AddApplicationCloudWatchLoggingOptionRequest : AmazonKinesisAnalyticsV2Request
    {
        private string _applicationName;
        private CloudWatchLoggingOption _cloudWatchLoggingOption;
        private long? _currentApplicationVersionId;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The Kinesis Data Analytics application name.
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
        /// Provides the Amazon CloudWatch log stream Amazon Resource Name (ARN). 
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
        /// The version ID of the Kinesis Data Analytics application. You can retrieve the application
        /// version ID using <a>DescribeApplication</a>.
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