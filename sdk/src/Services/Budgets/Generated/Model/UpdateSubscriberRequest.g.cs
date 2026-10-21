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
    /// Container for the parameters to the UpdateSubscriber operation. Updates a subscriber.
    /// </summary>
    public partial class UpdateSubscriberRequest : AmazonBudgetsRequest
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The <c>accountId</c> that is associated with the budget whose subscriber you want
        /// to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property BudgetName. 
        /// <para>
        /// The name of the budget whose subscriber you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string BudgetName { get; set; }

        /// <summary>
        /// Checks to see if the BudgetName property is set.
        /// </summary>
        internal bool IsSetBudgetName() => this.BudgetName != null;

        /// <summary>
        /// Gets and sets the property NewSubscriber. 
        /// <para>
        /// The updated subscriber that is associated with a budget notification.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Subscriber NewSubscriber { get; set; }

        /// <summary>
        /// Checks to see if the NewSubscriber property is set.
        /// </summary>
        internal bool IsSetNewSubscriber() => this.NewSubscriber != null;

        /// <summary>
        /// Gets and sets the property Notification. 
        /// <para>
        /// The notification whose subscriber you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Notification Notification { get; set; }

        /// <summary>
        /// Checks to see if the Notification property is set.
        /// </summary>
        internal bool IsSetNotification() => this.Notification != null;

        /// <summary>
        /// Gets and sets the property OldSubscriber. 
        /// <para>
        /// The previous subscriber that is associated with a budget notification.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Subscriber OldSubscriber { get; set; }

        /// <summary>
        /// Checks to see if the OldSubscriber property is set.
        /// </summary>
        internal bool IsSetOldSubscriber() => this.OldSubscriber != null;
    }
}
