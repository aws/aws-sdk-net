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
    /// This is the response object from the UpdateBudgetAction operation.
    /// </summary>
    public partial class UpdateBudgetActionResponse : AmazonWebServiceResponse
    {
        private string _accountId;
        private string _budgetName;
        private Action _newAction;
        private Action _oldAction;

        /// <summary>
        /// Gets and sets the property AccountId.
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
        /// Gets and sets the property BudgetName.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property NewAction. 
        /// <para>
        ///  The updated action resource information. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Action NewAction
        {
            get { return this._newAction; }
            set { this._newAction = value; }
        }

        // Check to see if NewAction property is set
        internal bool IsSetNewAction()
        {
            return this._newAction != null;
        }

        /// <summary>
        /// Gets and sets the property OldAction. 
        /// <para>
        ///  The previous action resource information. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Action OldAction
        {
            get { return this._oldAction; }
            set { this._oldAction = value; }
        }

        // Check to see if OldAction property is set
        internal bool IsSetOldAction()
        {
            return this._oldAction != null;
        }

    }
}