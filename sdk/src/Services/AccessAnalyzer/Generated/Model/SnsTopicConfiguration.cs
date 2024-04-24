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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// The proposed access control configuration for an Amazon SNS topic. You can propose
    /// a configuration for a new Amazon SNS topic or an existing Amazon SNS topic that you
    /// own by specifying the policy. If the configuration is for an existing Amazon SNS topic
    /// and you do not specify the Amazon SNS policy, then the access preview uses the existing
    /// Amazon SNS policy for the topic. If the access preview is for a new resource and you
    /// do not specify the policy, then the access preview assumes an Amazon SNS topic without
    /// a policy. To propose deletion of an existing Amazon SNS topic policy, you can specify
    /// an empty string for the Amazon SNS policy. For more information, see <a href="https://docs.aws.amazon.com/sns/latest/api/API_Topic.html">Topic</a>.
    /// </summary>
    public partial class SnsTopicConfiguration
    {
        private string _topicPolicy;

        /// <summary>
        /// Gets and sets the property TopicPolicy. 
        /// <para>
        /// The JSON policy text that defines who can access an Amazon SNS topic. For more information,
        /// see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-access-policy-use-cases.html">Example
        /// cases for Amazon SNS access control</a> in the <i>Amazon SNS Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=30720)]
        public string TopicPolicy
        {
            get { return this._topicPolicy; }
            set { this._topicPolicy = value; }
        }

        // Check to see if TopicPolicy property is set
        internal bool IsSetTopicPolicy()
        {
            return this._topicPolicy != null;
        }

    }
}