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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the BatchEnableStandards operation.
    /// Enables the standards specified by the provided <code>standardsArn</code>. In this
    /// release, only CIS AWS Foundations standards are supported. For more information, see
    /// <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-standards.html">Standards
    /// Supported in AWS Security Hub</a>.
    /// </summary>
    public partial class BatchEnableStandardsRequest : AmazonSecurityHubRequest
    {
        private List<StandardsSubscriptionRequest> _standardsSubscriptionRequests = new List<StandardsSubscriptionRequest>();

        /// <summary>
        /// Gets and sets the property StandardsSubscriptionRequests. 
        /// <para>
        /// The list of standards compliance checks to enable.
        /// </para>
        ///  <important> 
        /// <para>
        /// In this release, Security Hub supports only the CIS AWS Foundations standard.
        /// </para>
        ///  
        /// <para>
        /// The ARN for the standard is <code>arn:aws:securityhub:::ruleset/cis-aws-foundations-benchmark/v/1.2.0</code>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public List<StandardsSubscriptionRequest> StandardsSubscriptionRequests
        {
            get { return this._standardsSubscriptionRequests; }
            set { this._standardsSubscriptionRequests = value; }
        }

        // Check to see if StandardsSubscriptionRequests property is set
        internal bool IsSetStandardsSubscriptionRequests()
        {
            return this._standardsSubscriptionRequests != null && this._standardsSubscriptionRequests.Count > 0; 
        }

    }
}