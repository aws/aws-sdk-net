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
    /// Container for the parameters to the UpdateApplication operation. Updates an existing
    /// Managed Service for Apache Flink application. Using this operation, you can update
    /// application code, input configuration, and output configuration. <para> Managed Service
    /// for Apache Flink updates the <c>ApplicationVersionId</c> each time you update your
    /// application. </para>
    /// </summary>
    public partial class UpdateApplicationRequest : AmazonKinesisAnalyticsV2Request
    {
        /// <summary>
        /// Gets and sets the property ApplicationConfigurationUpdate. 
        /// <para>
        /// Describes application configuration updates.
        /// </para>
        /// </summary>
        public ApplicationConfigurationUpdate ApplicationConfigurationUpdate { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationConfigurationUpdate property is set.
        /// </summary>
        internal bool IsSetApplicationConfigurationUpdate() => this.ApplicationConfigurationUpdate != null;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property CloudWatchLoggingOptionUpdates. 
        /// <para>
        /// Describes application Amazon CloudWatch logging option updates. You can only update
        /// existing CloudWatch logging options with this action. To add a new CloudWatch logging
        /// option, use <a>AddApplicationCloudWatchLoggingOption</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CloudWatchLoggingOptionUpdate> CloudWatchLoggingOptionUpdates { get; set; } = AWSConfigs.InitializeCollections ? new List<CloudWatchLoggingOptionUpdate>() : null;

        /// <summary>
        /// Checks to see if the CloudWatchLoggingOptionUpdates property is set.
        /// </summary>
        internal bool IsSetCloudWatchLoggingOptionUpdates() => this.CloudWatchLoggingOptionUpdates != null && (this.CloudWatchLoggingOptionUpdates.Count > 0 || !AWSConfigs.InitializeCollections);

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
        [AWSProperty(Min = 1, Max = 512)]
        public string ConditionalToken { get; set; }

        /// <summary>
        /// Checks to see if the ConditionalToken property is set.
        /// </summary>
        internal bool IsSetConditionalToken() => this.ConditionalToken != null;

        /// <summary>
        /// Gets and sets the property CurrentApplicationVersionId. 
        /// <para>
        /// The current application version ID. You must provide the <c>CurrentApplicationVersionId</c>
        /// or the <c>ConditionalToken</c>.You can retrieve the application version ID using <a>DescribeApplication</a>.
        /// For better concurrency support, use the <c>ConditionalToken</c> parameter instead
        /// of <c>CurrentApplicationVersionId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 999999999)]
        public long? CurrentApplicationVersionId { get; set; }

        /// <summary>
        /// Checks to see if the CurrentApplicationVersionId property is set.
        /// </summary>
        internal bool IsSetCurrentApplicationVersionId() => this.CurrentApplicationVersionId.HasValue;

        /// <summary>
        /// Gets and sets the property RunConfigurationUpdate. 
        /// <para>
        /// Describes updates to the application's starting parameters.
        /// </para>
        /// </summary>
        public RunConfigurationUpdate RunConfigurationUpdate { get; set; }

        /// <summary>
        /// Checks to see if the RunConfigurationUpdate property is set.
        /// </summary>
        internal bool IsSetRunConfigurationUpdate() => this.RunConfigurationUpdate != null;

        /// <summary>
        /// Gets and sets the property RuntimeEnvironmentUpdate. 
        /// <para>
        /// Updates the Managed Service for Apache Flink runtime environment used to run your
        /// code. To avoid issues you must:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Ensure your new jar and dependencies are compatible with the new runtime selected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure your new code's state is compatible with the snapshot from which your application
        /// will start
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public RuntimeEnvironment RuntimeEnvironmentUpdate { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeEnvironmentUpdate property is set.
        /// </summary>
        internal bool IsSetRuntimeEnvironmentUpdate() => this.RuntimeEnvironmentUpdate != null;

        /// <summary>
        /// Gets and sets the property ServiceExecutionRoleUpdate. 
        /// <para>
        /// Describes updates to the service execution role.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ServiceExecutionRoleUpdate { get; set; }

        /// <summary>
        /// Checks to see if the ServiceExecutionRoleUpdate property is set.
        /// </summary>
        internal bool IsSetServiceExecutionRoleUpdate() => this.ServiceExecutionRoleUpdate != null;
    }
}
