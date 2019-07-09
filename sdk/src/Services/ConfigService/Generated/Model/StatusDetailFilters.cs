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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class StatusDetailFilters
    {
        private string _accountId;
        private MemberAccountRuleStatus _memberAccountRuleStatus;

        /// <summary>
        /// Gets and sets the property AccountId.
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
        /// Gets and sets the property MemberAccountRuleStatus.
        /// </summary>
        public MemberAccountRuleStatus MemberAccountRuleStatus
        {
            get { return this._memberAccountRuleStatus; }
            set { this._memberAccountRuleStatus = value; }
        }

        // Check to see if MemberAccountRuleStatus property is set
        internal bool IsSetMemberAccountRuleStatus()
        {
            return this._memberAccountRuleStatus != null;
        }

    }
}