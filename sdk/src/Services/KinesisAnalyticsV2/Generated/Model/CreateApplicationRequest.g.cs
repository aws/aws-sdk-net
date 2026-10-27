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
    /// Container for the parameters to the CreateApplication operation. Creates a Managed
    /// Service for Apache Flink application. For information about creating a Managed Service
    /// for Apache Flink application, see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/java/getting-started.html">Creating
    /// an Application</a>.
    /// </summary>
    public partial class CreateApplicationRequest : AmazonKinesisAnalyticsV2Request
    {
        /// <summary>
        /// Gets and sets the property ApplicationConfiguration. 
        /// <para>
        /// Use this parameter to configure the application.
        /// </para>
        /// </summary>
        public ApplicationConfiguration ApplicationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationConfiguration property is set.
        /// </summary>
        internal bool IsSetApplicationConfiguration() => this.ApplicationConfiguration != null;

        /// <summary>
        /// Gets and sets the property ApplicationDescription. 
        /// <para>
        /// A summary description of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ApplicationDescription { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationDescription property is set.
        /// </summary>
        internal bool IsSetApplicationDescription() => this.ApplicationDescription != null;

        /// <summary>
        /// Gets and sets the property ApplicationMode. 
        /// <para>
        /// Use the <c>STREAMING</c> mode to create a Managed Service for Apache Flink application.
        /// To create a Managed Service for Apache Flink Studio notebook, use the <c>INTERACTIVE</c>
        /// mode.
        /// </para>
        /// </summary>
        public ApplicationMode ApplicationMode { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationMode property is set.
        /// </summary>
        internal bool IsSetApplicationMode() => this.ApplicationMode != null;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of your application (for example, <c>sample-app</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property CloudWatchLoggingOptions. 
        /// <para>
        /// Use this parameter to configure an Amazon CloudWatch log stream to monitor application
        /// configuration errors. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CloudWatchLoggingOption> CloudWatchLoggingOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<CloudWatchLoggingOption>() : null;

        /// <summary>
        /// Checks to see if the CloudWatchLoggingOptions property is set.
        /// </summary>
        internal bool IsSetCloudWatchLoggingOptions() => this.CloudWatchLoggingOptions != null && (this.CloudWatchLoggingOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RuntimeEnvironment. 
        /// <para>
        /// The runtime environment for the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RuntimeEnvironment RuntimeEnvironment { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeEnvironment property is set.
        /// </summary>
        internal bool IsSetRuntimeEnvironment() => this.RuntimeEnvironment != null;

        /// <summary>
        /// Gets and sets the property ServiceExecutionRole. 
        /// <para>
        /// The IAM role used by the application to access Kinesis data streams, Kinesis Data
        /// Firehose delivery streams, Amazon S3 objects, and other external resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ServiceExecutionRole { get; set; }

        /// <summary>
        /// Checks to see if the ServiceExecutionRole property is set.
        /// </summary>
        internal bool IsSetServiceExecutionRole() => this.ServiceExecutionRole != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of one or more tags to assign to the application. A tag is a key-value pair
        /// that identifies an application. Note that the maximum number of application tags includes
        /// system tags. The maximum number of user-defined application tags is 50. For more information,
        /// see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/java/how-tagging.html">Using
        /// Tagging</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
