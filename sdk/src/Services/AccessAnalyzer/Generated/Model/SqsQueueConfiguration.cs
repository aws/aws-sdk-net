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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// The proposed access control configuration for an SQS queue. You can propose a configuration
    /// for a new SQS queue or an existing SQS queue that you own by specifying the SQS policy.
    /// If the configuration is for an existing SQS queue and you do not specify the SQS policy,
    /// the access preview uses the existing SQS policy for the queue. If the access preview
    /// is for a new resource and you do not specify the policy, the access preview assumes
    /// an SQS queue without a policy. To propose deletion of an existing SQS queue policy,
    /// you can specify an empty string for the SQS policy. For more information about SQS
    /// policy limits, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/quotas-policies.html">Quotas
    /// related to policies</a>.
    /// </summary>
    public partial class SqsQueueConfiguration
    {
        private string _queuePolicy;

        /// <summary>
        /// Gets and sets the property QueuePolicy. 
        /// <para>
        ///  The proposed resource policy for the SQS queue. 
        /// </para>
        /// </summary>
        public string QueuePolicy
        {
            get { return this._queuePolicy; }
            set { this._queuePolicy = value; }
        }

        // Check to see if QueuePolicy property is set
        internal bool IsSetQueuePolicy()
        {
            return this._queuePolicy != null;
        }

    }
}