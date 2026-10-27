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
    /// Container for the parameters to the CreateSubscriber operation. Creates a subscriber.
    /// You must create the associated budget and notification before you create the subscriber.
    /// </summary>
    public partial class CreateSubscriberRequest : AmazonBudgetsRequest
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The <c>accountId</c> that is associated with the budget that you want to create a
        /// subscriber for.
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
        /// The name of the budget that you want to subscribe to. Budget names must be unique
        /// within an account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string BudgetName { get; set; }

        /// <summary>
        /// Checks to see if the BudgetName property is set.
        /// </summary>
        internal bool IsSetBudgetName() => this.BudgetName != null;

        /// <summary>
        /// Gets and sets the property Notification. 
        /// <para>
        /// The notification that you want to create a subscriber for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Notification Notification { get; set; }

        /// <summary>
        /// Checks to see if the Notification property is set.
        /// </summary>
        internal bool IsSetNotification() => this.Notification != null;

        /// <summary>
        /// Gets and sets the property Subscriber. 
        /// <para>
        /// The subscriber that you want to associate with a budget notification.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Subscriber Subscriber { get; set; }

        /// <summary>
        /// Checks to see if the Subscriber property is set.
        /// </summary>
        internal bool IsSetSubscriber() => this.Subscriber != null;
    }
}
