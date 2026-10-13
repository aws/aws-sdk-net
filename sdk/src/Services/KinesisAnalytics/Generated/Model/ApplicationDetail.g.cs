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

namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// <note> 
    /// <para>
    /// This documentation is for version 1 of the Amazon Kinesis Data Analytics API, which
    /// only supports SQL applications. Version 2 of the API supports SQL and Java applications.
    /// For more information about version 2, see <a href="/kinesisanalytics/latest/apiv2/Welcome.html">Amazon
    /// Kinesis Data Analytics API V2 Documentation</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// Provides a description of the application, including the application Amazon Resource
    /// Name (ARN), status, latest version, and input and output configuration.
    /// </para>
    /// </summary>
    public partial class ApplicationDetail
    {
        /// <summary>
        /// Gets and sets the property ApplicationARN. 
        /// <para>
        /// ARN of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ApplicationARN { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationARN property is set.
        /// </summary>
        internal bool IsSetApplicationARN() => this.ApplicationARN != null;

        /// <summary>
        /// Gets and sets the property ApplicationCode. 
        /// <para>
        /// Returns the application code that you provided to perform data analysis on any of
        /// the in-application streams in your application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 102400)]
        public string ApplicationCode { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationCode property is set.
        /// </summary>
        internal bool IsSetApplicationCode() => this.ApplicationCode != null;

        /// <summary>
        /// Gets and sets the property ApplicationDescription. 
        /// <para>
        /// Description of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ApplicationDescription { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationDescription property is set.
        /// </summary>
        internal bool IsSetApplicationDescription() => this.ApplicationDescription != null;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// Name of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property ApplicationStatus. 
        /// <para>
        /// Status of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ApplicationStatus ApplicationStatus { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationStatus property is set.
        /// </summary>
        internal bool IsSetApplicationStatus() => this.ApplicationStatus != null;

        /// <summary>
        /// Gets and sets the property ApplicationVersionId. 
        /// <para>
        /// Provides the current application version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 999999999)]
        public long? ApplicationVersionId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationVersionId property is set.
        /// </summary>
        internal bool IsSetApplicationVersionId() => this.ApplicationVersionId.HasValue;

        /// <summary>
        /// Gets and sets the property CloudWatchLoggingOptionDescriptions. 
        /// <para>
        /// Describes the CloudWatch log streams that are configured to receive application messages.
        /// For more information about using CloudWatch log streams with Amazon Kinesis Analytics
        /// applications, see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/cloudwatch-logs.html">Working
        /// with Amazon CloudWatch Logs</a>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CloudWatchLoggingOptionDescription> CloudWatchLoggingOptionDescriptions { get; set; } = AWSConfigs.InitializeCollections ? new List<CloudWatchLoggingOptionDescription>() : null;

        /// <summary>
        /// Checks to see if the CloudWatchLoggingOptionDescriptions property is set.
        /// </summary>
        internal bool IsSetCloudWatchLoggingOptionDescriptions() => this.CloudWatchLoggingOptionDescriptions != null && (this.CloudWatchLoggingOptionDescriptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreateTimestamp. 
        /// <para>
        /// Time stamp when the application version was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreateTimestamp property is set.
        /// </summary>
        internal bool IsSetCreateTimestamp() => this.CreateTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property InputDescriptions. 
        /// <para>
        /// Describes the application input configuration. For more information, see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-it-works-input.html">Configuring
        /// Application Input</a>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InputDescription> InputDescriptions { get; set; } = AWSConfigs.InitializeCollections ? new List<InputDescription>() : null;

        /// <summary>
        /// Checks to see if the InputDescriptions property is set.
        /// </summary>
        internal bool IsSetInputDescriptions() => this.InputDescriptions != null && (this.InputDescriptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastUpdateTimestamp. 
        /// <para>
        /// Time stamp when the application was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateTimestamp property is set.
        /// </summary>
        internal bool IsSetLastUpdateTimestamp() => this.LastUpdateTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property OutputDescriptions. 
        /// <para>
        /// Describes the application output configuration. For more information, see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-it-works-output.html">Configuring
        /// Application Output</a>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OutputDescription> OutputDescriptions { get; set; } = AWSConfigs.InitializeCollections ? new List<OutputDescription>() : null;

        /// <summary>
        /// Checks to see if the OutputDescriptions property is set.
        /// </summary>
        internal bool IsSetOutputDescriptions() => this.OutputDescriptions != null && (this.OutputDescriptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReferenceDataSourceDescriptions. 
        /// <para>
        /// Describes reference data sources configured for the application. For more information,
        /// see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-it-works-input.html">Configuring
        /// Application Input</a>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReferenceDataSourceDescription> ReferenceDataSourceDescriptions { get; set; } = AWSConfigs.InitializeCollections ? new List<ReferenceDataSourceDescription>() : null;

        /// <summary>
        /// Checks to see if the ReferenceDataSourceDescriptions property is set.
        /// </summary>
        internal bool IsSetReferenceDataSourceDescriptions() => this.ReferenceDataSourceDescriptions != null && (this.ReferenceDataSourceDescriptions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
