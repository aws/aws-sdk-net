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
 * Do not modify this file. This file is generated from the budgets-2016-10-20.normal.json service model.
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
    /// Container for the parameters to the CreateBudget operation.
    /// Creates a budget and, if included, notifications and subscribers. 
    /// 
    ///  <important> 
    /// <para>
    /// Only one of <c>BudgetLimit</c> or <c>PlannedBudgetLimits</c> can be present in the
    /// syntax at one time. Use the syntax that matches your use case. The Request Syntax
    /// section shows the <c>BudgetLimit</c> syntax. For <c>PlannedBudgetLimits</c>, see the
    /// <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_budgets_CreateBudget.html#API_CreateBudget_Examples">Examples</a>
    /// section.
    /// </para>
    ///  
    /// <para>
    /// Similarly, only one set of filter and metric selections can be present in the syntax
    /// at one time. Either <c>FilterExpression</c> and <c>Metrics</c> or <c>CostFilters</c>
    /// and <c>CostTypes</c>, not both or a different combination. We recommend using <c>FilterExpression</c>
    /// and <c>Metrics</c> as they provide more flexible and powerful filtering capabilities.
    /// The Request Syntax section shows the <c>FilterExpression</c>/<c>Metrics</c> syntax.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateBudgetRequest : AmazonBudgetsRequest
    {
        private string _accountId;
        private Budget _budget;
        private List<NotificationWithSubscribers> _notificationsWithSubscribers = AWSConfigs.InitializeCollections ? new List<NotificationWithSubscribers>() : null;
        private List<ResourceTag> _resourceTags = AWSConfigs.InitializeCollections ? new List<ResourceTag>() : null;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The <c>accountId</c> that is associated with the budget.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Budget. 
        /// <para>
        /// The budget object that you want to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Budget Budget
        {
            get { return this._budget; }
            set { this._budget = value; }
        }

        // Check to see if Budget property is set
        internal bool IsSetBudget()
        {
            return this._budget != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationsWithSubscribers. 
        /// <para>
        /// A notification that you want to associate with a budget. A budget can have up to five
        /// notifications, and each notification can have one SNS subscriber and up to 10 email
        /// subscribers. If you include notifications and subscribers in your <c>CreateBudget</c>
        /// call, Amazon Web Services creates the notifications and subscribers for you.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=10)]
        public List<NotificationWithSubscribers> NotificationsWithSubscribers
        {
            get { return this._notificationsWithSubscribers; }
            set { this._notificationsWithSubscribers = value; }
        }

        // Check to see if NotificationsWithSubscribers property is set
        internal bool IsSetNotificationsWithSubscribers()
        {
            return this._notificationsWithSubscribers != null && (this._notificationsWithSubscribers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceTags. 
        /// <para>
        /// An optional list of tags to associate with the specified budget. Each tag consists
        /// of a key and a value, and each key must be unique for the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<ResourceTag> ResourceTags
        {
            get { return this._resourceTags; }
            set { this._resourceTags = value; }
        }

        // Check to see if ResourceTags property is set
        internal bool IsSetResourceTags()
        {
            return this._resourceTags != null && (this._resourceTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}