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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteApplicationCloudWatchLoggingOption operation.
    /// Deletes an Amazon CloudWatch log stream from an SQL-based Kinesis Data Analytics application.
    /// </summary>
    public partial class DeleteApplicationCloudWatchLoggingOptionRequest : AmazonKinesisAnalyticsV2Request
    {
        private string _applicationName;
        private string _cloudWatchLoggingOptionId;
        private string _conditionalToken;
        private long? _currentApplicationVersionId;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The application name.
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
        /// Gets and sets the property CloudWatchLoggingOptionId. 
        /// <para>
        /// The <c>CloudWatchLoggingOptionId</c> of the Amazon CloudWatch logging option to delete.
        /// You can get the <c>CloudWatchLoggingOptionId</c> by using the <a>DescribeApplication</a>
        /// operation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
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
        /// Gets and sets the property ConditionalToken. 
        /// <para>
        /// A value you use to implement strong concurrency for application updates. You must
        /// provide the <c>CurrentApplicationVersionId</c> or the <c>ConditionalToken</c>. You
        /// get the application's current <c>ConditionalToken</c> using <a>DescribeApplication</a>.
        /// For better concurrency support, use the <c>ConditionalToken</c> parameter instead
        /// of <c>CurrentApplicationVersionId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string ConditionalToken
        {
            get { return this._conditionalToken; }
            set { this._conditionalToken = value; }
        }

        // Check to see if ConditionalToken property is set
        internal bool IsSetConditionalToken()
        {
            return this._conditionalToken != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentApplicationVersionId. 
        /// <para>
        /// The version ID of the application. You must provide the <c>CurrentApplicationVersionId</c>
        /// or the <c>ConditionalToken</c>. You can retrieve the application version ID using
        /// <a>DescribeApplication</a>. For better concurrency support, use the <c>ConditionalToken</c>
        /// parameter instead of <c>CurrentApplicationVersionId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=999999999)]
        public long? CurrentApplicationVersionId
        {
            get { return this._currentApplicationVersionId; }
            set { this._currentApplicationVersionId = value; }
        }

        // Check to see if CurrentApplicationVersionId property is set
        internal bool IsSetCurrentApplicationVersionId()
        {
            return this._currentApplicationVersionId.HasValue; 
        }

    }
}