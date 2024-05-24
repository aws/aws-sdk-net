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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
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
namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Returns the number of open reactive insights, the number of open proactive insights,
    /// and the number of metrics analyzed in your Amazon Web Services account. Use these
    /// numbers to gauge the health of operations in your Amazon Web Services account.
    /// </summary>
    public partial class AccountHealth
    {
        private string _accountId;
        private AccountInsightHealth _insight;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
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
        /// Gets and sets the property Insight. 
        /// <para>
        ///  Information about the health of the Amazon Web Services resources in your account,
        /// including the number of open proactive, open reactive insights, and the Mean Time
        /// to Recover (MTTR) of closed insights. 
        /// </para>
        /// </summary>
        public AccountInsightHealth Insight
        {
            get { return this._insight; }
            set { this._insight = value; }
        }

        // Check to see if Insight property is set
        internal bool IsSetInsight()
        {
            return this._insight != null;
        }

    }
}