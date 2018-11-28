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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteApplicationCloudWatchLoggingOption operation.
    /// Deletes an Amazon CloudWatch log stream from an Amazon Kinesis Data Analytics application.
    /// </summary>
    public partial class DeleteApplicationCloudWatchLoggingOptionRequest : AmazonKinesisAnalyticsV2Request
    {
        private string _applicationName;
        private string _cloudWatchLoggingOptionId;
        private long? _currentApplicationVersionId;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The application name.
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
        /// The <code>CloudWatchLoggingOptionId</code> of the Amazon CloudWatch logging option
        /// to delete. You can get the <code>CloudWatchLoggingOptionId</code> by using the <a>DescribeApplication</a>
        /// operation. 
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
        /// The version ID of the application. You can retrieve the application version ID using
        /// <a>DescribeApplication</a>.
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