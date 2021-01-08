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
    /// Description of the CloudWatch logging option.
    /// </summary>
    public partial class CloudWatchLoggingOptionDescription
    {
        private string _cloudWatchLoggingOptionId;
        private string _logStreamARN;
        private string _roleARN;

        /// <summary>
        /// Gets and sets the property CloudWatchLoggingOptionId. 
        /// <para>
        /// ID of the CloudWatch logging option description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// Gets and sets the property LogStreamARN. 
        /// <para>
        /// ARN of the CloudWatch log to receive application messages.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string LogStreamARN
        {
            get { return this._logStreamARN; }
            set { this._logStreamARN = value; }
        }

        // Check to see if LogStreamARN property is set
        internal bool IsSetLogStreamARN()
        {
            return this._logStreamARN != null;
        }

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// IAM ARN of the role to use to send application messages. Note: To write application
        /// messages to CloudWatch, the IAM role used must have the <code>PutLogEvents</code>
        /// policy action enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string RoleARN
        {
            get { return this._roleARN; }
            set { this._roleARN = value; }
        }

        // Check to see if RoleARN property is set
        internal bool IsSetRoleARN()
        {
            return this._roleARN != null;
        }

    }
}