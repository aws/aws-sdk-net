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
    /// Container for the parameters to the CreateNotification operation.
    /// Creates a notification. You must create the budget before you create the associated
    /// notification.
    /// </summary>
    public partial class CreateNotificationRequest : AmazonBudgetsRequest
    {
        private string _accountId;
        private string _budgetName;
        private Notification _notification;
        private List<Subscriber> _subscribers = new List<Subscriber>();

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The <code>accountId</code> that is associated with the budget that you want to create
        /// a notification for.
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
        /// The name of the budget that you want AWS to notified you about. Budget names must
        /// be unique within an account.
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
        /// The notification that you want to create.
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
        /// Gets and sets the property Subscribers. 
        /// <para>
        /// A list of subscribers that you want to associate with the notification. Each notification
        /// can have one SNS subscriber and up to ten email subscribers.
        /// </para>
        /// </summary>
        public List<Subscriber> Subscribers
        {
            get { return this._subscribers; }
            set { this._subscribers = value; }
        }

        // Check to see if Subscribers property is set
        internal bool IsSetSubscribers()
        {
            return this._subscribers != null && this._subscribers.Count > 0; 
        }

    }
}