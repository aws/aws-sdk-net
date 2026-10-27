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

namespace Amazon.Budgets.Model
{
    /// <summary>
    /// Container for the parameters to the CreateBudgetAction operation. Creates a budget
    /// action.
    /// </summary>
    public partial class CreateBudgetActionRequest : AmazonBudgetsRequest
    {
        /// <summary>
        /// Gets and sets the property AccountId.
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property ActionThreshold.
        /// </summary>
        [AWSProperty(Required = true)]
        public ActionThreshold ActionThreshold { get; set; }

        /// <summary>
        /// Checks to see if the ActionThreshold property is set.
        /// </summary>
        internal bool IsSetActionThreshold() => this.ActionThreshold != null;

        /// <summary>
        /// Gets and sets the property ActionType. 
        /// <para>
        ///  The type of action. This defines the type of tasks that can be carried out by this
        /// action. This field also determines the format for definition. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActionType ActionType { get; set; }

        /// <summary>
        /// Checks to see if the ActionType property is set.
        /// </summary>
        internal bool IsSetActionType() => this.ActionType != null;

        /// <summary>
        /// Gets and sets the property ApprovalModel. 
        /// <para>
        ///  This specifies if the action needs manual or automatic approval. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ApprovalModel ApprovalModel { get; set; }

        /// <summary>
        /// Checks to see if the ApprovalModel property is set.
        /// </summary>
        internal bool IsSetApprovalModel() => this.ApprovalModel != null;

        /// <summary>
        /// Gets and sets the property BudgetName.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string BudgetName { get; set; }

        /// <summary>
        /// Checks to see if the BudgetName property is set.
        /// </summary>
        internal bool IsSetBudgetName() => this.BudgetName != null;

        /// <summary>
        /// Gets and sets the property Definition.
        /// </summary>
        [AWSProperty(Required = true)]
        public Definition Definition { get; set; }

        /// <summary>
        /// Checks to see if the Definition property is set.
        /// </summary>
        internal bool IsSetDefinition() => this.Definition != null;

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        ///  The role passed for action execution and reversion. Roles and actions must be in
        /// the same account. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 32, Max = 618)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property NotificationType.
        /// </summary>
        [AWSProperty(Required = true)]
        public NotificationType NotificationType { get; set; }

        /// <summary>
        /// Checks to see if the NotificationType property is set.
        /// </summary>
        internal bool IsSetNotificationType() => this.NotificationType != null;

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// An optional list of tags to associate with the specified budget action. Each tag consists
        /// of a key and a value, and each key must be unique for the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<ResourceTag> ResourceTags { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceTag>() : null;

        /// <summary>
        /// Checks to see if the ResourceTags property is set.
        /// </summary>
        internal bool IsSetResourceTags() => this.ResourceTags != null && (this.ResourceTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Subscribers.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 11)]
        public List<Subscriber> Subscribers { get; set; } = AWSConfigs.InitializeCollections ? new List<Subscriber>() : null;

        /// <summary>
        /// Checks to see if the Subscribers property is set.
        /// </summary>
        internal bool IsSetSubscribers() => this.Subscribers != null && (this.Subscribers.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
