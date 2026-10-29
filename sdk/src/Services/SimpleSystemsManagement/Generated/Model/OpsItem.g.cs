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
    /// Operations engineers and IT professionals use Amazon Web Services Systems Manager
    /// OpsCenter to view, investigate, and remediate operational work items (OpsItems) impacting
    /// the performance and health of their Amazon Web Services resources. OpsCenter is integrated
    /// with Amazon EventBridge and Amazon CloudWatch. This means you can configure these
    /// services to automatically create an OpsItem in OpsCenter when a CloudWatch alarm enters
    /// the ALARM state or when EventBridge processes an event from any Amazon Web Services
    /// service that publishes events. Configuring Amazon CloudWatch alarms and EventBridge
    /// events to automatically create OpsItems allows you to quickly diagnose and remediate
    /// issues with Amazon Web Services resources from a single console.
    /// 
    ///  
    /// <para>
    /// To help you diagnose issues, each OpsItem includes contextually relevant information
    /// such as the name and ID of the Amazon Web Services resource that generated the OpsItem,
    /// alarm or event details, alarm history, and an alarm timeline graph. For the Amazon
    /// Web Services resource, OpsCenter aggregates information from Config, CloudTrail logs,
    /// and EventBridge, so you don't have to navigate across multiple console pages during
    /// your investigation. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter.html">Amazon
    /// Web Services Systems Manager OpsCenter</a> in the <i>Amazon Web Services Systems Manager
    /// User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class OpsItem
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
        /// An OpsItem category. Category options include: Availability, Cost, Performance, Recovery,
        /// Security.
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
        /// The ARN of the Amazon Web Services account that created the OpsItem.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The OpsItem description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// The ARN of the Amazon Web Services account that last updated the OpsItem.
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
        /// Gets and sets the property Notifications. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Amazon Simple Notification Service (Amazon SNS)
        /// topic where notifications are sent when this OpsItem is edited or changed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OpsItemNotification> Notifications { get; set; } = AWSConfigs.InitializeCollections ? new List<OpsItemNotification>() : null;

        /// <summary>
        /// Checks to see if the Notifications property is set.
        /// </summary>
        internal bool IsSetNotifications() => this.Notifications != null && (this.Notifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OperationalData. 
        /// <para>
        /// Operational data is custom data that provides useful reference details about the OpsItem.
        /// For example, you can specify log files, error strings, license keys, troubleshooting
        /// tips, or other relevant data. You enter operational data as key-value pairs. The key
        /// has a maximum length of 128 characters. The value has a maximum size of 20 KB.
        /// </para>
        ///  <important> 
        /// <para>
        /// Operational data keys <i>can't</i> begin with the following: <c>amazon</c>, <c>aws</c>,
        /// <c>amzn</c>, <c>ssm</c>, <c>/amazon</c>, <c>/aws</c>, <c>/amzn</c>, <c>/ssm</c>.
        /// </para>
        ///  </important> 
        /// <para>
        /// You can choose to make the data searchable by other users in the account or you can
        /// restrict search access. Searchable data means that all users with access to the OpsItem
        /// Overview page (as provided by the <a>DescribeOpsItems</a> API operation) can view
        /// and search on the specified data. Operational data that isn't searchable is only viewable
        /// by users who have access to the OpsItem (as provided by the <a>GetOpsItem</a> API
        /// operation).
        /// </para>
        ///  
        /// <para>
        /// Use the <c>/aws/resources</c> key in OperationalData to specify a related resource
        /// in the request. Use the <c>/aws/automations</c> key in OperationalData to associate
        /// an Automation runbook with the OpsItem. To view Amazon Web Services CLI example commands
        /// that use these keys, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-manually-create-OpsItems.html">Creating
        /// OpsItems manually</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
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
        /// Gets and sets the property OpsItemArn. 
        /// <para>
        /// The OpsItem Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string OpsItemArn { get; set; }

        /// <summary>
        /// Checks to see if the OpsItemArn property is set.
        /// </summary>
        internal bool IsSetOpsItemArn() => this.OpsItemArn != null;

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
        /// Gets and sets the property RelatedOpsItems. 
        /// <para>
        /// One or more OpsItems that share something in common with the current OpsItem. For
        /// example, related OpsItems can include OpsItems with similar error messages, impacted
        /// resources, or statuses for the impacted resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RelatedOpsItem> RelatedOpsItems { get; set; } = AWSConfigs.InitializeCollections ? new List<RelatedOpsItem>() : null;

        /// <summary>
        /// Checks to see if the RelatedOpsItems property is set.
        /// </summary>
        internal bool IsSetRelatedOpsItems() => this.RelatedOpsItems != null && (this.RelatedOpsItems.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the OpsItem. Severity options range from 1 to 4.
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
        /// The origin of the OpsItem, such as Amazon EC2 or Systems Manager. The impacted resource
        /// is a subset of source.
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
        /// The OpsItem status. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-working-with-OpsItems-editing-details.html">Editing
        /// OpsItem details</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
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

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of this OpsItem. Each time the OpsItem is edited the version number increments
        /// by one.
        /// </para>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
