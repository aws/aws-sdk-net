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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The configuration of user event logs to an external Amazon Web Services service like
    /// Amazon Data Firehose, Amazon S3, or Amazon CloudWatch Logs.
    /// </summary>
    public partial class LogConfigurationType
    {
        private CloudWatchLogsConfigurationType _cloudWatchLogsConfiguration;
        private EventSourceName _eventSource;
        private FirehoseConfigurationType _firehoseConfiguration;
        private LogLevel _logLevel;
        private S3ConfigurationType _s3Configuration;

        /// <summary>
        /// Gets and sets the property CloudWatchLogsConfiguration. 
        /// <para>
        /// The CloudWatch log group destination of user pool detailed activity logs, or of user
        /// activity log export with threat protection.
        /// </para>
        /// </summary>
        public CloudWatchLogsConfigurationType CloudWatchLogsConfiguration
        {
            get { return this._cloudWatchLogsConfiguration; }
            set { this._cloudWatchLogsConfiguration = value; }
        }

        // Check to see if CloudWatchLogsConfiguration property is set
        internal bool IsSetCloudWatchLogsConfiguration()
        {
            return this._cloudWatchLogsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property EventSource. 
        /// <para>
        /// The source of events that your user pool sends for logging. To send error-level logs
        /// about user notification activity, set to <c>userNotification</c>. To send info-level
        /// logs about threat-protection user activity in user pools with the Plus feature plan,
        /// set to <c>userAuthEvents</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EventSourceName EventSource
        {
            get { return this._eventSource; }
            set { this._eventSource = value; }
        }

        // Check to see if EventSource property is set
        internal bool IsSetEventSource()
        {
            return this._eventSource != null;
        }

        /// <summary>
        /// Gets and sets the property FirehoseConfiguration. 
        /// <para>
        /// The Amazon Data Firehose stream destination of user activity log export with threat
        /// protection. To activate this setting, your user pool must be on the <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/feature-plans-features-plus.html">
        /// Plus tier</a>.
        /// </para>
        /// </summary>
        public FirehoseConfigurationType FirehoseConfiguration
        {
            get { return this._firehoseConfiguration; }
            set { this._firehoseConfiguration = value; }
        }

        // Check to see if FirehoseConfiguration property is set
        internal bool IsSetFirehoseConfiguration()
        {
            return this._firehoseConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LogLevel. 
        /// <para>
        /// The <c>errorlevel</c> selection of logs that a user pool sends for detailed activity
        /// logging. To send <c>userNotification</c> activity with <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/exporting-quotas-and-usage.html">information
        /// about message delivery</a>, choose <c>ERROR</c> with <c>CloudWatchLogsConfiguration</c>.
        /// To send <c>userAuthEvents</c> activity with user logs from threat protection with
        /// the Plus feature plan, choose <c>INFO</c> with one of <c>CloudWatchLogsConfiguration</c>,
        /// <c>FirehoseConfiguration</c>, or <c>S3Configuration</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LogLevel LogLevel
        {
            get { return this._logLevel; }
            set { this._logLevel = value; }
        }

        // Check to see if LogLevel property is set
        internal bool IsSetLogLevel()
        {
            return this._logLevel != null;
        }

        /// <summary>
        /// Gets and sets the property S3Configuration. 
        /// <para>
        /// The Amazon S3 bucket destination of user activity log export with threat protection.
        /// To activate this setting, your user pool must be on the <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/feature-plans-features-plus.html">
        /// Plus tier</a>.
        /// </para>
        /// </summary>
        public S3ConfigurationType S3Configuration
        {
            get { return this._s3Configuration; }
            set { this._s3Configuration = value; }
        }

        // Check to see if S3Configuration property is set
        internal bool IsSetS3Configuration()
        {
            return this._s3Configuration != null;
        }

    }
}