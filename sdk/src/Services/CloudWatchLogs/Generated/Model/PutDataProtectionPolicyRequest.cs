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
        /// The contents of two <code>DataIdentifer</code> arrays must match exactly.
        /// </para>
        ///  </important>
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