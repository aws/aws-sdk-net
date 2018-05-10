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
    /// Container for the parameters to the UpdateSubscriber operation.
    /// Updates a subscriber.
    /// </summary>
    public partial class UpdateSubscriberRequest : AmazonBudgetsRequest
    {
        private string _accountId;
        private string _budgetName;
        private Subscriber _newSubscriber;
        private Notification _notification;
        private Subscriber _oldSubscriber;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The <code>accountId</code> that is associated with the budget whose subscriber you
        /// want to update.
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
        /// The name of the budget whose subscriber you want to update.
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
        /// Gets and sets the property NewSubscriber. 
        /// <para>
        /// The updated subscriber associated with a budget notification.
        /// </para>
        /// </summary>
        public Subscriber NewSubscriber
        {
            get { return this._newSubscriber; }
            set { this._newSubscriber = value; }
        }

        // Check to see if NewSubscriber property is set
        internal bool IsSetNewSubscriber()
        {
            return this._newSubscriber != null;
        }

        /// <summary>
        /// Gets and sets the property Notification. 
        /// <para>
        /// The notification whose subscriber you want to update.
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
        /// Gets and sets the property OldSubscriber. 
        /// <para>
        /// The previous subscriber associated with a budget notification.
        /// </para>
        /// </summary>
        public Subscriber OldSubscriber
        {
            get { return this._oldSubscriber; }
            set { this._oldSubscriber = value; }
        }

        // Check to see if OldSubscriber property is set
        internal bool IsSetOldSubscriber()
        {
            return this._oldSubscriber != null;
        }

    }
}