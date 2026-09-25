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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// The progress details of a specific domain configuration change.
    /// </summary>
    public partial class ChangeProgressStatusDetails
    {
        /// <summary>
        /// Gets and sets the property ChangeId. 
        /// <para>
        /// The unique change identifier associated with a specific domain configuration change.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ChangeId { get; set; }

        /// <summary>
        /// Checks to see if the ChangeId property is set.
        /// </summary>
        internal bool IsSetChangeId() => this.ChangeId != null;

        /// <summary>
        /// Gets and sets the property ChangeProgressStages. 
        /// <para>
        /// The specific stages that the domain is going through to perform the configuration
        /// change.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ChangeProgressStage> ChangeProgressStages { get; set; } = AWSConfigs.InitializeCollections ? new List<ChangeProgressStage>() : null;

        /// <summary>
        /// Checks to see if the ChangeProgressStages property is set.
        /// </summary>
        internal bool IsSetChangeProgressStages() => this.ChangeProgressStages != null && (this.ChangeProgressStages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CompletedProperties. 
        /// <para>
        /// The list of properties in the domain configuration change that have completed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CompletedProperties { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CompletedProperties property is set.
        /// </summary>
        internal bool IsSetCompletedProperties() => this.CompletedProperties != null && (this.CompletedProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConfigChangeStatus. 
        /// <para>
        /// The current status of the configuration change.
        /// </para>
        /// </summary>
        public ConfigChangeStatus ConfigChangeStatus { get; set; }

        /// <summary>
        /// Checks to see if the ConfigChangeStatus property is set.
        /// </summary>
        internal bool IsSetConfigChangeStatus() => this.ConfigChangeStatus != null;

        /// <summary>
        /// Gets and sets the property InitiatedBy. 
        /// <para>
        /// The IAM principal who initiated the configuration change.
        /// </para>
        /// </summary>
        public InitiatedBy InitiatedBy { get; set; }

        /// <summary>
        /// Checks to see if the InitiatedBy property is set.
        /// </summary>
        internal bool IsSetInitiatedBy() => this.InitiatedBy != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The last time that the status of the configuration change was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property PendingProperties. 
        /// <para>
        /// The list of properties in the domain configuration change that are still pending.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PendingProperties { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PendingProperties property is set.
        /// </summary>
        internal bool IsSetPendingProperties() => this.PendingProperties != null && (this.PendingProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time at which the configuration change is made on the domain.
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
        /// The overall status of the domain configuration change.
        /// </para>
        /// </summary>
        public OverallChangeStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TotalNumberOfStages. 
        /// <para>
        /// The total number of stages required for the configuration change.
        /// </para>
        /// </summary>
        public int? TotalNumberOfStages { get; set; }

        /// <summary>
        /// Checks to see if the TotalNumberOfStages property is set.
        /// </summary>
        internal bool IsSetTotalNumberOfStages() => this.TotalNumberOfStages.HasValue;
    }
}
