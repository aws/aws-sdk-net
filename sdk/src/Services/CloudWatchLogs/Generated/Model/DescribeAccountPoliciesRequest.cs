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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAccountPolicies operation.
    /// Returns a list of all CloudWatch Logs account policies in the account.
    /// </summary>
    public partial class DescribeAccountPoliciesRequest : AmazonCloudWatchLogsRequest
    {
        private List<string> _accountIdentifiers = new List<string>();
        private string _policyName;
        private PolicyType _policyType;

        /// <summary>
        /// Gets and sets the property AccountIdentifiers. 
        /// <para>
        /// If you are using an account that is set up as a monitoring account for CloudWatch
        /// unified cross-account observability, you can use this to specify the account ID of
        /// a source account. If you do, the operation returns the account policy for the specified
        /// account. Currently, you can specify only one account ID in this parameter.
        /// </para>
        ///  
        /// <para>
        /// If you omit this parameter, only the policy in the current account is returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<string> AccountIdentifiers
        {
            get { return this._accountIdentifiers; }
            set { this._accountIdentifiers = value; }
        }

        // Check to see if AccountIdentifiers property is set
        internal bool IsSetAccountIdentifiers()
        {
            return this._accountIdentifiers != null && this._accountIdentifiers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// Use this parameter to limit the returned policies to only the policy with the name
        /// that you specify.
        /// </para>
        /// </summary>
        public string PolicyName
        {
            get { return this._policyName; }
            set { this._policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this._policyName != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// Use this parameter to limit the returned policies to only the policies that match
        /// the policy type that you specify. Currently, the only valid value is <code>DATA_PROTECTION_POLICY</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PolicyType PolicyType
        {
            get { return this._policyType; }
            set { this._policyType = value; }
        }

        // Check to see if PolicyType property is set
        internal bool IsSetPolicyType()
        {
            return this._policyType != null;
        }

    }
}