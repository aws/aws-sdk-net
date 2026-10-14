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
    /// Describes the application, including the application Amazon Resource Name (ARN), status,
    /// latest version, and input and output configurations.
    /// </summary>
    public partial class ApplicationDetail
    {
        /// <summary>
        /// Gets and sets the property ApplicationARN. 
        /// <para>
        /// The ARN of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ApplicationARN { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationARN property is set.
        /// </summary>
        internal bool IsSetApplicationARN() => this.ApplicationARN != null;

        /// <summary>
        /// Gets and sets the property ApplicationConfigurationDescription. 
        /// <para>
        /// Describes details about the application code and starting parameters for a Managed
        /// Service for Apache Flink application.
        /// </para>
        /// </summary>
        public ApplicationConfigurationDescription ApplicationConfigurationDescription { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationConfigurationDescription property is set.
        /// </summary>
        internal bool IsSetApplicationConfigurationDescription() => this.ApplicationConfigurationDescription != null;

        /// <summary>
        /// Gets and sets the property ApplicationDescription. 
        /// <para>
        /// The description of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ApplicationDescription { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationDescription property is set.
        /// </summary>
        internal bool IsSetApplicationDescription() => this.ApplicationDescription != null;

        /// <summary>
        /// Gets and sets the property ApplicationMaintenanceConfigurationDescription. 
        /// <para>
        /// The details of the maintenance configuration for the application.
        /// </para>
        /// </summary>
        public ApplicationMaintenanceConfigurationDescription ApplicationMaintenanceConfigurationDescription { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationMaintenanceConfigurationDescription property is set.
        /// </summary>
        internal bool IsSetApplicationMaintenanceConfigurationDescription() => this.ApplicationMaintenanceConfigurationDescription != null;

        /// <summary>
        /// Gets and sets the property ApplicationMode. 
        /// <para>
        /// To create a Managed Service for Apache Flink Studio notebook, you must set the mode
        /// to <c>INTERACTIVE</c>. However, for a Managed Service for Apache Flink application,
        /// the mode is optional.
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
        /// The name of the application.
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
        /// The status of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ApplicationStatus ApplicationStatus { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationStatus property is set.
        /// </summary>
        internal bool IsSetApplicationStatus() => this.ApplicationStatus != null;

        /// <summary>
        /// Gets and sets the property ApplicationVersionCreateTimestamp. 
        /// <para>
        /// The timestamp that indicates when the application version was created.
        /// </para>
        /// </summary>
        public DateTime? ApplicationVersionCreateTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationVersionCreateTimestamp property is set.
        /// </summary>
        internal bool IsSetApplicationVersionCreateTimestamp() => this.ApplicationVersionCreateTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ApplicationVersionId. 
        /// <para>
        /// Provides the current application version. Managed Service for Apache Flink updates
        /// the <c>ApplicationVersionId</c> each time you update the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 999999999)]
        public long? ApplicationVersionId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationVersionId property is set.
        /// </summary>
        internal bool IsSetApplicationVersionId() => this.ApplicationVersionId.HasValue;

        /// <summary>
        /// Gets and sets the property ApplicationVersionRolledBackFrom. 
        /// <para>
        /// If you reverted the application using <a>RollbackApplication</a>, the application
        /// version when <c>RollbackApplication</c> was called.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 999999999)]
        public long? ApplicationVersionRolledBackFrom { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationVersionRolledBackFrom property is set.
        /// </summary>
        internal bool IsSetApplicationVersionRolledBackFrom() => this.ApplicationVersionRolledBackFrom.HasValue;

        /// <summary>
        /// Gets and sets the property ApplicationVersionRolledBackTo. 
        /// <para>
        /// The version to which you want to roll back the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 999999999)]
        public long? ApplicationVersionRolledBackTo { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationVersionRolledBackTo property is set.
        /// </summary>
        internal bool IsSetApplicationVersionRolledBackTo() => this.ApplicationVersionRolledBackTo.HasValue;

        /// <summary>
        /// Gets and sets the property ApplicationVersionUpdatedFrom. 
        /// <para>
        /// The previous application version before the latest application update. <a>RollbackApplication</a>
        /// reverts the application to this version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 999999999)]
        public long? ApplicationVersionUpdatedFrom { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationVersionUpdatedFrom property is set.
        /// </summary>
        internal bool IsSetApplicationVersionUpdatedFrom() => this.ApplicationVersionUpdatedFrom.HasValue;

        /// <summary>
        /// Gets and sets the property CloudWatchLoggingOptionDescriptions. 
        /// <para>
        /// Describes the application Amazon CloudWatch logging options.
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
        /// Gets and sets the property ConditionalToken. 
        /// <para>
        /// A value you use to implement strong concurrency for application updates.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string ConditionalToken { get; set; }

        /// <summary>
        /// Checks to see if the ConditionalToken property is set.
        /// </summary>
        internal bool IsSetConditionalToken() => this.ConditionalToken != null;

        /// <summary>
        /// Gets and sets the property CreateTimestamp. 
        /// <para>
        /// The current timestamp when the application was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreateTimestamp property is set.
        /// </summary>
        internal bool IsSetCreateTimestamp() => this.CreateTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdateTimestamp. 
        /// <para>
        /// The current timestamp when the application was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateTimestamp property is set.
        /// </summary>
        internal bool IsSetLastUpdateTimestamp() => this.LastUpdateTimestamp.HasValue;

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
        /// Specifies the IAM role that the application uses to access external resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ServiceExecutionRole { get; set; }

        /// <summary>
        /// Checks to see if the ServiceExecutionRole property is set.
        /// </summary>
        internal bool IsSetServiceExecutionRole() => this.ServiceExecutionRole != null;
    }
}
