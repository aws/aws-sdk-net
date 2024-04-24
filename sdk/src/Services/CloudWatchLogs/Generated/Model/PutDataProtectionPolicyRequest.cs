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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the PutDataProtectionPolicy operation.
    /// Creates a data protection policy for the specified log group. A data protection policy
    /// can help safeguard sensitive data that's ingested by the log group by auditing and
    /// masking the sensitive log data.
    /// 
    ///  <important> 
    /// <para>
    /// Sensitive data is detected and masked when it is ingested into the log group. When
    /// you set a data protection policy, log events ingested into the log group before that
    /// time are not masked.
    /// </para>
    ///  </important> 
    /// <para>
    /// By default, when a user views a log event that includes masked data, the sensitive
    /// data is replaced by asterisks. A user who has the <c>logs:Unmask</c> permission can
    /// use a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetLogEvents.html">GetLogEvents</a>
    /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_FilterLogEvents.html">FilterLogEvents</a>
    /// operation with the <c>unmask</c> parameter set to <c>true</c> to view the unmasked
    /// log events. Users with the <c>logs:Unmask</c> can also view unmasked data in the CloudWatch
    /// Logs console by running a CloudWatch Logs Insights query with the <c>unmask</c> query
    /// command.
    /// </para>
    ///  
    /// <para>
    /// For more information, including a list of types of data that can be audited and masked,
    /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/mask-sensitive-log-data.html">Protect
    /// sensitive log data with masking</a>.
    /// </para>
    ///  
    /// <para>
    /// The <c>PutDataProtectionPolicy</c> operation applies to only the specified log group.
    /// You can also use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutAccountPolicy.html">PutAccountPolicy</a>
    /// to create an account-level data protection policy that applies to all log groups in
    /// the account, including both existing log groups and log groups that are created level.
    /// If a log group has its own data protection policy and the account also has an account-level
    /// data protection policy, then the two policies are cumulative. Any sensitive term specified
    /// in either policy is masked.
    /// </para>
    /// </summary>
    public partial class PutDataProtectionPolicyRequest : AmazonCloudWatchLogsRequest
    {
        private string _logGroupIdentifier;
        private string _policyDocument;

        /// <summary>
        /// Gets and sets the property LogGroupIdentifier. 
        /// <para>
        /// Specify either the log group name or log group ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string LogGroupIdentifier
        {
            get { return this._logGroupIdentifier; }
            set { this._logGroupIdentifier = value; }
        }

        // Check to see if LogGroupIdentifier property is set
        internal bool IsSetLogGroupIdentifier()
        {
            return this._logGroupIdentifier != null;
        }

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
        /// The first block must include both a <c>DataIdentifer</c> array and an <c>Operation</c>
        /// property with an <c>Audit</c> action. The <c>DataIdentifer</c> array lists the types
        /// of sensitive data that you want to mask. For more information about the available
        /// options, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/mask-sensitive-log-data-types.html">Types
        /// of data that you can mask</a>.
        /// </para>
        ///  
        /// <para>
        /// The <c>Operation</c> property with an <c>Audit</c> action is required to find the
        /// sensitive data terms. This <c>Audit</c> action must contain a <c>FindingsDestination</c>
        /// object. You can optionally use that <c>FindingsDestination</c> object to list one
        /// or more destinations to send audit findings to. If you specify destinations such as
        /// log groups, Firehose streams, and S3 buckets, they must already exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The second block must include both a <c>DataIdentifer</c> array and an <c>Operation</c>
        /// property with an <c>Deidentify</c> action. The <c>DataIdentifer</c> array must exactly
        /// match the <c>DataIdentifer</c> array in the first block of the policy.
        /// </para>
        ///  
        /// <para>
        /// The <c>Operation</c> property with the <c>Deidentify</c> action is what actually masks
        /// the data, and it must contain the <c> "MaskConfig": {}</c> object. The <c> "MaskConfig":
        /// {}</c> object must be empty.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For an example data protection policy, see the <b>Examples</b> section on this page.
        /// </para>
        ///  <important> 
        /// <para>
        /// The contents of the two <c>DataIdentifer</c> arrays must match exactly.
        /// </para>
        ///  </important> 
        /// <para>
        /// In addition to the two JSON blocks, the <c>policyDocument</c> can also include <c>Name</c>,
        /// <c>Description</c>, and <c>Version</c> fields. The <c>Name</c> is used as a dimension
        /// when CloudWatch Logs reports audit findings metrics to CloudWatch.
        /// </para>
        ///  
        /// <para>
        /// The JSON specified in <c>policyDocument</c> can be up to 30,720 characters.
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

    }
}