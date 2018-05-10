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
    /// Container for the parameters to the UpdateNotification operation.
    /// Updates a notification.
    /// </summary>
    public partial class UpdateNotificationRequest : AmazonBudgetsRequest
    {
        private string _accountId;
        private string _budgetName;
        private Notification _newNotification;
        private Notification _oldNotification;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The <code>accountId</code> that is associated with the budget whose notification you
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
        /// The name of the budget whose notification you want to update.
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
        /// Gets and sets the property NewNotification. 
        /// <para>
        /// The updated notification to be associated with a budget.
        /// </para>
        /// </summary>
        public Notification NewNotification
        {
            get { return this._newNotification; }
            set { this._newNotification = value; }
        }

        // Check to see if NewNotification property is set
        internal bool IsSetNewNotification()
        {
            return this._newNotification != null;
        }

        /// <summary>
        /// Gets and sets the property OldNotification. 
        /// <para>
        /// The previous notification associated with a budget.
        /// </para>
        /// </summary>
        public Notification OldNotification
        {
            get { return this._oldNotification; }
            set { this._oldNotification = value; }
        }

        // Check to see if OldNotification property is set
        internal bool IsSetOldNotification()
        {
            return this._oldNotification != null;
        }

    }
}