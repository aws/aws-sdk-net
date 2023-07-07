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
    /// Container for the parameters to the PutAccountPolicy operation.
    /// Creates an account-level data protection policy that applies to all log groups in
    /// the account. A data protection policy can help safeguard sensitive data that's ingested
    /// by your log groups by auditing and masking the sensitive log data. Each account can
    /// have only one account-level policy.
    /// 
    ///  <important> 
    /// <para>
    /// Sensitive data is detected and masked when it is ingested into a log group. When you
    /// set a data protection policy, log events ingested into the log groups before that
    /// time are not masked.
    /// </para>
    ///  </important> 
    /// <para>
    /// If you use <code>PutAccountPolicy</code> to create a data protection policy for your
    /// whole account, it applies to both existing log groups and all log groups that are
    /// created later in this account. The account policy is applied to existing log groups
    /// with eventual consistency. It might take up to 5 minutes before sensitive data in
    /// existing log groups begins to be masked.
    /// </para>
    ///  
    /// <para>
    /// By default, when a user views a log event that includes masked data, the sensitive
    /// data is replaced by asterisks. A user who has the <code>logs:Unmask</code> permission
    /// can use a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetLogEvents.html">GetLogEvents</a>
    /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_FilterLogEvents.html">FilterLogEvents</a>
    /// operation with the <code>unmask</code> parameter set to <code>true</code> to view
    /// the unmasked log events. Users with the <code>logs:Unmask</code> can also view unmasked
    /// data in the CloudWatch Logs console by running a CloudWatch Logs Insights query with
    /// the <code>unmask</code> query command.
    /// </para>
    ///  
    /// <para>
    /// For more information, including a list of types of data that can be audited and masked,
    /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/mask-sensitive-log-data.html">Protect
    /// sensitive log data with masking</a>.
    /// </para>
    ///  
    /// <para>
    /// To use the <code>PutAccountPolicy</code> operation, you must be signed on with the
    /// <code>logs:PutDataProtectionPolicy</code> and <code>logs:PutAccountPolicy</code> permissions.
    /// </para>
    ///  
    /// <para>
    /// The <code>PutAccountPolicy</code> operation applies to all log groups in the account.
    /// You can also use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDataProtectionPolicy.html">PutDataProtectionPolicy</a>
    /// to create a data protection policy that applies to just one log group. If a log group
    /// has its own data protection policy and the account also has an account-level data
    /// protection policy, then the two policies are cumulative. Any sensitive term specified
    /// in either policy is masked.
    /// </para>
    /// </summary>
    public partial class PutAccountPolicyRequest : AmazonCloudWatchLogsRequest
    {
        private string _policyDocument;
        private string _policyName;
        private PolicyType _policyType;
        private Scope _scope;

        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// Specify the data protection policy, in JSON.
        /// </para>
        ///  
        /// <para>
        /// This policy must include two JSON blocks:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The first block must include both a <code>DataIdentifer</code> array and an <code>Operation</code>
        /// property with an <code>Audit</code> action. The <code>DataIdentifer</code> array lists
        /// the types of sensitive data that you want to mask. For more information about the
        /// available options, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/mask-sensitive-log-data-types.html">Types
        /// of data that you can mask</a>.
        /// </para>
        ///  
        /// <para>
        /// The <code>Operation</code> property with an <code>Audit</code> action is required
        /// to find the sensitive data terms. This <code>Audit</code> action must contain a <code>FindingsDestination</code>
        /// object. You can optionally use that <code>FindingsDestination</code> object to list
        /// one or more destinations to send audit findings to. If you specify destinations such
        /// as log groups, Kinesis Data Firehose streams, and S3 buckets, they must already exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The second block must include both a <code>DataIdentifer</code> array and an <code>Operation</code>
        /// property with an <code>Deidentify</code> action. The <code>DataIdentifer</code> array
        /// must exactly match the <code>DataIdentifer</code> array in the first block of the
        /// policy.
        /// </para>
        ///  
        /// <para>
        /// The <code>Operation</code> property with the <code>Deidentify</code> action is what
        /// actually masks the data, and it must contain the <code> "MaskConfig": {}</code> object.
        /// The <code> "MaskConfig": {}</code> object must be empty.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For an example data protection policy, see the <b>Examples</b> section on this page.
        /// </para>
        ///  <important> 
        /// <para>
        /// The contents of the two <code>DataIdentifer</code> arrays must match exactly.
        /// </para>
        ///  </important> 
        /// <para>
        /// In addition to the two JSON blocks, the <code>policyDocument</code> can also include
        /// <code>Name</code>, <code>Description</code>, and <code>Version</code> fields. The
        /// <code>Name</code> is different than the operation's <code>policyName</code> parameter,
        /// and is used as a dimension when CloudWatch Logs reports audit findings metrics to
        /// CloudWatch.
        /// </para>
        ///  
        /// <para>
        /// The JSON specified in <code>policyDocument</code> can be up to 30,720 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PolicyDocument
        {
            get { return this._policyDocument; }
            set { this._policyDocument = value; }
        }

        // Check to see if PolicyDocument property is set
        internal bool IsSetPolicyDocument()
        {
            return this._policyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// A name for the policy. This must be unique within the account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Currently the only valid value for this parameter is <code>DATA_PROTECTION_POLICY</code>.
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

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Currently the only valid value for this parameter is <code>ALL</code>, which specifies
        /// that the data protection policy applies to all log groups in the account. If you omit
        /// this parameter, the default of <code>ALL</code> is used.
        /// </para>
        /// </summary>
        public Scope Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

    }
}