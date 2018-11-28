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
    /// Container for the parameters to the CreateApplication operation.
    /// Creates an Amazon Kinesis Data Analytics application. For information about creating
    /// a Kinesis Data Analytics application, see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/Java/creating-app.html">Creating
    /// an Application</a>. 
    /// 
    ///  <note> 
    /// <para>
    /// SQL is not enabled for this private beta release. Using SQL parameters (such as <a>SqlApplicationConfiguration</a>)
    /// will result in an error.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateApplicationRequest : AmazonKinesisAnalyticsV2Request
    {
        private ApplicationConfiguration _applicationConfiguration;
        private string _applicationDescription;
        private string _applicationName;
        private List<CloudWatchLoggingOption> _cloudWatchLoggingOptions = new List<CloudWatchLoggingOption>();
        private RuntimeEnvironment _runtimeEnvironment;
        private string _serviceExecutionRole;

        /// <summary>
        /// Gets and sets the property ApplicationConfiguration. 
        /// <para>
        /// Use this parameter to configure the application.
        /// </para>
        /// </summary>
        public ApplicationConfiguration ApplicationConfiguration
        {
            get { return this._applicationConfiguration; }
            set { this._applicationConfiguration = value; }
        }

        // Check to see if ApplicationConfiguration property is set
        internal bool IsSetApplicationConfiguration()
        {
            return this._applicationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationDescription. 
        /// <para>
        /// A summary description of the application.
        /// </para>
        /// </summary>
        public string ApplicationDescription
        {
            get { return this._applicationDescription; }
            set { this._applicationDescription = value; }
        }

        // Check to see if ApplicationDescription property is set
        internal bool IsSetApplicationDescription()
        {
            return this._applicationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of your application (for example, <code>sample-app</code>).
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
        /// Gets and sets the property CloudWatchLoggingOptions. 
        /// <para>
        /// Use this parameter to configure an Amazon CloudWatch log stream to monitor application
        /// configuration errors. 
        /// </para>
        /// </summary>
        public List<CloudWatchLoggingOption> CloudWatchLoggingOptions
        {
            get { return this._cloudWatchLoggingOptions; }
            set { this._cloudWatchLoggingOptions = value; }
        }

        // Check to see if CloudWatchLoggingOptions property is set
        internal bool IsSetCloudWatchLoggingOptions()
        {
            return this._cloudWatchLoggingOptions != null && this._cloudWatchLoggingOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RuntimeEnvironment. 
        /// <para>
        /// The runtime environment for the application (<code>SQL-1.0</code> or <code>JAVA-8-FLINK-1.5</code>).
        /// </para>
        /// </summary>
        public RuntimeEnvironment RuntimeEnvironment
        {
            get { return this._runtimeEnvironment; }
            set { this._runtimeEnvironment = value; }
        }

        // Check to see if RuntimeEnvironment property is set
        internal bool IsSetRuntimeEnvironment()
        {
            return this._runtimeEnvironment != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceExecutionRole. 
        /// <para>
        /// The IAM role used by the application to access Kinesis data streams, Kinesis Data
        /// Firehose delivery streams, Amazon S3 objects, and other external resources.
        /// </para>
        /// </summary>
        public string ServiceExecutionRole
        {
            get { return this._serviceExecutionRole; }
            set { this._serviceExecutionRole = value; }
        }

        // Check to see if ServiceExecutionRole property is set
        internal bool IsSetServiceExecutionRole()
        {
            return this._serviceExecutionRole != null;
        }

    }
}