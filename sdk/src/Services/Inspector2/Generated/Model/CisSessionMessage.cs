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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// The CIS session message.
    /// </summary>
    public partial class CisSessionMessage
    {
        private MemoryStream _cisRuleDetails;
        private string _ruleId;
        private CisRuleStatus _status;

        /// <summary>
        /// Gets and sets the property CisRuleDetails. 
        /// <para>
        /// The CIS rule details for the CIS session message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
        public MemoryStream CisRuleDetails
        {
            get { return this._cisRuleDetails; }
            set { this._cisRuleDetails = value; }
        }

        // Check to see if CisRuleDetails property is set
        internal bool IsSetCisRuleDetails()
        {
            return this._cisRuleDetails != null;
        }

        /// <summary>
        /// Gets and sets the property RuleId. 
        /// <para>
        /// The rule ID for the CIS session message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string RuleId
        {
            get { return this._ruleId; }
            set { this._ruleId = value; }
        }

        // Check to see if RuleId property is set
        internal bool IsSetRuleId()
        {
            return this._ruleId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the CIS session message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CisRuleStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}