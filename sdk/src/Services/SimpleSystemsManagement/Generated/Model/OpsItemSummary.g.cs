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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// A count of OpsItems.
    /// </summary>
    public partial class OpsItemSummary
    {
        /// <summary>
        /// Gets and sets the property ActualEndTime. 
        /// <para>
        /// The time a runbook workflow ended. Currently reported only for the OpsItem type <c>/aws/changerequest</c>.
        /// </para>
        /// </summary>
        public DateTime? ActualEndTime { get; set; }

        /// <summary>
        /// Checks to see if the ActualEndTime property is set.
        /// </summary>
        internal bool IsSetActualEndTime() => this.ActualEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ActualStartTime. 
        /// <para>
        /// The time a runbook workflow started. Currently reported only for the OpsItem type
        /// <c>/aws/changerequest</c>.
        /// </para>
        /// </summary>
        public DateTime? ActualStartTime { get; set; }

        /// <summary>
        /// Checks to see if the ActualStartTime property is set.
        /// </summary>
        internal bool IsSetActualStartTime() => this.ActualStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// A list of OpsItems by category.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM entity that created the OpsItem.
        /// </para>
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The date and time the OpsItem was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM entity that created the OpsItem.
        /// </para>
        /// </summary>
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedBy property is set.
        /// </summary>
        internal bool IsSetLastModifiedBy() => this.LastModifiedBy != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time the OpsItem was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property OperationalData. 
        /// <para>
        /// Operational data is custom data that provides useful reference details about the OpsItem.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, OpsItemDataValue> OperationalData { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, OpsItemDataValue>() : null;

        /// <summary>
        /// Checks to see if the OperationalData property is set.
        /// </summary>
        internal bool IsSetOperationalData() => this.OperationalData != null && (this.OperationalData.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OpsItemId. 
        /// <para>
        /// The ID of the OpsItem.
        /// </para>
        /// </summary>
        public string OpsItemId { get; set; }

        /// <summary>
        /// Checks to see if the OpsItemId property is set.
        /// </summary>
        internal bool IsSetOpsItemId() => this.OpsItemId != null;

        /// <summary>
        /// Gets and sets the property OpsItemType. 
        /// <para>
        /// The type of OpsItem. Systems Manager supports the following types of OpsItems:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>/aws/issue</c> 
        /// </para>
        ///  
        /// <para>
        /// This type of OpsItem is used for default OpsItems created by OpsCenter. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>/aws/changerequest</c> 
        /// </para>
        ///  
        /// <para>
        /// This type of OpsItem is used by Change Manager for reviewing and approving or rejecting
        /// change requests. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>/aws/insight</c> 
        /// </para>
        ///  
        /// <para>
        /// This type of OpsItem is used by OpsCenter for aggregating and reporting on duplicate
        /// OpsItems. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string OpsItemType { get; set; }

        /// <summary>
        /// Checks to see if the OpsItemType property is set.
        /// </summary>
        internal bool IsSetOpsItemType() => this.OpsItemType != null;

        /// <summary>
        /// Gets and sets the property PlannedEndTime. 
        /// <para>
        /// The time specified in a change request for a runbook workflow to end. Currently supported
        /// only for the OpsItem type <c>/aws/changerequest</c>.
        /// </para>
        /// </summary>
        public DateTime? PlannedEndTime { get; set; }

        /// <summary>
        /// Checks to see if the PlannedEndTime property is set.
        /// </summary>
        internal bool IsSetPlannedEndTime() => this.PlannedEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property PlannedStartTime. 
        /// <para>
        /// The time specified in a change request for a runbook workflow to start. Currently
        /// supported only for the OpsItem type <c>/aws/changerequest</c>.
        /// </para>
        /// </summary>
        public DateTime? PlannedStartTime { get; set; }

        /// <summary>
        /// Checks to see if the PlannedStartTime property is set.
        /// </summary>
        internal bool IsSetPlannedStartTime() => this.PlannedStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The importance of this OpsItem in relation to other OpsItems in the system.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// A list of OpsItems by severity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The impacted Amazon Web Services resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The OpsItem status.
        /// </para>
        /// </summary>
        public OpsItemStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A short heading that describes the nature of the OpsItem and the impacted resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
