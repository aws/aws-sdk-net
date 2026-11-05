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
    /// Container for the parameters to the CreateOpsItem operation. Creates a new OpsItem.
    /// You must have permission in Identity and Access Management (IAM) to create a new OpsItem.
    /// For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-setup.html">Set
    /// up OpsCenter</a> in the <i>Amazon Web Services Systems Manager User Guide</i>. <para>
    /// Operations engineers and IT professionals use Amazon Web Services Systems Manager
    /// OpsCenter to view, investigate, and remediate operational issues impacting the performance
    /// and health of their Amazon Web Services resources. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter.html">Amazon
    /// Web Services Systems Manager OpsCenter</a> in the <i>Amazon Web Services Systems Manager
    /// User Guide</i>. </para>
    /// </summary>
    public partial class CreateOpsItemRequest : AmazonSimpleSystemsManagementRequest
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The target Amazon Web Services account where you want to create an OpsItem. To make
        /// this call, your account must be configured to work with OpsItems across accounts.
        /// For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-setup.html">Set
        /// up OpsCenter</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

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
        /// Specify a category to assign to an OpsItem. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// User-defined text that contains information about the OpsItem, in Markdown format.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// Provide enough information so that users viewing this OpsItem for the first time understand
        /// the issue. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Notifications. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an SNS topic where notifications are sent when this
        /// OpsItem is edited or changed.
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
        /// that use these keys, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/OpsCenter-manually-create-OpsItems.html">Create
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
        /// Gets and sets the property OpsItemType. 
        /// <para>
        /// The type of OpsItem to create. Systems Manager supports the following types of OpsItems:
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
        ///  <c>/aws/insight</c> 
        /// </para>
        ///  
        /// <para>
        /// This type of OpsItem is used by OpsCenter for aggregating and reporting on duplicate
        /// OpsItems. 
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
        ///  <important> 
        /// <para>
        /// Amazon Web Services Systems Manager Change Manager is no longer open to new customers.
        /// Existing customers can continue to use the service as normal. For more information,
        /// see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/change-manager-availability-change.html">Amazon
        /// Web Services Systems Manager Change Manager availability change</a>.
        /// </para>
        ///  </important> </li> </ul>
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
        /// One or more OpsItems that share something in common with the current OpsItems. For
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
        /// Specify a severity to assign to an OpsItem.
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
        /// The origin of the OpsItem, such as Amazon EC2 or Systems Manager.
        /// </para>
        ///  <note> 
        /// <para>
        /// The source name can't contain the following strings: <c>aws</c>, <c>amazon</c>, and
        /// <c>amzn</c>. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Optional metadata that you assign to a resource.
        /// </para>
        ///  
        /// <para>
        /// Tags use a key-value pair. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>Key=Department,Value=Finance</c> 
        /// </para>
        ///  <important> 
        /// <para>
        /// To add tags to a new OpsItem, a user must have IAM permissions for both the <c>ssm:CreateOpsItems</c>
        /// operation and the <c>ssm:AddTagsToResource</c> operation. To add tags to an existing
        /// OpsItem, use the <a>AddTagsToResource</a> operation.
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A short heading that describes the nature of the OpsItem and the impacted resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
