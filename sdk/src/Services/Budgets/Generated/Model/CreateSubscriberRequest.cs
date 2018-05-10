/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Budgets.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSubscriber operation.
    /// Creates a subscriber. You must create the associated budget and notification before
    /// you create the subscriber.
    /// </summary>
    public partial class CreateSubscriberRequest : AmazonBudgetsRequest
    {
        private string _accountId;
        private string _budgetName;
        private Notification _notification;
        private Subscriber _subscriber;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The <code>accountId</code> associated with the budget that you want to create a subscriber
        /// for.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property BudgetName. 
        /// <para>
        /// The name of the budget that you want to subscribe to. Budget names must be unique
        /// within an account.
        /// </para>
        /// </summary>
        public string BudgetName
        {
            get { return this._budgetName; }
            set { this._budgetName = value; }
        }

        // Check to see if BudgetName property is set
        internal bool IsSetBudgetName()
        {
            return this._budgetName != null;
        }

        /// <summary>
        /// Gets and sets the property Notification. 
        /// <para>
        /// The notification that you want to create a subscriber for.
        /// </para>
        /// </summary>
        public Notification Notification
        {
            get { return this._notification; }
            set { this._notification = value; }
        }

        // Check to see if Notification property is set
        internal bool IsSetNotification()
        {
            return this._notification != null;
        }

        /// <summary>
        /// Gets and sets the property Subscriber. 
        /// <para>
        /// The subscriber that you want to associate with a budget notification.
        /// </para>
        /// </summary>
        public Subscriber Subscriber
        {
            get { return this._subscriber; }
            set { this._subscriber = value; }
        }

        // Check to see if Subscriber property is set
        internal bool IsSetSubscriber()
        {
            return this._subscriber != null;
        }

    }
}