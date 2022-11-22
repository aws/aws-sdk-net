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
    /// Container for the parameters to the CreateApplication operation.
    /// Creates a Kinesis Data Analytics application. For information about creating a Kinesis
    /// Data Analytics application, see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/java/getting-started.html">Creating
    /// an Application</a>.
    /// </summary>
    public partial class CreateApplicationRequest : AmazonKinesisAnalyticsV2Request
    {
        private ApplicationConfiguration _applicationConfiguration;
        private string _applicationDescription;
        private ApplicationMode _applicationMode;
        private string _applicationName;
        private List<CloudWatchLoggingOption> _cloudWatchLoggingOptions = new List<CloudWatchLoggingOption>();
        private RuntimeEnvironment _runtimeEnvironment;
        private string _serviceExecutionRole;
        private List<Tag> _tags = new List<Tag>();

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
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property ApplicationMode. 
        /// <para>
        /// Use the <code>STREAMING</code> mode to create a Kinesis Data Analytics For Flink application.
        /// To create a Kinesis Data Analytics Studio notebook, use the <code>INTERACTIVE</code>
        /// mode.
        /// </para>
        /// </summary>
        public ApplicationMode ApplicationMode
        {
            get { return this._applicationMode; }
            set { this._applicationMode = value; }
        }

        // Check to see if ApplicationMode property is set
        internal bool IsSetApplicationMode()
        {
            return this._applicationMode != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of your application (for example, <code>sample-app</code>).
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
        /// The runtime environment for the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true, Min=1, Max=2048)]
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of one or more tags to assign to the application. A tag is a key-value pair
        /// that identifies an application. Note that the maximum number of application tags includes
        /// system tags. The maximum number of user-defined application tags is 50. For more information,
        /// see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/java/how-tagging.html">Using
        /// Tagging</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}