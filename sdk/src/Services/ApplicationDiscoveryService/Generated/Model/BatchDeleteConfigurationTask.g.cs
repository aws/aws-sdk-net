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

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// A metadata object that represents the deletion task being executed.
    /// </summary>
    public partial class BatchDeleteConfigurationTask
    {
        /// <summary>
        /// Gets and sets the property ConfigurationType. 
        /// <para>
        ///  The type of configuration item to delete. Supported types are: SERVER. 
        /// </para>
        /// </summary>
        public DeletionConfigurationItemType ConfigurationType { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationType property is set.
        /// </summary>
        internal bool IsSetConfigurationType() => this.ConfigurationType != null;

        /// <summary>
        /// Gets and sets the property DeletedConfigurations. 
        /// <para>
        ///  The list of configuration IDs that were successfully deleted by the deletion task.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DeletedConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DeletedConfigurations property is set.
        /// </summary>
        internal bool IsSetDeletedConfigurations() => this.DeletedConfigurations != null && (this.DeletedConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DeletionWarnings. 
        /// <para>
        ///  A list of configuration IDs that produced warnings regarding their deletion, paired
        /// with a warning message. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DeletionWarning> DeletionWarnings { get; set; } = AWSConfigs.InitializeCollections ? new List<DeletionWarning>() : null;

        /// <summary>
        /// Checks to see if the DeletionWarnings property is set.
        /// </summary>
        internal bool IsSetDeletionWarnings() => this.DeletionWarnings != null && (this.DeletionWarnings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        ///  An epoch seconds timestamp (UTC) of when the deletion task was completed or failed.
        /// 
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailedConfigurations. 
        /// <para>
        ///  A list of configuration IDs that failed to delete during the deletion task, each
        /// paired with an error message. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FailedConfiguration> FailedConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<FailedConfiguration>() : null;

        /// <summary>
        /// Checks to see if the FailedConfigurations property is set.
        /// </summary>
        internal bool IsSetFailedConfigurations() => this.FailedConfigurations != null && (this.FailedConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RequestedConfigurations. 
        /// <para>
        ///  The list of configuration IDs that were originally requested to be deleted by the
        /// deletion task. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RequestedConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RequestedConfigurations property is set.
        /// </summary>
        internal bool IsSetRequestedConfigurations() => this.RequestedConfigurations != null && (this.RequestedConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        ///  An epoch seconds timestamp (UTC) of when the deletion task was started. 
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current execution status of the deletion task. Valid status are: INITIALIZING
        /// | VALIDATING | DELETING | COMPLETED | FAILED. 
        /// </para>
        /// </summary>
        public BatchDeleteConfigurationTaskStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        ///  The deletion task's unique identifier. 
        /// </para>
        /// </summary>
        public string TaskId { get; set; }

        /// <summary>
        /// Checks to see if the TaskId property is set.
        /// </summary>
        internal bool IsSetTaskId() => this.TaskId != null;
    }
}
